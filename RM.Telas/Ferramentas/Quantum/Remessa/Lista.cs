using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Telas.Ferramentas.Quantum.Remessa
{
    public partial class Lista : Form
    {
        //
        //PROPRIEDADES
        public List<Model> Lancamentos { get; set; }
        public Dados.GFILIAL Filial { get; set; }

        //
        //CONSTRUTORES
        public Lista()
        {
            InitializeComponent();
        }


        //
        //EVENTOS
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            SetLancamentos();
            CarregaGrid();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Exportar();
        }

        private void btnBloqueio_Click(object sender, EventArgs e)
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

        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaFiliais();
        }

        //
        //METODOS
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

        private void SetFilial() 
        {
            Filial = Lib.Filiais.GetByCnpj(filiaisComboBox.SelectedValue.ToString());
        }

        private void SetLancamentos() 
        {
            Lancamentos = Model.GetLista(Filial.CODCOLIGADA, Filial.CODFILIAL, inicioDateTimePicker.Value.Date, fimDateTimePicker.Value.Date);
        }

        private void Exportar() 
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                try
                {
                    if (dialog.SelectedPath != null)
                    {
                        Model.ExportaLista(Lancamentos, GetFilename(dialog.SelectedPath));
                        MessageBox.Show("Lista exportada com sucesso");
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

        private string GetFilename(string path)
        {
            return string.Format(@"{0}\{1}_{2}_{3}.xlsx", path,
                                                   Filial.NOMEFANTASIA,
                                                   inicioDateTimePicker.Value.ToShortDateString().Replace("/", "-"),
                                                   fimDateTimePicker.Value.ToShortDateString().Replace("/", "-"));
        }

        private void Bloqueia() 
        {
            try
            {
                Model.BloqueiaLancamentos(Filial.CODCOLIGADA, Filial.CODFILIAL, 1, Lancamentos, decimal.Parse(comissaoTextBox.Text));
                MessageBox.Show("Lancamentos bloqueados com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Desbloqueia()
        {
            try
            {
                Model.BloqueiaLancamentos(Filial.CODCOLIGADA, Filial.CODFILIAL, 0, Lancamentos, decimal.Parse(comissaoTextBox.Text));
                MessageBox.Show("Lancamentos desbloqueados com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
