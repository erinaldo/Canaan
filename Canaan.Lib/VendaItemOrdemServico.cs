using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class VendaItemOrdemServico : IBase<Dados.VendaItemOrdemServico>
    {
        public List<Dados.VendaItemOrdemServico> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.VendaItemOrdemServico> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.VendaItemOrdemServico> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.VendaItemOrdemServico GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaItemOrdemServico.FirstOrDefault(a => a.IdVendaItemOrdemServico == id);
            }
        }

        public Dados.VendaItemOrdemServico Insert(Dados.VendaItemOrdemServico item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.VendaItemOrdemServico.Add(item);

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
                    return GetById(item.IdVendaItemOrdemServico);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.VendaItemOrdemServico Update(Dados.VendaItemOrdemServico item)
        {
            throw new NotImplementedException();
        }

        public Dados.VendaItemOrdemServico Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.VendaItemOrdemServico> lista)
        {
            throw new NotImplementedException();
        }


    }
}
