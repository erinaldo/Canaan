using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Entradas.ComissaoVendedora
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
            if (Filial != null)
                comboFilial.Enabled = false;
            else
                comboFilial.Enabled = true;

            //carrega combos
            CarregaFiliais();
            CarregaVendedora();
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

        private void CarregaVendedora()
        {
            //carrega objetos
            Filial = Lib.Filiais.GetByCnpj(comboFilial.SelectedValue.ToString());
            List<Dados.TVEN> vendedoras = Lib.Vendedora.GetByFilial(Filial.CODCOLIGADA, Filial.CODFILIAL).Where(a => a.VENDECOMPRA == (short)Lib.Enums.Funcoes.Vendedor).ToList();

            //carrega combo
            comboVendedora.ValueMember = "CODVEN";
            comboVendedora.DisplayMember = "NOME";
            comboVendedora.DataSource = vendedoras;
        }

        private void CarregaRelatorio()
        {
            Resultado frm = new Resultado(GetResult(), comboFilial.Text, comboVendedora.Text, dataInicio.Value, dataFim.Value);
            frm.Show();
        }

        private List<Model> GetResult()
        {
            //declara objetos
            Dados.GFILIAL filial = Lib.Filiais.GetByCnpj(comboFilial.SelectedValue.ToString());
            Dados.TVEN vendedora = Lib.Vendedora.GetById(filial, comboVendedora.SelectedValue.ToString());
            List<Dados.FLAN> lancamentos = Lib.Lancamento.GetEntradasByVendedora(filial, vendedora, dataInicio.Value, dataFim.Value);
            List<Model> result = new List<Model>();

            //cria resultado
            foreach (Dados.FLAN item in lancamentos)
            {
                Model modelo = new Model();

                modelo.CodColigada = item.CODCOLIGADA;
                modelo.CodFilial = item.CODFILIAL;
                modelo.CodLancamento = item.IDLAN;
                modelo.CodVenda = (int)item.IDMOV;
                modelo.CodClasse = item.CODTB1FLX;
                modelo.CodVendedor = item.TMOV.CODVEN1;
                modelo.CodCliente = item.CODCFO;
                if (item.FCFO.FCFOCOMPL.CODCMASTER != null)
                    modelo.CodCmaster = (int)item.FCFO.FCFOCOMPL.CODCMASTER;
                else
                    modelo.CodCmaster = 0;
                modelo.NomeVendedor = Lib.Vendedora.GetByVenda((int)item.IDMOV, item.CODCOLIGADA).NOME;
                modelo.NomeCliente = item.FCFO.NOMEFANTASIA;
                modelo.DataBaixa = item.DATABAIXA.Value;
                modelo.Percentual = (decimal)vendedora.COMISSAO1;
                modelo.ValorBaixa = item.VALORBAIXADO;
                modelo.ValorComissao = ((modelo.ValorBaixa * modelo.Percentual) / 100);
                modelo.StatusLan = item.STATUSLAN;

                result.Add(modelo);
            }

            //retorna resultado
            return result;
        }

        //eventos
        private void Filtro_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }

        private void comboFilial_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaVendedora();
        }
    }
}
