using System;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Movimentacoes.Sessao.Telas;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using System.Linq;

namespace Canaan.Telas.Movimentacoes.Sessao
{
    public partial class Edita : XtraForm
    {
        #region PROPRIEDADES

        private int SelectedSessao;

        public Dados.Atendimento Atendimento { get; set; }

        public Lib.Pasta LibPasta
        {
            get
            {
                return new Lib.Pasta();
            }
        }

        public Lib.Sessao LibSessao
        {
            get
            {
                return new Lib.Sessao();
            }
        }

        public Lib.SessaoPasta LibSessaoPasta
        {
            get
            {
                return new Lib.SessaoPasta();
            }
        }

        public Dados.Sessao Sessao { get; set; }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }


        #endregion

        #region CONSTRUTOR

        /// <summary>
        /// Criar Nova Sessao
        /// </summary>
        /// <param name="Atendimento"></param>
        public Edita(Dados.Atendimento Atendimento)
        {
            this.Atendimento = Atendimento;

            NovaSessao();

            InitializeComponent();
        }

        /// <summary>
        /// Editar Sessao Existente
        /// </summary>
        /// <param name="selectedSessao"></param>
        public Edita(int selectedSessao)
        {
            SelectedSessao = selectedSessao;
            Sessao = LibSessao.GetById(SelectedSessao);

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Edita_Load(object sender, EventArgs e)
        {
            CarregaInfo();
            CarregaPastas();
        }

        private void navBarControl1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (e.Link.ItemName == "nvBtInfo")
            {
                CarregaInfo();
            }
            else
            {
                if ((int)Sessao.Genero == 0 && (int)Sessao.Tipo == 0)
                {
                    MessageBoxUtilities.MessageWarning("Antes de prosseguir você deve salvar o genero e o tipo de sessão.");
                }
                else
                {

                    if (e.Link.ItemName.Contains("folder"))
                    {
                        var id = int.Parse(e.Link.ItemName.Replace("folder_", string.Empty));

                        CarregarImagem(id);
                    }
                }
            }

        }

        #endregion

        #region METODOS

        private void NovaSessao()
        {
            if (Atendimento == null)
                throw new Exception("Não existe atendimento criado este cliente.");

            var numSessao = LibSessao.GetNumSessao(Atendimento.IdAtendimento);
            //var numSessao = LibSessao.GetNumSessao()

            try
            {
                //inicializa o objeto
                Sessao = new Dados.Sessao
                {
                    IdAtendimento = Atendimento.IdAtendimento,
                    IdUsuario = Session.Usuario.IdUsuario,
                    Data = DateTime.Now,
                    NumSessao = numSessao,
                    IsAtivo = true, 
                    IsCriptografado = new Config().GetByFilial(Session.Contexto.IdFilial).IsCriptogradado
                };

                //cria pastas da sessao
                CriaPastasCliente();

                if (!string.IsNullOrEmpty(this.Sessao.Pasta))
                {
                    //inclui no banco de dados
                    Sessao = LibSessao.Insert(Sessao);

                    //cria pastas pre definidas no sistema
                    CriaPastasPadrao();
                }
                else
                {
                    MessageBox.Show("A pasta do cliente nao foi criada.\nA inclusão da sessão fotográfica foi cancelada");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void CriaPastasCliente()
        {
            //verifica se usa ano e mes
            var config = new Lib.Config().Get().FirstOrDefault();
            var caminho = string.Format(@"\\{0}\{1}", config.ServImagem, config.Folder);
            
            //verifica se usa pasta de ano
            if (config.PastaUsaAno == true)
            {
                caminho = string.Format(@"{0}\{1}", caminho, Sessao.Data.Year.ToString());

                if (!System.IO.Directory.Exists(caminho))
                    System.IO.Directory.CreateDirectory(caminho);
            }

            //verifica se ja existe pasta do mes
            if (config.PastaUsaMes == true)
            {
                caminho = string.Format(@"{0}\{1}", caminho, Lib.Utilitarios.Comum.GetMes(Sessao.Data.Month));
                if (!System.IO.Directory.Exists(caminho))
                    System.IO.Directory.CreateDirectory(caminho);
            }

            // verifica se existe pasta personalizada
            var pastas = new Lib.Pasta().Get();
            if (pastas.Count == 0)
            {
                var server = string.Format(@"\\{0}\{1}\", config.ServImagem, config.Folder);
                caminho = string.Format(@"{0}\{1}-{2}", caminho, this.Atendimento.CodigoReduzido, this.Sessao.NumSessao);

                this.Sessao.Pasta = caminho.Replace(server, string.Empty);
            }
            else
            {
                //verifica pasta cliente
                var frm = new Telas.FolderName(caminho, Lib.Utilitarios.Comum.GetFolderName(this.Atendimento.CliFor.Nome));
                frm.ShowDialog();

                if (!string.IsNullOrEmpty(frm.Folder))
                {
                    var server = string.Format(@"\\{0}\{1}\", config.ServImagem, config.Folder);
                    this.Sessao.Pasta = string.Format(@"{0}\{1}", frm.Caminho, frm.Folder).Replace(server, string.Empty);
                }
                else
                {
                    this.Sessao.Pasta = string.Empty;
                }
            }
        }

        private void CriaPastasPadrao()
        {
            var config = new Lib.Config().Get().FirstOrDefault();
            var server = string.Format(@"\\{0}\{1}", config.ServImagem, config.Folder);
            var pastas = this.LibPasta.Get();

            //faz loop criando as pastas padroes
            if (!string.IsNullOrEmpty(this.Sessao.Pasta))
            {
                //pasta com codigo simples
                if (pastas.Count == 0)
                {
                    var pasta = string.Format(@"{0}", this.Sessao.Pasta);

                    //verifica se ja existe pagina criada
                    if (!System.IO.Directory.Exists(string.Format(@"{0}\{1}", server, pasta)))
                    {
                        System.IO.Directory.CreateDirectory(string.Format(@"{0}\{1}", server, pasta));
                        System.IO.Directory.CreateDirectory(string.Format(@"{0}\{1}\thumb", server, pasta));
                    }

                    //verifica se ja existe registro no banco de dados
                    if (LibSessaoPasta.GetByNome(Sessao.IdSessao, pasta).Count == 0)
                    {
                        var sessaoPasta = new Dados.SessaoPasta();
                        sessaoPasta.IdSessao = Sessao.IdSessao;
                        sessaoPasta.Nome = pasta;
                        sessaoPasta.Caminho = pasta;
                        sessaoPasta.IsDefault = true;

                        LibSessaoPasta.Insert(sessaoPasta);
                    }
                }
                else
                {
                    foreach (var item in pastas)
                    {

                        var pasta = string.Format(@"{0}\{1}", this.Sessao.Pasta, item.Nome);

                        //verifica se ja existe pagina criada
                        if (!System.IO.Directory.Exists(string.Format(@"{0}\{1}", server, pasta)))
                        {
                            System.IO.Directory.CreateDirectory(string.Format(@"{0}\{1}", server, pasta));
                            System.IO.Directory.CreateDirectory(string.Format(@"{0}\{1}\thumb", server, pasta));
                        }

                        //verifica se ja existe registro no banco de dados
                        if (LibSessaoPasta.GetByNome(Sessao.IdSessao, item.Nome).Count == 0)
                        {
                            var sessaoPasta = new Dados.SessaoPasta();
                            sessaoPasta.IdSessao = Sessao.IdSessao;
                            sessaoPasta.Nome = item.Nome;
                            sessaoPasta.Caminho = pasta;
                            sessaoPasta.IsDefault = item.IsDefault;

                            LibSessaoPasta.Insert(sessaoPasta);
                        }
                    }
                }
                
            }
        }

        private void CarregaPastas()
        {
            var pastas = LibSessaoPasta.GetBySessao(this.Sessao.IdSessao);

            foreach (var pasta in pastas)
            {
                var item = new NavBarItem();
                item.Name = string.Format("folder_{0}", pasta.IdSessaoPasta);
                item.Caption = pasta.Nome;

                nvBar.ItemLinks.Add(item);
            }
            
        }

        private void CarregaInfo()
        {
            //Limpa controles
            LimpaControles();

            //verifica numero de imagens da sessao


            ///Abre tela de informações
            var frm = new Info(Sessao);
            frm.TopLevel = false;

            panelControls.Controls.Add(frm);

            frm.Show();
            Focus();
        }

        private void CarregarImagem(int id)
        {
            //Limpa controles
            LimpaControles();

            ///Abre tela de informações
            var frm = new Imagem(Sessao, id);
            frm.TopLevel = false;

            panelControls.Controls.Add(frm);

            frm.Show();
            Focus();
        }

        private void LimpaControles()
        {
            foreach (Control item in panelControls.Controls)
            {
                if (item as Form != null)
                {
                    ((Form)item).Close();
                }
            }

            panelControls.Controls.Clear();
        }

        #endregion
    }
}

