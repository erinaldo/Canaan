using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Canaan.Lib;
using DevExpress.Data.PLinq.Helpers;

namespace Canaan.Relatorios.Marketing.ListaTele.Avulsas
{
    public partial class EtiquetaAvulsa : Form
    {
        public BindingList<int> ListCodes { get; set; }

        public Lib.Atendimento LibAtendimento
        {
            get
            {
                return new Lib.Atendimento();
            }
        }

        public EtiquetaAvulsa()
        {
            InitializeComponent();
        }

        private void EtiquetaAvulsa_Load(object sender, EventArgs e)
        {
            ListCodes = new BindingList<int>();
            ConfiguraForm();
        }

        private void ConfiguraForm()
        {
            btnAdicionar.Focus();
            lbCodigos.DataSource = ListCodes;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var cod = int.Parse(txtCode.Text);

                if (Valida(cod))
                {
                    ListCodes.Add(cod);
                }
                else
                {
                    Lib.MessageBoxUtilities.MessageWarning(string.Format("{0} não existe e não será adicionado", cod));
                }
            }
            catch (Exception ex)
            {
                Lib.MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private bool Valida(int cod)
        {
            var result = LibAtendimento.GetByCodigoReduzidoAndFilial(cod, Session.Instance.Contexto.IdFilial);
            return result.Any();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var frm = new Viewer(ListCodes.ToList());
            frm.ShowDialog();
        }
    }
}
