using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class Filtro : IBase<Dados.Filtro>
    {

        public List<Dados.Filtro> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Filtro.Include(a => a.Parametro).ToList();
            }
        }

        public List<Dados.Filtro> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Filtro.Include(a => a.Parametro).Where(a => a.Nome == nome).ToList();
            }
        }

        public FilterExpressionCollection GetByNome(string nome, string entityName, int idUsuario)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                var filtro = conn.Filtro.Include(a => a.Parametro).FirstOrDefault(a => a.Nome == nome && a.EntidadeName == entityName && (a.idUsuario == null || a.idUsuario == idUsuario));


                var FilterExpression = new FilterExpressionCollection();

                //Carrega todos os Parametros do filtro
                foreach (var item in filtro.Parametro)
                {
                    FilterExpression.AddFilterExpression(
                        new FilterExpression
                        {
                            Logico = item.OperadorLogico,
                            Relacional = item.OperadorRelacional,
                            Property = item.Propriedade,
                            Type = item.Type,
                            Valor = item.Valor
                        });
                }


                return FilterExpression;

            }
        }

        public List<Dados.Filtro> GetByEntidade(string entityName, int idUsuario)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Filtro.Where(a => (a.idUsuario == idUsuario || a.idUsuario == null) && a.EntidadeName.Contains(entityName)).ToList();
            }
        }

        public List<Dados.Filtro> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.Filtro GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Filtro.FirstOrDefault(a => a.IdFiltro == id);
            }
        }

        public Dados.Filtro Insert(Dados.Filtro item)
        {
            try
            {

                if (ValidaInsercao(item))
                    throw new Exception(string.Format("Já Existe um filtro para a entidade {0} com o nome {1}", item.EntidadeName, item.Nome));

                if (item.Padrao)
                {
                    if (MessageBoxUtilities.MessageQuestion("Deseja Realmente que este filtro seja Padrão") == System.Windows.Forms.DialogResult.Yes)
                    {
                        //Remove o atual filtro padrão para esta entidade
                        RemoveFiltroPadrao(item);
                    }
                }

                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Filtro.Add(item);

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
                    return GetById(item.IdFiltro);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool ValidaInsercao(Dados.Filtro item)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.Filtro.FirstOrDefault(a => a.EntidadeName == item.EntidadeName && a.Nome == item.Nome);
                return result != null;
            }
        }

        private void RemoveFiltroPadrao(Dados.Filtro item)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.Filtro.FirstOrDefault(a => a.EntidadeName == item.EntidadeName);
                
                if (result == null)
                    return;

                result.Padrao = false;
                conn.SaveChanges();
            }
        }

        public Dados.Filtro Update(Dados.Filtro item)
        {
            throw new NotImplementedException();
        }

        public Dados.Filtro Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.Filtro> lista)
        {
            throw new NotImplementedException();
        }
    }
}
