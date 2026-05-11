using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioGestor.Domain.Entities
{
    public class AgendamentoServico
    {
        public Guid Id { get; private set; }

        public Guid AgendamentoId { get; private set; }
        public Guid ServicoId { get; private set; }

        public string NomeServico { get; private set; } = null!;
        public decimal Valor { get; private set; } = 0;
        public int? DuracaoEmMinutos { get; private set; }

        public Agendamento Agendamento { get; private set; } = null!;
        public Servico Servico { get; private set; } = null!;

        protected AgendamentoServico() { }

        public AgendamentoServico(
            Guid agendamentoId,
            Guid servicoId,
            string nomeServico,
            decimal valor,
            int duracaoEmMinutos)
        {
            Id = Guid.NewGuid();
            AgendamentoId = agendamentoId;
            ServicoId = servicoId;
            NomeServico = nomeServico;
            Valor = valor;
            DuracaoEmMinutos = duracaoEmMinutos;
        }
    }
}