using System;
using Canaan.Lib;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Base
{
    public partial class FormEdita : XtraForm
    {
        //
        //PROPRIEDADES
        protected bool IsNovo { get; set; }
        public string Title { get; set; }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        //
        //CONSTRUTOR
        public FormEdita()
        {
            InitializeComponent();
        }

        //
        //EVENTOS
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IsNovo)
                Incluir();
            else
                Editar();
        }

        //
        //METODOS
        protected virtual void SetTitle() 
        {
            throw new NotImplementedException();
        }

        protected virtual void CarregaForm() 
        {
            throw new NotImplementedException();
        }

        protected virtual void CarregaItem()
        {
            throw new NotImplementedException();
        }

        protected virtual void Incluir() 
        {
            throw new NotImplementedException();
        }

        protected virtual void Editar() 
        {
            throw new NotImplementedException();
        }

        private void FormEdita_Load(object sender, EventArgs e)
        {

        }
    }
}
