using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BoletoNet;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Telas.Configuracoes.Geral.Filiais;
using DevExpress.XtraEditors;
using Extrato = Canaan.Dados.Extrato;

namespace Canaan.Telas.Financeiro.Retorno
{
    public partial class Edita : XtraForm
    {
        #region PROPRIEDADES

        public Lib.Lancamento objLanc { get; set; }
        public Lib.Retorno objLib { get; set; }
        public Dados.Retorno Retorno { get; set; }
        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }
        public ArquivoRetornoCNAB400 ArquivoRetorno { get; set; }
        public string Arquivo { get; set; }
        
        #endregion

        #region CONSTRUTORES

        public Edita()
        {
            objLanc = new Lib.Lancamento();
            objLib = new Lib.Retorno();
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();
            InitForm();
        }

        private void filialLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregaFilial();
        }

        private void contaCaixaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregaContaCaixa();
        }

        private void arquivoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelecionaArquivo();
        }

        private void btnProcessa_Click(object sender, EventArgs e)
        {
            InitRetorno();
        }

        

        #endregion

        #region METODOS

        protected virtual void SetTitle()
        {
            Text = "Retorno de Arquivos Bancarios";
        }

        private void CarregaFilial()
        {
            var frm = new Seleciona();
            frm.ShowDialog();

            if (frm.objItem != null)
            {
                idFilialTextEdit.Text = frm.objItem.IdFilial.ToString();
                filialLinkLabel.Text = frm.objItem.NomeFantasia;
            }
        }

        private void CarregaContaCaixa()
        {
            var frm = new ContaCaixa.Seleciona();
            frm.ShowDialog();

            if (frm.objItem != null)
            {
                idContaCaixaTextEdit.Text = frm.objItem.IdContaCaixa.ToString();
                contaCaixaLinkLabel.Text = frm.objItem.Nome;
            }
        }

        private void InitForm() 
        { 
            //pega filial atual
            idFilialTextEdit.Text = Session.Contexto.Filial.IdFilial.ToString();
            filialLinkLabel.Text = Session.Contexto.Filial.NomeFantasia;

            //pega conta caixa padrao da filial
            var contacaixa = new Lib.ContaCaixa().GetByFilial(Session.Contexto.Filial.IdFilial).Where(a => a.IsPadrao == true).FirstOrDefault();
            if(contacaixa != null)
            {
                idContaCaixaTextEdit.Text = contacaixa.IdContaCaixa.ToString();
                contaCaixaLinkLabel.Text = contacaixa.Nome;
            }
            
            //inicializa as informacoes do tabstrip
            infoToolStripLabel.Visible = false;
            infoToolStripProgressBar.Visible = false;
        }

        private void SelecionaArquivo() 
        {
            if (retornoFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(retornoFileDialog.FileName))
                {
                    Arquivo = retornoFileDialog.FileName;
                    arquivoLinkLabel.Text = retornoFileDialog.FileName;
                }
            }
        }

        private void InitRetorno()
        {
            try
            {
                if (string.IsNullOrEmpty(idContaCaixaTextEdit.Text) == false && string.IsNullOrEmpty(Arquivo) == false)
                {
                    //recupera o retorno
                    ArquivoRetorno = objLib.LerRetorno(int.Parse(idContaCaixaTextEdit.Text), Arquivo);

                    //cria objeto do retorno
                    CriaRetorno();

                    //inicializa informações
                    InitInfo();

                    //faz loop no retorno
                    retornoBackgroundWorker.RunWorkerAsync();
                }
                else
                {
                    throw new Exception("O arquivo e a conta caixa são obrigatórios");
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void InitInfo()
        {
            infoToolStripLabel.Visible = true;
            infoToolStripProgressBar.Visible = true;
            infoToolStripProgressBar.Maximum = ArquivoRetorno.ListaDetalhe.Count;
            UpdateProgress(0);
        }

        private void CriaRetorno()
        {
            Retorno = new Dados.Retorno();
            Retorno.IdFilial = int.Parse(idFilialTextEdit.Text);
            Retorno.IdContaCaixa = int.Parse(idContaCaixaTextEdit.Text);
            Retorno.IdUsuario = Session.Usuario.IdUsuario;
            Retorno.Data = DateTime.Today;
            Retorno.Arquivo = Arquivo;
        }

        private void ProcessaRetorno() 
        {
            int i = 0;
            int filial = int.Parse(idFilialTextEdit.Text);

            foreach (var item in ArquivoRetorno.ListaDetalhe)
            {
                //atualiza porcentagem
                i++;
                retornoBackgroundWorker.ReportProgress(i);

                //recupera o lancamento
                var lanc = objLanc.GetByNossoNumero(filial, item.NossoNumero);

                //cria o log
                var log = objLib.CriaLog(filial, lanc, item, Session.Usuario);

                //baixa lancamento
                if (!log.IsErro) 
                {
                    UpdateLancamento(lanc, item);
                }
                

                //adiciona log ao retorno
                Retorno.RetornoLog.Add(log);
            }
        }

        private void UpdateProgress(int p)
        {
            infoToolStripLabel.Text = string.Format("{0} de {1} registros", p, ArquivoRetorno.ListaDetalhe.Count);
            infoToolStripProgressBar.Value = p;
        }

        private void UpdateLancamento(Dados.Lancamento lanc, DetalheRetorno item) 
        {
            //cria o extrato
            Extrato extrato = SalvaExtrato(item);
            
            //baixa o lancamento
            lanc.IdExtrato = extrato.IdExtrato;
            lanc.Status = EnumStatusLanc.Baixado;
            lanc.DataBaixa = DateTime.Today;
            lanc.ValorBaixado = item.ValorPago + item.TarifaCobranca;

            //salva dados no banco de dados
            objLanc.Update(lanc, false);
        }

        private Extrato SalvaExtrato(DetalheRetorno item)
        {
            try
            {
                //cria dados do extrato
                Extrato Extrato = new Extrato();
                Extrato.IdUsuario = Session.Usuario.IdUsuario;
                Extrato.IdContaCaixa = int.Parse(idContaCaixaTextEdit.Text);
                Extrato.TipoPgto = EnumPgtoTipo.Boleto;
                Extrato.Status = EnumStatusExtrato.Baixado;
                Extrato.ValorLiquido = item.ValorTitulo;
                Extrato.ValorPago = item.ValorPago + item.TarifaCobranca;
                Extrato.ValorTroco = 0;
                Extrato.ValorBaixado = item.ValorPago + item.TarifaCobranca;
                Extrato.Data = DateTime.Today;
                Extrato.Hora = DateTime.Now.TimeOfDay;

                //salva extrato no banco de dados
                return new Lib.Extrato().Insert(Extrato);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected virtual void Incluir()
        {
            objLib.Insert(Retorno);
        }

        #endregion

        private void retornoBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessaRetorno();
        }

        private void retornoBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateProgress(e.ProgressPercentage);
        }

        private void retornoBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                Incluir();
                MessageBoxUtilities.MessageInfo("Finalizou leitura");
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
            
        }

    }
}
