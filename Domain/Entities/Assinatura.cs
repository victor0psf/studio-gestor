using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudioGestor.Domain.Enums;

namespace StudioGestor.Domain.Entities
{
    public class Assinatura
    {
        public Guid Id { get; private set; }

        public Guid EmpresaId { get; private set; }
        public Guid PlanoId { get; private set; }

        public DateTime DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }

        public AssinaturaStatus Status { get; private set; }

        public Empresa Empresa { get; private set; } = null!;
        public Plano Plano { get; private set; } = null!;

        protected Assinatura() { }

        public Assinatura(Guid empresaId, Guid planoId, DateTime dataInicio)
        {
            Id = Guid.NewGuid();
            EmpresaId = empresaId;
            PlanoId = planoId;
            DataInicio = dataInicio;
            Status = AssinaturaStatus.Ativa;
        }

        public void Cancelar()
        {
            Status = AssinaturaStatus.Cancelada;
            DataFim = DateTime.Now;
        }

        public void Suspender()
        {
            Status = AssinaturaStatus.Suspensa;
        }

    }
}