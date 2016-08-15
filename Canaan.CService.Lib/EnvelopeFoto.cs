using Canaan.Lib.Model.Envio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.CService.Lib
{
    public class EnvelopeFoto
    {

        public Canaan.Lib.Model.Envio.SumaryOrdemServicoItemModel SalvaOrdensItem(OrdemServicoItemEnvioModel item, int idEnvelopeCPC)
        {
            using (var conn = new Dados.CServicosEntities())
            {
                try
                {

                    if (!ExisteCPC(idEnvelopeCPC, item.NomeFoto))
                    {
                        var envelope = new Dados.env_envelopes_fotos
                        {
                            id_envelope = idEnvelopeCPC,
                            cod_pacote = item.CodPacote,
                            quant = item.Quantidade,
                            nome_foto = item.NomeFoto,
                            efeito_digital = item.EfeitoDigital,
                            caminho_foto = item.CaminhoFoto,
                            obs = item.Observacao
                        };

                        conn.env_envelopes_fotos.Add(envelope);
                        conn.SaveChanges();


                        return new SumaryOrdemServicoItemModel
                        {
                            IdFotoCpc = envelope.id_envelope_foto
                        };

                    }else
                    {
                        var env_foto = conn.env_envelopes_fotos.FirstOrDefault(a => a.id_envelope == idEnvelopeCPC && a.nome_foto == item.NomeFoto);

                        return new SumaryOrdemServicoItemModel
                        {
                            IdFotoCpc = env_foto.id_envelope_foto
                        };
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private bool ExisteCPC(int idEnvelope, string nomeFoto)
        {
            using (var conn = new CService.Dados.CServicosEntities())
            {
                var result = conn.env_envelopes_fotos.Where(a => a.id_envelope == idEnvelope && a.nome_foto == nomeFoto).ToList();
                return result.Any();
            }
        }
    }
}
