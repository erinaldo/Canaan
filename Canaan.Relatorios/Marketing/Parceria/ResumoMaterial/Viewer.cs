using System;
using System.Collections.Generic;
using System.Linq;
using Canaan.Dados;

namespace Canaan.Relatorios.Marketing.Parceria.ResumoMaterial
{
    public partial class Viewer : Base.Viewer
    {
        private Dados.Filial Filial
        {
            get
            {
                return Lib.Session.Instance.Contexto.Filial;
            }
        }

        private List<ModelParceria> _parcerias;

        public Viewer()
        {
            InitializeComponent();
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
                Relatorio report = new Relatorio();

                report.SetDataSource(_parcerias);

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
                var pars = conn.Parceria.Where(a => a.IdFilial == Filial.IdFilial && a.Cupom.Any(b => b.IsDescartado == false && b.IsAgendado == false && b.TelemarketingMov.Count(c => c.IdStatus != Dados.EnumTelemarketingStatus.Distribuido) == 0));

                _parcerias = pars.Select(a => new ModelParceria
                {
                    IdParceria = a.IdParceria,
                    Nome = a.Nome,
                    Filial = Filial.NomeFantasia,
                    Abertura = a.DataInicio ?? DateTime.Today,
                    Encerramento = a.DataRetirada ?? DateTime.Today,
                    CuponsTotal = a.Cupom.Count(),
                    CuponsAbertos = a.Cupom.Count(b => b.IsDescartado == false && b.IsAgendado == false && b.TelemarketingMov.Count(c => c.IdStatus != Dados.EnumTelemarketingStatus.Distribuido) == 0),
                    CuponsAgendados = a.Cupom.Count(b => b.IsAgendado == true),
                    CuponsDescartados = a.Cupom.Count(b => b.IsDescartado == true),
                    CuponsFaltantes = a.Cupom.Count(b => b.Status == EnumCupomStatus.Faltante)
                }).ToList();


                _parcerias.ForEach(a => a.Logo = Utilitarios.Comum.GetLogoReport());
            }
        }
    }
}
