using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;

namespace Canaan.Telas.Financeiro.Lancamento
{
    public partial class Filtro : Form
    {
        #region PROPRIEDADES

        public List<Dados.Lancamento> Lancamentos { get; set; }
        public bool IsCancelado { get; set; }
        private CanaanModelContainer db 
        { 
            get 
            {
                return new CanaanModelContainer();
            } 
        }

        #endregion

        #region CONSTRUTORES

        public Filtro()
        {
            //inicializa as propriedades
            Lancamentos = new List<Dados.Lancamento>();
            IsCancelado = false;

            //inicializa a tela
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Filtro_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                ExecutaConsulta();

                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelaConsulta();
        }

        private void Filtro_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }

        #endregion

        #region METODOS

        private void InitForm() 
        {
            filtroCodigo.Checked = true;
            filtroNome.Checked = false;
            filtroCpf.Checked = false;
            filtroEmissao.Checked = false;
            filtroVencimento.Checked = false;
            filtroBaixa.Checked = false;

            statusAberto.Checked = true;
            statusBaixado.Checked = true;
            statusAcordo.Checked = true;
            statusCancelado.Checked = false;

            tipoReceber.Checked = true;
            tipoPagar.Checked = true;
        }

        private bool ValidaForm() 
        {
            var isValid = true;
            var errorMessage = "";

            //valida codigo
            if (filtroCodigo.Checked) {
                if (string.IsNullOrEmpty(codigoTextBox.Text)) {
                    isValid = false;
                    errorMessage += "- Campo código é obrigatório\n";
                }
            }

            //valida nome
            if (filtroNome.Checked)
            {
                if (string.IsNullOrEmpty(nomeTextBox.Text))
                {
                    isValid = false;
                    errorMessage += "- Campo nome é obrigatório\n";
                }
            }

            //valida cpf
            if (filtroCpf.Checked)
            {
                if (string.IsNullOrEmpty(cpfTextBox.Text))
                {
                    isValid = false;
                    errorMessage += "- Campo Cpf é obrigatório\n";
                }
            }

            //valida emissao
            if (filtroEmissao.Checked)
            {
                if (emissaoFimDate.Value.Date < emissaoInicioDate.Value.Date)
                {
                    isValid = false;
                    errorMessage += "- Data de emissão final deve ser menor que a inicial\n";
                }
            }

            //valida vencimento
            if (filtroVencimento.Checked)
            {
                if (vencFimDate.Value.Date < vencInicioDate.Value.Date)
                {
                    isValid = false;
                    errorMessage += "- Data de vencimento final deve ser menor que a inicial\n";
                }
            }

            //valida baixa
            if (filtroBaixa.Checked)
            {
                if (baixaFimDate.Value.Date < baixaInicioDate.Value.Date)
                {
                    isValid = false;
                    errorMessage += "- Data de baixa final deve ser menor que a inicial\n";
                }
            }

            //valida status
            if (!statusAberto.Checked && !statusBaixado.Checked && !statusAcordo.Checked && !statusCancelado.Checked) 
            {
                isValid = false;
                errorMessage += "- Você deve selecionar pelo menos 1 status de lançamento\n";
            }

            //exibe mensagem de erro
            if (!isValid) {
                MessageBox.Show(errorMessage);
            }

            //retorna
            return isValid;
        }

        public void ExecutaConsulta() 
        {
            //cria objeto da consulta
            IQueryable<Dados.Lancamento> consulta = db.Lancamento
                                                      .Include(a => a.Filial)
                                                      .Include(a => a.CliFor);

            //filtra o tipo
            if (tipoPagar.Checked && tipoReceber.Checked)
            {
                consulta = consulta.Where(a => a.Tipo == EnumLancTipo.Pagar || a.Tipo == EnumLancTipo.Receber);
            }
            else 
            {
                if (tipoReceber.Checked)
                {
                    consulta = consulta.Where(a => a.Tipo == EnumLancTipo.Receber);
                }

                if (tipoPagar.Checked)
                {
                    consulta = consulta.Where(a => a.Tipo == EnumLancTipo.Pagar);
                }
            }

            

            //filtra o codigo
            if(filtroCodigo.Checked && !string.IsNullOrEmpty(codigoTextBox.Text))
            {
                var codReduzido = int.Parse(codigoTextBox.Text);
                consulta = consulta.Where(a => (a.Pedido as Venda).Atendimento.CodigoReduzido == codReduzido);
            }

            //verifica nome
            if(filtroNome.Checked)
            {
                consulta = consulta.Where(a => a.CliFor.Nome.Contains(nomeTextBox.Text));
            }

            //verifica cpf
            if (filtroCpf.Checked)
            {
                consulta = consulta.Where(a => a.CliFor.Documento.Contains(cpfTextBox.Text));
            }

            //verifica emissao
            if (filtroEmissao.Checked) 
            {
                consulta = consulta.Where(a => a.DataEmissao >= emissaoInicioDate.Value && a.DataEmissao <= emissaoFimDate.Value);
            }

            //verifica vencimento
            if (filtroVencimento.Checked)
            {
                consulta = consulta.Where(a => a.DataVencimento >= vencInicioDate.Value.Date && a.DataVencimento <= vencFimDate.Value.Date);
            }

            //verifica baixa
            if (filtroBaixa.Checked)
            {
                consulta = consulta.Where(a => a.DataBaixa >= baixaInicioDate.Value && a.DataBaixa <= baixaFimDate.Value);
            }

            //filtra os status
            var status = new List<EnumStatusLanc>();

            //verifica em aberto
            if (statusAberto.Checked) {
                status.Add(EnumStatusLanc.EmAberto);
            }

            //verifica baixado
            if (statusBaixado.Checked)
            {
                status.Add(EnumStatusLanc.Baixado);
            }

            //verifica acordo
            if (statusAcordo.Checked)
            {
                status.Add(EnumStatusLanc.BaixadoAcordo);
            }

            //verifica cancelado
            if (statusCancelado.Checked)
            {
                status.Add(EnumStatusLanc.Cancelado);
            }

            consulta = consulta.Where(a => status.Contains(a.Status));

            //salva consulta na lista
            Lancamentos = consulta.ToList();
        }

        private void CancelaConsulta() 
        {
            IsCancelado = true;
            Close();
        }

        public List<Dados.Lancamento> GetResult() 
        {
            if (!IsCancelado) 
            {
                return Lancamentos;
            }
            else 
            {
                return null;
            }
        }

        #endregion
    }
}
