using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Telas.Properties;
using Cupom = Canaan.Lib.Cupom;

namespace Canaan.Telas.Suporte.CorrigeCupons
{
    public partial class Formulario : Form
    {
        #region PROPRIEDADES

        public BindingList<Model> Modelo { get; set; }
       

        #endregion

        #region CONSTRUTORES

        public Formulario()
        {
            Modelo = new BindingList<Model>();
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Formulario_Load(object sender, EventArgs e)
        {
            dataGridViewCupons.DataSource = Modelo;
        }

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            workerCarrega.RunWorkerAsync();
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            labelInfo.Text = "";
            labelQuantModel.Text = "";
            progressInfo.Value = 0;

            workerExecuta.RunWorkerAsync();
        }
        

        #endregion

        #region CONSULTA

        private void workerCarrega_DoWork(object sender, DoWorkEventArgs e)
        {
            //Carrega
            using (var conn = new CanaanModelContainer())
            {
                //cria lista model e carrega cupons agendados ou descartados
                var libCupom = new Cupom();
                var cupons = conn.Cupom.Where(a => (a.IsAgendado == true || a.IsDescartado == true) && a.Obs != "Cupom migrado do Cmaster").OrderByDescending(a => a.IdCupom);
                var total = cupons.Count();
                var i = 0;

                //faz loop nos itens
                foreach (var item in cupons)
                {
                    var duplicados = libCupom.GetDuplicados(item);

                    //verifica se cupom tem duplicado
                    if (duplicados.Count > 1)
                    {
                        //verifica se tem condição movimentada
                        var verifica = libCupom.VerificaCondicao(item);

                        if (verifica != null)
                        {
                            var novo = new Model {
                                IdCupom = item.IdCupom,
                                Telefone = item.Telefone,
                                Celular = item.Celular,
                                Nome = item.Nome,
                                Status = verifica.GetValueOrDefault(),
                                Quantidade = duplicados.Count,
                                Imagem = Resources.clock_16xLG
                            };

                            workerCarrega.ReportProgress(total, novo);
                        }
                    }

                    //reporta o progresso
                    i++;
                    workerCarrega.ReportProgress(total, i);
                }
            }
        }

        private void workerCarrega_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int result;

            //verifica se o user state é um id ou um cupo para incluir no bindinglist
            if (int.TryParse(e.UserState.ToString(), out result))
            {
                labelInfo.Text = string.Format("{0} de {1}", result, e.ProgressPercentage.ToString());
                progressInfo.Value = ((int)result * 100) / e.ProgressPercentage;
            }
            else 
            {
                Modelo.Add((Model)e.UserState);

                labelQuantModel.Text = string.Format("{0} de registros duplicados", Modelo.Count.ToString());
            }
        }

        private void workerCarrega_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Todos os registros carregados");
        }

        #endregion

        #region EXECUTA CORREÇAO

        private void workerExecuta_DoWork(object sender, DoWorkEventArgs e)
        {
            var libCupom = new Cupom();
            var i = 0;

            foreach (var item in Modelo)
            {
                var cupom = libCupom.GetById(item.IdCupom);
                libCupom.UpdateCondicao(cupom, item.Status);

                i++;
                workerExecuta.ReportProgress(i, item);
            }
        }

        private void workerExecuta_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelInfo.Text = string.Format("{0} de {1} corrigido", e.ProgressPercentage.ToString(), Modelo.Count);
            progressInfo.Value = ((int)e.ProgressPercentage * 100) / Modelo.Count;


            var cupom = (Model)e.UserState;
            cupom.Imagem = Resources.StatusAnnotations_Complete_and_ok_16xLG_color;
        }

        private void workerExecuta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Todos os registros executados");
        }

        #endregion
    }
}
