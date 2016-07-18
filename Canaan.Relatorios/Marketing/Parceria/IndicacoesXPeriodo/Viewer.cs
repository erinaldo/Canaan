using Canaan.Relatorios.Marketing.Parceria.ParceriaXPeriodo;
using Canaan.Relatorios.Marketing.Parceria.ParceriaXResultado;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Marketing.Parceria.IndicacoesXPeriodo
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Model DataModel { get; set; }
        public Dados.Filial Filial
        {
            get
            {
                return Lib.Session.Instance.Contexto.Filial;
            }
        }

        #endregion

        #region CONSTRUTORES

        public Viewer(DateTime pDataInicio, DateTime pDataFim)
        {
            this.DataInicio = pDataInicio;
            this.DataFim = pDataFim;
            this.DataModel = new Model();

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }

        #endregion

        #region METODOS

        private void CarregaDados()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                
                var arrayInt = conn.Convenio.Where(a => a.Tipo == Dados.EnumConvenioTipo.Indicacao || a.Tipo == Dados.EnumConvenioTipo.PosVenda).Select(a => a.IdConvenio).ToArray();
                var parcerias = conn.Parceria.Where(a => arrayInt.Contains(a.IdConvenio));

                foreach (var parceria in parcerias)
                {
                    var nome = parceria.Nome;
                    var cupons = parceria.Cupom.Where(a => a.Data >= this.DataInicio && a.Data <= this.DataFim);

                    if (cupons.Any())
                    {
                        var row = DataModel.Resultado.NewResultadoRow();

                        row.IdParceria = parceria.IdParceria;
                        row.Logo = Utilitarios.Comum.GetLogoReport();
                        row.Estudio = Filial.NomeFantasia;
                        row.Parceria = parceria.Nome;
                        row.QuantCupom = cupons.Count();
                        row.QuantAgendado = cupons.Count(a => a.IsAgendado == true);
                        row.QuantAtendido = cupons.Count(a => a.Agendamento.Any(b => b.Atendimento.Count > 0));
                        row.QuantDescartado = cupons.Count(a => a.IsDescartado == true);
                        row.QuantNaoUtilizado = cupons.Count(a => a.IsDescartado == false &&
                                                                  a.IsAgendado == false &&
                                                                  a.TelemarketingMov.Count(
                                                                      b =>
                                                                          b.IdStatus !=
                                                                          Dados.EnumTelemarketingStatus.Distribuido) ==
                                                                  0);

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
                                    foreach (
                                        var venda in
                                            atendimento.Venda.Where(
                                                a =>
                                                    a.IsConfirmado == true && a.IsLiberado == true && a.ValorLiquido > 0)
                                        )
                                    {
                                        row.QuantVendido++;
                                        row.Faturamento += venda.ValorLiquido.GetValueOrDefault();
                                    }

                                    //devolvidos
                                    foreach (
                                        var venda in atendimento.Venda.Where(a => a.IsDevolvida && a.ValorLiquido > 0))
                                    {
                                        row.QuantDevolvido++;
                                    }

                                    //brinde
                                    foreach (
                                        var venda in
                                            atendimento.Venda.Where(
                                                a =>
                                                    a.IsConfirmado == true && a.IsLiberado == true &&
                                                    a.ValorLiquido == 0))
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

        private void CarregaRelatorio()
        {
            try
            {
                //carrega os dados
                CarregaDados();

                //configura o relatorio
                Relatorio report = new Relatorio();
                TextObject txtPeriodo = (TextObject)report.ReportDefinition.Sections["Section1"].ReportObjects["txtPeriodo"];

                //carrega dados
                txtPeriodo.Text = string.Format("{0} à {1}", DataInicio.ToShortDateString(), DataFim.ToShortDateString());
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

        #endregion
    }
}
