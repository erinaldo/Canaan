using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib.Model.Envio
{
    public class OrdemServicoItemEnvioModel
    {

        public int IdFotoCpc { get; set; }

        public int IdOrdemItem { get; set; }

        public int IdEnvelopeFoto { get; set; }

        public int IdOrdem { get; set; }

        public Dados.Foto Foto { get; set; }

        public int CodPacote { get; set; }

        public int Quantidade { get; set; }

        public string NomeFoto { get; set; }

        public string EfeitoDigital { get; set; }

        public string CaminhoFoto { get; set; }

        public string Observacao { get; set; }

        public Dados.OrdemServico Ordem { get; set; }

    }
}
