using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.CService.Telas.Integracao.Venda.Sincronismo
{
    public partial class Libera : Form
    {
        #region PROPRIEDADES

        public int Coligada
        {
            get
            {
                return Properties.Settings.Default.Coligada;
            }
        }
        public string Movimento
        {
            get
            {
                return Properties.Settings.Default.Movimento;
            }
        }
        public int Prazo
        {
            get
            {
                return Properties.Settings.Default.Prazo;
            }
        }
        public Lib.Integracao.Venda Venda { get; set; }

        #endregion

        #region CONSTRUTORES

        public Libera(Lib.Integracao.Venda pVenda)
        {
            this.Venda = pVenda;

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Libera_Load(object sender, EventArgs e)
        {

        }

        private void btnLibera_Click(object sender, EventArgs e)
        {
            LiberaVenda();
        }

        

        #endregion

        #region METODOS

        private void LiberaVenda()
        {
            var usuario = Lib.Usuario.GetByLogin(usuarioTextBox.Text, senhaTextBox.Text);

            if (usuario != null)
            {
                if (usuario.env_usuarios_grupos.nome.Contains("Administrador"))
                {
                    Venda.DataEmissao = DateTime.Today;

                    foreach (var item in Venda.Envelopes)
                    {
                        item.DataVenda = DateTime.Today;
                        item.Observacao = item.Observacao + Environment.NewLine  + @"************ Autorizado por: " + usuario.nome + " - " + DateTime.Now.ToString() + " ************";
                    }

                    Sincroniza();
                }
                else 
                {
                    MessageBox.Show("Usuário não é administrador");
                }
            }
            else 
            {
                MessageBox.Show("Usuário e senha inválidos");
            }
        }

        private void Sincroniza()
        {
            var hasErros = false;
            var errorLog = string.Empty;

            try
            {
                Lib.Integracao.Venda.SincronizarVenda(Venda, Coligada, Prazo, true);
            }
            catch (Exception ex)
            {
                hasErros = true;
                errorLog = errorLog + ex.Message + "\n\n";
            }

            if (hasErros)
            {
                MessageBox.Show(errorLog);
            }
            else 
            {
                MessageBox.Show("Venda sincronizada com sucesso");
                this.Close();
            }
        }

        #endregion
    }
}
