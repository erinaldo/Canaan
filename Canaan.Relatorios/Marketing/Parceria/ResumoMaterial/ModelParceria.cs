using System;

namespace Canaan.Relatorios.Marketing.Parceria.ResumoMaterial
{
    public class ModelParceria
    {
        public int IdParceria { get; set; }
        public string Nome { get; set; }
        public string Filial { get; set; }
        public int CuponsTotal { get; set; }
        public int CuponsAbertos { get; set; }
        public int CuponsDescartados { get; set; }
        public int CuponsFaltantes { get; set; }
        public int CuponsAgendados { get; set; }
        public DateTime Abertura { get; set; }
        public DateTime Encerramento { get; set; }
        public byte[] Logo { get; set; }
    }
}
