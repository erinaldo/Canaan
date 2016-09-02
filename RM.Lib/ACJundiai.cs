using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Lib
{
    public class ACJundiai
    {
        public ACJundiai_Header Header { get; set; }
        public List<ACJundiai_Detalhe> Detalhes { get; set; }
        public ACJundiai_Trailler Trailler { get; set; }

        public ACJundiai() {
            this.Header = new ACJundiai_Header();
            this.Detalhes = new List<ACJundiai_Detalhe>();
            this.Trailler = new ACJundiai_Trailler();
        }

        public string FormataData(DateTime data) 
        {
            return string.Format("{0}{1}{2}",
                data.Day.ToString().PadLeft(2, '0'),
                data.Month.ToString().PadLeft(2, '0'),
                data.Year.ToString().PadLeft(4, '0'));
        }

        public string FormataDocumento(string doc) 
        { 
            doc = doc.Replace(".","");
            doc = doc.Replace("-", "");
            doc = doc.Replace("/", "");

            return doc;
        }

        public string FormataValor(decimal valor) 
        {
            string s = decimal.Round(valor, 2).ToString();
            s = s.Replace(",", "");
            s = s.Replace(".", "");

            return s;
        }        

        public string Imprime() 
        {
            string arquivo = "";

            arquivo += this.Header.Imprime();
            foreach (var item in Detalhes)
            {
                arquivo += item.Imprime();
            }
            arquivo += this.Trailler.Imprime();

            return GetStringNoAccents(arquivo);
        }

        public static string GetStringNoAccents(string str)
        {
            /** Troca os caracteres acentuados por não acentuados **/
            string[] acentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };
            string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            for (int i = 0; i < acentos.Length; i++)
            {
                str = str.Replace(acentos[i], semAcento[i]);
            }
            /** Troca os caracteres especiais da string por "" **/
            string[] caracteresEspeciais = { "\\.", ",", "-", ":", "\\(", "\\)", "ª", "\\|", "\\\\", "°" };
            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                str = str.Replace(caracteresEspeciais[i], "");
            }
            /** Troca os espaços no início por "" **/
            str = str.Replace("^\\s+", "");
            /** Troca os espaços no início por "" **/
            str = str.Replace("\\s+$", "");
            /** Troca os espaços duplicados, tabulações e etc por  " " **/
            str = str.Replace("\\s+", " ");
            return str;
        }

        public static string GeraArquivo(TipoAtualizacao tipo, List<int> lancamentos, Dados.GFILIAL filial) 
        {
            using (RM.Dados.CorporeEntities conn = new RM.Dados.CorporeEntities())
            {
                //pega dados
                var lanc = conn.FLAN.Where(a => lancamentos.Contains(a.IDLAN) && a.CODCOLIGADA == filial.CODCOLIGADA && a.CODFILIAL == filial.CODFILIAL);

                //cria informações do arquivo de remessa
                RM.Lib.ACJundiai remessa = new RM.Lib.ACJundiai();
                remessa.Header.Constante1 = "REMESSA";
                remessa.Header.DataMovimento = remessa.FormataData(DateTime.Today);
                remessa.Header.Remetente = filial.NOMEFANTASIA;
                remessa.Header.Codigo = CPanel.Lib.Filiais.GetByRM(filial.CODCOLIGADA, filial.CODFILIAL).spc;

                //detalhes
                int sequencia = 0;
                foreach (var item in lanc)
                {
                    sequencia++;

                    RM.Lib.ACJundiai_Detalhe detalhe = new RM.Lib.ACJundiai_Detalhe();
                    detalhe.TipoRegistro = "1";
                    if (tipo == TipoAtualizacao.Inclusao)
                        detalhe.TipoAtualizacao = "I";
                    else
                        detalhe.TipoAtualizacao = "E";

                    //dados do devedor
                    detalhe.Devedor.Pessoa = item.FCFO.PESSOAFISOUJUR;
                    if (item.FCFO.PESSOAFISOUJUR == "F")
                        detalhe.Devedor.Cpf = remessa.FormataDocumento(item.FCFO.CGCCFO);
                    else
                        detalhe.Devedor.CGC = remessa.FormataDocumento(item.FCFO.CGCCFO);
                    detalhe.Devedor.Nome = item.FCFO.NOME;
                    detalhe.Devedor.DataNascimento = remessa.FormataData(item.FCFO.DTNASCIMENTO.GetValueOrDefault());

                    //dados do endereco
                    detalhe.Debito.Endereco = item.FCFO.RUA;
                    detalhe.Debito.Numero = string.IsNullOrEmpty(item.FCFO.NUMERO) ? string.Empty : item.FCFO.NUMERO;
                    detalhe.Debito.Complemento = string.IsNullOrEmpty(item.FCFO.COMPLEMENTO) ? string.Empty : item.FCFO.COMPLEMENTO;
                    detalhe.Debito.Bairro = string.IsNullOrEmpty(item.FCFO.BAIRRO) ? "" : item.FCFO.BAIRRO;
                    detalhe.Debito.Cidade = string.IsNullOrEmpty(item.FCFO.CIDADE) ? "" : item.FCFO.CIDADE;
                    detalhe.Debito.Uf = string.IsNullOrEmpty(item.FCFO.CODETD) ? "" : item.FCFO.CODETD;
                    detalhe.Debito.Cep = string.IsNullOrEmpty(item.FCFO.CEP) ? "" : remessa.FormataDocumento(item.FCFO.CEP);

                    //dados dodocumento
                    detalhe.Debito.TipoDocumento = "CS";
                    detalhe.Debito.Contrato = item.FCFO.CODCFO.ToString();
                    detalhe.Debito.DataCompra = remessa.FormataData(item.DATAEMISSAO);
                    detalhe.Debito.DataVencimento = remessa.FormataData(item.DATAVENCIMENTO);
                    detalhe.Debito.ValorDebito = remessa.FormataValor(item.TMOV.FLAN.Where(a => a.STATUSLAN == 0).Sum(a => a.VALORORIGINAL));
                    detalhe.Debito.NumeroSequencia = sequencia.ToString();

                    //adiciona na remessa
                    remessa.Detalhes.Add(detalhe);
                }

                //trailer
                remessa.Trailler.TipoRegistro = "9";
                remessa.Trailler.DataMovimento = remessa.FormataData(DateTime.Today);
                remessa.Trailler.Inclusoes = lanc.Count().ToString();
                remessa.Trailler.NumeroSequencia = (sequencia + 1).ToString();

                //salva no arquivo
                return remessa.Imprime();
            }
        }
    }

    public class ACJundiai_Header 
    {
        public string Tipo { get; set; }
        public string Constante1 { get; set; }
        public string Remessa { get; set; }
        public string DataMovimento { get; set; }
        public string Constante2 { get; set; }
        public string Constante3 { get; set; }
        public string Remetente { get; set; }
        public string Codigo { get; set; }
        public string Constante4 { get; set; }
        public string NumeroSequencia { get; set; }
        public string Retorno { get; set; }

        public ACJundiai_Header() 
        {
            this.Tipo = "";
            this.Remessa = "";
            this.DataMovimento = "";
            this.Remetente = "";
            this.Codigo = "";
            this.NumeroSequencia = "";
            this.Constante1 = "";
            this.Constante2 = "";
            this.Constante3 = "";
            this.Constante4 = "";
            this.Retorno = "";
        }

        public void Formata() 
        {
            this.Tipo = this.Tipo.PadLeft(1, '0').Substring(0, 1);
            this.Constante1 = this.Constante1.PadRight(7, ' ').Substring(0, 7);
            this.Remessa = this.Remessa.PadLeft(7, '0').Substring(0, 7);
            this.DataMovimento = this.DataMovimento.PadRight(8, ' ').Substring(0, 8);
            this.Constante2 = this.Constante2.PadRight(100, ' ').Substring(0, 100);
            this.Constante3 = this.Constante3.PadRight(100, ' ').Substring(0, 100);
            this.Remetente = this.Remetente.PadRight(40, ' ').Substring(0, 40);
            this.Codigo = this.Codigo.PadLeft(8, '0').Substring(0, 8);
            this.Constante4 = this.Constante4.PadRight(166, ' ').Substring(0, 166);
            this.NumeroSequencia = this.NumeroSequencia.PadLeft(7, '0').Substring(0, 7);
            this.Retorno = this.Retorno.PadRight(20, ' ').Substring(0, 20);
        }

        public string Imprime() 
        { 
            Formata();
            var formatada = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}",
                    this.Tipo,
                    this.Constante1,
                    this.Remessa,
                    this.DataMovimento,
                    this.Constante2,
                    this.Constante3,
                    this.Remetente,
                    this.Codigo,
                    this.Constante4,
                    this.NumeroSequencia,
                    this.Retorno,
                    Environment.NewLine
                );
            return formatada;
        }
    }

    public class ACJundiai_Detalhe 
    {
        public string TipoRegistro { get; set; }
        public string TipoAtualizacao { get; set; }
        public ACJundiai_Devedor Devedor { get; set; }
        public ACJundiai_Debito Debito { get; set; }

        public ACJundiai_Detalhe() 
        {
            this.TipoRegistro = "";
            this.TipoAtualizacao = "";
            this.Devedor = new ACJundiai_Devedor();
            this.Debito = new ACJundiai_Debito();
        }

        public void Formata() 
        {
            this.TipoRegistro = this.TipoRegistro.PadLeft(1, '0').Substring(0, 1);
            this.TipoAtualizacao = this.TipoAtualizacao.PadRight(1, ' ').Substring(0, 1);
        }

        public string Imprime() 
        {
            Formata();

            return string.Format("{0}{1}{2}{3}{4}",
                this.TipoRegistro,
                this.TipoAtualizacao,
                this.Devedor.Imprime(),
                this.Debito.Imprime(),
                Environment.NewLine
            );
        }
    }

    public class ACJundiai_Devedor 
    {
        public string Pessoa { get; set; }
        public string Cpf { get; set; }
        public string CGC { get; set; }
        public string RG { get; set; }
        public string DigitoRG { get; set; }
        public string EstadoEmissor { get; set; }
        public string OrgaoEmissor { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Mae { get; set; }
        public string Conjuge { get; set; }

        public ACJundiai_Devedor() 
        {
            this.Pessoa = "";
            this.Cpf = "";
            this.CGC = "";
            this.RG = "";
            this.DigitoRG = "";
            this.EstadoEmissor = "";
            this.OrgaoEmissor = "";
            this.Nome = "";
            this.DataNascimento = "";
            this.Mae = "";
            this.Conjuge = "";
        }

        public void Formata() 
        {
            this.Pessoa = this.Pessoa.PadRight(1, ' ').Substring(0, 1);
            this.Cpf = this.Cpf.PadLeft(11, '0').Substring(0, 11);
            this.CGC = this.CGC.PadLeft(14, '0').Substring(0, 14);
            this.RG = this.RG.PadLeft(14, ' ').Substring(0, 14);
            this.DigitoRG = this.DigitoRG.PadRight(1, ' ').Substring(0, 1);
            this.EstadoEmissor = this.EstadoEmissor.PadRight(2, ' ').Substring(0, 2);
            this.OrgaoEmissor = this.OrgaoEmissor.PadRight(3, ' ').Substring(0, 3);
            this.Nome = this.Nome.PadRight(45, ' ').Substring(0, 45);
            this.DataNascimento = this.DataNascimento.PadLeft(8, '0').Substring(0, 8);
            this.Mae = this.Mae.PadRight(45, ' ').Substring(0, 45);
            this.Conjuge = this.Conjuge.PadRight(45, ' ').Substring(0, 45);
        }

        public string Imprime() 
        {
            Formata();
            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}",
                    this.Pessoa,
                    this.Cpf,
                    this.CGC,
                    this.RG,
                    this.DigitoRG,
                    this.EstadoEmissor,
                    this.OrgaoEmissor,
                    this.Nome,
                    this.DataNascimento,
                    this.Mae,
                    this.Conjuge
                );
        }
    }

    public class ACJundiai_Debito 
    {
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Constante1 { get; set; }
        public string TipoDocumento { get; set; }
        public string Contrato { get; set; }
        public string DataCompra { get; set; }
        public string DataVencimento { get; set; }
        public string ValorDebito { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public string DigitoContaCorrente { get; set; }
        public string Alinea { get; set; }
        public string Constante2 { get; set; }
        public string NumeroSequencia { get; set; }
        public string Codigo { get; set; }

        public ACJundiai_Debito() 
        { 
            this.Endereco = "";
            this.Numero = "";
            this.Complemento = "";
            this.Bairro = "";
            this.Cidade = "";
            this.Uf = "";
            this.Cep = "";
            this.Constante1 = "";
            this.TipoDocumento = "";
            this.Contrato = "";
            this.DataCompra = "";
            this.DataVencimento = "";
            this.ValorDebito = "";
            this.Banco = "";
            this.Agencia = "";
            this.ContaCorrente = "";
            this.DigitoContaCorrente = "";
            this.Alinea = "";
            this.Constante2 = "";
            this.NumeroSequencia = "";
            this.Codigo = "";
        }

        public void Formata() 
        {
            this.Endereco = this.Endereco.PadRight(35, ' ').Substring(0, 35);
            this.Numero = this.Numero.PadRight(6, ' ').Substring(0, 6);
            this.Complemento = this.Complemento.PadRight(9, ' ').Substring(0, 9);
            this.Bairro = this.Bairro.PadRight(36, ' ').Substring(0, 36);
            this.Cidade = this.Cidade.PadRight(35, ' ').Substring(0, 35);
            this.Uf = this.Uf.PadRight(2, ' ').Substring(0, 2);
            this.Cep = this.Cep.PadLeft(8, '0').Substring(0, 8);
            this.Constante1 = this.Constante1.PadRight(20, ' ').Substring(0, 20);
            this.TipoDocumento = this.TipoDocumento.PadRight(2, ' ').Substring(0, 2);
            this.Contrato = this.Contrato.PadLeft(20, ' ').Substring(0, 20);
            this.DataCompra = this.DataCompra.PadLeft(8, '0').Substring(0, 8);
            this.DataVencimento = this.DataVencimento.PadLeft(8, '0').Substring(0, 8);
            this.ValorDebito = this.ValorDebito.PadLeft(12, '0').Substring(0, 12);
            this.Banco = this.Banco.PadRight(3, '0').Substring(0, 3);
            this.Agencia = this.Agencia.PadRight(3, '0').Substring(0, 3);
            this.ContaCorrente = this.ContaCorrente.PadRight(15, ' ').Substring(0, 15);
            this.DigitoContaCorrente = this.DigitoContaCorrente.PadRight(1, ' ').Substring(0, 1);
            this.Alinea = this.Alinea.PadLeft(2, '0').Substring(0, 2);
            this.Constante2 = this.Constante2.PadRight(20, ' ').Substring(0, 20);
            this.NumeroSequencia = this.NumeroSequencia.PadLeft(7, '0').Substring(0, 7);
            this.Codigo = this.Codigo.PadRight(20, ' ').Substring(0, 20);
        }

        public string Imprime() {
            Formata();
            var formatada = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}",
                    this.Endereco,
                    this.Numero,
                    this.Complemento,
                    this.Bairro,
                    this.Cidade,
                    this.Uf,
                    this.Cep,
                    this.Constante1,
                    this.TipoDocumento,
                    this.Contrato,
                    this.DataCompra,
                    this.DataVencimento,
                    this.ValorDebito,
                    this.Banco,
                    this.Agencia,
                    this.ContaCorrente,
                    this.DigitoContaCorrente,
                    this.Alinea,
                    this.Constante2,
                    this.NumeroSequencia,
                    this.Codigo
                );

            formatada = formatada.Replace(',', ' ');
            formatada = formatada.Replace('.', ' ');

            return formatada;
        }
    }

    public class ACJundiai_Trailler 
    {
        public string TipoRegistro { get; set; }
        public string DataMovimento { get; set; }
        public string UsoCliente { get; set; }
        public string Inclusoes { get; set; }
        public string Exclusoes { get; set; }
        public string Constante1 { get; set; }
        public string NumeroSequencia { get; set; }
        public string Constante2 { get; set; }

        public ACJundiai_Trailler() 
        { 
            this.TipoRegistro = "";
            this.DataMovimento = "";
            this.UsoCliente = "";
            this.Inclusoes = "";
            this.Exclusoes = "";
            this.Constante1 = "";
            this.NumeroSequencia = "";
            this.Constante2 = "";
        }

        public void Formata() 
        {
            this.TipoRegistro = this.TipoRegistro.PadLeft(1, '0').Substring(0, 1);
            this.DataMovimento = this.DataMovimento.PadRight(8, ' ').Substring(0, 8);
            this.UsoCliente = this.UsoCliente.PadRight(30, ' ').Substring(0, 30);
            this.Inclusoes = this.Inclusoes.PadLeft(5, '0').Substring(0, 5);
            this.Exclusoes = this.Exclusoes.PadLeft(5, '0').Substring(0, 5);
            this.Constante1 = this.Constante1.PadRight(387, ' ').Substring(0, 387);
            this.NumeroSequencia = this.NumeroSequencia.PadLeft(7, '0').Substring(0, 7);
            this.Constante2 = this.Constante2.PadRight(20, ' ').Substring(0, 20);
        }

        public string Imprime() 
        {
            Formata();

            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}",
                this.TipoRegistro,
                this.DataMovimento,
                this.UsoCliente,
                this.Inclusoes,
                this.Exclusoes,
                this.Constante1,
                this.NumeroSequencia,
                this.Constante2
            );
        }
    }

    public enum TipoAtualizacao
	{
        Inclusao,
        Exclusao
	}
}
