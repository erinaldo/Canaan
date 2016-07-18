using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class OrdemServicoMov : IBase<Dados.OrdemServicoMov>
    {

        public List<Dados.OrdemServicoMov> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.OrdemServicoMov> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.OrdemServicoMov> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.OrdemServicoMov GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServicoMov
                           .Include(a => a.OrdemStatus)
                           .FirstOrDefault(a => a.IdMov == id);
            }
        }

        public Dados.OrdemServicoMov Insert(Dados.OrdemServicoMov item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.OrdemServicoMov.Add(item);

                    //atualiza o status da ordem de serviço
                    var os = conn.OrdemServico.FirstOrDefault(a => a.IdOrdemServico == item.IdOrdemServico);
                    os.Status = item.Status;

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
                    return GetById(item.IdMov);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.OrdemServicoMov Update(Dados.OrdemServicoMov item)
        {
            throw new NotImplementedException();
        }

        public Dados.OrdemServicoMov Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.OrdemServicoMov> lista)
        {
            throw new NotImplementedException();
        }
    }
}
