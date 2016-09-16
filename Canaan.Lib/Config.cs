using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class Config : IBase<Dados.Config>
    {
        public List<Dados.Config> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer()) 
            {
                return conn.Config.ToList();
            }
        }

        public Dados.Config GetByFilial(int idFilial)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Config.FirstOrDefault(a => a.IdFilial == idFilial);
            }
        }

        public List<Dados.Config> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.Config> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.Config GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Dados.Config Insert(Dados.Config item)
        {
            throw new NotImplementedException();
        }

        public Dados.Config Update(Dados.Config item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Config.FirstOrDefault(a => a.IdConfig == item.IdConfig);

                    //atualiza dados
                    //geral
                    updated.IdFilial = item.IdFilial;
                    updated.ServImagem = item.ServImagem;
                    updated.Folder = item.Folder;
                    updated.LocalHost = item.LocalHost;
                    updated.LocalFolder = item.LocalFolder;
                    updated.IsCriptogradado = item.IsCriptogradado;
                    updated.UsaManipulacao = item.UsaManipulacao;
                    updated.UsaLiberacao = item.UsaLiberacao;
                    updated.PastaUsaAno = item.PastaUsaAno;
                    updated.PastaUsaMes = item.PastaUsaMes;
                    updated.Logomarca = item.Logomarca;

                    //atualiza imagem da sessao
                    Session.Instance.LogoReport = item.Logomarca;

                    //laboratorio
                    updated.FtpHost = item.FtpHost;
                    updated.FtpUser = item.FtpUser;
                    updated.FtpPass = item.FtpPass;
                    updated.FtpFolder = item.FtpFolder;
                    updated.FtpPort = item.FtpPort;

                    //financeiro
                    updated.Financ_Juros = item.Financ_Juros;
                    updated.Financ_Multa = item.Financ_Multa;
                    updated.UsaFinanceiro = item.UsaFinanceiro;
                    updated.UsaAtendimentoAutomatico = item.UsaAtendimentoAutomatico;
                    updated.UsaBaixaEntrada = item.UsaBaixaEntrada;

                    //variaveis
                    updated.CurrentAtendimento = item.CurrentAtendimento;
                    updated.CurrentBackup = item.CurrentBackup;

                    //integracao
                    updated.CServiceId = item.CServiceId;
                    updated.CPanelId = item.CPanelId;
                    updated.CMarketingId = item.CMarketingId;
                    updated.RMColigada = item.RMColigada;
                    updated.RMFilial = item.RMFilial;

                    //textos
                    updated.TextoEvento = item.TextoEvento;
                    updated.TextoContrato = item.TextoContrato;

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return updated;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Config Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.Config> lista)
        {
            throw new NotImplementedException();
        }
    }
}
