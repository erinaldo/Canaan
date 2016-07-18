using System;
using System.Collections.Generic;
using System.Linq;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Relatorios.Financeiro.Boleto.Itau;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Financeiro.Lancamento
{
    public partial class Email : XtraForm
    {
        #region PROPRIEDADES

        public List<Dados.Lancamento> Lancamentos { get; set; }

        #endregion

        #region CONSTRUTORES

        public Email(List<Dados.Lancamento> p_Lancamentos)
        {
            Lancamentos = p_Lancamentos;
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Email_Load(object sender, EventArgs e)
        {
            InitForm();
            CarregaGrid();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Enviar();
        }

        #endregion

        #region METODOS

        private void InitForm() 
        {
            if (Lancamentos.Count > 0) 
            {
                emailTextBox.Text = Lancamentos.FirstOrDefault().CliFor.Email;
            }
        }

        private void Enviar() 
        {
            try
            {
                if (Lancamentos.Count > 0)
                {
                    if (!string.IsNullOrEmpty(emailTextBox.Text.Trim()))
                    {
                        var lanc = Lancamentos.FirstOrDefault();
                        var report = new Viewer(new Lib.Lancamento().GetIds(Lancamentos));
                        var pdfPath = report.ExportaBoletos();
                        var nome = lanc.CliFor.Nome;
                        var texto = string.Format("Olá {0}, segue em anexo os boletos da sua compra efetuada no {1}", nome, Session.Instance.Contexto.Filial.NomeFantasia);
                        List<string> destinatarios = new List<string>();
                        List<string> anexos = new List<string>();
                        
                        //configura as listas
                        destinatarios.Add(emailTextBox.Text);
                        anexos.Add(pdfPath);

                        try
                        {
                            Comum.SendEmail(destinatarios.ToArray(), "Boletos Bancários Canaan", texto, anexos.ToArray());
                            MessageBoxUtilities.MessageInfo("Email enviado com sucesso");
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBoxUtilities.MessageError(null, ex);
                        }
                    }
                    else 
                    {
                        throw new Exception("Nenhum email de cliente informado");
                    }
                }
                else
                {
                    throw new Exception("Nenhum lancamento selecionado para envio de email");
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
            
        }

        private void CarregaGrid() 
        {
            var dados = Lancamentos.Select(a => new { 
                Codigo = a.IdLancamento,
                Cliente = a.CliFor.Nome,
                Vencimento = a.DataVencimento,
                Valor = a.ValorLiquido
            }).ToList();

            lancDataGridView.DataSource = dados;
        }

        #endregion
    }
}
