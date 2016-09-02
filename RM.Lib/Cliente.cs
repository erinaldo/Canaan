using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RM.Lib
{
    public class Cliente
    {
        public static List<Dados.FCFO> Get()
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.FCFO
                           .ToList();
            }
        }

        public static Dados.FCFO Get(string CodCliente, int CodColigada)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.FCFO
                           .Include(a => a.FCFOCOMPL)
                           .FirstOrDefault(a => a.CODCFO == CodCliente && a.CODCOLIGADA == CodColigada);
            }
        }

        public static List<Dados.FLAN> PendenciaFinanceiro(string codCliente, int codColigada) 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                var status = (short)RM.Lib.Enums.StatusLan.EmAberto;
                var lancamentos = RM.Lib.Lancamento.GetByCliente(codColigada, codCliente).Where(a => a.STATUSLAN == status && a.DATAVENCIMENTO < DateTime.Today).ToList();

                return lancamentos;
            }
        }

        public static void Update(Dados.FCFO updated) 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                //cliente
                var cliente = conn.FCFO.FirstOrDefault(a => a.CODCFO == updated.CODCFO && a.CODCOLIGADA == updated.CODCOLIGADA);

                //altera os dados
                cliente.NOMEFANTASIA = updated.NOMEFANTASIA;
                cliente.NOME = updated.NOME;
                cliente.EMAIL = updated.EMAIL;
                cliente.CGCCFO = updated.CGCCFO;
                cliente.INSCRESTADUAL = updated.INSCRESTADUAL;
                cliente.RUA = updated.RUA;
                cliente.NUMERO = updated.NUMERO;
                cliente.COMPLEMENTO = updated.COMPLEMENTO;
                cliente.BAIRRO = updated.BAIRRO;
                cliente.CEP = updated.CEP;
                cliente.CIDADE = updated.CIDADE;
                cliente.TELEFONE = updated.TELEFONE;
                cliente.TELEX = updated.TELEX;
                cliente.FAX = updated.FAX;
                cliente.TELEFONECOMERCIAL = updated.TELEFONECOMERCIAL;
                cliente.FCFOCOMPL.OBSERVACOES = updated.FCFOCOMPL.OBSERVACOES;

                //salva os dados
                conn.SaveChanges();
            }
        }
    }
}
