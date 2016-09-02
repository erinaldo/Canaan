using Canaan.Telas.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Geral.Eventos
{
    public partial class Edita : FormEdita
    {
        //
        //PROPRIEDADES
        public Lib.Evento LibEvento { get; set; }
        public Dados.Filial Filial { get; set; }
        public List<Dados.Parceria> Parcerias { get; set; }
        public Dados.Evento Evento { get; set; }

        //
        //CONSTRUTORES
        public Edita()
        {
            //carrega as propriedades
            this.IsNovo = true;
            this.LibEvento = new Lib.Evento();
            this.Filial = Lib.Session.Instance.Contexto.Filial;
            this.Evento = new Dados.Evento();

            InitializeComponent();
        }

        public Edita(int id)
        {
            //carrega as propriedades
            this.IsNovo = false;
            this.LibEvento = new Lib.Evento();
            this.Evento = new Lib.Evento().GetById(id);
            this.Filial = new Lib.Filial().GetById(this.Evento.Parceria.IdFilial);
            this.Title = "Editando Evento: " + Evento.Nome;

            InitializeComponent();
        }

        //
        //EVENTOS
        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();
            CarregaParceria();
            CarregaForm();
        }

        //
        //METODOS
        private void CarregaParceria()
        {
            this.Parcerias = new Lib.Parceria().GetByFilial(this.Filial.IdFilial);
            if (this.Evento.IdParceria == 0)
                this.Evento.IdParceria = this.Parcerias.FirstOrDefault().IdParceria;

            //carrega o combo
            this.parceriaComboBox.ValueMember = "IdParceria";
            this.parceriaComboBox.DisplayMember = "Nome";
            this.parceriaComboBox.DataSource = this.Parcerias;
        }

        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Novo Evento";
            else
                Text = "Editando Evento: " + Evento.Nome;
        }

        protected override void CarregaForm()
        {
            parceriaComboBox.SelectedValue = Evento.IdParceria;
            nomeTextBox.Text = Evento.Nome;
            descricaoTextBox.Text = Evento.Descricao;
        }

        protected override void CarregaItem()
        {
            //configura objeto
            Evento.IdParceria = (int)parceriaComboBox.SelectedValue;
            Evento.Nome = nomeTextBox.Text;
            Evento.Descricao = descricaoTextBox.Text;

        }

        protected override void Incluir()
        {
            try
            {
                //configura objeto
                CarregaItem();

                //envia para metodo de update
                Evento = LibEvento.Insert(Evento);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' incluido com sucesso", Evento.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }

        protected override void Editar()
        {
            try
            {
                //configura objeto
                CarregaItem();

                //envia para metodo de update
                Evento = LibEvento.Update(Evento);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' alterado com sucesso", Evento.Nome));

                //marca para edicao
                IsNovo = false;
                SetTitle();
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }
    }
}
