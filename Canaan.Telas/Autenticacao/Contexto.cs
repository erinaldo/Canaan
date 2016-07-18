using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Lib;
using DevExpress.XtraEditors;
using Filial = Canaan.Dados.Filial;
using Usuario = Canaan.Dados.Usuario;
using UsuarioFilial = Canaan.Dados.UsuarioFilial;

namespace Canaan.Telas.Autenticacao
{
    public partial class Contexto : XtraForm
    {
        //
        //PROPRIEDADES
        public bool ExitApp { get; set; }
        public Usuario Usuario { get; set; }
        public List<UsuarioFilial> UsuarioFiliais { get; set; }
        public List<Filial> Filiais { get; set; }
        public UsuarioFilial ContextoItem { get; set; }

        public Contexto(int idUsuario)
        {
            ExitApp = false;
            Usuario = new Lib.Usuario().GetById(idUsuario);
            UsuarioFiliais = new Lib.UsuarioFilial().GetByUsuario(idUsuario);
            Filiais = UsuarioFiliais.Select(a => a.Filial).ToList();


            //inicializa componentes
            InitializeComponent();
        }

        private void Contexto_Load(object sender, EventArgs e)
        {
            //carrega o datasource
            idFilialComboBox.DataSource = Filiais;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar a seleção do contexto?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                if (Session.Instance.Contexto == null)
                {
                    ExitApp = true;
                }
                Close();
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            ContextoItem = UsuarioFiliais.FirstOrDefault(a => a.IdFilial == (int)idFilialComboBox.SelectedValue);
            Close();
        }
    }
}
