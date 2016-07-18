using System;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using DevExpress.XtraEditors;
using CliFor = Canaan.Dados.CliFor;

namespace Canaan.Telas.Movimentacoes.Sessao.Telas
{
    public partial class Info : XtraForm
    {
        #region PROPRIEDADES
        
        private Dados.Sessao Sessao;

        public CliFor Cliente { get; set; }
        public Lib.CliFor LibViewCliFor
        {
            get
            {
                return new Lib.CliFor();
            }
        }

        public Lib.Sessao LibSessao
        {
            get
            {
                return new Lib.Sessao();
            }
        }

        #endregion

        #region CONTRUTOR

        public Info(Dados.Sessao Sessao)
        {
            try
            {
                this.Sessao = Sessao;
                Cliente = LibViewCliFor.GetById(Sessao.Atendimento.IdCliFor);

                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }


        }

        #endregion

        #region EVENTOS

        private void Info_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaForm();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void toolStripSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Sessao.Tipo = (EnumSessaoTipo)Enum.Parse(typeof(EnumSessaoTipo), cbTipo.SelectedItem.ToString());
                Sessao.Genero = (EnumSessaoGenero)Enum.Parse(typeof(EnumSessaoGenero), cbGenero.SelectedItem.ToString());

                Sessao = LibSessao.Update(Sessao);

                CarregaForm();
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }
        #endregion

        #region METODOS
        
        private void CarregaForm()
        {
            SetLabes();
            CarregaGeneros();
            CarregaTipos();
        }

        private void CarregaTipos()
        {
            cbTipo.DataSource = UtilityEnum.EnumToList<EnumSessaoTipo>();
            cbTipo.SelectedItem = Sessao.Tipo;
        }

        private void CarregaGeneros()
        {
            cbGenero.DataSource = UtilityEnum.EnumToList<EnumSessaoGenero>();
            cbGenero.SelectedItem = Sessao.Genero;
        }

        private void SetLabes()
        {
            lbAtendimento.Text = Sessao.IdAtendimento.ToString();
            lbCodigoSessao.Text = Sessao.IdSessao.ToString();
            lbCliente.Text = Cliente.Nome;
            lbGenero.Text = Sessao.Genero.ToString();
            lbTipo.Text = Sessao.Tipo.ToString();
            lbFotografa.Text = Sessao.Usuario.Nome;
            lbDataSessao.Text = Sessao.Data.ToShortDateString();
            lbNumeroSessao.Text = Sessao.NumSessao.ToString();
            lbQuantidadeFoto.Text = Sessao.Foto.Count.ToString();
            lbTempoSessao.Text = Sessao.TempoSessao.ToString();
            lbBackup.Text = Sessao.HasBackup == false ? "Não" : "Sim";
            lbCriptografia.Text = Sessao.IsCriptografado == false ? "Não" : "Sim";
        }

        #endregion

        private void Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

    }
}
