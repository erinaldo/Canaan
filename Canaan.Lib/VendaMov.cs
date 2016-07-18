using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class VendaMov : IBase<Dados.VendaMov>
    {
        public List<Dados.VendaMov> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaMov.ToList();
            }
        }

        public List<Dados.VendaMov> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.VendaMov> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.VendaMov GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaMov.FirstOrDefault(a => a.IdMov == id);
            }
        }

        public Dados.VendaMov Insert(Dados.VendaMov item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.VendaMov.Add(item);

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

        public Dados.VendaMov Update(Dados.VendaMov item)
        {
            throw new NotImplementedException();
        }

        public Dados.VendaMov Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.VendaMov> lista)
        {
            throw new NotImplementedException();
        }

        public Dados.VendaMov GetLastMov(int idVenda, Dados.EnumStatusVenda status)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaMov.Where(a => a.Status == status && a.IdPedido == idVenda).ToList().OrderBy(a => a.Data).LastOrDefault();
            }
        }

        public List<Model.VendaMovModel> GetDevolucoes(int idPedido)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Pedido.OfType<Dados.Venda>()
                      .Where(a => a.IdPedido == idPedido)
                      .Select(a => a.VendaMov)
                      .FirstOrDefault()
                      .Where(a => a.Status == Dados.EnumStatusVenda.Devolvido)
                      .Select(a => new Model.VendaMovModel
                      {
                          IdMov = a.IdMov,
                          Status = a.Status,
                          Atendimento = a.Venda.Atendimento.CodigoReduzido,
                          Data = a.Data
                      })
                      .ToList();
            }
        }

        public List<Model.VendaMovModel> GetMovimentacoes(int idPedido)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaMov
                           .Include(a => a.Venda)
                           .Include(a => a.Venda.Atendimento)
                           .Include(a => a.Usuario)
                           .Where(a => a.IdPedido == idPedido)
                           .ToList()
                           .Select(a => new Model.VendaMovModel
                           {
                               IdMov = a.IdMov,
                               Status = a.Status,
                               Usuario = string.Format("{0} {1}", a.Usuario.Nome, a.Usuario.Sobrenome),
                               Atendimento = a.Venda.Atendimento.CodigoReduzido,
                               Data = a.Data
                           })
                           .ToList();
                           
            }
        }
    }
}
