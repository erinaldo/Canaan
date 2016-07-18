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
using Canaan.Relatorios.Marketing.Parceria.ParceriaXPeriodo;
using Canaan.Relatorios.Marketing.Parceria.ResumoMaterial;
using CrystalDecisions.CrystalReports.Engine;

namespace Canaan.Relatorios.Marketing.Parceria.ParceriaOnlineXResultado
{
    public partial class Viewer : Base.Viewer
    {
        private readonly int _idconsultora;
        private readonly string _consultora;

        private Dados.Filial Filial
        {
            get
            {
                return Lib.Session.Instance.Contexto.Filial;
            }
        }

        private List<ModelParceria> _parcerias;

        public Viewer(int idconsultora, string consultora)
        {
            _idconsultora = idconsultora;
            _consultora = consultora;

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

                TextObject txt = (TextObject)report.Section1.ReportObjects["txtConsultora"];
                txt.Text = _consultora;
                
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
            using (var conn = new CanaanModelContainer())
            {
                var pars = conn.Parceria.Where(a => a.IdFilial == Filial.IdFilial && a.IdConsultora == _idconsultora);

                _parcerias = pars.Select(a => new ModelParceria
                {
                    IdParceria = a.IdParceria,
                    Nome = a.Nome,
                    Filial = Filial.NomeFantasia,
                    Abertura = a.DataInicio ?? DateTime.Today,
                    Encerramento = a.DataRetirada ?? DateTime.Today,
                    CuponsTotal = a.Cupom.Count(),
                    CuponsAbertos = a.Cupom.Count((b => b.IsDescartado == false && b.IsAgendado == false)),
                    CuponsAgendados = a.Cupom.Count(b => b.IsAgendado == true && b.IsDescartado == false && b.Status != EnumCupomStatus.Faltante),
                    CuponsDescartados = a.Cupom.Count(b => b.IsDescartado == true && b.IsAgendado == false),
                    CuponsFaltantes = a.Cupom.Count(b => b.Status == EnumCupomStatus.Faltante)
                }).ToList();


                _parcerias.ForEach(a => a.Logo = Utilitarios.Comum.GetLogoReport());
            }
        }
    }
}
