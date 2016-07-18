using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Componentes
{
    public class CRadioButtonTeleFilter : System.Windows.Forms.RadioButton
    {
        [Category("Behavior")]
        [Browsable(true)]
        public TipoRelatorioTele Tipo { set; get; }

        public string TipoRelatorio
        {
            get 
            {
                return Tipo.ToString();
            }
            set 
            {
                Tipo = (TipoRelatorioTele)Enum.Parse(typeof(TipoRelatorioTele), value);
            }
        }
    }
    public enum TipoRelatorioTele
    {
        FichaPronta,
        NaoViu,
        NaoComprou,
        PegouBrinde,
        AguardandoFinalizacao,
        Programadas,
        Devolvidas,
        Vendidos,
        ListaOuro,
        Aniversario
    }
}
