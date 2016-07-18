using System.Windows.Forms;

namespace Canaan.Telas.Base
{
    public partial class FormVendaBase : Form
    {
        public bool IsModified { get; set; }

        public FormVendaBase()
        {
            InitializeComponent();
        }
    }
}
