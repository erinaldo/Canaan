using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Telas.Consultas.Cliente
{
    public class ModelConsulta
    {
        public string CodCliente { get; set; }
        public string CodCMaster { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int NumCompras { get; set; }
        public int ParcelasPagas { get; set; }
        public int ParcelasAberto { get; set; }
        public int ParcelasAtraso { get; set; }
        public string Situacao { get; set; }
        public int MediaAtraso { get; set; }


        public static List<ModelConsulta> GetByResult(string consulta, int tipo, double coligada) 
        {
            using (var conn = new Dados.CorporeEntities()) 
            {
                var lista = new List<ModelConsulta>();
                IQueryable < Dados.FCFO > clientes;

                if (tipo == 1)
                {
                    //codigo cmaster
                    var cmaster = int.Parse(consulta);
                    clientes = conn.FCFO.Where(a => a.FCFOCOMPL.CODCMASTER == cmaster && a.CODCOLIGADA == coligada);
                }
                else 
                {
                    if (tipo == 2)
                    {
                        //cpf
                        clientes = conn.FCFO.Where(a => a.CGCCFO.Contains(consulta) && a.CODCOLIGADA == coligada);
                    }
                    else 
                    {
                        //nome
                        clientes = conn.FCFO.Where(a => a.NOMEFANTASIA.Contains(consulta) && a.CODCOLIGADA == coligada);
                    }
                }

                foreach (var cli in clientes)
                {
                    var item = new ModelConsulta();
                    item.CodCliente = cli.CODCFO;
                    item.CodCMaster = cli.FCFOCOMPL.CODCMASTER.ToString();
                    item.Nome = cli.NOMEFANTASIA;
                    item.Documento = cli.CGCCFO;
                    item.Telefone = cli.TELEFONE;
                    item.Celular = cli.TELEX;
                    item.NumCompras = cli.TMOV.Where(a => a.CODTMV.Contains("2.2.") && a.CODTB1FLX == "2.005" && a.STATUS != "C").Count();
                    item.ParcelasPagas = cli.FLAN.Where(a => a.PAGREC == 1 && a.STATUSLAN == 1).Count();
                    item.ParcelasAberto = cli.FLAN.Where(a => a.PAGREC == 1 && a.STATUSLAN == 0).Count();
                    item.ParcelasAtraso = cli.FLAN.Where(a => a.PAGREC == 1 && a.STATUSLAN == 0 && a.DATAVENCIMENTO < DateTime.Today).Count();

                    if (item.ParcelasAberto == 0)
                    {
                        item.Situacao = "REGULAR";
                    }
                    else 
                    {
                        item.Situacao = cli.FLAN.Where(a => a.PAGREC == 1 && a.STATUSLAN == 0 && a.DATAVENCIMENTO < DateTime.Today).Count() == 0 ? "REGULAR" : "INADIMPLENTE";
                    }                    
                        
                    item.MediaAtraso = CalculaMedia(cli.FLAN.Where(a => a.PAGREC == 1 && a.STATUSLAN == 1).ToList());

                    lista.Add(item);
                }

                return lista;
            }
        }

        private static int CalculaMedia(List<Dados.FLAN> lanc) 
        {
            int media = 0;
            int atual = 0;

            if (lanc.Count > 0) 
            {
                foreach (var item in lanc)
                {
                    if ((item.DATABAIXA.GetValueOrDefault() - item.DATAVENCIMENTO).Days < 0)
                        atual = 0;
                    else
                        atual = (item.DATABAIXA.GetValueOrDefault() - item.DATAVENCIMENTO).Days;

                    media += atual;
                }

                media = media / lanc.Count;
            }
            
            return media;
        }
    }
}
