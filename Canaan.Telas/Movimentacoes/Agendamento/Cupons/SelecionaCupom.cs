using System;
using System.Collections.Generic;
using System.Linq;
using Canaan.Dados;
using Canaan.Telas.Base;

namespace Canaan.Telas.Movimentacoes.Agendamento.Cupons
{
    public partial class SelecionaCupom : FormSelecao
    {
        #region PROPRIEDADES

        public List<Cupom> Cupons { get; set; }
       
        public Cupom SelectedCupom { get; set; }

        #endregion

        #region CONSTRUTOR

        public SelecionaCupom(List<Cupom> listaCupons)
        {
            InitializeComponent();

            Text = "Cupons com mesmo número de telefone";
            toolStripSeleciona.Visible = false;
            Cupons = listaCupons;
        }

        #endregion

        #region EVENTOS

        private void SelecionaCupom_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        protected override void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            SelecionaItem();
        }

        #endregion

        #region METODOS

        private void CarregaGrid()
        {
            dataGrid.DataSource = Cupons.Select(a => new
            {
                a.IdCupom,
                a.Nome,
                Parceria = a.Parceria.Nome,
                a.Telefone,
                a.Celular,
                a.Status,
                a.IsAtivo
            }).ToList();
        }

        private void SelecionaItem()
        {
            var id = int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString());
            SelectedCupom = Cupons.FirstOrDefault(a => a.IdCupom == id);
            Close();
        }

        #endregion

    }
}


