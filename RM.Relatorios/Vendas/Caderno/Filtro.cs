using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Vendas.Caderno
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

        private List<Model> GetResult()
        {
            //declara objetos
            Dados.GFILIAL filial = Lib.Filiais.GetByCnpj(comboFilial.SelectedValue.ToString());
            
            List<Dados.TMOV> vendas = Lib.Movimento.GetVendasLiberadas(filial, dataInicio.Value, dataFim.Value);

            //cria resultado
            List<Model> result = new List<Model>();
            foreach (Dados.TMOV item in vendas)
            {
                Model modelo = new Model();

                modelo.CodColigada = item.CODCOLIGADA;
                modelo.CodFilial = (short)item.CODFILIAL;
                modelo.CodVenda = (int)item.IDMOV;
                modelo.CodRm = item.FCFO.CODCFO;
                if (item.FCFO.FCFOCOMPL.CODCMASTER != null)
                    modelo.CodCmaster = (int)item.FCFO.FCFOCOMPL.CODCMASTER;
                else
                    modelo.CodCmaster = 0;
                modelo.DataEmissao = item.DATAEMISSAO.Value.Date;
                if (item.TMOVCOMPL.DTLIBERACAO != null)
                    modelo.DataLiberacao = item.TMOVCOMPL.DTLIBERACAO.Value.Date;
                else
                    modelo.DataLiberacao = item.DATAEMISSAO.Value.Date;
                modelo.NomeCliente = item.FCFO.NOMEFANTASIA;
                modelo.ValorBruto = (decimal)item.VALORBRUTO;
                modelo.ValorDesconto = (decimal)item.VALORDESC;
                modelo.ValorDespesa = (decimal)item.VALORDESP;
                modelo.ValorLiquido = (decimal)item.VALORLIQUIDO;

                result.Add(modelo);
            }

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

        private void btnGerar_Click(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }
    }
}
