using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Telas.Ferramentas.Pherfil.Remessa
{
    public partial class Lista : Form
    {
        #region PROPRIEDADES

        public List<Model> Lancamentos { get; set; }
        public Dados.GFILIAL Filial { get; set; }
        public Service Servico { get; set; }
        public string Pasta { get; set; }

        #endregion

        #region CONSTRUTOR

        public Lista()
        {
            this.Servico = new Service();
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaFiliais();
        }
        
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            SetLancamentos();
            CarregaGrid();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Exportar();
        }

        private void btnBloqueia_Click(object sender, EventArgs e)
        {
            Bloqueia();
        }

        private void btnDesbloqueia_Click(object sender, EventArgs e)
        {
            Desbloqueia();
        }

        private void filiaisComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFilial();
        }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            var i = 0;

            //seleciona a pasta
            SetFolder();

            while (true) 
            {
                //carrega os lancamentos
                SetLancamentos();
                Thread.Sleep(5000);

                CarregaGrid();
                Thread.Sleep(5000);

                if (this.Lancamentos.Count > 0)
                {
                    //exporta
                    Exportar(false, i);
                    Thread.Sleep(5000);

                    //bçoqueia os lancamentos
                    Bloqueia(false);
                    Thread.Sleep(5000);

                    //limpa o grid
                    this.Lancamentos.Clear();
                    CarregaGrid();
                    Thread.Sleep(5000);

                    //incrementa o contador
                    i++;
                }
                else {
                    break;
                }
                
            }

            MessageBox.Show("Foram exportados " + i.ToString() + " arquivos");
        }
        
        #endregion

        #region METODOS

        private void CarregaFiliais()
        {
            filiaisComboBox.DisplayMember = "NOMEFANTASIA";
            filiaisComboBox.ValueMember = "CGC";
            filiaisComboBox.DataSource = Lib.Filiais.Get();
        }

        private void CarregaGrid()
        {
            resultDataGridView.DataSource = Lancamentos;
        }

        private void SetLancamentos()
        {
            var min = string.IsNullOrEmpty(minTextBox.Text) == false ? int.Parse(minTextBox.Text) : 0;
            var max = string.IsNullOrEmpty(maxTextBox.Text) == false ? int.Parse(maxTextBox.Text) : 0;

            if (min > 0)
            {
                if (max > 0)
                    Lancamentos = this.Servico.GetLista(Filial.CODCOLIGADA, Filial.CODFILIAL, min, max);
                else
                    Lancamentos = this.Servico.GetLista(Filial.CODCOLIGADA, Filial.CODFILIAL, min);
            }
            else 
            {
                MessageBox.Show("Um periodo mínimo deve ser irnformado");
            }
        }

        private void Exportar(bool showDialog = true, int id = 0)
        {
            if (showDialog)
            {
                this.SetFolder();

                this.Servico.ExportaLista(Lancamentos, this.GetFilename(this.Pasta));

                MessageBox.Show("Lista exportada com sucesso");
            }
            else 
            {
                this.Servico.ExportaLista(Lancamentos, this.GetFilename(this.Pasta, id));
            }
            
        }

        private string GetFilename(string path, int id = -1)
        {
            var comp = DateTime.Today.ToShortDateString().Replace("/", "-");

            if (id >= 0)
                comp = id.ToString();

            return string.Format(@"{0}\{1}_{2}.xlsx", path, Filial.NOMEFANTASIA, comp);
        }

        private void SetFolder() 
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (dialog.SelectedPath != null)
                    {
                        this.Pasta = dialog.SelectedPath;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum caminho selecionado");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Bloqueia(bool showDialog = true)
        {
            try
            {
                this.Servico.BloqueiaLancamentos(Filial.CODCOLIGADA, Filial.CODFILIAL, 1, Lancamentos);

                if(showDialog)
                    MessageBox.Show("Lancamentos bloqueados com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Desbloqueia(bool showDialog = true)
        {
            try
            {
                this.Servico.BloqueiaLancamentos(Filial.CODCOLIGADA, Filial.CODFILIAL, 0, Lancamentos);

                if(showDialog)
                    MessageBox.Show("Lancamentos desbloqueados com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetFilial()
        {
            Filial = Lib.Filiais.GetByCnpj(filiaisComboBox.SelectedValue.ToString());
        }

        #endregion

        
    }
}
