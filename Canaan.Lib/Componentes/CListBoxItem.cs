using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Lib.Componentes
{
    public class CListViewItem : ListViewItem
    {
        public object Item { get; set; }

        public CListViewItem(object item, string nome, int i) :
            base(nome, i)
        {
            Item = item;
            ConfiguraCor();
        }

        private void ConfiguraCor()
        {
            if (Item as Dados.OrdemServicoItem != null)
            {
                var comp = Item as Dados.OrdemServicoItem;
                if (comp.IdEfeito != null)
                    BackColor = Color.Silver;
            }
        }
    }
}
