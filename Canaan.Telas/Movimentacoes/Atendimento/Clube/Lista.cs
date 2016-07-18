using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;

namespace Canaan.Telas.Movimentacoes.Atendimento.Clube
{
    public partial class Lista : Form
    {
        #region PROPRIEDADES

        public List<Dados.Atendimento> Clientes { get; set; }

        public Lib.Atendimento LibAtendimento
        {
            get
            {
                return new Lib.Atendimento();
            }
        }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public Dados.Atendimento Atendimento { get; set; }

        public Dados.Atendimento Selecionado { get; set; }

        public bool PermiteSelecionar { get; set; }

        public Indicacao LibIndicacao 
        { 
            get
            {
                return new Indicacao();
            }
        }

        #endregion

        #region CONSTRUTORES

        public Lista()
        {
            InitializeComponent();
            PermiteSelecionar = true;
        }

        public Lista(Dados.Atendimento atendimento)
            : this()
        {
            Atendimento = atendimento;
            
            var result = LibAtendimento.GetAtedimentosIndicados(atendimento.IdAtendimento);
            dgvAtendimentos.DataSource = LibAtendimento.CarregaGrid(result.ToList());

            //desabilita o groupbox de busca
            this.groupBox1.Enabled = false;

            //altera o titulo
            this.Text = string.Format("Indicados por {0}", Atendimento.CliFor.Nome);
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {
            dgvAtendimentos.AutoGenerateColumns = false;

            CarregaTipoBusca();

            ddlTipoBusca.SelectedIndex = 0;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                BuscaClientes();
                CarregaGridAtendimentos();
            }
            catch (Exception ex)
            {

                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void dgvAtendimentos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAtendimentos.SelectedRows.Count > 0)
            {
                var idAtendimento = int.Parse(dgvAtendimentos.SelectedRows[0].Cells[0].Value.ToString());
                Selecionado = LibAtendimento.GetById(idAtendimento);
                CalculaIndicacaoes();
            }
        }

        private void dgvAtendimentos_DoubleClick(object sender, EventArgs e)
        {
            MostraIndicacoes();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MostraIndicacoes();
        }

        #endregion

        #region METODOS

        private void CalculaIndicacaoes()
        {
            lbQtdade.Text = LibIndicacao.GetIndicadosAtendidos(Selecionado.IdAtendimento).ToString();
        }

        private void CarregaTipoBusca()
        {
            ddlTipoBusca.Items.Clear();
            ddlTipoBusca.Items.AddRange(Enum.GetNames(typeof(TipoBusca)));
        }

        private void BuscaClientes()
        {
            var value = ddlTipoBusca.SelectedItem.ToString();
            var selected = (TipoBusca)Enum.Parse(typeof(TipoBusca), value);

            switch (selected)
            {
                case TipoBusca.Codigo:
                    Clientes = (LibAtendimento.GetByCodigoReduzidoAndFilial(int.Parse(tbBusca.Text.Trim()), Session.Contexto.IdFilial));
                    break;
                case TipoBusca.Cpf:
                    Clientes = LibAtendimento.GetByCpfAndFilial(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                    break;
                case TipoBusca.Nome:
                    Clientes = LibAtendimento.GetByNomeAndFilial(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                    break;
                default:
                    Clientes = LibAtendimento.GetByNomeAndFilial(tbBusca.Text.Trim(), Session.Contexto.IdFilial);
                    break;
            }
        }

        private void CarregaGridAtendimentos()
        {
            dgvAtendimentos.DataSource = LibAtendimento.CarregaGrid(Clientes);
        }

        private void MostraIndicacoes()
        {
            var frm = new Lista(Selecionado);
            frm.ShowDialog();
        }

        #endregion
    }
}
