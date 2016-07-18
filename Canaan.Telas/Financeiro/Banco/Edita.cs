using System;
using System.Windows.Forms;
using Canaan.Telas.Base;

namespace Canaan.Telas.Financeiro.Banco
{
    public partial class Edita : FormEdita
    {
        #region PROPRIEDADES

        public Lib.Banco objLib { get; set; }
        private Dados.Banco Banco { get; set; }

        #endregion


        #region CONSTRUTORES

        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.Banco();
            Banco = new Dados.Banco();

            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Lib.Banco();
            Banco = objLib.GetById(id);

            //carrega os componentes
            InitializeComponent();
            
        }

        #endregion


        #region EVENTOS
        
        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();
            CarregaForm();
        }

        #endregion


        #region METODOS

        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Novo Banco";
            else
                Text = "Editando Banco: " + Banco.Nome;
        }

        protected override void CarregaForm()
        {
            nomeTextEdit.Text = Banco.Nome;
            abreviacaoTextEdit.Text = Banco.Abreviacao;
            numeroTextEdit.Text = Banco.Numero;
            digitoTextEdit.Text = Banco.Digito;

            if (!IsNovo)
                isAtivoCheckEdit.Checked = Banco.IsAtivo;
            else
                isAtivoCheckEdit.Checked = true;
        }

        protected override void CarregaItem()
        {
            //configura objeto
            Banco.Nome = nomeTextEdit.Text;
            Banco.Abreviacao = abreviacaoTextEdit.Text;
            Banco.Numero = numeroTextEdit.Text;
            Banco.Digito = digitoTextEdit.Text;
            Banco.IsAtivo = isAtivoCheckEdit.Checked;
        }

        protected override void Incluir()
        {
            try
            {
                //configura objeto
                CarregaItem();

                //envia para metodo de update
                Banco = objLib.Insert(Banco);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' incluido com sucesso", Banco.Nome));

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
                Banco = objLib.Update(Banco);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' alterado com sucesso", Banco.Nome));

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

        #endregion

    }
}
