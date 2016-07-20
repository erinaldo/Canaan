using Canaan.Telas.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Geral.Pasta
{
    public partial class Edita : FormEdita
    {
        //
        //PROPRIEDADES
        public Lib.Pasta objLib { get; set; }
        private Dados.Pasta Pasta { get; set; }

        //
        //CONSTRUTORES
        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.Pasta();
            Pasta = new Dados.Pasta();


            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Lib.Pasta();
            Pasta = objLib.GetById(id);
            Title = "Editando Pasta: " + Pasta.Nome;

            //carrega os componentes
            InitializeComponent();
        }

        //
        //EVENTOS
        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();
            CarregaForm();
        }

        //
        //METODOS
        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Nova Pasta";
            else
                Text = "Editando Pasta: " + Pasta.Nome;
        }

        protected override void CarregaForm()
        {
            ctrlNome.Text = Pasta.Nome;
            ctrlDefault.Checked = Pasta.IsDefault;
        }

        protected override void CarregaItem()
        {
            //configura objeto
            Pasta.Nome = ctrlNome.Text;
            Pasta.IsDefault = ctrlDefault.Checked;
        }

        protected override void Incluir()
        {
            try
            {
                //configura objeto
                CarregaItem();

                //envia para metodo de update
                Pasta = objLib.Insert(Pasta);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' incluido com sucesso", Pasta.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }

        protected override void Editar()
        {
            try
            {
                //configura objeto
                CarregaItem();

                //envia para metodo de update
                Pasta = objLib.Update(Pasta);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' alterado com sucesso", Pasta.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }
    }
}
