using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class EnvioPedido
    {
        public Dados.EnvioPedido GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.EnvioPedido
                           .Include(a => a.EnvioImagem)
                           .FirstOrDefault(a => a.IdEnvioPedido == id);
            }
        }

        public List<Dados.EnvioPedido> GetByEnvio(int idEnvio)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.EnvioPedido
                           .Include(a => a.Envio)
                           .Include(a => a.EnvioImagem)
                           .Where(a => a.IdEnvio == idEnvio)
                           .ToList();
            }
        }

        public List<Dados.EnvioPedido> GetByStatus(bool isEnviado)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.EnvioPedido
                           .Include(a => a.Envio)
                           .Include(a => a.EnvioImagem)
                           .Where(a => a.IsEnviado == isEnviado)
                           .ToList();
            }
        }

        public Dados.EnvioPedido Insert(Dados.EnvioPedido item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.EnvioPedido.Add(item);

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
                    return GetById(item.IdEnvioPedido);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.EnvioPedido UpdateStatus(Dados.EnvioPedido item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    var updated = conn.EnvioPedido.FirstOrDefault(a => a.IdEnvioPedido == item.IdEnvioPedido);
                    updated.IsEnviado = true;

                    //salva no banco de dados
                    conn.SaveChanges();

                    //verifica se existe algum pedido pendente
                    if (item.IdEnvio != null)
                    {
                        var pendentes = conn.EnvioPedido.Where(a => a.IdEnvio == item.IdEnvio && a.IsEnviado == false).Count();
                        if (pendentes == 0)
                        {
                            var envio = conn.Envio.FirstOrDefault(a => a.IdEnvio == item.IdEnvio);
                            envio.IdStatus = Dados.EnumEnvioStatus.Enviado;

                            conn.SaveChanges();
                        }
                    }
                    
                    
                    //retorna
                    return GetById(item.IdEnvioPedido);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
