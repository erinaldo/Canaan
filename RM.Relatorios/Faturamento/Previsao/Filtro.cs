using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Faturamento.Previsao
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
            Resultado frm = new Resultado(GetResult(), comboFilial.Text, dataInicio.Value, dataFim.Value);
            frm.Show();
        }

        private List<Model> GetResult()
        {
            //declara objetos
            Dados.GFILIAL filial = Lib.Filiais.GetByCnpj(comboFilial.SelectedValue.ToString());

            //retorna a lista
            return Model.GetResult(filial.CODCOLIGADA, filial.CODFILIAL, dataInicio.Value, dataFim.Value);
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
