using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.CService.Lib
{
    public class Produto
    {
        public static List<Dados.env_tamanhos> Get() 
        {
            using (var conn = new Dados.CServicosEntities()) 
            {
                return conn.env_tamanhos.Where(a => a.exibir_studio.Value == true).ToList();
            }
        }

        public static Dados.env_tamanhos GetById(int id)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                return conn.env_tamanhos.FirstOrDefault(a => a.id_tamanho == id);
            }
        }

        public static Dados.env_tamanhos GetByNome(string nome)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                return conn.env_tamanhos.FirstOrDefault(a => a.nome == nome);
            }
        }

        public static Dados.env_tamanhos Insert(Dados.env_tamanhos item) 
        {
            using (var conn = new Dados.CServicosEntities())
            {
                item.perm_album = false;
                item.perm_moldura = false;
                item.perm_paspatur = false;
                item.perm_quant_fotos = false;
                item.perm_sacola_branca = false;
                item.perm_sacola_verde = false;
                item.comissaoPeso = 1;
                item.comissaoTipo = "I";
                item.descontoPeso = 1;
                item.descontoTipo = "I";
                item.valor_paspatur = 0;
                item.valor_sacola_branca = 0;
                item.valor_sacola_verde = 0;
                if (item.prazo == null) {
                    item.prazo = 15;
                }

                conn.env_tamanhos.Add(item);
                conn.SaveChanges();

                return item;
            }
        }

        public static Dados.env_tamanhos Update(Dados.env_tamanhos item)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                var updated = conn.env_tamanhos.FirstOrDefault(a => a.id_tamanho == item.id_tamanho);
                updated.nome = item.nome;
                updated.prazo = item.prazo;
                updated.valor = item.valor;
                updated.exibir_studio = item.exibir_studio;

                conn.SaveChanges();

                return updated;
            }
        }

        public static Dados.env_tamanhos Delete(Dados.env_tamanhos item)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                var updated = conn.env_tamanhos.FirstOrDefault(a => a.id_tamanho == item.id_tamanho);
                updated.exibir_studio = false;

                conn.SaveChanges();

                return updated;
            }
        }
    }
}
