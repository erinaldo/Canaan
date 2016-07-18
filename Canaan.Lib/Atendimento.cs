using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Atendimento : IBase<Dados.Atendimento>
    {
        #region PROPRIEDADES

        public AtendimentoHist LibAtendimentoHist
        {
            get
            {
                return new AtendimentoHist();
            }
        }

        public CliFor LibCliFor
        {
            get
            {
                return new CliFor();
            }
        }

        #endregion

        public List<Dados.Atendimento> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Atendimento
                           .Where(a => a.IdFilial == Session.Instance.Contexto.IdFilial)
                           .ToList();
            }
        }

        public List<Dados.Atendimento> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.Atendimento
                                 .Include(a => a.CliFor)
                                 .Include(a => a.Agendamento)
                                 .Include(a => a.Agendamento.Cupom)
                                 .Include(a => a.Agendamento.Cupom.Parceria)
                                 .Where(a => a.CliFor.Nome.Contains(nome) || a.CliFor.Modelo.Any(b => b.NomeCompleto.Contains(nome))).Distinct()
                                 .ToList();

                return result;
            }
        }

        public List<Dados.Atendimento> Filter(string filtro, object[] parameters)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Atendimento.Include(a => a.Filial)
                                       .Include(a => a.CliFor)
                                       .Include(a => a.CliFor.Cidade)
                                       .Include(a => a.Agendamento)
                                       .Include(a => a.Agendamento.Cupom)
                                       .Include(a => a.Agendamento.Cupom.Parceria)
                                       .Where(filtro, parameters).ToList();
            }
        }

        public dynamic CarregaGridClientes(List<Dados.Atendimento> lista)
        {
            if (lista != null)
            {
                return lista.Select(a => new
                {
                    Codigo = a.IdCliFor,
                    Nome = a.CliFor.Nome,
                    Documento = a.CliFor.Documento,
                    Cidade = new Cidade().GetById(a.CliFor.Cidade.IdCidade).Nome,
                    Estado = new Cidade().GetById(a.CliFor.Cidade.IdCidade).Estado.Nome,
                }).ToList();
            }
            else
            {
                return null;
            }
        }

        public Dados.Atendimento GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Atendimento.Include(a => a.CliFor)
                                       .Include(a => a.Agendamento)
                                       .Include(a => a.Agendamento.Cupom)
                                       .Include(a => a.Agendamento.Cupom.Parceria)
                                       .Include(a => a.Filial)
                                       .Include(a => a.Usuario)
                                       .Include(a => a.CliFor.Cidade)
                                       .Include(a => a.AtendimentoModelo)
                                       .FirstOrDefault(a => a.IdAtendimento == id);
            }
        }

        public List<Dados.Atendimento> GetByCliFor(int idCliFor)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Atendimento
                           .Include(a => a.AtendimentoModelo)
                           .Include(a => a.Agendamento)
                           .Include(a => a.Agendamento.Cupom)
                           .Include(a => a.Agendamento.Cupom.Parceria)
                           .Include(a => a.CliFor.Cidade)
                           .Include(a => a.CliFor)
                           .Where(a => a.IdCliFor == idCliFor)
                           .ToList();
            }
        }

        public Dados.Atendimento GetByIdAgendamento(int idAgendamento)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Atendimento
                           .Include(a => a.AtendimentoModelo)
                           .Include(a => a.Agendamento)
                           .Include(a => a.Agendamento.Cupom)
                           .Include(a => a.Agendamento.Cupom.Parceria)
                           .Include(a => a.CliFor.Cidade)
                           .Include(a => a.CliFor)
                           .FirstOrDefault(a => a.IdAgendamento == idAgendamento);
            }
        }

        public Dados.Atendimento Insert(Dados.Atendimento item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Atendimento.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();

                        //Adicionar Historico Atendimento
                        AdicionarHistorico(item, Utilitarios.EnumTipoMov.Insert);

                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(item.IdAtendimento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Atendimento Update(Dados.Atendimento item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Atendimento
                                      .FirstOrDefault(a => a.IdAtendimento == item.IdAtendimento);

                    //atualiza dados
                    updated.IdFilial = item.IdFilial;
                    updated.IdAgendamento = item.IdAgendamento;
                    updated.IdUsuario = item.IdUsuario;
                    updated.Data = item.Data;
                    updated.IsConfirmado = item.IsConfirmado;
                    updated.IsAtivo = item.IsAtivo;

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();

                        AdicionarHistorico(updated, Utilitarios.EnumTipoMov.Update);
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(updated.IdAgendamento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Atendimento Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Atendimento.FirstOrDefault(a => a.IdAtendimento == id);

                    //salva no banco de dados
                    conn.Atendimento.Remove(deleted);
                    conn.SaveChanges();

                    //Adiciona historico
                    AdicionarHistorico(deleted, Utilitarios.EnumTipoMov.Delete);

                    //retorna
                    return deleted;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Dados.Atendimento> GetListById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Atendimento
                            .Include(a => a.CliFor)
                            .Include(a => a.Agendamento)
                            .Include(a => a.Agendamento.Cupom)
                            .Include(a => a.Agendamento.Cupom.Parceria)
                            .Where(a => a.CodigoReduzido == id)
                            .ToList();
            }
        }

        public List<Dados.Atendimento> GetByCodigoReduzidoAndFilial(int codigoReduzido, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Atendimento
                           .Include(a => a.CliFor)
                           .Include(a => a.Agendamento)
                           .Include(a => a.Agendamento.Cupom)
                           .Include(a => a.Agendamento.Cupom.Parceria)
                           .Where(a => a.CodigoReduzido == codigoReduzido && a.IdFilial == idFilial)
                           .ToList();
            }
        }

        public List<Dados.Atendimento> GetByCpfAndFilial(string cpf, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Atendimento
                           .Include(a => a.CliFor)
                           .Include(a => a.Agendamento)
                           .Include(a => a.Agendamento.Cupom)
                           .Include(a => a.Agendamento.Cupom.Parceria)
                           .Where(a => a.CliFor.Documento.Contains(cpf) && a.IdFilial == idFilial)
                           .ToList();
            }
        }

        public List<Dados.Atendimento> GetByNomeAndFilial(string nome, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.Atendimento
                                .Include(a => a.CliFor)
                                .Include(a => a.Agendamento)
                                .Include(a => a.Agendamento.Cupom)
                                .Include(a => a.Agendamento.Cupom.Parceria)
                                .Where(a => (a.CliFor.Nome.Contains(nome) ||
                                            a.CliFor.Modelo.Any(b => b.NomeCompleto.Contains(nome)) &&
                                            a.IdFilial == idFilial)).Distinct()
                                .ToList();

                return result;
            }
        }

        public List<Dados.Atendimento> GetByCodigoReduzido(int codigoReduzido)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Atendimento
                           .Include(a => a.CliFor)
                           .Include(a => a.Agendamento)
                           .Include(a => a.Agendamento.Cupom)
                           .Include(a => a.Agendamento.Cupom.Parceria)
                           .Where(a => a.CodigoReduzido == codigoReduzido)
                           .ToList();
            }
        }

        public List<Dados.Atendimento> GetAtedimentosIndicados(int idAtendimento)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var cupons = conn.Indicacao.Where(a => a.IdAtendimento == idAtendimento &&
                                                  a.Cupom.Agendamento.Any(b => b.Status == Dados.EnumAgendamentoStatus.Atendido ||
                                                                          b.Status == Dados.EnumAgendamentoStatus.Fotografado))
                                                                     .Select(a => a.IdCupom).ToArray();

                List<Dados.Atendimento> atendimentos = new List<Dados.Atendimento>();

                foreach (var item in cupons)
                {
                    var atend = conn.Atendimento
                                    .Include(a => a.CliFor)
                                    .Include(a => a.Agendamento)
                                    .Include(a => a.Agendamento.Cupom)
                                    .Include(a => a.Agendamento.Cupom.Parceria)
                                    .FirstOrDefault(a => a.Agendamento.IdCupom == item);
                    atendimentos.Add(atend);
                }

                return atendimentos;

            }
        }

        public dynamic CarregaGrid(List<Dados.Atendimento> lista)
        {
            if ((lista == null) || (lista.Count == 0))
                return new List<Dados.Atendimento>();

            return lista.Select(a => new
            {
                Codigo = a.IdAtendimento,
                Atendimento = a.CodigoReduzido,
                Cliente = a.CliFor.Nome,
                Documento = Lib.Utilitarios.Comum.FormataCpf(a.CliFor.Documento),
                Data = a.Data.ToShortDateString(),
                Promocao = a.Agendamento.Cupom.Parceria.Nome
            })
            .ToList();
        }
       

        #region UTILITARIO

        private void AdicionarHistorico(Dados.Atendimento item, Utilitarios.EnumTipoMov enumTipoMov)
        {
            var his = new Dados.AtendimentoHist
            {
                IdAtendimento = item.IdAtendimento,
                IdUsuario = Session.Instance.Usuario.IdUsuario,
                Data = DateTime.Now,
            };

            var cliente = LibCliFor.GetById(item.IdCliFor);
            var nomeCliente = cliente.Nome;

            switch (enumTipoMov)
            {
                case Utilitarios.EnumTipoMov.Insert:
                    his.Observacao = string.Format("Atendimento {0} criado com sucesso: Cliente -> {1} IsConfirmado -> {2} ", item.IdAtendimento, nomeCliente, item.IsConfirmado);
                    break;
                case Utilitarios.EnumTipoMov.Update:
                    his.Observacao = string.Format("Atendimento {0} atualizado com sucesso: Cliente -> {1} IsConfirmado -> {2} ", item.IdAtendimento, nomeCliente, item.IsConfirmado);
                    break;
                case Utilitarios.EnumTipoMov.Delete:
                    his.Observacao = string.Format("Atendimento {0} deletado com sucesso: Cliente -> {1}", item.IdAtendimento, nomeCliente);
                    break;
                default:
                    his.Observacao = string.Format("Atendimento {0} criado com sucesso: Cliente -> {1} IsConfirmado -> {2} ", item.IdAtendimento, nomeCliente, item.IsConfirmado);
                    break;
            }

            LibAtendimentoHist.Insert(his);

        }

        #endregion

        
    }
}

