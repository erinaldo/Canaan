using Canaan.Lib.Model.Envio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace Canaan.Lib
{
    public class Envio
    {
        private Dados.CanaanModelContainer conn;

        public Envio()
        {

        }

        public Envio(Dados.CanaanModelContainer conn)
        {
            this.conn = conn;
        }

        public DateTime? GetUltimExecucaoFilial(int IdFilial)
        {
            var result = conn.Envio.OrderByDescending(a => a.DataFim).FirstOrDefault();

            if (result == null)
                return null;

            return result.DataFim;
        }

        public Dados.Envio GetById(int id) 
        {
            using (var conn = new Dados.CanaanModelContainer()) 
            {
                return conn.Envio.FirstOrDefault(a => a.IdEnvio == id);
            }
        }

        public List<Dados.Envio> GetByStatus(Dados.EnumEnvioStatus status)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Envio
                           .Include(a => a.Pedido_Venda)
                           .Include(a => a.Pedido_Venda.CliFor)
                           .Include(a => a.Pedido_Venda.Atendimento)
                           .Where(a => a.IdStatus == status)
                           .ToList();
            }
        }

        public List<Dados.Envio> GetByVenda(int idPedido)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Envio
                           .Include(a => a.Pedido_Venda)
                           .Include(a => a.Pedido_Venda.CliFor)
                           .Include(a => a.Pedido_Venda.Atendimento)
                           .Where(a => a.IdPedido == idPedido)
                           .ToList();
            }
        }

        public DateTime CalculaDataPrevista(DateTime data) 
        {
            var previsao = DateTime.Today;

            //verifica se o envio esta sendo feito entre os dias 11 e 25
            if (data.Day >= 11 && data.Day <= 25)
            {
                //define previsao para o dia 1 do proximo mes
                previsao = new DateTime(previsao.Year, previsao.Month, 1).AddMonths(1);
            }
            else
            {
                //verifica se o envio esta sendo feito entre o dia 26 e 31
                if (data.Day >= 26 && data.Day <= 31)
                {
                    //define previsao para o dia 15 do proximo mes
                    previsao = new DateTime(previsao.Year, previsao.Month, 15).AddMonths(1);
                }
                else
                {
                    //define previsao para o dia 15 do mes atual
                    previsao = new DateTime(previsao.Year, previsao.Month, 15);
                }
            }

            return previsao;
        }

        public List<EnvioModel> GetEnvioByFilial(int IdFilial)
        {
            //Config
            var config = new Config().GetByFilial(IdFilial);

            if (config == null)
                throw new Exception("Configuração da filial não foi encontrada");


            //Carrega itens do da tabela de Envio
            var result = conn.Envio.Include(a => a.Pedido_Venda)
                                   .Where(a => a.Pedido_Venda.IdFilial == IdFilial && a.IdStatus != Dados.EnumEnvioStatus.Enviado) // Envio com status != de enviado
                                   .ToList()
                                   .Select(a => new EnvioModel
                                   {
                                       Selecionado = false,
                                       IdEnvio = a.IdEnvio,
                                       IdVenda = a.IdPedido,
                                       IdAtendimento = a.Pedido_Venda.IdAtendimento,
                                       IdFilial = a.Pedido_Venda.IdFilial,
                                       CodigoReduzido = a.Pedido_Venda.Atendimento.CodigoReduzido,
                                       Cliente = a.Pedido_Venda.Atendimento.CliFor.Nome,
                                       DataVenda = a.Pedido_Venda.DataVenda,
                                       LibEscrit = a.Pedido_Venda.IsLiberado,
                                       LibGerente = a.Pedido_Venda.IsConfirmado,
                                       Valor = a.Pedido_Venda.ValorLiquido,
                                       NomeEnvio = a.Usuario.Nome,
                                       Icone = Properties.Resources.aguardando
                                   })
                                   .OrderBy(a => a.DataVenda)
                                   .ToList();

            //Iterar sobre a lista de envio
            foreach (var envio in result)
            {
                //Carrega Ordens de Serviço de Cada Venda
                envio.OrdensEnvio = GetOrdemModelByVenda(envio.IdVenda, envio.IdFilial);

                foreach (var envelope in envio.OrdensEnvio)
                {
                    //Carrega os itens da ordem de serviço
                    envelope.OrdensServicoItem = GetOrdemItemModelByOrdem(envelope.IdOrdem, envio.IdFilial);
                }
            }

            return result;

        }

        public List<OrdemServicoEnvioModel> GetOrdemModelByVenda(int idVenda, int idFilial, int IdEnvelopeCPC = 0)
        {
            var config = new Config().GetByFilial(idFilial);

            if (config == null)
                throw new Exception("Configuração da filial não foiencontrada");

            //calcula a data prevista
            //var dataprevista = DateTime.Today.AddDays(15); //CalculaDataPrevista(DateTime.Today);

            return conn.OrdemServico.Where(a => a.IdPedido == idVenda && a.Servico.IsEnvio == true).Select(a => new OrdemServicoEnvioModel
            {
                IdEnvelopeCpc = IdEnvelopeCPC,
                IdOrdem = a.IdOrdemServico,
                IdCService = config.CServiceId,
                IdFilialEstudio = idFilial,
                Status = EnumStatusEnvio.RecebendoImagens,
                CodigoReduzido = a.Pedido_Venda.Atendimento.CodigoReduzido,
                CodigoCliente = a.Pedido_Venda.Atendimento.IdCliFor,
                CodEnvelope = a.IdOrdemServico,
                NumFotos = a.OrdemServicoItem.Count,
                DataVenda = a.Pedido_Venda.DataVenda,
                DataEnvio = DateTime.Now,
                DataPrevista = DbFunctions.AddDays(a.Pedido_Venda.DataLiberacao, 15),
                NomeCliente = a.Pedido_Venda.Atendimento.CliFor.Nome,
                NomeVendedora = a.Pedido_Venda.Usuario.Nome,
                NomeAbertura = a.NomeAbertura,
                Album = a.Album.Nome,
                Moldura = a.Moldura.Nome,
                Servico = a.Servico.Nome,
                Obs = a.Observacao,
                Faturado = false,
                Distribuido = false,
                DataStatus = DateTime.Now,
                DataStatusPrevista = DbFunctions.AddDays(DateTime.Today, 2),  // Dois dias recebendo imagem definido no banco do cservice
                Expedicao = false,
                CodVenda = a.IdPedido
            }).ToList();
        }

        public List<OrdemServicoItemEnvioModel> GetOrdemItemModelByOrdem(int IdOrdem, int idFilial, int idFotoCPC = 0)
        {
            var config = new Config().GetByFilial(idFilial);

            if (config == null)
                throw new Exception("Configuração da filial não foiencontrada");

            return conn.OrdemServicoItem.Include(a => a.OrdemServico)
                                        .Include(a => a.OrdemServico.Pedido_Venda)
                                        .Include(a => a.OrdemServico.Pedido_Venda.Atendimento)
                                        .Include(a => a.Foto)
                                        .Include(a => a.EfeitoDigital)
                                        .Where(a => a.IdOrdemServico == IdOrdem)
                                        .ToList()
                                        .Select(a => new OrdemServicoItemEnvioModel
                                          {
                                              IdOrdemItem = a.IdItem,
                                              IdOrdem = a.IdOrdemServico,
                                              IdFotoCpc = idFotoCPC,
                                              Foto = a.Foto,
                                              CodPacote = a.OrdemServico.Pedido_Venda.Atendimento.CodigoReduzido,
                                              Quantidade = a.Quantidade,
                                              NomeFoto = string.Format(@"{0}\{1}", a.Foto.Sessao.NumSessao, a.Foto.Url.Split('\\').LastOrDefault()),
                                              EfeitoDigital = a.EfeitoDigital == null ? "Nenhum" : a.EfeitoDigital.Nome,
                                              CaminhoFoto = string.Format(@"\{0}\{1}\{2}", config.FtpFolder, a.Foto.Sessao.NumSessao, a.Foto.Url.Split('\\').LastOrDefault()),
                                              Observacao = a.Observacao
                                          }).ToList();
        }

        public void UpdateEnvio(Dados.EnumEnvioStatus enumEnvioStatus, int idEnvio)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var envio = conn.Envio.FirstOrDefault(a => a.IdEnvio == idEnvio);
                envio.IdStatus = enumEnvioStatus;
                envio.DataFim = DateTime.Now;

                conn.SaveChanges();
            }
        }

        public void UpdateEnvioInicio(Dados.EnumEnvioStatus enumEnvioStatus, int idEnvio)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var envio = conn.Envio.FirstOrDefault(a => a.IdEnvio == idEnvio);
                envio.IdStatus = enumEnvioStatus;
                envio.DataInicio = DateTime.Now;

                conn.SaveChanges();
            }
        }

        public void Insert(Dados.Venda item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    var status = Dados.EnumEnvioStatus.Aguardando;
                    var manipulacao = new Lib.Config().GetByFilial(Session.Instance.Contexto.IdFilial).UsaManipulacao;

                    //verifica se cliente usa manipulacao
                    if (manipulacao == true)
                        status = Dados.EnumEnvioStatus.Configurando;

                    var envio = new Dados.Envio
                    {
                        DataInicio = DateTime.Now,
                        DataFim = DateTime.Now,
                        IdStatus = status,
                        IdUsuario = Session.Instance.Usuario.IdUsuario,
                        IdPedido = item.IdPedido,
                    };

                    //salva no banco de dados
                    conn.Envio.Add(envio);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
