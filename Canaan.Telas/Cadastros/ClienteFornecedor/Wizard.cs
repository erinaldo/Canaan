using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Configuracoes.Geral.Cidade;
using DevExpress.XtraEditors;
using DevExpress.XtraWizard;
using Cidade = Canaan.Dados.Cidade;
using CliFor = Canaan.Dados.CliFor;
using PessoaFisica = Canaan.Dados.PessoaFisica;
using PessoaJuridica = Canaan.Lib.PessoaJuridica;

namespace Canaan.Telas.Cadastros.ClienteFornecedor
{
    public partial class Wizard : XtraForm
    {
        #region "PROPRIEDADES"

        public EnumCliForTipo TipoCliFor { get; set; }
        public EnumCliForPessoa TipoPessoa { get; set; }
        public Cidade Cidade { get; set; }
        public CliFor CliFor { get; set; }
        public List<CliFor> ListaCliFor { get; set; }

        public string MascaraDoc { get; set; }
        public bool IsNew { get; set; }

        #endregion

        #region "CONSTRUTORES"

        public Wizard()
        {
            InitializeComponent();
        }

        public Wizard(int id)
        {
            //inicializa os componentes
            InitializeComponent();

            //carrega info
            CliFor = new Lib.CliFor().GetById(id);

            tipoPessoaRadioGroup.EditValue = CliFor is PessoaFisica ? EnumCliForPessoa.PessoaFisica : EnumCliForPessoa.PessoaJuridica;
            SetPessoaTipo();

            tipoClienteRadioGroup.EditValue = CliFor.Tipo;
            SetClienteTipo();

            documentoTextEdit.Text = CliFor.Documento;
            CarregaForm();

            //vai para a tela de ediçãp
            wizardCliFor.SelectedPageIndex = 2;
        }

        #endregion

        #region "EVENTOS"
        private void Wizard_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificaDocumento_Click(object sender, EventArgs e)
        {
            //carrega o cliente / fornecedor
            CarregaCliFor(documentoTextEdit.Text);

            //vai para a pagina de cadastro
            wizardCliFor.SetNextPage();
        }

        private void btnCidade_Click(object sender, EventArgs e)
        {
            var frm = new Seleciona();
            frm.ShowDialog();

            Cidade = frm.Cidade;
            SetCidade();
        }

        #endregion

        #region "EVENTOS DO WIZARD"

        private void wizardCliFor_NextClick(object sender, WizardCommandButtonClickEventArgs e)
        {
            switch (e.Page.Name)
            {
                case "pageTipo":
                    PageTipo_Executa(e);
                    break;
                case "pageDocumento":
                    PageDocumento_Executa(e);
                    break;
                case "pageCadastro":
                    PageCadastro_Executa(e);
                    break;
            }
        }

        private void wizardCliFor_SelectedPageChanging(object sender, WizardPageChangingEventArgs e)
        {
            switch (e.Page.Name)
            {
                case "pageDocumento":
                    PageDocumento_Init();
                    break;
                case "pageCadastro":
                    PageCadastro_Init();
                    break;
            }
        }

        private void wizardCliFor_FinishClick(object sender, CancelEventArgs e)
        {
            try
            {
                Salvar();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(this, ex);
                e.Cancel = true;
            }
        }

        #endregion

        #region "PAGINA - TIPO"

        private void PageTipo_Executa(WizardCommandButtonClickEventArgs e)
        {
            if (!PageTipo_Valida())
            {
                e.Handled = true;
            }
            else
            {
                SetClienteTipo();
                SetPessoaTipo();
            }
        }

        private bool PageTipo_Valida()
        {
            //variaveis
            bool isValid = true;
            string erros = "Ocorreram erros ao validar:\n\n";

            //valida tipo de cliente
            if (tipoClienteRadioGroup.EditValue == null)
            {
                erros += "- Tipo de Cliente é obrigatório";
                isValid = false;
            }

            //valida tipo de pessoa
            if (tipoPessoaRadioGroup.EditValue == null)
            {
                erros += "- Tipo de Pessoa é obrigatório";
                isValid = false;
            }

            //mensagem de erro
            if (!isValid)
            {
                MessageBoxUtilities.MessageError(this, new Exception(erros));
            }

            //retorno
            return isValid;
        }

        #endregion

        #region "PAGINA - DOCUMENTO"

        private void PageDocumento_Init()
        {
            //zera as propriedades
            CliFor = null;
            documentoTextEdit.Text = "";

            //verifica o tipo de cadastro
            switch (TipoPessoa)
            {
                case EnumCliForPessoa.PessoaFisica:
                    documentoGroupControl.Text = "Informe o CPF";
                    documentoTextEdit.Properties.Mask.EditMask = MascaraDoc;
                    break;
                case EnumCliForPessoa.PessoaJuridica:
                    documentoGroupControl.Text = "Informe o CNPJ";
                    documentoTextEdit.Properties.Mask.EditMask = MascaraDoc;
                    break;
                default:
                    documentoGroupControl.Text = "Informe o CPF";
                    documentoTextEdit.Properties.Mask.EditMask = MascaraDoc;
                    break;
            }
        }

        private void PageDocumento_Executa(WizardCommandButtonClickEventArgs e)
        {
            if (!PageDocumento_Valida())
            {
                e.Handled = true;
            }
        }

        private bool PageDocumento_Valida()
        {
            //variaveis
            bool isValid = true;
            string erros = "Ocorreram erros ao validar:\n\n";

            //verifica se algum cliente foi verificado
            //if (PessoaFisica == null && PessoaJuridica == null)
            if (CliFor == null)
            {
                //erros += "- É necessário verificar o cliente";
                //isValid = false;
                CarregaCliFor("");

                Cidade = new Lib.Cidade().GetById(Session.Instance.Contexto.Filial.IdCidade);
                SetCidade();
                //CarregaForm();
            }

            //mensagem de erro
            if (!isValid)
            {
                MessageBoxUtilities.MessageError(this, new Exception(erros));
            }

            //retorno
            return isValid;
        }

        #endregion

        #region "PAGINA - CADASTRO"

        private void PageCadastro_Init()
        {
            switch (TipoPessoa)
            {
                case EnumCliForPessoa.PessoaFisica:
                    //carrega abas
                    tabPessoaFisica.PageVisible = true;
                    tabPessoaJuridica.PageVisible = false;
                    cadastroTabControl.SelectedTabPageIndex = 0;

                    //carrega controles
                    CarregaSexo();
                    CarregaEstadoCivil();

                    break;
                case EnumCliForPessoa.PessoaJuridica:
                    tabPessoaFisica.PageVisible = false;
                    tabPessoaJuridica.PageVisible = true;
                    cadastroTabControl.SelectedTabPageIndex = 1;
                    break;
                default:
                    break;
            }

            //carrega form
            CarregaForm();
        }

        private void PageCadastro_Executa(WizardCommandButtonClickEventArgs e)
        {
            //atualiza objetos do form
            SetCliFor();

            //valida objetos
            if (!PageCadastro_Valida())
            {
                e.Handled = true;
            }

        }

        private bool PageCadastro_Valida()
        {
            //variaveis
            bool isValid = false;

            //verifica tipo de cadastro
            try
            {
                switch (TipoPessoa)
                {
                    case EnumCliForPessoa.PessoaFisica:
                        isValid = new Lib.PessoaFisica().IsValid(CliFor as PessoaFisica);
                        break;
                    case EnumCliForPessoa.PessoaJuridica:
                        isValid = new PessoaJuridica().IsValid(CliFor as Dados.PessoaJuridica);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(this, ex);
            }


            //retorno
            return isValid;
        }


        #endregion

        #region "PAGINA - CONFIRMACAO"

        #endregion

        #region "METODOS"

        //
        //SETA A PROPRIEDADE TIPO DE PESSOA
        private void SetPessoaTipo()
        {
            switch (tipoPessoaRadioGroup.EditValue.ToString())
            {
                case "PessoaFisica":
                    TipoPessoa = EnumCliForPessoa.PessoaFisica;
                    MascaraDoc = "999.999.999-99";
                    break;
                case "PessoaJuridica":
                    TipoPessoa = EnumCliForPessoa.PessoaJuridica;
                    MascaraDoc = "99.999.999/9999-99";
                    break;
                default:
                    TipoPessoa = EnumCliForPessoa.PessoaFisica;
                    MascaraDoc = "999.999.999-99";
                    break;
            }
        }

        //
        //SETA A PRORPIEDADE TIPO DE CLIENTE
        private void SetClienteTipo()
        {
            switch (tipoClienteRadioGroup.EditValue.ToString())
            {
                case "Cliente":
                    TipoCliFor = EnumCliForTipo.Cliente;
                    break;
                case "Fornecedor":
                    TipoCliFor = EnumCliForTipo.Fornecedor;
                    break;
                default:
                    TipoCliFor = EnumCliForTipo.Cliente;
                    break;
            }
        }

        //
        //SETA AS PRORPIEDADES DO CLIENTE FORNECEDOR
        private void SetCliFor()
        {
            //carrega dados especificos
            switch (TipoPessoa)
            {
                case EnumCliForPessoa.PessoaFisica:
                    SetPessoaFisica();
                    break;
                case EnumCliForPessoa.PessoaJuridica:
                    SetPessoaJuridica();
                    break;
                default:
                    break;
            }

            //dados globais
            CliFor.Tipo = TipoCliFor;

            //endereco
            CliFor.Endereco = enderecoTextEdit.Text;
            CliFor.Numero = numeroTextEdit.Text;
            CliFor.Complemento = complementoTextEdit.Text;
            CliFor.Bairro = bairroTextEdit.Text;
            CliFor.Cep = cepTextEdit.Text;
            CliFor.IdCidade = int.Parse(idCidadeTextEdit.Text);

            //contato
            CliFor.Email = emailTextEdit.Text;
            CliFor.Telefone = telefone1TextEdit.Text;
            CliFor.Telefone2 = telefone2TextEdit.Text;
            CliFor.Telefone3 = telefone3TextEdit.Text;
            CliFor.Celular = celular1TextEdit.Text;
            CliFor.Celular2 = celular2TextEdit.Text;
            CliFor.Celular3 = celular3TextEdit.Text;
            CliFor.Fax = faxTextEdit.Text;

            //outras info
            CliFor.IsAtivo = isAtivoCheckEdit.Checked;

            //referencias
        }

        //
        //SETA A PROPRIEDADE PESSOA FISICA
        private void SetPessoaFisica()
        {
            CliFor.Nome = nomeCompletoTextEdit.Text;
            (CliFor as PessoaFisica).Nascimento = nascimentoDateEdit.DateTime.Date;
            CliFor.Documento = cpfTextEdit.Text;
            (CliFor as PessoaFisica).Rg = rgTextEdit.Text;
            (CliFor as PessoaFisica).NomePai = nomePaiTextEdit.Text;
            (CliFor as PessoaFisica).NomeMae = nomeMaeTextEdit.Text;
            (CliFor as PessoaFisica).Sexo = (EnumCliForSexo)sexoComboBox.SelectedValue;
            (CliFor as PessoaFisica).EstadoCivil = (EnumCliForEstadoCivil)estadoCivilComboBox.SelectedValue;
            (CliFor as PessoaFisica).Conjuge = conjugeTextEdit.Text;
            (CliFor as PessoaFisica).IsEmancipado = ckEmancipado.Checked;
        }

        //
        //SETA A PRORPIEDADE PESSOA JURIDICA
        private void SetPessoaJuridica()
        {
            (CliFor as Dados.PessoaJuridica).RazaoSocial = razaoSocialTextEdit.Text;
            CliFor.Nome = nomeFantasiaTextEdit.Text;
            CliFor.Documento = cnpjTextEdit.Text;
            (CliFor as Dados.PessoaJuridica).InscSocial = inscEstadualTextEdit.Text;
        }

        //
        //DEFINE A MASCARA DOS CAMPOS DE CELULAR
        private void SetMascaraCelular() { }

        //
        //SETA A PROPRIEDADE CIDADE
        private void SetCidade()
        {
            if (Cidade != null)
            {
                idCidadeTextEdit.Text = Cidade.IdCidade.ToString();
                cidadeLabelControl.Text = string.Format("{0} - {1}", Cidade.Nome, Cidade.Estado.Nome);
            }
            else
            {
                idCidadeTextEdit.Text = "0";
                cidadeLabelControl.Text = string.Format("{0}", "Selecione uma cidade");
            }
        }

        //
        //ABRE A TELA DE SELECAO DE CIDADE
        private void SelecionaCidade() { }

        //
        //FAZ A BUSCA E INICIALIZA A PROPRIEDADE PESSOA FISICA / PESSOA JURIDICA
        private void CarregaCliFor(string documento)
        {
            List<CliFor> lista = new List<Dados.CliFor>();

            if(!string.IsNullOrEmpty(documento))
                lista = new Lib.CliFor().GetByDoc(documento);

            if (lista.Count > 0)
            {
                IsNew = false;

                if (lista.FirstOrDefault() is PessoaFisica)
                {
                    //PessoaFisica = lista.FirstOrDefault() as Dados.PessoaFisica;
                    CliFor = lista.FirstOrDefault() as PessoaFisica;
                }
                else
                {
                    //PessoaJuridica = lista.FirstOrDefault() as Dados.PessoaJuridica;
                    CliFor = lista.FirstOrDefault() as Dados.PessoaJuridica;
                }
            }
            else
            {
                IsNew = true;

                switch (TipoPessoa)
                {
                    case EnumCliForPessoa.PessoaFisica:
                        CliFor = new PessoaFisica();
                        break;
                    case EnumCliForPessoa.PessoaJuridica:
                        CliFor = new Dados.PessoaJuridica();
                        break;
                }
            }
        }

        //
        //CARREGA CONTROLES DO FORM
        private void CarregaForm()
        {
            if (IsNew)
            {
                CarregaNovo();
            }
            else
            {
                CarregaEdita();
                CarregaRefGrid();
            }
        }

        //
        //CARREGA CONTROLES DO FORM PARA REGISTRO EXISTENTE
        private void CarregaEdita()
        {
            //pessoa fisica
            switch (TipoPessoa)
            {
                case EnumCliForPessoa.PessoaFisica:
                    CarregaPessoaFisica();
                    break;
                case EnumCliForPessoa.PessoaJuridica:
                    CarregaPessoaJuridica();
                    break;
                default:
                    break;
            }


            //endereco
            enderecoTextEdit.Text = CliFor.Endereco;
            numeroTextEdit.Text = CliFor.Numero;
            complementoTextEdit.Text = CliFor.Complemento;
            bairroTextEdit.Text = CliFor.Bairro;
            cepTextEdit.Text = CliFor.Cep;
            Cidade = new Lib.Cidade().GetById(CliFor.IdCidade);
            SetCidade();

            //contato
            emailTextEdit.Text = CliFor.Email;
            telefone1TextEdit.Text = CliFor.Telefone;
            telefone2TextEdit.Text = CliFor.Telefone2;
            telefone3TextEdit.Text = CliFor.Telefone3;
            celular1TextEdit.Text = CliFor.Celular;
            celular2TextEdit.Text = CliFor.Celular2;
            celular3TextEdit.Text = CliFor.Celular3;
            faxTextEdit.Text = CliFor.Fax;

            //outras info
            isAtivoCheckEdit.Checked = CliFor.IsAtivo;
        }

        //
        //CARREGA CONTROLES COM OS DADOS DA PESSOA JURIDICA
        private void CarregaPessoaJuridica()
        {
            if (IsNew)
            {
                //pessoa juridica
                razaoSocialTextEdit.Text = null;
                nomeFantasiaTextEdit.Text = null;
                cnpjTextEdit.Text = documentoTextEdit.Text;
                inscEstadualTextEdit.Text = null;
            }
            else
            {
                razaoSocialTextEdit.Text = (CliFor as Dados.PessoaJuridica).RazaoSocial;
                nomeFantasiaTextEdit.Text = CliFor.Nome;
                cnpjTextEdit.Text = CliFor.Documento;
                inscEstadualTextEdit.Text = (CliFor as Dados.PessoaJuridica).InscSocial;
            }
        }

        //
        //CARREGA CONTROLES COM OS DADOS DA PESSOA FISICA
        private void CarregaPessoaFisica()
        {
            if (IsNew)
            {
                nomeCompletoTextEdit.Text = null;
                nascimentoDateEdit.EditValue = DateTime.Today;
                cpfTextEdit.Text = documentoTextEdit.Text;
                rgTextEdit.Text = null;
                nomePaiTextEdit.Text = null;
                nomeMaeTextEdit.Text = null;
                sexoComboBox.SelectedIndex = 0;
                estadoCivilComboBox.SelectedIndex = 0;
                conjugeTextEdit.Text = null;
            }
            else
            {
                nomeCompletoTextEdit.Text = CliFor.Nome;
                nascimentoDateEdit.EditValue = (CliFor as PessoaFisica).Nascimento;
                cpfTextEdit.Text = CliFor.Documento;
                rgTextEdit.Text = (CliFor as PessoaFisica).Rg;
                nomePaiTextEdit.Text = (CliFor as PessoaFisica).NomePai;
                nomeMaeTextEdit.Text = (CliFor as PessoaFisica).NomeMae;
                sexoComboBox.SelectedItem = (CliFor as PessoaFisica).Sexo;
                estadoCivilComboBox.SelectedItem = (CliFor as PessoaFisica).EstadoCivil;
                conjugeTextEdit.Text = (CliFor as PessoaFisica).Conjuge;
                ckEmancipado.Checked = (CliFor as PessoaFisica).IsEmancipado.GetValueOrDefault();
            }
        }

        //
        //CARREGA CONTROLES DO FORM PARA NOVO REGISTRO
        private void CarregaNovo()
        {
            switch (TipoPessoa)
            {
                case EnumCliForPessoa.PessoaFisica:
                    CarregaPessoaFisica();
                    break;
                case EnumCliForPessoa.PessoaJuridica:
                    CarregaPessoaJuridica();
                    break;
                default:
                    break;
            }

            //endereco
            enderecoTextEdit.Text = null;
            numeroTextEdit.Text = null;
            complementoTextEdit.Text = null;
            bairroTextEdit.Text = null;
            cepTextEdit.Text = null;
            SetCidade();

            //contato
            emailTextEdit.Text = null;
            telefone1TextEdit.Text = null;
            telefone2TextEdit.Text = null;
            telefone3TextEdit.Text = null;
            celular1TextEdit.Text = null;
            celular2TextEdit.Text = null;
            celular3TextEdit.Text = null;
            faxTextEdit.Text = null;

            //outras info
            isAtivoCheckEdit.Checked = true;

            //referencias
        }

        //
        //CARREGA COMBOBOX SEXO
        private void CarregaSexo()
        {
            sexoComboBox.DataSource = Enum.GetValues(typeof(EnumCliForSexo));
        }

        //
        //CARREGA COMBOBOX ESTADO CIVIL
        private void CarregaEstadoCivil()
        {
            estadoCivilComboBox.DataSource = Enum.GetValues(typeof(EnumCliForEstadoCivil));
        }

        //
        //SALVA O REGISTRO
        private void Salvar()
        {
            if (IsNew)
            {
                switch (TipoPessoa)
                {
                    case EnumCliForPessoa.PessoaFisica:
                        CliFor = new Lib.CliFor().Insert(CliFor as PessoaFisica);
                        break;
                    case EnumCliForPessoa.PessoaJuridica:
                        CliFor = new Lib.CliFor().Insert(CliFor as Dados.PessoaJuridica);
                        break;
                }
            }
            else
            {
                switch (TipoPessoa)
                {
                    case EnumCliForPessoa.PessoaFisica:
                        CliFor = new Lib.CliFor().Update(CliFor as PessoaFisica);
                        break;
                    case EnumCliForPessoa.PessoaJuridica:
                        CliFor = new Lib.CliFor().Update(CliFor as Dados.PessoaJuridica);
                        break;
                }
            }
        }

        //
        //CARREGA LISTA DE REFERENCIAS
        private void CarregaRefGrid()
        {
            //limpa todas as linhas
            refDataGridView.Rows.Clear();

            //carrega o grid
            foreach (var item in CliFor.CliForReferencia)
            {
                refDataGridView.Rows.Add(item.IdReferencia,
                    item.Nome,
                    item.Tipo,
                    Comum.FormataTelefone(item.Telefone),
                    Comum.FormataTelefone(item.Celular));
            }

            //limpa seleção
            refDataGridView.ClearSelection();
        }

        #endregion

        //
        //NOVA REFERENCIA
        private void btnRefNovo_Click(object sender, EventArgs e)
        {
            //abre a tela de 
            var frm = new Referencia(CliFor);
            frm.ShowDialog();

            //verifica se foi salvo
            if (frm.IsSaved)
            {
                CliFor.CliForReferencia.Add(frm.CliForRef);
            }

            //atualiza a lista de referencias
            CarregaRefGrid();

        }

        private void btnRefEdita_Click(object sender, EventArgs e)
        {
            if (refDataGridView.SelectedRows.Count > 0)
            {
                //recupera item
                var id = (int)refDataGridView.SelectedRows[0].Cells["Codigo"].Value;
                var item = CliFor.CliForReferencia.FirstOrDefault(a => a.IdReferencia == id);

                //abre a tela de 
                var frm = new Referencia(CliFor, item);
                frm.ShowDialog();

                //atualiza a lista de referencias
                CarregaRefGrid();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado");
            }
        }

        private void wizardCliFor_CancelClick(object sender, CancelEventArgs e)
        {
            CliFor = null;
        }
    }
}