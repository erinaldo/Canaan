using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class MotivoDevolucao
    {
        public List<Dados.MotivoDevolucao> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.MotivoDevolucao> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.MotivoDevolucao> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.MotivoDevolucao GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.MotivoDevolucao.FirstOrDefault(a => a.IdMotivoDevolucao == id);
            }
        }

        public Dados.MotivoDevolucao Insert(Dados.MotivoDevolucao item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.MotivoDevolucao.Add(item);

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
                    return GetById(item.IdMotivoDevolucao);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.MotivoDevolucao Update(Dados.MotivoDevolucao item)
        {
            throw new NotImplementedException();
        }

        public Dados.MotivoDevolucao Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.MotivoDevolucao> lista)
        {
            throw new NotImplementedException();
        }

        public List<Model.MotivoDevolucaoModel> GetByIdMov(int SelectedMov)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.MotivoDevolucao.Where(a => a.IdVendaMov == SelectedMov)
                                           .ToList()
                                           .Select(a => new Model.MotivoDevolucaoModel
                                           {
                                               IdMotivoDevolucao = a.IdMotivoDevolucao,
                                               IdMotivo = a.IdMotivo,
                                               Motivo = a.Motivo.Descricao,
                                               Observacao = a.Observacao,
                                               Quantidade = a.Quantidade.GetValueOrDefault()
                                           })
                                           .ToList();
            }
        }
    }
}
