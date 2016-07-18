using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Relatorios.Fichas.Termo
{
    public partial class Filtro : Base.FiltroBase
    {
        #region PROPRIEDADES

        public Lib.Atendimento LibAtendimento
        {
            get
            {
                return new Lib.Atendimento();
            }
        }

        public int IdAtendimento { get; set; }


        public int IdModelo { get; set; }

        public Lib.AtendimentoModelo LibAtendimentoModelo
        {
            get
            {
                return new Lib.AtendimentoModelo();
            }
        }

        #endregion

        #region CONSTRUTOR
        public Filtro()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                {
                    CarregaClientes(BuscaCodigo());
                }
                else if (!string.IsNullOrEmpty(txtNome.Text))
                {
                    CarregaClientes(BuscaNome());
                }
            }
            catch (Exception ex)
            {
                Lib.MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void Filtro_Load(object sender, EventArgs e)
        {
            dataGridClientes.AutoGenerateColumns = false;
            dataGridModelos.AutoGenerateColumns = false;
            CarregaParentesco();
        }


        private void brGerar_Click(object sender, EventArgs e)
        {
            var parent = (Dados.EnumModeloTipoResp)Enum.Parse(typeof(Dados.EnumModeloTipoResp), cbParentesco.SelectedValue.ToString());

            if (dataGridModelos.SelectedRows.Count > 0)
                IdModelo = int.Parse(dataGridModelos.SelectedRows[0].Cells[0].Value.ToString());

            var frm = new Viewer(IdModelo, IdAtendimento, parent);
            frm.ShowDialog();
        }

        #endregion

        #region METODOS

        private void CarregaClientes(List<Dados.Atendimento> atedimento)
        {
            dataGridClientes.DataSource = atedimento.Select(a => new
            {
                Codigo = a.CodigoReduzido,
                Nome = a.CliFor.Nome,
                Data = a.Data
            }).ToList();
        }

        private List<Dados.Atendimento> BuscaNome()
        {
            return LibAtendimento.GetByNome(txtNome.Text.Trim());
        }

        private List<Dados.Atendimento> BuscaCodigo()
        {
            return LibAtendimento.GetByCodigoReduzido(int.Parse(txtCodigo.Text.Trim()));
        }


        private void CarregaParentesco()
        {
            cbParentesco.ValueMember = "Key";
            cbParentesco.DisplayMember = "Value";
            cbParentesco.DataSource = Lib.Utilitarios.UtilityEnum.GetItemsFromEnum<Dados.EnumModeloTipoResp>()
                                      .Select(a => new ParentescoModel
                                      {
                                          Key = a.Key.ToString(),
                                          Value = a.Value
                                      }).ToList();
        }

        private void dataGridClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridClientes.SelectedRows.Count > 0)
            {
                IdAtendimento = int.Parse(dataGridClientes.SelectedRows[0].Cells[0].Value.ToString());
                CarregaModelos();
            }
        }

        private void CarregaModelos()
        {
            dataGridModelos.DataSource = LibAtendimentoModelo.GetByCodigoReduzido(IdAtendimento)
                                                             .Select(a => new
                                                             {
                                                                 Codigo = a.IdModelo,
                                                                 Modelo = a.Modelo.NomeCompleto,
                                                                 Documento = Lib.Utilitarios.Comum.FormataCpf(a.Modelo.Cpf)
                                                             }).ToList();
        }
        #endregion
    }

    public class ParentescoModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
