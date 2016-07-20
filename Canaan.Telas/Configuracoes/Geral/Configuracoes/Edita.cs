﻿using Canaan.Lib;
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

namespace Canaan.Telas.Configuracoes.Geral.Configuracoes
{
    public partial class Edita : FormEdita
    {
        //
        //PROPRIEDADES
        public Config objLib { get; set; }
        private Dados.Config Item { get; set; }

        //
        //CONSTRUTORES
        public Edita()
        {
            //carrega as propriedades
            IsNovo = false;
            objLib = new Config();
            Item = objLib.Get().FirstOrDefault();

            //carrega os componentes
            InitializeComponent();
        }

        //
        //EVENTOS
        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();

            CarregaFiliais();
            CarregaForm();
        }

        //
        //METODOS
        private void CarregaFiliais()
        {
            var filiais = new Lib.Filial().GetByAtivo(true);

            filialComboBox.DisplayMember = "NomeFantasia";
            filialComboBox.ValueMember = "IdFilial";
            filialComboBox.DataSource = filiais;
        }

        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Nova Configuração Geral";
            else
                Text = "Editando Configurações Gerais";
        }

        protected override void CarregaForm()
        {
            //geral
            filialComboBox.SelectedValue = this.Item.IdFilial;
            servImagemTextBox.Text = this.Item.ServImagem;
            folderTextBox.Text = this.Item.Folder;
            localHostTextBox.Text = this.Item.LocalHost;
            localFolderTextBox.Text = this.Item.LocalFolder;
            IsCriptogradadoCheckBox.Checked = this.Item.IsCriptogradado;
            UsaManipulacaoCheckBox.Checked = this.Item.UsaManipulacao.GetValueOrDefault();
            pastaUsaAnoCheckBox.Checked = this.Item.PastaUsaAno.GetValueOrDefault();
            pastaUsaMesCheckBox.Checked = this.Item.PastaUsaMes.GetValueOrDefault();

            //laboratorio
            ftpHostTextBox.Text = this.Item.FtpHost;
            ftpUserTextBox.Text = this.Item.FtpUser;
            ftpPassTextBox.Text = this.Item.FtpPass;
            ftpFolderTextBox.Text = this.Item.FtpFolder;
            FtpPortTextBox.Text = this.Item.FtpPort.ToString();

            //financeiro
            jurosTextBox.Text = this.Item.Financ_Juros.ToString();
            multaTextBox.Text = this.Item.Financ_Multa.ToString();
            usaFinanceiroCheckBox.Checked = this.Item.UsaFinanceiro.GetValueOrDefault();

            //variaveis
            currentAtendimentoTextBox.Text = this.Item.CurrentAtendimento.ToString();
            currentBackupTextBox.Text = this.Item.CurrentBackup.ToString();

            //integracao
            cServiceIdTextBox.Text = this.Item.CServiceId.ToString();
            cPanelIdTextBox.Text = this.Item.CPanelId.ToString();
            cMarketingIdTextBox.Text = this.Item.CMarketingId.ToString();
            rmColigadaTextBox.Text = this.Item.RMColigada.ToString();
            rmFilialTextBox.Text = this.Item.RMFilial.ToString();
        }

        protected override void CarregaItem()
        {
            //geral
            this.Item.IdFilial = (int)filialComboBox.SelectedValue;
            this.Item.ServImagem = servImagemTextBox.Text;
            this.Item.Folder = folderTextBox.Text;
            this.Item.LocalHost = localHostTextBox.Text;
            this.Item.LocalFolder = localFolderTextBox.Text;
            this.Item.IsCriptogradado = IsCriptogradadoCheckBox.Checked;
            this.Item.UsaManipulacao = UsaManipulacaoCheckBox.Checked;
            this.Item.PastaUsaAno = pastaUsaAnoCheckBox.Checked;
            this.Item.PastaUsaMes = pastaUsaMesCheckBox.Checked;

            //laboratorio
            this.Item.FtpHost = ftpHostTextBox.Text;
            this.Item.FtpUser = ftpUserTextBox.Text;
            this.Item.FtpPass = ftpPassTextBox.Text;
            this.Item.FtpFolder = ftpFolderTextBox.Text;
            this.Item.FtpPort = int.Parse(FtpPortTextBox.Text);

            //financeiro
            this.Item.Financ_Juros = decimal.Parse(jurosTextBox.Text);
            this.Item.Financ_Multa = decimal.Parse(multaTextBox.Text);
            this.Item.UsaFinanceiro = usaFinanceiroCheckBox.Checked;

            //variaveis
            this.Item.CurrentAtendimento = int.Parse(currentAtendimentoTextBox.Text);
            this.Item.CurrentBackup = int.Parse(currentBackupTextBox.Text);

            //integracao
            this.Item.CServiceId = int.Parse(cServiceIdTextBox.Text);
            this.Item.CPanelId = int.Parse(cPanelIdTextBox.Text);
            this.Item.CMarketingId = int.Parse(cMarketingIdTextBox.Text);
            this.Item.RMColigada = int.Parse(rmColigadaTextBox.Text);
            this.Item.RMFilial = int.Parse(rmFilialTextBox.Text);
        }

        protected override void Editar()
        {
            try
            {
                //atualiza dados do objeto
                CarregaItem();

                //salca no banco de dados
                objLib.Update(this.Item);

                //mensagem de retorno
                MessageBox.Show("Informações atualizadas com sucesso");
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }
    }
}
