using System.Collections.Generic;
using Canaan.Dados;
using Canaan.Telas.Base;

namespace Canaan.Telas.Rotinas.Marketing.Telemarketing.Historico
{
    public partial class HistoricoCupom : FormLista
    {
        public List<TelemarketingMov> Movimentacao { get; set; }

        public Lib.TelemarketingMov LibTeleMov 
        {
            get
            {
                return new Lib.TelemarketingMov();
            }
        }

        public Cupom Cupom { get; set; }

        public Lib.Cupom LibCupom 
        {
            get
            {
                return new Lib.Cupom();
            }
        }

        public HistoricoCupom(int idCupom)
        {
            Cupom = LibCupom.GetById(idCupom);
            Movimentacao = LibTeleMov.GetByCupom(idCupom);
            dataGrid.DataSource = LibTeleMov.CarregaGrid(Movimentacao);

            ConfiguraForm();

            InitializeComponent();
        }

        private void ConfiguraForm()
        {
            Text += string.Format(" do Cupom {0}", Cupom.Nome);
            toolstripActions.Visible = false;
        }

        protected override void CarregaEdita()
        {
            
        }
    }
}
