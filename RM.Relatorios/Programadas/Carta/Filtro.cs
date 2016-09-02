using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Programadas.Carta
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

        private void CarregaRelatorio()
        {
            string tipo;

            if (rbCarta.Checked)
                tipo = "Carta";
            else
                tipo = "Etiqueta";

            Resultado frm = new Resultado(GetResult(), tipo);
            frm.Show();
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
                Model modelo = new Model();

                //carrega campos do modelo
                if (item.FCFO.FCFOCOMPL.CODCMASTER != null)
                    modelo.CodCmaster = (int)item.FCFO.FCFOCOMPL.CODCMASTER;
                else
                    modelo.CodCmaster = 0;
                modelo.CodRM = item.CODCFO;
                modelo.NomeCliente = item.FCFO.NOMEFANTASIA;
                modelo.DataVencimento = item.DATAVENCIMENTO;
                modelo.Endereco = string.Format("{0}, {1} - {2}", item.FCFO.RUA, item.FCFO.NUMERO, item.FCFO.COMPLEMENTO);
                modelo.Bairro = string.Format("{0}", item.FCFO.BAIRRO);
                modelo.Cidade = string.Format("{0}", item.FCFO.CIDADE);
                modelo.Estado = string.Format("{0}", item.FCFO.CODETD);
                modelo.Cep = string.Format("{0}", item.FCFO.CEP);

                result.Add(modelo);
            }

            //retorna resultado
            return result;
        }


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
