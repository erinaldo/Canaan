using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Cobranca.UltimaParcela
{
    public partial class frmFiltro : Form
    {
        #region PROPRIEDADES
            public dsReport Dados { get; set; }
        #endregion

        #region CONSTRUTORES

        public frmFiltro()
        {
            Dados = new dsReport();
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void frmFiltro_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void contextoGrupo_CheckedChanged(object sender, EventArgs e)
        {
            ConfigContexto();
        }

        private void contextoFranquia_CheckedChanged(object sender, EventArgs e)
        {
            ConfigContexto();
        }

        private void contextoIndividual_CheckedChanged(object sender, EventArgs e)
        {
            ConfigContexto();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

            //frmReport frm = new frmReport(CarregaDados());
            //frm.ShowDialog();
        }

        #endregion

        #region METODOS

        private void InitForm() 
        {
            CarregaFiliais();

            contextoGrupo.Checked = true;
            relAnalitico.Checked = true;
        }

        private void ConfigContexto() 
        {
            if (contextoIndividual.Checked)
            {
                filialComboBox.Enabled = true;
            }
            else {
                filialComboBox.Enabled = false;
            }
        }

        private void CarregaFiliais()
        {
            var filiais = Lib.Filiais.GetEstudios();
            filialComboBox.DisplayMember = "NOMEFANTASIA";
            filialComboBox.ValueMember = "CGC";
            filialComboBox.DataSource = filiais;
        }

        private void CarregaDados() 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities()) 
            {
                //lista filiais selecionadas
                int i = 0;
                int count;
                string[] filiais = GetEstudios().Select(a => a.CGC).ToArray();

                //inicializa a consulta
                lbProgress.Text = "Aguarde. Executando consulta";

                //seleciona as parcelas
                var query = conn.TMOV
                                .Where(a => a.FLAN.OrderByDescending(b => b.IDLAN).Take(1).Where(b => b.STATUSLAN == 0 && b.PAGREC == 1 && b.DATAVENCIMENTO >= inicioDateTimePicker.Value.Date && b.DATAVENCIMENTO <= finalDateTimePicker.Value.Date).Count() > 0 && 
                                            filiais.Contains(a.GFILIAL.CGC) &&
                                            a.STATUS != "C");

                //inicializa o carregamento de dados
                count = query.Count();
                Dados.Lancamento.Rows.Clear();

                //carrega o dataset
                foreach (var venda in query) 
                {
                    //pega lancamentos em aberto
                    var lanc = conn.FLAN.Where(a => a.CODCOLIGADA == venda.CODCOLIGADA && a.CODFILIAL == venda.CODFILIAL && a.IDMOV == venda.IDMOV && a.STATUSLAN == 0);

                    foreach (var item in lanc) 
                    {
                        //cria a linha
                        var row = Dados.Lancamento.NewLancamentoRow();
                        row.IdLan = item.IDLAN;
                        row.IdMov = venda.IDMOV;
                        row.IdCliente = venda.CODCFO;
                        row.IdEstudio = (int)venda.CODFILIAL;
                        row.IdColigada = (int)venda.CODCOLIGADA;

                        row.Estudio = venda.GFILIAL.NOMEFANTASIA;
                        row.Cliente = venda.FCFO.NOME;
                        row.ValorVenda = (decimal)venda.VALORLIQUIDO;
                        row.ValorParcela = item.VALORORIGINAL;
                        row.DataParcela = item.DATAVENCIMENTO;
                        row.DataUltima = venda.FLAN.LastOrDefault().DATAVENCIMENTO;

                        row.EndRua = string.Format("{0}", string.IsNullOrEmpty(venda.FCFO.RUA) == true ? "" : venda.FCFO.RUA);
                        row.EndNum = string.IsNullOrEmpty(venda.FCFO.NUMERO) == true ? "" : venda.FCFO.NUMERO;
                        row.EndCompl = string.IsNullOrEmpty(venda.FCFO.COMPLEMENTO) == true ? "" : venda.FCFO.COMPLEMENTO;
                        row.EndBairro = string.Format("{0}", string.IsNullOrEmpty(venda.FCFO.BAIRRO) == true ? "" : venda.FCFO.BAIRRO);
                        row.EndCidade = string.IsNullOrEmpty(venda.FCFO.CIDADE) == true ? "" : venda.FCFO.CIDADE;
                        row.EndEstado = string.IsNullOrEmpty(venda.FCFO.CODETD) == true ? "" : venda.FCFO.CODETD;
                        row.EndCep = string.IsNullOrEmpty(venda.FCFO.CEP) == true ? "" : venda.FCFO.CEP;

                        //adiciona no dataset
                        Dados.Lancamento.Rows.Add(row);
                    }

                    i++;
                    backgroundWorker1.ReportProgress(count, i);
                }
            }
        }

        private List<Dados.GFILIAL> GetEstudios()
        {
            if (contextoGrupo.Checked)
            {
                return Lib.Filiais.GetEstudiosRede();
            }
            else 
            {
                if (contextoFranquia.Checked)
                {
                    return Lib.Filiais.GetEstudiosFranquia();
                }
                else 
                {
                    List<Dados.GFILIAL> lista = new List<Dados.GFILIAL>();
                    lista.Add(Lib.Filiais.GetByCnpj(filialComboBox.SelectedValue.ToString()));

                    return lista;
                }
            }

            
        }

        private string GetTipo() 
        {
            if (relAnalitico.Checked == true)
            {
                return "Analitico";
            }
            else 
            {
                if (relSintetico.Checked == true)
                {
                    return "Sintetico";
                }
                else 
                {
                    return "Etiqueta";
                }
            }

        }

        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CarregaDados();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbProgress.Text = "Consulta finalizada com sucesso";

            frmReport frm = new frmReport(Dados, GetTipo());
            frm.ShowDialog();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbProgress.Text = string.Format("Executando {0} de {1}", e.UserState, e.ProgressPercentage);
        }

    }
}
