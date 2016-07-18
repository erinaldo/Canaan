using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Canaan.Lib;
using Canaan.Telas.Base;

namespace Canaan.Telas.Configuracoes.Pedido.Tabela.Estudio
{
    public partial class Seleciona : FormEdita
    {
        public Filial LibFilial 
        { 
            get
            {
                return new Filial();
            }
        }

        public Lib.Tabela LibTabela 
        { 
            get
            {
                return new Lib.Tabela();
            }
        }

        public TabelaFilial LibTabelaFilial 
        { 
            get
            {
                return new TabelaFilial();
            }
        }

        public Dados.Tabela Tabela { get; set; }

        public IEnumerable<Dados.Filial> DisponivelSelected 
        { 
            get
            {
                if (lbDisponivel.SelectedItems.Count > 0)
                {
                    return lbDisponivel.SelectedItems.Cast<Dados.Filial>();
                }

                return null;
            }
        }

        public IEnumerable<Dados.Filial> VinculadosSelected 
        {
            get
            {
                if (lbSelecionado.SelectedItems.Count > 0)
                {
                    return lbSelecionado.SelectedItems.Cast<Dados.Filial>();
                }

                return null;
            }
        }

        public BindingList<Dados.Filial> Filiais { get; set; }
        public BindingList<Dados.Filial> Restante { get; set; }
        public BindingList<Dados.Filial> Selecionadas { get; set; }

        public Seleciona(int idTabela)
        {
            //Carrega Tabela
            Tabela = LibTabela.GetById(idTabela);

            InitializeComponent();
        }

        private void Seleciona_Load(object sender, EventArgs e)
        {
            CarregaListas();
            CarregaLbDisponiveis();
            ConfiguraForm();
        }

        private void ConfiguraForm()
        {
            lkNomeTabela.Text = Tabela.Nome;
            CarregaListas();
            CarregaLbDisponiveis();
            CarregaLbSelecionados();
        }

        private void CarregaLbSelecionados()
        {
            lbSelecionado.DataSource = Selecionadas;
            lbSelecionado.ValueMember = "IdFilial";
            lbSelecionado.DisplayMember = "NomeFantasia";
        }

        private void CarregaLbDisponiveis()
        {
            lbDisponivel.DataSource = Restante;
            lbDisponivel.ValueMember = "IdFilial";
            lbDisponivel.DisplayMember = "NomeFantasia";
        }

        private void CarregaListas()
        {
            Filiais = new BindingList<Dados.Filial>(LibFilial.GetByAtivo(true));
            Selecionadas = new BindingList<Dados.Filial>(LibFilial.GetByTabela(Tabela.IdTabela));
            Restante = new BindingList<Dados.Filial>(Filiais.Where(a => !Selecionadas.Any(b => b.IdFilial == a.IdFilial)).ToList());
        }

        private void addEstudio_Click(object sender, EventArgs e)
        {
            if (DisponivelSelected != null)
            {
                foreach (var item in DisponivelSelected)
                {
                    LibTabelaFilial.Insert(new Dados.TabelaFilial { IdFilial = item.IdFilial, IdTabela = Tabela.IdTabela });
                }

                ConfiguraForm();

                MessageBoxUtilities.MessageInfo("Registros selecionados com sucesso");
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (VinculadosSelected != null)
            {
                foreach (var item in VinculadosSelected)
                {
                    LibTabelaFilial.Delete(item.IdFilial, Tabela.IdTabela);
                }

                ConfiguraForm();

                MessageBoxUtilities.MessageInfo("Registros removidos com sucesso");
            }
        }

    }
}
