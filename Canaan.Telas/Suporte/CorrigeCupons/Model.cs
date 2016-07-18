using System.Drawing;
using Canaan.Dados;

namespace Canaan.Telas.Suporte.CorrigeCupons
{
    public class Model
    {
        public int IdCupom { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Nome { get; set; }
        public EnumTelemarketingStatus Status { get; set; }
        public int Quantidade { get; set; }
        public Bitmap Imagem { get; set; }


    }
}
