using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Canaan.Relatorios.Venda.Produtos
{
    public partial class Filtro : Form
    {
        private static Lib.Produto LibProduto
        {
            get { return new Lib.Produto(); }
        }

        private List<Dados.Produto> Produtos { get; set; }


        public Filtro()
        {
            InitializeComponent();
        }

        private void Filtro_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaForm();
        }

        private void CarregaForm()
        {
            cbProdutos.DisplayMember = "Nome";
            cbProdutos.ValueMember = "IdProduto";
            cbProdutos.DataSource = Produtos;
        }

        private void CarregaDados()
        {
            Produtos = LibProduto.Get().GroupBy(a => a.Nome).Select(a => a.First()).OrderBy(a => a.Nome).ToList();
        }

        private void ckEspecifico_CheckedChanged(object sender, EventArgs e)
        {
            cbProdutos.Enabled = ckEspecifico.Checked;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var filtro = new ModelFiltro
            {
                Especifico = ckEspecifico.Checked,
                DataInicial = dtInicial.Value,
                DataFinal =  dtFinal.Value,                
                TipoRelatorio = GetTipoRelatorio(),
                Produto = ckEspecifico.Checked ? LibProduto.GetById(int.Parse(cbProdutos.SelectedValue.ToString())) : null,
                Todos = !ckEspecifico.Checked,
                Produtos = Produtos
            };


            var frm = new Viewer(filtro);
            frm.ShowDialog();

        }

        private TipoRelatorio GetTipoRelatorio()
        {
            if (cbDevolvidas.Checked)
                return TipoRelatorio.Devolvidas;

            if (cbLiberadas.Checked)
                return TipoRelatorio.Liberadas;

            if (cbTodas.Checked)
                return TipoRelatorio.Todas;

            return TipoRelatorio.Programadas;
        }
    }
}
