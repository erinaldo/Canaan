using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Faturamento.Vendedora
{
    public partial class Filtro : Form
    {
        //propriedades
        Dados.GFILIAL Filial { get; set; }

        //contrutores
        public Filtro()
        {
            InitializeComponent();
        }

        public Filtro(short CodColigada, short CodFilial)
        {
            Filial = Lib.Filiais.GetById(CodColigada, CodFilial);

            InitializeComponent();
        }


        //metodos
        private void InitForm()
        {
            //habilita - desabilita controles
            if (Filial != null)
                comboFilial.Enabled = false;
            else
                comboFilial.Enabled = true;

            //carrega combos
            CarregaFiliais();
            CarregaVendedoras();
        }

        private void CarregaFiliais()
        {
            comboFilial.ValueMember = "CGC";
            comboFilial.DisplayMember = "NOMEFANTASIA";

            if (Filial != null)
            {
                List<Dados.GFILIAL> filiais = new List<Dados.GFILIAL>();
                filiais.Add(Filial);

                comboFilial.DataSource = filiais;
            }
            else
            {
                comboFilial.DataSource = Lib.Filiais.GetEstudios();
            }
        }

        private void CarregaVendedoras()
        {
            //carrega objetos
            Filial = Lib.Filiais.GetByCnpj(comboFilial.SelectedValue.ToString());
            List<Dados.TVEN> vendedoras = Lib.Vendedora.GetByFilial(Filial.CODCOLIGADA, Filial.CODFILIAL);

            //carrega combo
            comboVendedora.ValueMember = "CODVEN";
            comboVendedora.DisplayMember = "NOME";
            comboVendedora.DataSource = vendedoras;
        }

        private List<Model> GetResult()
        {
            //declara objetos
            Dados.GFILIAL filial = Lib.Filiais.GetByCnpj(comboFilial.SelectedValue.ToString());
            List<Dados.FLAN> lancamentos = Lib.Lancamento.GetEntradas_AbertoByVencimento(filial.CODCOLIGADA, filial.CODFILIAL, dataInicio.Value, dataFim.Value);

            //filta o resultado
            if (checkVendedora.Checked == false)
                return Model.GetAll(filial.CODCOLIGADA, filial.CODFILIAL, dataInicio.Value, dataFim.Value);
            else
                return Model.GetByVendedora(filial.CODCOLIGADA, filial.CODFILIAL, (string)comboVendedora.SelectedValue, dataInicio.Value, dataFim.Value);
        }

        private void CarregaRelatorio()
        {
            Resultado frm = new Resultado(GetResult(), comboFilial.Text, dataInicio.Value, dataFim.Value);
            frm.Show();
        }

        //eventos
        private void Filtro_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void comboFilial_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaVendedoras();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }


    }
}
