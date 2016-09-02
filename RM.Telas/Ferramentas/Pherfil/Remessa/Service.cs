using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace RM.Telas.Ferramentas.Pherfil.Remessa
{
    public class Service : IDisposable
    {
        #region PROPRIEDADES

        private Dados.CorporeEntities conn;

        #endregion

        #region CONSTRUTOR

        public Service()
        {
            conn = new Dados.CorporeEntities();
        }

        #endregion

        #region METODOS

        public List<Model> GetLista(short coligada, short filial, int minDias, int maxDias = 100)
        {
            //cria a nova lista
            var erros = 0;
            var lista = new List<Model>();
            var statusLan = new int[] { 0, 1 };
            var dataConsulta = DateTime.Today.AddDays(minDias * (-1));
            var classeContabil = "2.027";
            var credor = 125;

            //carrega a lista
            //filtra os lancamentos
            var vendas = conn.FLAN
                           .Where(a => a.PAGREC == 1 &&
                                       a.STATUSLAN == 0 &&
                                       a.CODTB1FLX != classeContabil &&
                                       a.CODTB1FLX != "2.028" &&
                                       a.CODCOLIGADA == coligada &&
                                       a.CODFILIAL == filial &&
                                       a.DATAVENCIMENTO < dataConsulta &&
                                       a.IDMOV != null &&
                                       a.TMOV.STATUS != "C")
                           .OrderBy(a => a.IDMOV)
                           .ThenBy(a => a.DATAEMISSAO)
                           .GroupBy(a => new ModelVenda { 
                                CodVenda = a.IDMOV.Value,
                                CodColigada = a.CODCOLIGADA,
                                CodFilial = a.CODFILIAL,
                                CodCliente = a.CODCFO,
                                Data = a.DATAEMISSAO,
                                Valor = a.TMOV.VALORLIQUIDO.Value
                           }).Take(maxDias).ToList();

            //faz loop nos lancamentos
            foreach (var venda in vendas)
            {
                try
                {
                    var lanc = conn.FLAN.Where(a => a.CODCOLIGADA == venda.Key.CodColigada &&
                                                    a.CODFILIAL == venda.Key.CodFilial &&
                                                    a.IDMOV == venda.Key.CodVenda &&
                                                    a.STATUSLAN == 0 &&
                                                    a.PAGREC == 1)
                                        .OrderBy(a => a.DATAVENCIMENTO)
                                        .ToList();

                    foreach (var item in lanc)
                    {
                        var acordo = conn.FACORDOREL.Where(a => a.CODCOLIGADA == item.CODCOLIGADA && a.IDLAN == item.IDLAN && a.CLASSIFICACAO == 2)
                                                .OrderByDescending(a => a.IDACORDO)
                                                .AsNoTracking()
                                                .FirstOrDefault();


                        try
                        {
                            lista.Add(new Model
                            {
                                CodCredor = credor,
                                Cpf = FormataCPF(item.FCFO.CGCCFO),
                                Nome = item.FCFO.NOME,
                                Sexo = "",
                                EstadoCivil = GetEstadoCivil(item.FCFO.ESTADOCIVIL),
                                DataNasc = item.FCFO.DTNASCIMENTO,
                                Rg = item.FCFO.CIDENTIDADE,
                                EndRua = string.Format("{0} {1} {2}", item.FCFO.DTIPORUA != null ? item.FCFO.DTIPORUA.DESCRICAO : "", item.FCFO.RUA, item.FCFO.NUMERO),
                                EndCompl = item.FCFO.COMPLEMENTO,
                                EndBairro = item.FCFO.BAIRRO,
                                EndCidade = item.FCFO.CIDADE,
                                EndUf = item.FCFO.CODETD != null ? item.FCFO.CODETD : "",
                                EndCep = FormataCep(item.FCFO.CEP),
                                Fone1 = FormataFone(item.FCFO.TELEFONE),
                                Fone2 = FormataFone(item.FCFO.TELEX),
                                Filial = string.Format("{0}_{1}", coligada.ToString().PadLeft(2, '0'), filial.ToString().PadLeft(2, '0')),
                                Contrato = item.IDMOV != null ? item.IDMOV.Value.ToString() : "",
                                Lancamento = item.IDLAN,
                                Vencimento = item.DATAVENCIMENTO.Date,
                                Valor = item.VALORORIGINAL,
                                Plano = GetPlano(item.TMOV, acordo),
                                Parcela = GetParcelaIndice(item, acordo),
                                ParcelaCompl = item.FACORDOREL.Count > 0 ? "ACORDO" : "",
                                DataVenda = item.DATAEMISSAO.Date
                            });
                        }
                        catch (Exception)
                        {
                            erros++;
                        }

                        
                    }
                }
                catch (Exception)
                {
                    erros++;
                }
                
                
            }

            //retorna lista carregada
            return lista;
        }

        private int GetPlano(Dados.TMOV mov, Dados.FACORDOREL ac)
        {
            var statusLan = new int[] { 0, 1 };
            
            if (ac != null)
            {
                return conn.FACORDOREL.Where(a => a.CODCOLIGADA == ac.CODCOLIGADA && a.IDACORDO == ac.IDACORDO && a.CLASSIFICACAO == 2).Count();
            }
            else 
            {
                return mov.FLAN.Where(a => statusLan.Contains(a.STATUSLAN)).OrderBy(a => a.DATAEMISSAO).ThenBy(a => a.DATAVENCIMENTO).Count();
            }
        }

        private int GetParcelaIndice(Dados.FLAN lanc, Dados.FACORDOREL ac)
        {
            var indice = 1;
            var statusLan = new int[] { 0, 1 };

            if (ac != null)
            {
                var result = conn.FACORDOREL.Where(a => a.IDACORDO == ac.IDACORDO && a.CODCOLIGADA == ac.CODCOLIGADA && a.CLASSIFICACAO == 2).AsNoTracking();

                foreach (var item in result)
                {
                    if (item.IDLAN != lanc.IDLAN)
                        indice++;
                    else
                        break;
                }
            }
            else 
            {
                var result = conn.FLAN.Where(a => a.CODCOLIGADA == lanc.CODCOLIGADA && a.IDMOV == lanc.IDMOV && statusLan.Contains(a.STATUSLAN)).OrderBy(a => a.DATAVENCIMENTO).AsNoTracking();
                foreach (var item in result)
                {
                    if (item.IDLAN != lanc.IDLAN)
                        indice++;
                    else
                        break;
                }
            }

            return indice;
        }

        public void BloqueiaLancamentos(short coligada, short filial, short numBloqueio, List<Model> lista)
        {
            foreach (var item in lista)
            {
                //encontra registro do lancamento no banco de dados
                var lanc = conn.FLAN.FirstOrDefault(a => a.CODCOLIGADA == coligada && a.CODFILIAL == filial && a.IDLAN == item.Lancamento);

                //marca como bloqueado / desbloqueado
                lanc.NUMBLOQUEIOS = numBloqueio;
                lanc.CODTB1FLX = item.ClasseContabil;
            }

            //grava dados no banco de dados
            conn.SaveChanges();
        }

        public void ExportaLista(List<Model> lista, string filename)
        {
        }

        private string FormataFone(string p)
        {
            var phone = Canaan.Lib.Utilitarios.Comum.RemoveEspeciais(p);

            return Regex.Replace(phone, "[^0-9.]", "");
        }

        private string FormataCep(string p)
        {
            return Canaan.Lib.Utilitarios.Comum.RemoveEspeciais(p);
        }

        private string FormataCPF(string p)
        {
            return Canaan.Lib.Utilitarios.Comum.RemoveEspeciais(p);
        }

        private string GetEstadoCivil(string p)
        {
            var result = "";

            switch (p)
            {
                case "C":
                    result = "Casado";
                    break;
                case "D":
                    result = "Desquitado";
                    break;
                case "I":
                    result = "Divorciado";
                    break;
                case "O":
                    result = "Outros";
                    break;
                case "S":
                    result = "Solteiro";
                    break;
                case "V":
                    result = "Viúvo";
                    break;
            }

            return result.ToUpper();
        }

        public void Dispose()
        {
            conn.Dispose();
        }

        #endregion
    }
}
