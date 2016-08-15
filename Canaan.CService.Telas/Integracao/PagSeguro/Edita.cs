using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.CService.Telas.Integracao.PagSeguro
{
    public partial class Edita : Form
    {
        public Model Venda { get; set; }

        public Edita()
        {
            this.Venda = new Model();
            InitializeComponent();
        }

        private void Edita_Load(object sender, EventArgs e)
        {
            CarregaForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var frm = new RM.Telas.Consultas.Cliente.Consulta(7, false);
            frm.ShowDialog();

            if (!string.IsNullOrEmpty(frm.CodCliente)) {
                this.Venda = Model.GetByCodigo(frm.CodCliente, 7);
                CarregaForm();
            }
        }

        private void btnFinaliza_Click(object sender, EventArgs e)
        {
            FinalizaVenda();
        }

        private void CarregaForm()
        {
            codigoTextBox.Text = this.Venda.Codigo;
            nomeTextBox.Text = this.Venda.Nome;
            documentoTextBox.Text = this.Venda.Documento;
            emailTextBox.Text = this.Venda.Email;
            dddTextBox.Text = this.Venda.DDD;
            telefoneTextBox.Text = this.Venda.Telefone;

            estadoTextBox.Text = this.Venda.Estado;
            cidadeTextBox.Text = this.Venda.Cidade;
            bairroTextBox.Text = this.Venda.Bairro;
            cepTextBox.Text = this.Venda.Cep;
            ruaTextBox.Text = this.Venda.Endereco;
            numeroTextBox.Text = this.Venda.Numero;
            complementoTextBox.Text = this.Venda.Complemento;

            servicoTextBox.Text = this.Venda.Servico;
            valorTextBox.Text = this.Venda.Valor.ToString();
            freteTextBox.Text = this.Venda.Frete.ToString();
        }

        private void CarregaModel()
        {
            this.Venda.Codigo = codigoTextBox.Text;
            this.Venda.Nome = nomeTextBox.Text;
            this.Venda.Documento = documentoTextBox.Text;
            this.Venda.Email = emailTextBox.Text;
            this.Venda.DDD = dddTextBox.Text;
            this.Venda.Telefone = telefoneTextBox.Text;

            this.Venda.Estado = estadoTextBox.Text;
            this.Venda.Cidade = cidadeTextBox.Text;
            this.Venda.Bairro = bairroTextBox.Text;
            this.Venda.Cep = cepTextBox.Text;
            this.Venda.Endereco = ruaTextBox.Text;
            this.Venda.Numero = numeroTextBox.Text;
            this.Venda.Complemento = complementoTextBox.Text;

            this.Venda.Servico = servicoTextBox.Text;
            this.Venda.Valor = decimal.Parse(valorTextBox.Text);
            this.Venda.Frete = decimal.Parse(freteTextBox.Text);
        }

        private void FinalizaVenda()
        {
            CarregaModel();

            var url = Model.CriaPagamento(this.Venda).AbsoluteUri;
            var frm = new Browser(url);
            frm.Show();
        }
    }
}
