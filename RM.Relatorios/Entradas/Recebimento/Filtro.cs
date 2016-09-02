using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Entradas.Recebimento
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
			//variaveis
			List<Model> lista = new List<Model>();
			DateTime dtInicio = dataInicio.Value;
			DateTime dtFim = dataFim.Value;
			Filial = Lib.Filiais.GetByCnpj(comboFilial.SelectedValue.ToString());

			using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
			{
				var classe = new string[] { "2.011", "2.019" };

				//lista de parcelas baixadas no dia
				var parcelas = conn.FLAN.Where(a => a.CODCOLIGADA == Filial.CODCOLIGADA &&
													a.CODFILIAL == Filial.CODFILIAL &&
													classe.Contains(a.CODTB1FLX) &&
													a.DATABAIXA >= dtInicio.Date &&
													a.DATABAIXA <= dtFim.Date &&
													a.PAGREC == 1);

				//faz loop nas parcelas
				foreach (var parc in parcelas)
				{
					Model item = new Model();
					item.CodCMaster = parc.FCFO.FCFOCOMPL.CODCMASTER.ToString();
					item.CodRm = parc.FCFO.FCFOCOMPL.CODCFO.ToString();
					item.NomeCliente = parc.FCFO.NOME;
					item.NomeVendedora = parc.TMOV.TVEN.NOME;
					item.DataVencimento = parc.DATAVENCIMENTO.Date;
					item.DataBaixa = parc.DATABAIXA.Value.Date;
					item.ParcelaAtual = parc.TMOV.FLAN.Where(a => classe.Contains(a.CODTB1FLX)).ToList().IndexOf(parc) + 1;
					item.NumParcelas = parc.TMOV.FLAN.Where(a => classe.Contains(a.CODTB1FLX)).ToList().Count;
					item.ContaCaixa = parc.FCXA.DESCRICAO;
					item.ValorBaixado = parc.VALORBAIXADO;

					lista.Add(item);
				}
			}

			return lista;
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

		}
	}
}
