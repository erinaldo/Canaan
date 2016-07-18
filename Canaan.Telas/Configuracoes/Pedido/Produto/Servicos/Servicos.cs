using System;
using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib;

namespace Canaan.Telas.Configuracoes.Pedido.Produto.Servicos
{
	public partial class Servicos : Form
	{
		#region PROPRIEDADES

		private int idProduto;

		public Servico LibServico
		{
			get
			{
				return new Servico();
			}
		}
		public Dados.Servico Servico { get; set; }

		public ProdutoServico LibProdutoServico
		{
			get
			{
				return new ProdutoServico();
			}

		}

		public int Quantidade
		{
			get
			{
				int value;
				var result = int.TryParse(txtQuantidade.Text, out value);

				if (result)
					return value;

				return 0;
			}
		}

		public BindingList<Lib.Model.ProdutoServico> ProdutosServicos { get; set; }

		public Lib.Model.ProdutoServico Current
		{
			get
			{
				return dataGrid.BindingContext[ProdutosServicos].Current as Lib.Model.ProdutoServico;
			}
		}

		public Lib.Produto LibProduto
		{
			get
			{
				return new Lib.Produto();
			}
		}
		public Dados.Produto Produto { get; set; }

		#endregion

		#region CONSTRUTOR

		public Servicos(int id)
		{
			idProduto = id;
			InitializeComponent();
		}

		#endregion

		#region METODOS

		private void Servicos_Load(object sender, EventArgs e)
		{
			SetTitle();
			CarregaGrid();
		}

		private void SetTitle()
		{
			//throw new NotImplementedException();
		}

		public void CarregaGrid()
		{
			try
			{
				var result = LibProdutoServico.CarregaGridModel(LibProdutoServico.GetByProduto(idProduto));
				ProdutosServicos = new BindingList<Lib.Model.ProdutoServico>(result);
				dataGrid.DataSource = ProdutosServicos;
			}
			catch (Exception ex)
			{
				MessageBoxUtilities.MessageError(null, ex);
			}
		}

		#endregion

		#region EVENTOS

		private void lkServico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var frmSeleciona = new Seleciona();
			frmSeleciona.ShowDialog();

			if (frmSeleciona.Id != 0)
				Servico = LibServico.GetById(frmSeleciona.Id);

			if (Servico == null)
				return;

			lkServico.Text = Servico.Nome;
			txtCodigo.Text = Servico.IdServico.ToString();
		}

		private void dataGrid_SelectionChanged(object sender, EventArgs e)
		{

		}

		private void btAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if (Servico == null || Quantidade == 0)
				{
					MessageBoxUtilities.MessageWarning("Nenhum serviço selecionado, ou quantidade esta em branco");
					return;
				}


				var value = 0;
				var result = int.TryParse(txtQuantidade.Text, out value);

				if (!result)
				{
					MessageBoxUtilities.MessageWarning("Quantidade não é um inteiro valido ");
					return;
				}


				var produtoServico = new Dados.ProdutoServico
				{
					IdProduto = idProduto,
					IdServico = Servico.IdServico,
					Quantidade = value
				};

				LibProdutoServico.Insert(produtoServico);

				MessageBoxUtilities.MessageInfo("Serviço adicionado com sucesso");

				CarregaGrid();
			}
			catch (Exception ex)
			{
				MessageBoxUtilities.MessageError(null, ex);
			}
		}

		private void btRem_Click(object sender, EventArgs e)
		{

			try
			{
				if (Current == null)
				{
					MessageBoxUtilities.MessageWarning("Nenhum Registro Selecionado");
					return;
				}

				LibProdutoServico.Delete(Current.Codigo);
				CarregaGrid();
				MessageBoxUtilities.MessageInfo("Serviço removido com sucesso");

			}
			catch (Exception ex)
			{
				MessageBoxUtilities.MessageError(null, ex);
			}
		}

		#endregion
	}
}
