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

namespace Canaan.Telas.Movimentacoes.Venda.Evento
{
    public partial class Edita : FormEdita
    {
        #region PROPRIEDADES

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }
        public Lib.Evento LibEvento
        {
            get
            {
                return new Lib.Evento();
            }
        }
        public Lib.VendaEvento LibVendaEvento
        {
            get
            {
                return new Lib.VendaEvento();
            }
        }

        public Dados.Venda Venda { get; set; }
        public List<Dados.Evento> Eventos { get; set; }
        public Dados.VendaEvento VendaEvento { get; set; }

        #endregion

        #region CONSTRUTORES

        public Edita(Dados.Venda pVenda)
        {
            //inicializa propriedades
            this.IsNovo = true;
            this.Venda = pVenda;
            this.Eventos = LibEvento.GetByFilial(this.Venda.IdFilial);
            this.VendaEvento = new Dados.VendaEvento();

            //inicializa objeto
            this.VendaEvento.IdEvento = this.Eventos.FirstOrDefault().IdEvento;
            this.VendaEvento.IdPedido = this.Venda.IdPedido;
            this.VendaEvento.DataInicio = DateTime.Today;
            this.VendaEvento.DataFim = DateTime.Today;

            InitializeComponent();
        }

        public Edita(Dados.Venda pVenda, int idVendaEvento)
        {
            this.IsNovo = false;
            this.Venda = pVenda;
            this.Eventos = LibEvento.GetByFilial(this.Venda.IdFilial);
            this.VendaEvento = LibVendaEvento.GetById(idVendaEvento);

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Edita_Load(object sender, EventArgs e)
        {
            SetTitle();
            CarregaEventos();
            CarregaForm();
        }

        #endregion

        #region METODOS

        private void CarregaEventos()
        {
            //carrega o combo
            this.eventoComboBox.ValueMember = "IdEvento";
            this.eventoComboBox.DisplayMember = "Nome";
            this.eventoComboBox.DataSource = this.Eventos;
        }

        protected override void SetTitle()
        {
            if (IsNovo)
                Text = "Novo Registro";
            else
                Text = "Editando: " + this.VendaEvento.Evento.Nome;
        }

        protected override void CarregaForm()
        {
            var evento = LibEvento.GetById(this.VendaEvento.IdEvento);

            eventoComboBox.SelectedValue = this.VendaEvento.IdEvento;
            dataInicioDateTimePicker.Value = this.VendaEvento.DataInicio;
            horaInicioDateTimePicker.Value = this.VendaEvento.DataInicio;
            dataFimDateTimePicker.Value = this.VendaEvento.DataFim;
            horaFimDateTimePicker.Value = this.VendaEvento.DataFim;

            if (!string.IsNullOrEmpty(this.VendaEvento.Descricao))
                descricaoTextBox.Text = this.VendaEvento.Descricao;
            else
                descricaoTextBox.Text = evento.Descricao;
        }

        protected override void CarregaItem()
        {
            //arruma datas
            
            //configura objeto
            this.VendaEvento.IdEvento = (int)eventoComboBox.SelectedValue;
            this.VendaEvento.DataInicio = new DateTime(dataInicioDateTimePicker.Value.Year, dataInicioDateTimePicker.Value.Month, dataInicioDateTimePicker.Value.Day, horaInicioDateTimePicker.Value.Hour, horaInicioDateTimePicker.Value.Minute, horaInicioDateTimePicker.Value.Second);
            this.VendaEvento.DataFim = new DateTime(dataFimDateTimePicker.Value.Year, dataFimDateTimePicker.Value.Month, dataFimDateTimePicker.Value.Day, horaFimDateTimePicker.Value.Hour, horaFimDateTimePicker.Value.Minute, horaFimDateTimePicker.Value.Second);
            this.VendaEvento.Descricao = descricaoTextBox.Text;
        }

        protected override void Incluir()
        {
            try
            {
                //configura objeto
                CarregaItem();

                //envia para metodo de update
                this.VendaEvento = this.LibVendaEvento.Insert(this.VendaEvento);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' incluido com sucesso", this.VendaEvento.Evento.Nome));

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
                this.VendaEvento = this.LibVendaEvento.Update(this.VendaEvento);

                //mensagem de retorno
                MessageBox.Show(string.Format("Registro '{0}' alterado com sucesso", this.VendaEvento.Evento.Nome));

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

        #endregion
    }
}
