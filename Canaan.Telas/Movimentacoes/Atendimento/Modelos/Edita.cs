using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Telas.Base;
using Canaan.Telas.Configuracoes.Geral.Cidade;
using CliFor = Canaan.Dados.CliFor;
using Modelo = Canaan.Dados.Modelo;
using ModeloResp = Canaan.Dados.ModeloResp;
using PessoaFisica = Canaan.Dados.PessoaFisica;

namespace Canaan.Telas.Movimentacoes.Atendimento.Modelos
{
    public partial class Edita : FormEdita
    {
        #region PROPRIEDADES

        public CliFor Cliente { get; set; }
        public Lib.CliFor LibCliente
        {
            get
            {
                return new Lib.CliFor();
            }
        }

        public Modelo Modelo { get; set; }
        public Lib.Modelo LibModelo
        {
            get
            {
                return new Lib.Modelo();
            }
        }

        public Dados.Atendimento Atendimento { get; set; }
        public Lib.Atendimento LibAtendimento
        {
            get
            {
                return new Lib.Atendimento();
            }
        }

        public List<ModeloResp> Responsaveis { get; set; }
        public Lib.ModeloResp LibReponsavel
        {
            get
            {
                return new Lib.ModeloResp();
            }
        }

        public int ResponsalSelected
        {
            get
            {
                if (dataGrid.SelectedRows.Count > 0)
                {
                    return int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString());
                }

                return 0;
            }
        }

        #endregion

        #region CONTRUTORES

        //Novo
        public Edita(Dados.Atendimento atendimento)
        {
            Atendimento = atendimento;

            Cliente = LibCliente.GetById(atendimento.IdCliFor);

            //Novo Modelo
            Modelo = new Modelo
            {
                IdCliFor = atendimento.IdCliFor,
                Nascimento = DateTime.Today,
                IsAtivo = true
            };

            //carrega as propriedades
            IsNovo = true;

            InitializeComponent();
        }

        //Edita
        public Edita(int idModelo)
        {
            Modelo = LibModelo.GetById(idModelo);
            Atendimento = LibAtendimento.GetByCliFor(Modelo.IdCliFor).FirstOrDefault();
            Cliente = LibCliente.GetById(Modelo.IdCliFor);
            Responsaveis = LibReponsavel.GetByModelo(Modelo.IdModelo);

            //carrega as propriedades
            IsNovo = false;

            InitializeComponent();

            //Habilita tabs
            HabilitaTabResponsaveis(true);
        }


        #endregion

        #region EVENTOS

        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();
            CarregaForm();

            if (IsNovo)
                ImportarDadosCliente();

        }

        private void lkCidade_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var seleciona = new Seleciona();
            seleciona.ShowDialog();

            if (seleciona.Cidade != null)
            {
                //atualiza item bindado
                var source = (Modelo)modeloBindingSource.Current;
                source.IdCidade = seleciona.Cidade.IdCidade;
                lkCidade.Text = seleciona.Cidade.Nome;

                modeloBindingSource.EndEdit();
                modeloBindingSource.ResetBindings(true);
            }
        }

        private void novo_Click(object sender, EventArgs e)
        {
            var frm = new Responsavel.Edita(Modelo);
            frm.ShowDialog();

            CarregaForm();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            OpenEditReposnsavel();
        }

        private void excluir_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            OpenEditReposnsavel();
        }

        #endregion

        #region METODOS

        //
        //METODOS

        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Novo Modelo";
            else
                Text = "Editando Modelo: " + Modelo.NomeCompleto;
        }

        protected override void CarregaForm()
        {
            //Carrega Nome do Cliente no link
            lkNomeCliente.Text = Cliente.Nome;

            //Carrega Enum Sexo
            CarregaSexo();

            CarregaGridResponsaveis();

            //carrega o data source
            modeloBindingSource.DataSource = Modelo;

            //inicializa para inclusao
            if (IsNovo)
            {
                isAtivoCheckEdit.Checked = true;
                lkCidade.Text = "Selecione uma Cidade";
            }
            else
            {
                lkCidade.Text = Modelo.Cidade.Nome;
            }
        }

        private void CarregaGridResponsaveis()
        {
            Responsaveis = LibReponsavel.GetByModelo(Modelo.IdModelo);

            if (Responsaveis != null && Responsaveis.Count > 0)
            {        
                dataGrid.DataSource = LibReponsavel.CarregaGrid(Responsaveis);
            }
        }

        private void ImportarDadosCliente()
        {
            if (MessageBoxUtilities.MessageQuestion("Deseja importar os dados do cliente?") == DialogResult.Yes)
            {
                Modelo.NomeCompleto = Cliente.Nome;

                Modelo.IdCidade = Atendimento.CliFor.IdCidade;
                //Atualiza nome da cidade
                lkCidade.Text = Atendimento.CliFor.Cidade.Nome;

                Modelo.Sexo = Cliente as PessoaFisica != null ? (int)((PessoaFisica)Cliente).Sexo : (int)EnumCliForSexo.Masculino;
                Modelo.Nascimento = Cliente as PessoaFisica != null ? ((PessoaFisica)Cliente).Nascimento : DateTime.Today;
                Modelo.Cpf = Cliente.Documento;
                Modelo.Rg = Cliente as PessoaFisica != null ? ((PessoaFisica)Cliente).Rg : null;
                Modelo.Email = Atendimento.CliFor.Email;
                Modelo.Telefone = Atendimento.CliFor.Telefone;
                Modelo.Celular = Atendimento.CliFor.Celular;

                Modelo.Endereco = Atendimento.CliFor.Endereco;
                Modelo.Numero = Atendimento.CliFor.Numero;
                Modelo.Complemento = Atendimento.CliFor.Complemento;
                Modelo.Bairro = Atendimento.CliFor.Bairro;
                Modelo.Bairro = Atendimento.CliFor.Bairro;
                Modelo.Cep = Atendimento.CliFor.Cep;

                modeloBindingSource.ResetBindings(false);

                //return true;
            }

            //return false;
        }

        private void CarregaSexo()
        {
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Value";
            comboBox1.DataSource = LibModelo.GetValuesFromEnum().ToList();
        }

        protected override void Incluir()
        {
            try
            {
                //para a edicao do datasource
                modeloBindingSource.EndEdit();

                //envia para metodo de update
                Modelo = LibModelo.Insert((Modelo)modeloBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' incluido com sucesso", Modelo.NomeCompleto));

                //marca para edicao
                IsNovo = false;
                SetTitle();

                HabilitaTabResponsaveis(true);

                //recarrega o datasource
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        private void HabilitaTabResponsaveis(bool status)
        {
            tbResponsaveis.PageEnabled = true;
        }

        protected override void Editar()
        {
            try
            {
                //para a edicao do datasource
                nascimentoDateEdit.DoValidate();
                modeloBindingSource.EndEdit();

                //envia para metodo de update
                Modelo = LibModelo.Update((Modelo)modeloBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' alterado com sucesso", Modelo.NomeCompleto));

                //marca para edicao
                IsNovo = false;
                SetTitle();

                //recarrega o datasource
                CarregaForm();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        private void OpenEditReposnsavel()
        {
            if (ResponsalSelected != 0)
            {
                var frm = new Responsavel.Edita(ResponsalSelected);
                frm.ShowDialog();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum Registro Selecionado");
            }


            CarregaForm();
        }

        #endregion
    }
}
