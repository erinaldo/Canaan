using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Extrato : IBase<Dados.Extrato>
    {
        public List<Dados.Extrato> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.Extrato> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.Extrato> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.Extrato GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Extrato
                           .Include(a => a.Lancamento)
                           .FirstOrDefault(a => a.IdExtrato == id);
            }
        }

        public Dados.Extrato Insert(Dados.Extrato item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Extrato.Add(item);

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
                    return GetById(item.IdExtrato);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Extrato Update(Dados.Extrato item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    var updated = conn.Extrato.FirstOrDefault(a => a.IdExtrato == item.IdExtrato);

                    //valida e salva
                    updated.IdContaCaixa = item.IdContaCaixa;
                    updated.IdUsuario = item.IdUsuario;
                    updated.TipoPgto = item.TipoPgto;
                    updated.Status = item.Status;
                    updated.ValorLiquido = item.ValorLiquido;
                    updated.ValorPago = item.ValorPago;
                    updated.ValorTroco = item.ValorTroco;
                    updated.ValorBaixado = item.ValorBaixado;
                    updated.Data = item.Data;
                    updated.Hora = item.Hora;

                    conn.SaveChanges();

                    //retorna
                    return updated;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Extrato Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.Extrato> lista)
        {
            throw new NotImplementedException();
        }
    }
}
