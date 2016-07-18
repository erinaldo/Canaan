using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Canaan.Lib;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Financeiro.Retorno
{
    public partial class Lista : XtraForm
    {
        #region PROPRIEDADES

        public Lib.Retorno objLib { get; set; }
        public List<Dados.Retorno> Retornos { get; set; }
        public BindingList<Lib.Model.Retorno> BindList { get; set; }
        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }
        public Lib.Model.Retorno CurrentItem 
        { 
            get 
            {
                return BindList[retornoDataGridView.SelectedRows[0].Index];
            } 
        }

        #endregion

        #region CONSTRUTORES

        public Lista()
        {
            objLib = new Lib.Retorno();
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {
            CarregaLista();
            CarregaBindList();
            CarregaGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
            CarregaLista();
            CarregaBindList();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void retornoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Consulta();
        }

        #endregion

        #region METODOS

        private void CarregaLista() 
        {
            Retornos = objLib.Get();
        }

        private void CarregaBindList() 
        {
            BindList = new BindingList<Lib.Model.Retorno>(Retornos.Select(a => new Lib.Model.Retorno { 
                Codigo = a.IdRetorno,
                Filial = a.Filial.NomeFantasia,
                ContaCaixa = a.ContaCaixa.Nome,
                Usuario = a.Usuario.Nome,
                Data = a.Data,
                Arquivo = a.Arquivo,
                Registros = a.RetornoLog.Count,
                Erros = a.RetornoLog.Where(b => b.IsErro == true).Count()
            }).ToList());
        }

        private void CarregaGrid() 
        {
            retornoDataGridView.DataSource = BindList;
        }

        private void Novo() 
        {
            var frm = new Edita();
            frm.ShowDialog();

            CarregaLista();
            CarregaBindList();
        }

        private void Consulta() 
        {
            try
            {
                if (retornoDataGridView.SelectedRows.Count > 0)
                {
                    var id = CurrentItem.Codigo;
                    var form = new Log(id);
                    form.ShowDialog();
                }
                else 
                {
                    throw new Exception("Nenhum registro selecionado");
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
            
        }

        #endregion

        

        

        

        
    }
}
