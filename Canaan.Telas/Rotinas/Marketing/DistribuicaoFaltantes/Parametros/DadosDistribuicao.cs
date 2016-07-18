using System;
using System.Windows.Forms;

namespace Canaan.Telas.Rotinas.Marketing.DistribuicaoFaltantes.Parametros
{
    public partial class DadosDistribuicao : Form
    {
        /// <summary>
        /// Numero de Cupons
        /// </summary>
        public int NumeroDeCupons { get; set; }

        /// <summary>
        /// Data limite do Telemarketing
        /// </summary>
        public DateTime DataLimite { get; set; }

        /// <summary>
        /// Contrutor
        /// </summary>
        public DadosDistribuicao()
        {
            InitializeComponent();

            //Data padrão para o limite do cupom
            dtEditLimite.EditValue = DateTime.Today.AddDays(1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CarregaQuantidade();
            CarregarDataLimite();
            Close();
        }

        /// <summary>
        /// Carrega Data Limite
        /// </summary>
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

        /// <summary>
        /// Carrega Quantidade
        /// </summary>
        /// <returns></returns>
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
