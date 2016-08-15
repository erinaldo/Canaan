using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.CService.Relatorios.ImagensXPeriodo
{
    public partial class Viewer : Form
    {
        #region PROPRIEDADES

        public Dados.CServicosEntities Conn { get; set; }
        public List<Dados.env_studios> Estudios { get; set; }
        public Model DataSet { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int Tipo { get; set; }

        #endregion

        #region CONSTRUTOR

        public Viewer(List<Dados.env_studios> pEstudios, DateTime pDataInicio, DateTime pDataFim, int pTipo)
        {
            this.Conn = new Dados.CServicosEntities();
            this.Estudios = pEstudios;
            this.DataInicio = pDataInicio;
            this.DataFim = pDataFim;
            this.Tipo = pTipo;
            this.DataSet = new Model();

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Viewer_Load(object sender, EventArgs e)
        {
            CarregaDados();
            CarregaRelatorio();
        }

        private void Viewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Conn.Dispose();
        }

        #endregion

        #region METODOS

        public void CarregaDados() 
        {
            var indice = 0;

            //faz loop por estudio
            foreach (var estudio in this.Estudios)
            {
                var pDataFim = this.DataFim.AddDays(1); // corrige problema de minutos e horas

                var envelopes = Conn.env_envelopes
                                    .Where(a => a.id_studio == estudio.id_studio &&
                                                a.is_manipulado == true &&
                                                a.data_manipulacao >= this.DataInicio &&
                                                a.data_manipulacao <= pDataFim)
                                    .GroupBy(a => new
                                    {
                                        IdEstudio = a.id_studio,
                                        CodPacote = a.cod_pacote,
                                        CodVenda = a.cod_venda
                                    });

                //var envelopes = Conn.env_envelopes
                //                    .Where(a => a.id_studio == estudio.id_studio &&
                //                                a.data_envio >= this.DataInicio &&
                //                                a.data_envio <= pDataFim)
                //                    .GroupBy(a => new
                //                    {
                //                        IdEstudio = a.id_studio,
                //                        CodPacote = a.cod_pacote,
                //                        CodVenda = a.cod_venda
                //                    });

                foreach (var item in envelopes)
                {
                    //cria registro do envelope
                    if (item.Key.CodPacote != null && item.Key.CodVenda != null) 
                    { 
                        var row = this.DataSet.Resultado.NewResultadoRow();
                        row.Id = indice + 1;
                        row.Cidade = estudio.nome;
                        row.DataEnvio = item.FirstOrDefault().data_envio.GetValueOrDefault().Date;
                        row.DataManipulacao = item.OrderBy(a => a.data_manipulacao).LastOrDefault().data_manipulacao.GetValueOrDefault().Date;
                        row.Manipulador = GetManipulador(item.FirstOrDefault());
                        row.CodPacote = item.Key.CodPacote != null ? item.Key.CodPacote.Value : 0;
                        row.CodVenda = item.Key.CodVenda != null ? item.Key.CodVenda.Value : 0;
                        row.NumEnvelopes = item.Count();
                        row.NumImagens = CalculaImagens(item.Key.CodPacote.Value, item.Key.CodVenda.Value, item.Key.IdEstudio.Value);

                        this.DataSet.Resultado.AddResultadoRow(row);

                        indice++;
                    }
                    
                }

                //verifica total de imagens e atualiza as linhas com o valor a ser aplicado
                decimal valorUnitario = GetValorUnitario(DataSet.Resultado.Sum(a => a.NumImagens));

                //atualiza valores
                foreach (var row in DataSet.Resultado)
                {
                    row.Valor = (row.NumEnvelopes * valorUnitario) + (row.NumImagens * valorUnitario);
                }
            }
        }

        private string GetManipulador(Dados.env_envelopes item)
        {
            if (item.env_laboratoristas_envelopes.FirstOrDefault() != null)
            {
                if (item.env_laboratoristas_envelopes.FirstOrDefault().env_laboratoristas != null)
                {
                    return item.env_laboratoristas_envelopes.FirstOrDefault().env_laboratoristas.nome;
                }
                else 
                {
                    return "NÃO INFORMADO";
                }
            }
            else 
            {
                return "NÃO INFORMADO";
            }
        }

        public void CarregaRelatorio() 
        {
            Relatorio report = new Relatorio();

            TextObject periodo = (TextObject)report.ReportDefinition.Sections["Section2"].ReportObjects["txtPeriodo"];
            periodo.Text = string.Format("Periodo: {0} à {1}", this.DataInicio.ToShortDateString(), this.DataFim.ToShortDateString());
            
            //carrega dados
            report.SetDataSource(this.DataSet);

            //carrega o report viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Zoom(100);
        }
        
        private int CalculaImagens(int codPacote, int codVenda, int codEstudio)
        {
            //define a quantidade de imagens
            if (this.Tipo == 0)
            {
                return Conn.env_envelopes_fotos
                           .Where(a => a.env_envelopes.cod_pacote == codPacote && 
                                       a.env_envelopes.cod_venda == codVenda && 
                                       a.env_envelopes.id_studio == codEstudio)
                           .GroupBy(a => a.nome_foto)
                           .Count();
            }
            else
            {
                return Conn.env_envelopes_fotos
                           .Where(a => a.env_envelopes.cod_pacote == codPacote && 
                                       a.env_envelopes.cod_venda == codVenda && 
                                       a.env_envelopes.id_studio == codEstudio)
                           .Count();
            }
        }

        private decimal GetValorUnitario(int numImagens) 
        {
            decimal valor = 0;

            if (numImagens <= 10000)
            {
                valor = 0.6M;
            }
            else 
            {
                if (numImagens <= 15000)
                {
                    valor = 0.5M;
                }
                else 
                {
                    if (numImagens <= 25000)
                    {
                        valor = 0.45M;
                    }
                    else 
                    {
                        valor = 0.42M;
                    }

                }
            }

            return valor;
        }

        #endregion       
    }
}
