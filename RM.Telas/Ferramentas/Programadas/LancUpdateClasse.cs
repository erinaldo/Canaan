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
    public partial class LancUpdateClasse : Form
    {
        //
        //PROPRIEDADES
        public List<Dados.FLAN> Selecteds { get; set; }
        public List<Dados.FLAN> Unselecteds { get; set; }
        public Dados.GFILIAL Filial { get; set; }

        //
        //CONSTRUTORES
        public LancUpdateClasse(Dados.GFILIAL pFilial, List<Dados.FLAN> pSelecteds, List<Dados.FLAN> pUnselecteds)
        {
            //inicializa propriedades
            Filial = pFilial;
            Selecteds = pSelecteds;
            Unselecteds = pUnselecteds;

            //inicializa os controles
            InitializeComponent();
        }

        //
        //EVENTOS
        private void LancUpdateClasse_Load(object sender, EventArgs e)
        {
            CarregaClasses();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            UpdateClasse();
        }

        
        //
        //METODOS
        private void UpdateClasse() 
        {
            string confirm = "Tem certeza que deseja alterar a classe contabil dos lançamentos.\n" +
                             "SELECIONADOS: " + classe1ComboBox.Text + "\n" +
                             "NÃO SELECIONADOS: " + classe2ComboBox.Text + "";

            if (MessageBox.Show(confirm, "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) 
            {
                try
                {
                    //atualiza lancamentos selecionados
                    foreach (var item in Selecteds)
                    {
                        item.CODTB1FLX = classe1ComboBox.SelectedValue.ToString();
                        Lib.Lancamento.UpdateClasseContabil(item);
                    }

                    //atualiza lancamentos nao selecionados
                    foreach (var item in Unselecteds)
                    {
                        item.CODTB1FLX = classe2ComboBox.SelectedValue.ToString();
                        Lib.Lancamento.UpdateClasseContabil(item);
                    }

                    //mensagem de retorno
                    MessageBox.Show("Atualização completada com sucesso");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
                             
        }

        private void CarregaClasses() 
        {
            //configura a lista
            var lista = Lib.ClasseContabil.Get(Filial.CODCOLIGADA).Select(a => new { 
                Codigo = a.CODTB1FLX,
                Nome = string.Format("{0} - {1}", a.CODTB1FLX, a.DESCRICAO)
            }).OrderBy(a => a.Nome).ToList();

            var lista2 = Lib.ClasseContabil.Get(Filial.CODCOLIGADA).Select(a => new
            {
                Codigo = a.CODTB1FLX,
                Nome = string.Format("{0} - {1}", a.CODTB1FLX, a.DESCRICAO)
            }).OrderBy(a => a.Nome).ToList();

            //configura combo das selecionadas
            classe1ComboBox.DisplayMember = "Nome";
            classe1ComboBox.ValueMember = "Codigo";
            classe1ComboBox.DataSource = lista;

            //configura combo das nao selecionadas
            classe2ComboBox.DisplayMember = "Nome";
            classe2ComboBox.ValueMember = "Codigo";
            classe2ComboBox.DataSource = lista2;
        
            //inicializa listas
            if (Selecteds.Count > 0) 
            {
                classe1ComboBox.SelectedValue = Selecteds.FirstOrDefault().CODTB1FLX;
            }

            if (Unselecteds.Count > 0)
            {
                classe2ComboBox.SelectedValue = Unselecteds.FirstOrDefault().CODTB1FLX;
            }
        }
    }
}
