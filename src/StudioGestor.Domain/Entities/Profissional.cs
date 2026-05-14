using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioGestor.Domain.Entities
{
    public class Profissional
    {
        public Guid Id { get; private set; }
        public Guid EmpresaId { get; private set; }

        public string Nome { get; private set; } = null!;
        public string Telefone { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public string Cargo { get; private set; } = null!;
        public DateTime? DataAdmissao { get; private set; }
        public bool Ativo { get; private set; }

        // Relacionamentos
        public Empresa Empresa { get; private set; } = null!;
        public ICollection<Agendamento> Agendamentos { get; private set; } = [];

        protected Profissional() { }

        public Profissional(Guid empresaId, string nome, string telefone, string email, string cargo, DateTime? dataAdmissao, bool ativo)
        {
            Id = Guid.NewGuid();
            EmpresaId = empresaId;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Cargo = cargo;
            DataAdmissao = dataAdmissao;
            Ativo = ativo;
        }

        public void Inativar()
        {
            Ativo = false;
        }
    }
}