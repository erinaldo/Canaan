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
    public partial class VendaCaderno : Form
    {
        //
        //PROPRIEDADES
        public Dados.TMOV Venda { get; set; }
        public bool HasEntrada { get; set; }

        //
        //CONTRUTORES
        public VendaCaderno(Dados.TMOV pVenda)
        {
            //inicializa propriedades
            Venda = pVenda;
            HasEntrada = true;

            //inicializa controles
            InitializeComponent();
        }

        //
        //EVENTOS
        private void VendaCaderno_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void rbSemEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSemEntrada.Checked)
            {
                HasEntrada = false;
                HabilitaLanc(false);
            }
        }

        private void rbComEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbComEntrada.Checked)
            {
                HasEntrada = true;
                HabilitaLanc(true);
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            CorrigeCaderno();
        }


        //
        //METODOS
        private void InitForm() 
        {
            //iniciliza titulo
            this.Text = string.Format("Caderno de Vendas: {0} - {1}", Venda.IDMOV, Venda.FCFO.NOME);

            //carrega lista de lancamentos
            CarregaGrid();

            //inicializa  com entrada
            rbComEntrada.Checked = true;

            //carrega classes contabeis
            CarregaClasses();
        }

        private void HabilitaLanc(bool status) 
        {
            lancamentoGridView.Enabled = status;

            if (status)
                lancamentoGridView.Rows[0].Selected = true;
            else
                lancamentoGridView.ClearSelection();
        }

        private void CarregaGrid()
        {
            var Lancamentos = Lib.Lancamento.GetByVenda(Venda);

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

        private void CarregaClasses()
        {
            //configura a lista
            var lista = Lib.ClasseContabil.Get(Venda.CODCOLIGADA).Select(a => new
            {
                Codigo = a.CODTB1FLX,
                Nome = string.Format("{0} - {1}", a.CODTB1FLX, a.DESCRICAO)
            }).OrderBy(a => a.Nome).ToList();

            //configura combo das selecionadas
            classeComboBox.DisplayMember = "Nome";
            classeComboBox.ValueMember = "Codigo";
            classeComboBox.DataSource = lista;
            classeComboBox.SelectedValue = "2.005";

        }

        private void CorrigeCaderno() 
        {
            if (ConfirmaExecucao() == true) 
            {
                if (ConfirmaInfo() == true) 
                {
                    try
                    {
                        ExecutaCorrecao();
                        MessageBox.Show("Venda atualizada com sucesso");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }    
            }
        }

        private bool ConfirmaExecucao() 
        {
            bool status = false;
            string msg = string.Format("Tem certeza que deseja incluir a venda {0} - {1}, no valor de {2} no caderno do dia {3}", Venda.IDMOV, Venda.FCFO.NOME, Venda.VALORLIQUIDO, cadernoDateTimePicker.Value.ToShortDateString());

            if (MessageBox.Show(msg, "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                status = true;
            }

            return status;
        }

        private bool ConfirmaInfo() 
        {
            bool status = false;
            string msg = "As seguintes informações stao corretas?\n";

            //data
            msg += string.Format("- Data do caderno: {0}\n", cadernoDateTimePicker.Value.ToShortDateString());

            //tipo de entrada
            if (HasEntrada)
            {
                msg += "\n- Informações da entrada:\n";
                
                //classe contabil
                msg += string.Format("- Classe contábil das parcelas: {0}\n", classeComboBox.SelectedValue.ToString());

                //enradas
                msg += "\n- Parcelas que compõem a entrada:\n";

                //loop nas estradas
                foreach (DataGridViewRow item in lancamentoGridView.SelectedRows)
                {
                    msg += string.Format("{0} - {1:d} - {2:c}\n", item.Cells["Codigo"].Value, item.Cells["Vencimento"].Value, item.Cells["Valor"].Value);
                }
            }
            else 
            {
                msg += string.Format("- Tipo de Entrada: {0}\n", "Venda sem entrada");
            }

            //faz confirmação
            if (MessageBox.Show(msg, "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                status = true;
            }

            //retorna
            return status;
        }

        private void ExecutaCorrecao() 
        { 
            //inclui venda no caderno
            Lib.Movimento.UpdateIncluiCaderno(Venda, cadernoDateTimePicker.Value.Date);

            //atualiza classe contabil das parcelas
            foreach (DataGridViewRow item in lancamentoGridView.Rows)
            {
                //recupera lancamento atual
                var lanc = Lib.Lancamento.GetById(Venda.CODCOLIGADA, (int)item.Cells["Codigo"].Value);

                //verifica se tem entrada
                if (HasEntrada)
                {
                    if (item.Selected)
                    {
                        lanc.CODTB1FLX = "2.019";
                    }
                    else 
                    {
                        lanc.CODTB1FLX = classeComboBox.SelectedValue.ToString();
                    }
                }
                else 
                {
                    lanc.CODTB1FLX = classeComboBox.SelectedValue.ToString();
                }

                //atualiza no banco de dados
                Lib.Lancamento.UpdateClasseContabil(lanc);
            }

        }
    }
}
