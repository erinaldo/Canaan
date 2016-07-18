using System;
using System.Windows.Forms;
using Canaan.Lib;
using System.Collections.Generic;

namespace Canaan.Telas.Rotinas.Marketing.DistribuicaoCupons.Parametros
{
    public partial class DadosDistribuicao : Form
    {
        public int NumeroDeCupons { get; set; }
        public DateTime DataLimite { get; set; }
        public List<string> Operadoras { get; set; }

        
        public DadosDistribuicao()
        {
            InitializeComponent();

            //Data padrão para o limite do cupom
            dtEditLimite.EditValue = DateTime.Today;
            
        }

        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                CarregaQuantidade();
                CarregarDataLimite();
                CarregaOperadoras();
                Close();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }


        }

        private void CarregaOperadoras()
        {
            this.Operadoras = new List<string>();

            if (oiCheckBox.Checked)
                this.Operadoras.Add("OI");

            if (timCheckBox.Checked)
                this.Operadoras.Add("TIM");

            if (vivoCheckBox.Checked)
                this.Operadoras.Add("Telefônica");

            if (claroCheckBox.Checked)
                this.Operadoras.Add("Claro");
        }

        private void CarregarDataLimite()
        {
            try
            {
                DataLimite = DateTime.Parse(dtEditLimite.EditValue.ToString());
            }
            catch
            {
                DataLimite = DateTime.Today.AddDays(1);
            }
        }

        private string CarregaQuantidade()
        {
            //Input para carregar numero de cupons
            var result = txtQuantidade.Text;

            //Converte string para int
            int val = 0;
            var conversaoOK = int.TryParse(result, out val);

            if (!conversaoOK)
                throw new Exception("O valor digitado não é um numero válido");

            NumeroDeCupons = val;
            return result;
        }
    }
}
