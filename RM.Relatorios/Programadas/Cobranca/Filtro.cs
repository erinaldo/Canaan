using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Programadas.Cobranca
{
    public partial class Filtro : Form
    {
        //propriedades
        Dados.GFILIAL Filial { get; set; }

        //contrutores
        public Filtro()
        {
            InitializeComponent();
        }

        public Filtro(short CodColigada, short CodFilial) 
        {
            Filial = Lib.Filiais.GetById(CodColigada, CodFilial);

            InitializeComponent();
        }

        //metodos
        private void InitForm() 
        { 
            //habilita - desabilita controles
            if(Filial != null)
                comboFilial.Enabled = false;
            else
                comboFilial.Enabled = true;

            //carrega combos
            CarregaFiliais();
            CarregaVendedoras();
        }

        private void CarregaFiliais() 
        {
            comboFilial.ValueMember = "CGC";
            comboFilial.DisplayMember = "NOMEFANTASIA";

            if (Filial != null)
            {
                List<Dados.GFILIAL> filiais = new List<Dados.GFILIAL>();
                filiais.Add(Filial);

                comboFilial.DataSource = filiais;
            }
            else
            {
                comboFilial.DataSource = Lib.Filiais.GetEstudios();
            }
        }

        private void CarregaVendedoras() 
        {
            //carrega objetos
            Filial = Lib.Filiais.GetByCnpj(comboFilial.SelectedValue.ToString());
            List<Dados.TVEN> vendedoras = Lib.Vendedora.GetByFilial(Filial.CODCOLIGADA, Filial.CODFILIAL);

            //carrega combo
            comboVendedora.ValueMember = "CODVEN";
            comboVendedora.DisplayMember = "NOME";
            comboVendedora.DataSource = vendedoras;
        }

        private List<Model> GetResult() 
        {
            //declara objetos
            Dados.GFILIAL filial = Lib.Filiais.GetByCnpj(comboFilial.SelectedValue.ToString());
            List<Dados.FLAN> lancamentos = Lib.Lancamento.GetEntradas_AbertoByVencimento(filial.CODCOLIGADA, filial.CODFILIAL, dataInicio.Value, dataFim.Value);

            //cria resultado
            List<Model> result = new List<Model>();
            foreach (Dados.FLAN item in lancamentos) 
            { 
                List<Dados.FLAN> lancVenda = Lib.Lancamento.GetEntradasByVenda(item.CODCOLIGADA, (int)item.IDMOV);

                Model modelo = new Model();

                modelo.CodColigada = item.CODCOLIGADA;
                modelo.CodFilial = item.CODFILIAL;
                modelo.CodLancamento = item.IDLAN;
                modelo.CodVenda = (int)item.IDMOV;
                modelo.CodClasse = item.CODTB1FLX;
                modelo.CodVendedor = item.TMOV.CODVEN1;
                modelo.CodCliente = item.CODCFO;
                if(item.FCFO.FCFOCOMPL.CODCMASTER != null)
                    modelo.CodCmaster = (int)item.FCFO.FCFOCOMPL.CODCMASTER;
                else
                    modelo.CodCmaster = 0;
                modelo.NomeVendedor = Lib.Vendedora.GetByVenda((int)item.IDMOV, item.CODCOLIGADA).NOME;
                modelo.NomeCliente = item.FCFO.NOMEFANTASIA;
                modelo.TelFixo = item.FCFO.TELEFONE;
                modelo.TelCelular = item.FCFO.TELEX;
                modelo.TelFax = item.FCFO.FAX;
                modelo.TelComercial = item.FCFO.TELEFONECOMERCIAL;
                modelo.DataVencimento = item.DATAVENCIMENTO;
                modelo.Valor = item.VALORORIGINAL;
                modelo.NumParcelas = lancVenda.Count;
                modelo.NumPagas = lancVenda.Where(a => a.STATUSLAN == (short)Lib.Enums.StatusLan.Baixada).Count();
                modelo.NumRestantes = lancVenda.Where(a => a.STATUSLAN == (short)Lib.Enums.StatusLan.EmAberto).Count();
                modelo.StatusLan = item.STATUSLAN;
                modelo.DataVenda = (DateTime)item.TMOV.DATAEMISSAO;
                modelo.ValorVenda = (decimal)item.TMOV.VALORLIQUIDO;

                result.Add(modelo);
            }

            //filta o resultado
            if (checkVendedora.Checked == false)
                result = result.Where(a => a.CodVendedor == (string)comboVendedora.SelectedValue).ToList();

            if (checkUltima.Checked == true)
                result = result.Where(a => a.NumRestantes == 1).ToList();

            //retorna resultado
            return result;
        }

        private void CarregaRelatorio() 
        {
            Resultado frm = new Resultado(GetResult(), dataInicio.Value, dataFim.Value, comboFilial.Text);
            frm.Show();
        }

        //eventos
        private void Filtro_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void comboFilial_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaVendedoras();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
