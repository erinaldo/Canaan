using System;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Geral.Filiais
{
    public partial class Edita : FormEdita
    {
        //
        //PROPRIEDADES
        public Filial objLib { get; set; }
        private Dados.Filial Filial { get; set; }

        //
        //CONSTRUTORES
        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Filial();
            Filial = new Dados.Filial();


            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Filial();
            Filial = objLib.GetById(id);

            //carrega os componentes
            InitializeComponent();
        }


        //
        //EVENTOS
        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();

            CarregaGrupoEmpresa();
            CarregaForm();
        }

        //
        //METODOS
        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Nova Filial";
            else
                Text = "Editando Filial: " + Filial.NomeFantasia;
        }

        protected override void CarregaForm()
        {
            //carrega o data source
            filialBindingSource.DataSource = Filial;

            //inicializa para inclusao
            if (IsNovo) 
            {
                idGrupoEmpresaComboBox.SelectedIndex = 0;
                isAtivoCheckBox.Checked = true;
                nomeCidadeLabel.Text = "Selecione uma cidade";
            }
        }

        protected override void Incluir()
        {
            try
            {
                //para a edicao do datasource
                filialBindingSource.EndEdit();

                //envia para metodo de update
                Filial = objLib.Insert((Dados.Filial)filialBindingSource.Current);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' incluido com sucesso", Filial.NomeFantasia));

                //marca para edicao
                IsNovo = false;
                SetTitle();

                //recarrega o datasource
                CarregaForm();
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
                //para a edicao do datasource
                filialBindingSource.EndEdit();

                //envia para metodo de update
                Filial = objLib.Update((Dados.Filial)filialBindingSource.Current);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' alterado com sucesso", Filial.NomeFantasia));

                //marca para edicao
                IsNovo = false;
                SetTitle();

                //recarrega o datasource
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregaGrupoEmpresa() {
            var grupoempresa = new Lib.GrupoEmpresa();

            grupoEmpresaBindingSource.DataSource = grupoempresa.GetByAtivo(true);
        }

        private void nomeCidadeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var seleciona = new Cidade.Seleciona();
            seleciona.ShowDialog();

            if (seleciona.Cidade != null) 
            { 
                //atualiza item bindado
                var source = (Dados.Filial)filialBindingSource.Current;
                source.Cidade = seleciona.Cidade;
                source.IdCidade = seleciona.Cidade.IdCidade;

                filialBindingSource.EndEdit();
                filialBindingSource.ResetBindings(true);
            }
        }
    }
}
