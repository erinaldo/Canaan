using Canaan.Lib.Model.Envio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Canaan.CService.Lib
{
    public class Envelope
    {
        public Lib.EnvelopeMov LibEnvelopeMov
        {
            get
            {
                return new Lib.EnvelopeMov();
            }
        }

        public List<Lib.Model.ConsultaModel> GetByAtendimento(int codpacote, int idStudio)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                return conn.env_envelopes.Where(a => a.cod_pacote == codpacote && a.id_studio == idStudio)
                                         .ToList()
                                         .Select(a => new Lib.Model.ConsultaModel
                                         {
                                             CodPacote = a.cod_pacote,
                                             Cliente = a.nome_cliente,
                                             Quantidade = a.num_fotos,
                                             Servico = a.servico,
                                             Status = a.env_status.nome,
                                             DataStatus = a.data_status,
                                             EntradaCPC = a.data_envio,
                                             Previsao = GetPrevisao(a.data_prevista.GetValueOrDefault())
                                         }).ToList();
            }
        }

        public DateTime GetPrevisao(DateTime data) 
        {
            return data.AddDays(5);
        }

        public List<Dados.env_envelopes> GetByVenda(int codpacote, int codvenda, int idStudio)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                return conn.env_envelopes
                           .Where(a => a.cod_pacote == codpacote && a.cod_venda == codvenda && a.id_studio == idStudio).ToList();
            }
        }

        public static List<Dados.env_envelopes> GetByPacoteStatus(int codpacote, int idstudio, int idstatus)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                return conn.env_envelopes.Where(a => a.cod_pacote == codpacote && a.id_studio == idstudio && a.id_status == idstatus).ToList();
            }
        }



        public static Dados.env_envelopes GetById(int idEnvelope)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                return conn.env_envelopes.FirstOrDefault(a => a.id_envelope == idEnvelope);
            }
        }

        public Dados.env_envelopes GetByOrdemPacoteFilial(int idOrdem, int idFilial, int codpacote)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                var result = conn.env_envelopes.FirstOrDefault(a => a.cod_envelope == idOrdem && a.id_studio == idFilial && a.cod_pacote == codpacote);
                return result;
            }
        }

        public void DeletaEnvelope(Dados.env_envelopes item) 
        {
            using (var conn = new CService.Dados.CServicosEntities())
            {
                var env = conn.env_envelopes.FirstOrDefault(a => a.id_envelope == item.id_envelope);

                conn.env_envelopes.Remove(env);
                conn.SaveChanges();
            }
        }

        public SumaryOrdemServicoModel SalvaOrdens(OrdemServicoEnvioModel item)
        {
            SumaryOrdemServicoModel retorno;

            using (var conn = new Dados.CServicosEntities())
            {
                try
                {
                    if (ExisteCPC(item.IdOrdem, item.IdCService, item.CodigoReduzido) == false)
                    {
                        var envelope = new Dados.env_envelopes
                        {
                            id_studio = item.IdCService,
                            id_status = (int)item.Status,
                            cod_pacote = item.CodigoReduzido,
                            cod_cliente = item.CodigoCliente,
                            cod_envelope = item.IdOrdem,
                            cod_venda = item.CodVenda,
                            num_fotos = item.NumFotos,
                            data_venda = item.DataEnvio,
                            data_envio = item.DataEnvio,
                            data_prevista = item.DataPrevista,
                            nome_cliente = item.NomeCliente,
                            nome_vendedora = item.NomeVendedora,
                            nome_envio = item.NomeEnvio,
                            nome_abertura = item.NomeAbertura,
                            album = item.Album ?? "Nenhum",
                            moldura = item.Moldura ?? "Nenhum",
                            servico = item.Servico,
                            obs = item.Obs,
                            faturado = item.Faturado,
                            distribuido = item.Distribuido,
                            data_status = item.DataStatus,
                            data_status_prevista = item.DataStatusPrevista,
                            expedicao = item.Expedicao,
                            is_manipulado = false,
                            is_repeticao = false,
                            data_impressao = null
                        };

                        conn.env_envelopes.Add(envelope);
                        conn.SaveChanges();

                        //Insere Movimentação do Envelope
                        LibEnvelopeMov.Insert(envelope.id_envelope, EnumStatusEnvio.RecebendoImagens);

                        retorno = new SumaryOrdemServicoModel
                        {
                            IdEnvelopeCpc = envelope.id_envelope
                        };
                    }
                    else
                    {
                        var envelope = conn.env_envelopes.FirstOrDefault(a => a.cod_envelope == item.IdOrdem && a.id_studio == item.IdCService && a.cod_pacote == item.CodigoReduzido);

                        retorno = new SumaryOrdemServicoModel
                        {
                            IdEnvelopeCpc = envelope.id_envelope
                        };
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return retorno;
        }

        private bool ExisteCPC(int idOrdem, int? idCservice, int codigoreduzido)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                var result = conn.env_envelopes.Where(a => a.cod_envelope == idOrdem && a.id_studio == idCservice && a.cod_pacote == codigoreduzido);

                return result.Any();
            }
        }
      
        
        public static Dados.env_envelopes InsertFromRM(Integracao.Envelope env, int qtdeDias) 
        {
            using (var conn = new Dados.CServicosEntities())
            {
                //carrega status padrao
                var status = conn.env_status.FirstOrDefault(a => a.id_status == 1);

                //configura novo envelope
                var novo = new Dados.env_envelopes();
                novo.id_studio = conn.env_studios.FirstOrDefault().id_studio;
                novo.id_status = status.id_status;
                novo.cod_pacote = env.IdVenda;
                novo.cod_cliente = int.Parse(env.IdCliente);
                novo.cod_envelope = env.IdItem;
                novo.cod_venda = int.Parse(env.IdPedido);
                novo.num_fotos = env.NumFoto;
                novo.data_venda = env.DataVenda;
                novo.data_envio = DateTime.Today.Date;
                novo.data_prevista = CalculaPrevisao(env.DataVenda, qtdeDias);
                novo.nome_cliente = env.NomeCliente;
                novo.nome_vendedora = env.NomeVendedor;
                novo.nome_envio = "Sistema RM";
                novo.nome_abertura = env.NomeAbertura;
                novo.album = "Nenhum";
                novo.moldura = "Nenhum";
                novo.servico = env.Servico;
                novo.obs = env.Observacao;
                novo.faturado = false;
                novo.distribuido = false;
                novo.data_status = DateTime.Today.Date;
                novo.data_status_prevista = DateTime.Today.AddDays(status.prazo.GetValueOrDefault()).Date;
                novo.expedicao = false;
                novo.is_manipulado = false;
                novo.is_repeticao = false;

                //salva envelope no banco de dados
                conn.env_envelopes.Add(novo);
                conn.SaveChanges();

                //cria movimentacao do envelope
                var mov = new Dados.env_envelopes_mov();
                mov.id_envelope = novo.id_envelope;
                mov.id_status = status.id_status;
                mov.id_usuario = 0;
                mov.data = DateTime.Today.Date;

                //salva movimentacao no banco de dados
                conn.env_envelopes_mov.Add(mov);
                conn.SaveChanges();

                //retorna envelope criado
                return novo;
            }
        }

        private static DateTime CalculaPrevisao(DateTime data, int qtdeDias)
        {
            //var count = 0;
            
            //while (count < qtdeDias)
            //{
            //    data = data.AddDays(1);

            //    if (data.DayOfWeek != DayOfWeek.Saturday && data.DayOfWeek != DayOfWeek.Sunday)
            //        count++;
            //}

            //return data;

            return data.AddDays(qtdeDias + 2);
        }

        public void Update(EnumStatusEnvio enumStatusEnvio, int idEnvelopeCPC)
        {
            using (var conn = new CService.Dados.CServicosEntities())
            {
                var idStatus = (int)enumStatusEnvio;
                var status = conn.env_status.FirstOrDefault(a => a.id_status == idStatus);

                var result = conn.env_envelopes.FirstOrDefault(a => a.id_envelope == idEnvelopeCPC);
                result.id_status = status.id_status;
                result.data_status = DateTime.Now;
                result.data_status_prevista = DateTime.Today.AddDays(status.prazo.GetValueOrDefault());

                conn.SaveChanges();

                //Insere Movimentação do Envelope
                LibEnvelopeMov.Insert(result.id_envelope, enumStatusEnvio);
            }
        }

        public static void UpdateStatus(int idStatus, int idEnvelopeCPC)
        {
            using (var conn = new CService.Dados.CServicosEntities())
            {
                var status = conn.env_status.FirstOrDefault(a => a.id_status == idStatus);

                var result = conn.env_envelopes.FirstOrDefault(a => a.id_envelope == idEnvelopeCPC);
                result.id_status = status.id_status;
                result.data_status = DateTime.Now;
                result.data_status_prevista = DateTime.Today.AddDays(status.prazo.GetValueOrDefault());

                conn.SaveChanges();

                //Insere Movimentação do Envelope
                EnvelopeMov.Insert(result.id_envelope, idStatus);
            }
        }
    }
}
