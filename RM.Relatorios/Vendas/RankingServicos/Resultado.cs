using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Vendas.RankingServicos
{
    public partial class Resultado : Form
    {
        //
        //PROPRIEDADES
        private DateTime DataInicio { get; set; }
        private DateTime DataFim { get; set; }
        public bool IsSintetico { get; set; }
        public bool IsColecao { get; set; }

        //
        //CONSTRUTOR
        public Resultado(DateTime dtInicio, DateTime dtFim, bool Sintetico, bool Colecao)
        {
            DataInicio = dtInicio;
            DataFim = dtFim;
            IsSintetico = Sintetico;
            IsColecao = Colecao;

            InitializeComponent();
        }

        //
        //METODOS
        public void CarregaRelatorio()
        {
            List<Model> data = new List<Model>();

            //configura o relatorio
            Relatorio report = new Relatorio();

            //pega os dados
            if (IsSintetico)
            {
                data = Model.Get(DataInicio, DataFim)
                            .GroupBy(a => a.NomeProduto)
                            .Select(a => new Model{
                                CodColigada = 0,
                                CodFilial = 0,
                                CodProduto = 0,
                                NomeFilial = "Geral",
                                NomeProduto = a.Key,
                                Quantidade = a.Sum(b => b.Quantidade),
                                ValorUnitario = a.Sum(b => b.ValorUnitario),
                                ValorTotal = a.Sum(b => b.ValorTotal)
                            })
                            .OrderByDescending(a => a.Quantidade)
                            .ToList();
            }
            else 
            {
                data = Model.Get(DataInicio, DataFim)
                            .GroupBy(a => new { a.NomeFilial, a.NomeProduto })
                            .Select(a => new Model
                            {
                                CodColigada = 0,
                                CodFilial = 0,
                                CodProduto = 0,
                                NomeFilial = a.Key.NomeFilial,
                                NomeProduto = a.Key.NomeProduto,
                                Quantidade = a.Sum(b => b.Quantidade),
                                ValorUnitario = a.Sum(b => b.ValorUnitario),
                                ValorTotal = a.Sum(b => b.ValorTotal)
                            })
                            .OrderByDescending(a => a.Quantidade)
                            .ToList();
            }

            //verifica se e somente colecoes
            if (IsColecao)
            {
                //carrega dados
                report.SetDataSource(data.Where(a => a.NomeProduto.Contains("COLECAO") || a.NomeProduto.Contains("COLEÇAO") || a.NomeProduto.Contains("COLEÇÃO") || a.NomeProduto.Contains("PRESTAÇÃO")).ToList());
            }
            else {
                //carrega dados
                report.SetDataSource(data);
            }

            

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }


        //
        //EVENTOS
        private void Resultado_Load(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }
    }
}
