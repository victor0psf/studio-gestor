using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudioGestor.Domain.Enums;
using StudioGestor.Domain.Entities;

namespace StudioGestor.Domain
{
    public class Agendamento
    {
        public Guid Id { get; private set; }

        public Guid EmpresaId { get; private set; }
        public Guid ClienteId { get; private set; }
        public Guid ProfissionalId { get; private set; }

        public DateTime? DataHora { get; private set; }
        public string? Observacoes { get; private set; }

        // Relacionamentos
        public Empresa Empresa { get; private set; } = null!;
        public Cliente Cliente { get; private set; } = null!;
        public Profissional Profissional { get; private set; } = null!;
        public AgendamentoStatus Status { get; private set; } = AgendamentoStatus.Agendado;

        public ICollection<AgendamentoServico> AgendamentoServicos { get; private set; } = [];

        protected Agendamento() { }

        public Agendamento(Guid empresaId, Guid clienteId, Guid profissionalId, DateTime dataHora, string observacoes)
        {
            Id = Guid.NewGuid();
            EmpresaId = empresaId;
            ClienteId = clienteId;
            ProfissionalId = profissionalId;
            DataHora = dataHora;
            Observacoes = observacoes;
            Status = AgendamentoStatus.Agendado;
        }

        public void Confirmar()
        {
            Status = AgendamentoStatus.Confirmado;
        }

        public void Cancelar()
        {
            Status = AgendamentoStatus.Cancelado;
        }

        public void Finalizar()
        {
            Status = AgendamentoStatus.Finalizado;
        }
    }
}