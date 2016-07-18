using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Canaan.Dados;
using CrystalDecisions.CrystalReports.Engine;

namespace Canaan.Relatorios.Marketing.Parceria.ParceriaOnlineXPeriodo
{
    public partial class Viewer : Base.Viewer
    {
        private Parceria.ParceriaXResultado.Model DataModel { get; set; }
        private readonly DateTime _dataInicial;
        private readonly DateTime _dataFinal;

        private Filial Filial
        {
            get
            {
                return Lib.Session.Instance.Contexto.Filial;
            }
        }

        public Viewer()
        {
            InitializeComponent();
        }

        public Viewer(DateTime dataInicial, DateTime dataFinal)
            : this()
        {
            _dataInicial = dataInicial;
            _dataFinal = dataFinal;
            this.DataModel = new Parceria.ParceriaXResultado.Model();
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorio();
        }

        private void CarregaRelatorio()
        {
            try
            {
                //configura o relatorio
                var report = new Relatorio();
                var txtPeriodo = (TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["txtPeriodo"];

                //carrega dados
                txtPeriodo.Text = string.Format("{0} à {1}", _dataInicial.ToShortDateString(), _dataFinal.ToShortDateString());
                report.SetDataSource(DataModel);

                //carrega o report viewer
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Zoom(100);
            }
            catch (Exception ex)
            {
                Lib.MessageBoxUtilities.MessageError(null, ex);
            }
        }

        public void CarregaDados()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var parcerias = conn.Parceria.Where(a => a.IdFilial == Filial.IdFilial && a.IdConsultora != null && a.DataInicio >= _dataInicial && a.DataInicio <= _dataFinal);

                foreach (var parceria in parcerias)
                {
                    var nome = parceria.Nome;
                    var cupons = parceria.Cupom.ToList();

                    if (cupons.Any())
                    {
                        var row = DataModel.Resultado.NewResultadoRow();

                        row.IdParceria = parceria.IdParceria;
                        row.Logo = Utilitarios.Comum.GetLogoReport();
                        row.Estudio = this.Filial.NomeFantasia;
                        row.Parceria = parceria.Nome;
                        row.QuantCupom = cupons.Count();
                        row.QuantAgendado = cupons.Count(a => a.IsAgendado == true);
                        row.QuantAtendido = cupons.Count(a => a.Agendamento.Any(b => b.Atendimento.Count > 0));
                        row.QuantDescartado = cupons.Count(a => a.IsDescartado == true);
                        row.QuantNaoUtilizado = cupons.Count(a => a.IsDescartado == false &&
                                                                          a.IsAgendado == false &&
                                                                          a.TelemarketingMov.Count(b => b.IdStatus != Dados.EnumTelemarketingStatus.Distribuido) == 0);


                        row.QuantVendido = 0;
                        row.Faturamento = 0;
                        row.QuantDevolvido = 0;
                        row.QuantBrinde = 0;
                        foreach (var cupom in cupons)
                        {
                            foreach (var agendamento in cupom.Agendamento)
                            {
                                foreach (var atendimento in agendamento.Atendimento)
                                {
                                    //vendidos
                                    foreach (var venda in atendimento.Venda.Where(a => a.IsConfirmado == true && a.IsLiberado == true && a.ValorLiquido > 0))
                                    {
                                        row.QuantVendido++;
                                        row.Faturamento += venda.ValorLiquido.GetValueOrDefault();
                                    }

                                    //devolvidos
                                    foreach (var venda in atendimento.Venda.Where(a => a.IsDevolvida && a.ValorLiquido > 0))
                                    {
                                        row.QuantDevolvido++;
                                    }

                                    //brinde
                                    foreach (var venda in atendimento.Venda.Where(a => a.IsConfirmado == true && a.IsLiberado == true && a.ValorLiquido == 0))
                                    {
                                        row.QuantBrinde++;
                                    }
                                }
                            }
                        }


                        //conversao
                        row.Conversao = row.QuantAtendido > 0 ? (100 * row.QuantVendido) / row.QuantAtendido : 0;

                        //adiciona no dataset
                        DataModel.Resultado.AddResultadoRow(row);
                    }

                }
            }
        }
    }
}
