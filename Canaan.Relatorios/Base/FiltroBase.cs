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
    public partial class FiltroBase : Form
    {

        public Lib.Session Session 
        {
            get
            {
                return Lib.Session.Instance;
            }
        }

        public FiltroBase()
        {
            InitializeComponent();
        }
    }
}
