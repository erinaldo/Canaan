using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Telas.Ferramentas.Spc
{
    public partial class Lista : Form
    {
        #region PROPRIEDADES

        public ModelFiltro objFiltro { get; set; }
        public BindingList<ModelLista> DataList { get; set; }
        public ModelLista Atual 
        { 
            get 
            {
                return dataGridView1.BindingContext[DataList].Current as ModelLista;
            } 
        }
        
        #endregion

        #region CONSTRUTORES

        public Lista()
        {
            DataList = new BindingList<ModelLista>(new List<ModelLista>());
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataList;
            CarregaFitro();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            CarregaFitro();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void btnRemessa_Click(object sender, EventArgs e)
        {
            GeraArquivo();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (Atual != null)
            {
                var filial = Lib.Filiais.GetById((short)objFiltro.Filial.rm_coligada, (short)objFiltro.Filial.rm_filial);
                var frm = new Detalhe(Atual.CodCliente, filial);
                frm.ShowDialog();
            }
        }

        #endregion

        #region METODOS

        private void CarregaFitro() 
        {
            var frm = new Filtro();
            frm.ShowDialog();

            if(frm.objFiltro != null)
            {
                //carrega dados do filtro
                objFiltro = frm.objFiltro;

                //carrega informações
                CarregaInfo();

                //carrega grid
                CarregaGrid();
            }
        }

        private void CarregaInfo() 
        {
            lbInfo.Text = string.Format("{0} - {1} - {2} a {3}", 
                objFiltro.Filial.nome,
                objFiltro.Tipo.ToString(),
                objFiltro.DataInicio.ToShortDateString(), 
                objFiltro.DataFim.ToShortDateString());
        }

        private void CarregaGrid() 
        {
            List<Dados.FLAN> lanc;

            if(objFiltro.Tipo == TipoAcao.Registro)
                lanc = Lib.Lancamento.SPC_Registro(objFiltro.Filial, objFiltro.DataInicio, objFiltro.DataFim);
            else
                lanc = Lib.Lancamento.SPC_Reabilitar(objFiltro.Filial, objFiltro.DataInicio, objFiltro.DataFim);

            GetBindingList(lanc.OrderBy(a => a.DATAVENCIMENTO).ThenBy(a => a.CODCFO).ToList());
        }

        private void GetBindingList(List<Dados.FLAN> lanc) 
        {
            DataList.Clear();

            foreach (var item in lanc)
            {
                if (item.TMOV != null) {
                    ModelLista reg = new ModelLista();
                    reg.IsChecked = false;
                    reg.IdLan = item.IDLAN;
                    reg.IdMov = item.IDMOV.GetValueOrDefault();
                    reg.ClasseContabil = item.CODTB1FLX;
                    reg.CodCliente = item.CODCFO;
                    reg.NomeCliente = item.FCFO.NOMEFANTASIA;
                    reg.DataEmissao = item.DATAEMISSAO;
                    reg.DataVencimento = item.DATAVENCIMENTO;
                    reg.DataBaixa = item.DATABAIXA;
                    reg.ValorOriginal = item.TMOV.FLAN.Where(a => a.STATUSLAN == 0).Sum(a => a.VALORORIGINAL);
                    reg.ValorBaixado = item.VALORBAIXADO;

                    DataList.Add(reg);
                }
            }
        }

        private void RemoveItem() 
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            
            //cria lista com itens a serem excluidos
            var delete = DataList.Where(a => a.IsChecked).ToList();

            //verifica se existem itens para exclusao
            if (delete.Count > 0)
            {
                //confirma a exclusao
                var confirm = string.Format("Tem certeza que deseja excluir os {0} items selecionados\n\n", delete.Count);
                foreach (var item in delete)
                {
                    confirm += string.Format("{0} - {1} - {2}\n", item.IdLan, item.NomeCliente, item.ValorOriginal);
                }

                if (MessageBox.Show(confirm, "Confirmação", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) 
                {
                    foreach (var item in delete)
                    {
                        DataList.Remove(item);
                    }
                }
            }
            else 
            {
                MessageBox.Show("Nenhum registro selecionado");
            }
            
        }

        private void GeraArquivo() 
        {
            //carrega informacoes
            var tipo = objFiltro.Tipo == TipoAcao.Registro ? RM.Lib.TipoAtualizacao.Inclusao : RM.Lib.TipoAtualizacao.Exclusao;
            var lista = DataList.Select(a => a.IdLan).ToList();            
            var filial = Lib.Filiais.GetById((short)objFiltro.Filial.rm_coligada, (short)objFiltro.Filial.rm_filial);
            
            //abre a tela de envio
            var frm = new Envio(lista, filial, tipo);
            frm.ShowDialog();
        }

        #endregion
    }
}
