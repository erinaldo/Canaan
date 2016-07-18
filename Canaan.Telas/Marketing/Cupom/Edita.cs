using System;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Base;
using Canaan.Telas.Marketing.Cupom.Parceria;
using Indicacao = Canaan.Dados.Indicacao;

namespace Canaan.Telas.Marketing.Cupom
{
    public partial class Edita : FormEdita
    {
        private int idAtendimento;
        private EnumConvenioTipo convenioTipo;

        //
        //PROPRIEDADES
        public Lib.Cupom objLib { get; set; }
        private Dados.Cupom objCupon { get; set; }
        public Dados.Parceria objParceria { get; set; }

        public Dados.Parceria Parceria { get; set; }
        public Lib.Parceria LibParceria
        {
            get { return new Lib.Parceria(); }
        }

        public Indicacao Indicacao { get; set; }
        public Lib.Indicacao LibIndicacao
        {
            get { return new Lib.Indicacao(); }
        }

        //CONSTRUTORES
        public Edita()
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.Cupom();

            //Cria novo cupom com status em aberto
            objCupon = new Dados.Cupom
                {
                    Status = EnumCupomStatus.EmAberto,
                    IdUsuario = Session.Instance.Usuario.IdUsuario,
                    Data = DateTime.Today,
                    DataPreenchimento = DateTime.Today
                };


            //carrega os componentes
            InitializeComponent();
        }

        //Edição
        public Edita(int id)
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Lib.Cupom();
            objCupon = objLib.GetById(id);

            //carrega os componentes
            InitializeComponent();
        }

        //Novo Cupom a partir da tela de Parceria
        public Edita(Dados.Parceria parceria)
        {
            //carrega as propriedades
            IsNovo = true;
            objLib = new Lib.Cupom();
            objParceria = parceria;

            //Cria nova Parceria com um convenio Default
            objCupon = new Dados.Cupom
            {
                IdParceria = objParceria.IdParceria,
                Status = EnumCupomStatus.EmAberto,
                IdUsuario = Session.Instance.Usuario.IdUsuario,
                Data = DateTime.Today,
                DataPreenchimento = DateTime.Today

            };

            //carrega os componentes
            InitializeComponent();
        }

        public Edita(int idAtendimento, EnumConvenioTipo pConvenioTipo)
        {
            objLib = new Lib.Cupom();

            Parceria = LibParceria.GetByTipoConvenioAndFilial(Session.Instance.Contexto.IdFilial, pConvenioTipo);

            if (Parceria == null)
                throw new Exception("Não existe convênio com tipo Indicação cadastrado");

            //Cria novo cupom com status em aberto
            objCupon = new Dados.Cupom
            {
                Status = EnumCupomStatus.EmAberto,
                IdUsuario = Session.Instance.Usuario.IdUsuario,
                IdParceria = Parceria.IdParceria,
                Data = DateTime.Today,
                DataPreenchimento = DateTime.Today
            };


            // TODO: Complete member initialization
            this.idAtendimento = idAtendimento;
            this.convenioTipo = pConvenioTipo;
            objParceria = Parceria;
            IsNovo = true;

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
                Text = "Novo Cupom";
            else
                Text = "Editando Cupom: " + objCupon.Nome;
        }

        protected override void CarregaForm()
        {
            //carrega o data source
            cupomBindingSource.DataSource = objCupon;

            //inicializa para inclusao
            if (IsNovo)
            {
                if (objParceria == null)
                    parceriaLabel.Text = "Selecione Parceria";
                else
                    parceriaLabel.Text = objParceria.Nome;

                isAtivoCheckBox.Checked = true;
            }
            else
            {
                //Seta conveio selecionado na edição para o link
                parceriaLabel.Text = objCupon.Parceria.Nome;
            }
        }

        protected override void Incluir()
        {
            try
            {
                //para a edicao do datasource
                cupomBindingSource.EndEdit();

                var currentItem = (Dados.Cupom)cupomBindingSource.Current;

                if (objLib.ValidacaoCupomTel(currentItem))
                {

                    currentItem.Telefone = Comum.RemoveSpaces(objCupon.Telefone);
                    currentItem.Celular = Comum.RemoveSpaces(objCupon.Celular);
                    currentItem.IsAgendado = false;
                    currentItem.IsDescartado = false;
                    currentItem.IsLembrete = false;

                    //envia para metodo de update
                    objCupon = objLib.Insert(currentItem);


                    //Cadastro de Cupom 
                    if (idAtendimento == 0)
                    {

                        //mensagem de retorno
                        MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' incluido com sucesso", objCupon.Nome));


                        if (MessageBoxUtilities.MessageQuestion("Deseja adicionar novo registro?") == DialogResult.Yes)
                        {
                            IsNovo = true;

                            //Cria novo cupom com status em aberto
                            objCupon = new Dados.Cupom
                            {
                                Status = EnumCupomStatus.EmAberto,
                                IdUsuario = Session.Instance.Usuario.IdUsuario,
                                Data = DateTime.Today,
                                DataPreenchimento = DateTime.Today,
                                IdParceria = objParceria != null ? objParceria.IdParceria : 0
                            };

                            parceriaLabel.Text = objParceria != null ? objParceria.Nome : "Selecione uma parceria";

                            cupomBindingSource.EndEdit();

                            //Seta foco para o nomes
                            nomeTextBox.Focus();

                            CarregaForm();
                        }
                        else
                        {

                            Close();

                            //marca para edicao
                            //this.IsNovo = false;
                            //this.SetTitle();
                        }
                    }
                    else
                    {
                        //Salva Cupom de Indique e Ganhe
                        var indicacao = new Indicacao()
                                            {
                                                IdAtendimento = idAtendimento,
                                                IdCupom = objCupon.IdCupom
                                            };

                        LibIndicacao.Insert(indicacao);

                        //mensagem de retorno
                        MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' incluido com sucesso", objCupon.Nome));
                    }
                }else
                {
                    MessageBoxUtilities.MessageWarning("Celular ou Telefone é obrigatório");
                }
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBoxUtilities.MessageError(this, ex);
            }
        }

        protected override void Editar()
        {
            try
            {
                //para a edicao do datasource
                cupomBindingSource.EndEdit();

                //envia para metodo de update
                objCupon = objLib.Update((Dados.Cupom)cupomBindingSource.Current);

                //mensagem de retorno
                MessageBoxUtilities.MessageInfo(string.Format("Registro '{0}' alterado com sucesso", objCupon.Nome));

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

        private void convenioLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var seleciona = new Seleciona();
            seleciona.ShowDialog();

            if (seleciona.Parceria != null)
            {
                //atualiza item bindado
                var source = (Dados.Cupom)cupomBindingSource.Current;
                parceriaLabel.Text = seleciona.Parceria.Nome;
                source.IdParceria = seleciona.Parceria.IdParceria;

                cupomBindingSource.EndEdit();
                cupomBindingSource.ResetBindings(true);
            }
        }
    }
}
