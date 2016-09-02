using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Telas.Caderno
{
    public partial class frmVenda : Form
    {
        #region PROPRIEDADES
        public Dados.cadernos Caderno { get; set; }
        Dados.cadernos_vendas Venda { get; set; }
        public bool IsNovo { get; set; }
        public bool IsAdmin { get; set; }

        #endregion

        #region CONSTRUTORES

        public frmVenda(Dados.cadernos p_Caderno, bool p_IsAdmin)
        {
            //inicializa propriedades
            Caderno = p_Caderno;
            Venda = new Dados.cadernos_vendas();
            IsNovo = true;
            IsAdmin = p_IsAdmin;

            //inicializa componentes
            InitializeComponent();
        }

        public frmVenda(Dados.cadernos p_Caderno, int id, bool p_IsAdmin)
        {
            //inicializa propriedades
            Caderno = p_Caderno;
            Venda = Lib.CadernoVendas.GetById(id);
            IsNovo = false;
            IsAdmin = p_IsAdmin;

            //inicializa componentes
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void frmVenda_Load(object sender, EventArgs e)
        {
            CarregaVendedora();
            InitForm();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void venda_dinheiroTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateFaturamento();

            if (string.IsNullOrEmpty(venda_dinheiroTextBox.Text))
            {
                venda_dinheiroTextBox.Text = "0";
            }
        }

        private void venda_cartaoTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateFaturamento();

            if (string.IsNullOrEmpty(venda_cartaoTextBox.Text))
            {
                venda_cartaoTextBox.Text = "0";
            }
        }

        private void venda_prazoTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateFaturamento();

            if (string.IsNullOrEmpty(venda_prazoTextBox.Text))
            {
                venda_prazoTextBox.Text = "0";
            }
        }

        private void entrada_dinheiroTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entrada_dinheiroTextBox.Text))
            {
                entrada_dinheiroTextBox.Text = "0";
            }
        }

        private void entrada_depositadaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entrada_depositadaTextBox.Text))
            {
                entrada_depositadaTextBox.Text = "0";
            }
        }

        private void entrada_cartaoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entrada_cartaoTextBox.Text))
            {
                entrada_cartaoTextBox.Text = "0";
            }
        }

        #endregion

        #region METODOS

        private void InitForm()
        {
            if (IsNovo)
            {
                Text = string.Format(@"Nova venda do caderno do dia {0}", Caderno.data.ToShortDateString());

                //entradas
                entrada_dinheiroTextBox.Text = "0";
                entrada_cartaoTextBox.Text = "0";
                entrada_depositadaTextBox.Text = "0";

                //faturamento
                venda_dinheiroTextBox.Text = "0";
                venda_cartaoTextBox.Text = "0";
                venda_prazoTextBox.Text = "0";

                //programada
                is_programadaCheckBox.Checked = false;

                //vendedora
                vendedoraComboBox.SelectedIndex = 0;
            }
            else
            {
                Text = string.Format("Editando venda {0} - {1}", Venda.cod_cmaster, Venda.nome_cliente);

                //dados do cliente
                cod_cmasterTextBox.Text = Venda.cod_cmaster;
                cod_rmTextBox.Text = Venda.cod_rm;
                nome_clienteTextBox.Text = Venda.nome_cliente;
                vendedoraComboBox.SelectedValue = Venda.vendedora;

                //entradas
                entrada_dinheiroTextBox.Text = Venda.entrada_dinheiro.ToString();
                entrada_cartaoTextBox.Text = Venda.entrada_cartao.ToString();
                entrada_depositadaTextBox.Text = Venda.entrada_depositada.ToString();
                if (Venda.entrada_depositada_data.HasValue)
                    entrada_depositada_dataDateTimePicker.Value = (DateTime)Venda.entrada_depositada_data;

                //faturamento
                venda_dinheiroTextBox.Text = Venda.venda_dinheiro.ToString();
                venda_cartaoTextBox.Text = Venda.venda_cartao.ToString();
                venda_prazoTextBox.Text = Venda.venda_prazo.ToString();

                //programada
                is_programadaCheckBox.Checked = Venda.is_programada;
            }
        }

        private void UpdateFaturamento()
        {
            if (string.IsNullOrEmpty(venda_dinheiroTextBox.Text) == false && string.IsNullOrEmpty(venda_cartaoTextBox.Text) == false && string.IsNullOrEmpty(venda_prazoTextBox.Text) == false)
            {
                var venda_dinheiro = decimal.Parse(venda_dinheiroTextBox.Text);
                var venda_cartao = decimal.Parse(venda_cartaoTextBox.Text);
                var venda_prazo = decimal.Parse(venda_prazoTextBox.Text);
                var faturamento = venda_dinheiro + venda_cartao + venda_prazo;

                venda_totalTextBox.Text = faturamento.ToString();
            }
        }

        private void Salvar()
        {
            //atualiza dados do objeto
            Venda.id_caderno = Caderno.id_caderno;
            Venda.cod_cmaster = cod_cmasterTextBox.Text;
            Venda.cod_rm = cod_rmTextBox.Text;
            Venda.nome_cliente = nome_clienteTextBox.Text;
            Venda.vendedora = vendedoraComboBox.SelectedValue.ToString();

            Venda.entrada_dinheiro = decimal.Parse(entrada_dinheiroTextBox.Text);
            Venda.entrada_cartao = decimal.Parse(entrada_cartaoTextBox.Text);
            Venda.entrada_depositada = decimal.Parse(entrada_depositadaTextBox.Text);
            Venda.entrada_depositada_data = entrada_depositada_dataDateTimePicker.Value;

            Venda.venda_dinheiro = decimal.Parse(venda_dinheiroTextBox.Text);
            Venda.venda_cartao = decimal.Parse(venda_cartaoTextBox.Text);
            Venda.venda_prazo = decimal.Parse(venda_prazoTextBox.Text);
            Venda.venda_total = decimal.Parse(venda_totalTextBox.Text);

            Venda.is_programada = is_programadaCheckBox.Checked;

            //inclui ou atualiza venda
            try
            {
                if (IsNovo)
                {
                    //novo registro
                    Venda = Lib.CadernoVendas.Insert(Venda, IsAdmin);

                    //finaliza alteração
                    MessageBox.Show("Venda incluida com sucesso no caderno do dia " + Caderno.data.ToShortDateString());
                    IsNovo = false;
                    InitForm();
                }
                else
                {
                    //edita registro
                    Venda = Lib.CadernoVendas.Update(Venda, IsAdmin);

                    //finaliza alteração
                    MessageBox.Show(@"Venda alterada com sucesso no caderno do dia " + Caderno.data.ToShortDateString());
                    IsNovo = false;
                    InitForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaVendedora()
        {
            vendedoraComboBox.DisplayMember = "NOME";
            vendedoraComboBox.ValueMember = "NOME";

            if (Venda != null && Venda.id_venda == 0)
            {
                //recupera dados do banco
                var filial = Lib.Filiais.GetById(Caderno.id_filial);

                if (filial.rm_coligada == null || filial.rm_filial == null) return;

                var vendedoras = RM.Lib.Vendedora.GetByFilial((short)filial.rm_coligada, (short)filial.rm_filial);

                //carrega os dados da vendedora
                vendedoraComboBox.DataSource = vendedoras.Where(a => a.INATIVO == 0).OrderBy(a => a.NOME).ToList();
            }
            else
            {
                var list = new List<ModelVendedora> {new ModelVendedora {NOME = Venda.vendedora}};
                vendedoraComboBox.DataSource = list;
            }
        }

        #endregion

    }

    public class ModelVendedora
    {
        public string NOME { get; set; }
    }
}

