using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Relatorios.Programadas.Comparativo
{
    public partial class Filtro : Form
    {
        //construtores
        public Filtro()
        {
            InitializeComponent();
        }


        //metodos
        private void CarregaRelatorio()
        {
            Resultado frm = new Resultado(GetResult(), dataInicio.Value, dataFim.Value);
            frm.Show();
        }

        private List<Model> GetResult()
        {
            //declara objetos
            List<Model> result = new List<Model>();
            List<Dados.GFILIAL> filiais = new List<Dados.GFILIAL>();

            //verifica lista de estudios
            if (checkRede.Checked)
                filiais = Lib.Filiais.GetEstudiosRede();
            else
                filiais = Lib.Filiais.GetEstudios();


            //faz loop nas filiais
            foreach (Dados.GFILIAL filial in filiais)
            {
                //todos os lançamentos de uma filial
                List<Dados.FLAN> lancamentos = Lib.Lancamento.GetEntradasByFilial(filial.CODCOLIGADA, filial.CODFILIAL, dataInicio.Value, dataFim.Value);

                if (lancamentos.Sum(a => a.VALORORIGINAL) > 0)
                {
                    Model modelo = new Model();
                    modelo.NomeEstudio = filial.NOMEFANTASIA;
                    modelo.Receber = lancamentos.Sum(a => a.VALORORIGINAL);
                    modelo.Recebido = lancamentos.Where(a => a.STATUSLAN == 1).Sum(a => a.VALORORIGINAL);
                    modelo.Aberto = modelo.Receber - modelo.Recebido;
                    modelo.Percentual = (modelo.Recebido * 100) / modelo.Receber;

                    result.Add(modelo);
                }
            }

            //retorna resultado
            return result;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }
    }
}
