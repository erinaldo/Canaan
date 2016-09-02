using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Telas.Ferramentas.Programadas
{
    public partial class LancLista : Form
    {
        //
        //PROPRIEDADES
        public Dados.TMOV Venda { get; set; }
        public List<Dados.FLAN> Lancamentos { get; set; }


        //
        //CONSTRUTORES
        public LancLista(Dados.TMOV pVenda)
        {
            //inicializa propriedades
            Venda = pVenda;
            Lancamentos = Venda.FLAN.ToList();

            //inicializa controles
            InitializeComponent();
        }



        //
        //EVENTOS
        private void LancLista_Load(object sender, EventArgs e)
        {
            InitForm();
            CarregaGrid();
        }

        private void btnAtualizaClasse_Click(object sender, EventArgs e)
        {
            AtualizaClasse();
        }


        //
        //METODOS
        private void InitForm() 
        {
            this.Text = string.Format("Lançamentos da Venda: {0} - {1} - {2}", Venda.IDMOV, Venda.CODCFO, Venda.FCFO.NOME);
        }

        private void UpdateLista() 
        {
            Lancamentos = Lib.Lancamento.GetByVenda(Venda);
            CarregaGrid();
        }

        private void CarregaGrid() 
        {
            if (Lancamentos.Count > 0)
            {
                lancamentoGridView.DataSource = Lancamentos.Select(a => new
                {
                    Status = Lib.Lancamento.GetStatus(a.STATUSLAN),
                    Codigo = a.IDLAN,
                    Classe = a.CODTB1FLX,
                    Emissao = a.DATAEMISSAO,
                    Vencimento = a.DATAVENCIMENTO,
                    Baixa = a.DATABAIXA,
                    Valor = a.VALORORIGINAL,
                    Baixado = a.VALORBAIXADO
                }).ToList();

                lancamentoGridView.ClearSelection();
            }
        }

        private void AtualizaClasse() 
        { 
            var selecteds = new List<Dados.FLAN>();
            var unselecteds = new List<Dados.FLAN>();
            var filial = Lib.Filiais.GetById((short)Venda.CODCOLIGADA, (short)Venda.CODFILIAL);
            
            //separa lista de selecionadas e nao selecionadas
            foreach (DataGridViewRow item in lancamentoGridView.Rows)
            {
                if (item.Selected)
                {
                    selecteds.Add(Lancamentos.FirstOrDefault(a => a.IDLAN == (int)item.Cells["Codigo"].Value));
                }
                else 
                {
                    unselecteds.Add(Lancamentos.FirstOrDefault(a => a.IDLAN == (int)item.Cells["Codigo"].Value));
                }
            }

            //abre a tela de atualização
            LancUpdateClasse frm = new LancUpdateClasse(filial, selecteds, unselecteds);
            frm.ShowDialog();

            //atualiza lista
            UpdateLista();
        }
    }
}
