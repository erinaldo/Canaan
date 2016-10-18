using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;

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
            Excel.Application excelApp = null;
            Excel.Workbook wkbk;
            Excel.Worksheet sheet;

            try
            {
                // Inicializa Excel e cria um workbook and worksheet.
                excelApp = new Excel.Application();
                wkbk = excelApp.Workbooks.Add();
                sheet = wkbk.Sheets.Add() as Excel.Worksheet;
                sheet.Name = "Remessa Pherfil";

                //inicializa o contados
                int i = 1;

                //cria titulos
                sheet.Cells[i, 1] = "COD_CREDOR";
                sheet.Cells[i, 2] = "COD_OPER";
                sheet.Cells[i, 3] = "CPF_CNPJ";
                sheet.Cells[i, 4] = "NOME_DEV";
                sheet.Cells[i, 5] = "END_DEV";
                sheet.Cells[i, 6] = "COMPLEMENTO_DEV";
                sheet.Cells[i, 7] = "BAIRRO_DEV";
                sheet.Cells[i, 8] = "CIDADE_DEV";
                sheet.Cells[i, 9] = "UF_DEV";
                sheet.Cells[i, 10] = "CEP_DEV";
                sheet.Cells[i, 11] = "FONE_DEV";
                sheet.Cells[i, 12] = "FONE2_DEV";
                sheet.Cells[i, 13] = "EMPRESA_COML";
                sheet.Cells[i, 14] = "END_COML";
                sheet.Cells[i, 15] = "COMPLEMENTO_COML";
                sheet.Cells[i, 16] = "BAIRRO_COML";
                sheet.Cells[i, 17] = "CIDADE_COML";
                sheet.Cells[i, 18] = "UF_COML";
                sheet.Cells[i, 19] = "CEP_COML";
                sheet.Cells[i, 20] = "FONE_COML";
                sheet.Cells[i, 21] = "FONE2_COML";
                sheet.Cells[i, 22] = "TIPO_CONTRATO";
                sheet.Cells[i, 23] = "FILIAL";
                sheet.Cells[i, 24] = "CONTRATO";
                sheet.Cells[i, 25] = "COMPLEMENTO_CONTRATO";
                sheet.Cells[i, 26] = "VENCIMENTO";
                sheet.Cells[i, 27] = "VALOR";
                sheet.Cells[i, 28] = "PLANO";
                sheet.Cells[i, 29] = "PARCELA";
                sheet.Cells[i, 30] = "DTBORDERO";
                sheet.Cells[i, 31] = "CODFILIAL";
                sheet.Cells[i, 32] = "COMLPARCELAS";
                sheet.Cells[i, 33] = "FILIALPARADISTRIBUICAO";
                sheet.Cells[i, 34] = "OBSTITULO";
                sheet.Cells[i, 35] = "OBSDEVEDOR";
                sheet.Cells[i, 36] = "URL";
                sheet.Cells[i, 37] = "SEXO_PES";
                sheet.Cells[i, 38] = "ESTADO_CIVIL";
                sheet.Cells[i, 39] = "DTNASCIMENTO";
                sheet.Cells[i, 40] = "VCTO_INICIAL_TIT";
                sheet.Cells[i, 41] = "NUMERO_BORD_TIT";
                sheet.Cells[i, 42] = "COMISS_PARC";
                sheet.Cells[i, 43] = "RG";
                sheet.Cells[i, 44] = "MOEDA";
                sheet.Cells[i, 45] = "INDICE";

                i++;

                //carrega registros no arquivo
                foreach (var item in lista)
                {
                    sheet.Cells[i, 1] = item.CodCredor;
                    sheet.Cells[i, 2] = item.CodOper;
                    sheet.Cells[i, 3] = item.Cpf;
                    sheet.Cells[i, 4] = item.Nome;
                    sheet.Cells[i, 5] = item.EndRua;
                    sheet.Cells[i, 6] = item.EndCompl;
                    sheet.Cells[i, 7] = item.EndBairro;
                    sheet.Cells[i, 8] = item.EndCidade;
                    sheet.Cells[i, 9] = item.EndUf;
                    sheet.Cells[i, 10] = item.EndCep;
                    sheet.Cells[i, 11] = item.Fone1;
                    sheet.Cells[i, 12] = item.Fone2;
                    sheet.Cells[i, 22] = item.TipoContrato;
                    sheet.Cells[i, 23] = item.Filial;
                    sheet.Cells[i, 24] = item.Contrato;
                    sheet.Cells[i, 26] = item.Vencimento.ToOADate();
                    sheet.Cells[i, 27] = decimal.Round(item.Valor, 2);
                    sheet.Cells[i, 28] = item.Plano;
                    sheet.Cells[i, 29] = item.Parcela;
                    sheet.Cells[i, 32] = item.ParcelaCompl;
                    sheet.Cells[i, 38] = item.EstadoCivil;
                    if (item.DataNasc != null)
                        sheet.Cells[i, 39] = item.DataNasc.Value.ToOADate();
                    sheet.Cells[i, 40] = item.DataVenda.ToOADate();
                    sheet.Cells[i, 43] = item.Rg;
                    sheet.Cells[i, 44] = item.Moeda;
                    sheet.Cells[i, 45] = item.Indice;

                    //sheet.get_Range(sheet.Cells[i, 26], sheet.Cells[i, 26]).NumberFormat = "dd/MM/yyyy";
                    //sheet.get_Range(sheet.Cells[i, 39], sheet.Cells[i, 39]).NumberFormat = "dd/MM/yyyy";
                    //sheet.get_Range(sheet.Cells[i, 40], sheet.Cells[i, 40]).NumberFormat = "dd/MM/yyyy";

                    i++;

                }

                sheet.Columns[26].NumberFormat = "dd/mm/aaaa";
                sheet.Columns[39].NumberFormat = "dd/mm/aaaa";
                sheet.Columns[40].NumberFormat = "dd/mm/aaaa";


                //desabilita alertas
                excelApp.DisplayAlerts = false;

                //salva arquivo
                wkbk.SaveAs(filename);
            }
            catch
            {
            }
            finally
            {
                sheet = null;
                wkbk = null;

                // Close Excel.
                excelApp.Quit();
                excelApp = null;
            }
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
