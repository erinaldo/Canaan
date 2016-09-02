using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Telas.Ferramentas.Spc
{
    public partial class Envio : Form
    {
        public List<int> Ids { get; set; }
        public Dados.GFILIAL Filial { get; set; }
        public RM.Lib.TipoAtualizacao Tipo { get; set; }
        public List<AceJundiai.Socket.Registro> ListaEnvio { get; set; }
        public List<AceJundiai.Socket.Registro> ListaRetorno { get; set; }

        public Envio(List<int> p_Ids, Dados.GFILIAL p_Filial, RM.Lib.TipoAtualizacao p_Tipo)
        {
            //inicializa propriedades
            this.Ids = p_Ids;
            this.Filial = p_Filial;
            this.Tipo = p_Tipo;
            this.ListaEnvio = new List<AceJundiai.Socket.Registro>();
            this.ListaRetorno = new List<AceJundiai.Socket.Registro>();

            //inicializa componentes
            InitializeComponent();
        }

        private void Envio_Load(object sender, EventArgs e)
        {
            //carrega a lista de envio
            this.CarregaListaEnvio();

            workerRegistro.RunWorkerAsync();
        }

        private void CarregaListaEnvio() 
        {
            //abre conexao com o banco de dados
            using (RM.Dados.CorporeEntities conn = new RM.Dados.CorporeEntities())
            {
                //pega dados
                var lanc = conn.FLAN.Where(a => this.Ids.Contains(a.IDLAN) && a.CODCOLIGADA == this.Filial.CODCOLIGADA && a.CODFILIAL == this.Filial.CODFILIAL);
                var cpanel = CPanel.Lib.Filiais.GetByRM(this.Filial.CODCOLIGADA, this.Filial.CODFILIAL);
                var tipo = this.Tipo == Lib.TipoAtualizacao.Inclusao ? "I" : "E";

                //faz loop nos lancamentos gerando a lista
                foreach (var item in lanc)
                {
                    //cria o registro
                    var reg = new AceJundiai.Socket.Registro(cpanel.spc, cpanel.spc_senha, tipo);

                    //configura devedor
                    reg.Devedor.Pessoa = item.FCFO.PESSOAFISOUJUR;
                    if (item.FCFO.PESSOAFISOUJUR == "F")
                        reg.Devedor.CPF = AceJundiai.Socket.Comum.FormataDocumento(item.FCFO.CGCCFO);
                    else
                        reg.Devedor.CNPJ = AceJundiai.Socket.Comum.FormataDocumento(item.FCFO.CGCCFO);
                    reg.Devedor.Nome = item.FCFO.NOME;
                    reg.Devedor.DataNascimento = AceJundiai.Socket.Comum.FormataData(item.FCFO.DTNASCIMENTO.GetValueOrDefault());
                    reg.Devedor.Endereco = item.FCFO.RUA;
                    reg.Devedor.Numero = string.IsNullOrEmpty(item.FCFO.NUMERO) ? string.Empty : item.FCFO.NUMERO;
                    reg.Devedor.Complemento = string.IsNullOrEmpty(item.FCFO.COMPLEMENTO) ? string.Empty : item.FCFO.COMPLEMENTO;
                    reg.Devedor.Bairro = string.IsNullOrEmpty(item.FCFO.BAIRRO) ? "" : item.FCFO.BAIRRO;
                    reg.Devedor.Cidade = string.IsNullOrEmpty(item.FCFO.CIDADE) ? "" : item.FCFO.CIDADE;
                    reg.Devedor.UF = string.IsNullOrEmpty(item.FCFO.CODETD) ? "" : item.FCFO.CODETD;
                    reg.Devedor.CEP = string.IsNullOrEmpty(item.FCFO.CEP) ? "" : AceJundiai.Socket.Comum.FormataCep(item.FCFO.CEP);
                    reg.Devedor.Email = string.IsNullOrEmpty(item.FCFO.EMAIL) ? "" : AceJundiai.Socket.Comum.FormataEmail(item.FCFO.EMAIL);
                    
                    //configura o debito
                    reg.Debito.TipoDocumento = "CS";
                    reg.Debito.NumeroContrato = item.FCFO.CODCFO.ToString();
                    reg.Debito.DataCompra = AceJundiai.Socket.Comum.FormataData(item.DATAEMISSAO);
                    reg.Debito.DataVencimento = AceJundiai.Socket.Comum.FormataData(item.DATAVENCIMENTO);
                    reg.Debito.ValorDebito = AceJundiai.Socket.Comum.FormataValor(item.TMOV.FLAN.Where(a => a.STATUSLAN == 0).Sum(a => a.VALORORIGINAL));

                    //adiciona lista
                    this.ListaEnvio.Add(reg);
                }

            }
        }

        private void ProcessaLista() 
        {
            
            var indice = 0;

            //faz loop nos items do envio
            foreach (var item in this.ListaEnvio)
            {
                try
                {
                    //processa a requisicao
                    var ret = ProcessaRequest(item);

                    //verifica se é registro
                    if (item.Autenticacao.TipoAtualizacao == "I") {
                        EnviaEmail(item);
                    }

                    //adiciona na lista de retorno
                    this.ListaRetorno.Add(ret);

                    //chama o progress change
                    indice++;
                    workerRegistro.ReportProgress((indice * 100) / ListaEnvio.Count, ret);
                }
                catch (Exception ex)
                {
                    //cria registro com a exceção
                    var ret = new AceJundiai.Socket.Registro();
                    ret.Devedor.Nome = item.Devedor.Nome;
                    ret.Debito.NumeroContrato = item.Debito.NumeroContrato;
                    ret.Debito.CodRetorno = "10000";
                    ret.Debito.Diagnostico = ex.Message;

                    //adiciona na lista de retorno
                    this.ListaRetorno.Add(ret);
                }
                
            }

        }

        private AceJundiai.Socket.Registro ProcessaRequest(AceJundiai.Socket.Registro item)
        {
            //envia request para o socket
            var req = new AceJundiai.Socket.Request();
            var result = req.SendRequest(item.Serialize(), AceJundiai.Socket.Enums.Tipo.Regitrar);

            //cria registro de retorno
            var ret = new AceJundiai.Socket.Registro();
            ret.Deserialize(result);

            // verifica erros de cep
            if (ret.Debito.CodRetorno == "28")
            {
                var cpanel = CPanel.Lib.Filiais.GetByRM(Filial.CODCOLIGADA, Filial.CODFILIAL);

                if (cpanel.cep_padrao != null)
                {
                    item.Devedor.CEP = cpanel.cep_padrao;
                    ret = ProcessaRequest(item);
                }
            }

            //retorna
            return ret;
        }

        private void EnviaEmail(AceJundiai.Socket.Registro item)
        {
            using (WebClient client = new WebClient())
            {
                if (!string.IsNullOrEmpty(item.Devedor.Email)) 
                {
                    var assunto = "Oi aqui é o Joel Pereira";
                    var body = client.DownloadString("https://emailmarketing.locaweb.com.br/panel/templates/5");

                    //AceJundiai.Socket.Comum.SendEmail(assunto, body, "sac@canaanfotos.com.br", item.Devedor.Email);
                    AceJundiai.Socket.Comum.SendEmail(assunto, body, "sac@canaanfotos.com.br", "job@canaanfotos.com.br");
                }
            }
        }

        private void GeraArquivo() 
        {
            var br = Environment.NewLine;
            var text = "";
            
            //cabecalho
            text += string.Format("Relatório de retorno:{0}", br);
            text += string.Format("Filial: {0}{1}", Filial.NOMEFANTASIA, br);
            text += string.Format("Data da Execução: {0}{1}{2}", DateTime.Now, br, br);

            //cria o conteudo
            foreach (var item in ListaRetorno.OrderBy(a => a.Debito.CodRetorno))
            {
                text += string.Format("Cliente: {0} - {1}{2}", item.Debito.NumeroContrato, item.Devedor.Nome, br);
                text += string.Format("Status: {0} - {1}{2}{3}", item.Debito.CodRetorno, item.Debito.Diagnostico, br, br);
            }

            //salva o arquivo
            var filename = string.Format("{0}_{1}.txt", this.Tipo.ToString(), this.Filial.NOMEFANTASIA);
            var folder = string.Format("{0}-{1}-{2}", DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            try
            {
                //verifica se o diretorio existe
                if (!System.IO.Directory.Exists(string.Format(@"c:\temp\{0}", folder)))
                {
                    System.IO.Directory.CreateDirectory(string.Format(@"c:\temp\{0}", folder));
                }

                //verifica se o nome do arquivo existe
                if (System.IO.File.Exists(string.Format(@"c:\temp\{0}\{1}", folder, filename)))
                {
                    filename = string.Format("{0}_{1}_{2}{3}{4}.txt", 
                                              this.Tipo.ToString(), 
                                              this.Filial.NOMEFANTASIA, 
                                              DateTime.Now.Hour.ToString(), 
                                              DateTime.Now.Minute.ToString(), 
                                              DateTime.Now.Second.ToString());
                }

                //grava arquivo no disco
                System.IO.File.WriteAllText(string.Format(@"c:\temp\{0}\{1}", folder, filename), text);
                MessageBox.Show("Arquivo gerado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void workerRegistro_DoWork(object sender, DoWorkEventArgs e)
        {
            //processa a lista
            this.ProcessaLista();
        }

        private void workerRegistro_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var reg = (AceJundiai.Socket.Registro)e.UserState;

            statusProgress.Value = e.ProgressPercentage;
            statusText.Text = string.Format("{0}%", e.ProgressPercentage);
            listInfo.Items.Add(string.Format("{0} - {1}", reg.Debito.NumeroContrato, reg.Devedor.Nome));
            listInfo.SelectedIndex = listInfo.Items.Count - 1;
        }

        private void workerRegistro_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusProgress.Value = 100;
            statusText.Text = string.Format("{0}%", 100);

            //salva arquivo de retorno
            this.GeraArquivo();
        }
    }
}
