using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Base
{
    public partial class FiltroUsuario : Form
    {
        #region PROPRIEDADES

        public Lib.Session Session
        {
            get
            {
                return Lib.Session.Instance;
            }
        }
        public Dados.EnumRelatorioTipo TipoRelatorio { get; set; }

        #endregion

        #region CONSTRUTORES

        public FiltroUsuario(Dados.EnumRelatorioTipo pTipoRelatorio)
        {
            TipoRelatorio = pTipoRelatorio;
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void FiltroUsuario_Load(object sender, EventArgs e)
        {
            CarregaUsuarios();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            GeraRelatorio();
        }

        #endregion

        #region METODOS
    
        private void CarregaUsuarios()
        {
            var usuarios = new Lib.UsuarioFilial().GetByFilial(Session.Contexto.IdFilial).Select(a => a.Usuario).ToList();

            usuarioComboBox.ValueMember = "IdUsuario";
            usuarioComboBox.DisplayMember = "Nome";
            usuarioComboBox.DataSource = usuarios
                .Where(a => a.IsAtivo == true)
                .OrderBy(a => a.Nome)
                .Select(a => new{
                    IdUsuario = a.IdUsuario,
                    Nome = string.Format("{0} {1}", a.Nome, a.Sobrenome)
            }).ToList();
        }

        private void GeraRelatorio()
        {
            switch (TipoRelatorio)
            {
                case Canaan.Dados.EnumRelatorioTipo.Marketing_CuponsXUsuario:
                    var frmCupomFunc = new Relatorios.Marketing.CupomFunc.Viewer((int)usuarioComboBox.SelectedValue);
                    frmCupomFunc.Show();
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
