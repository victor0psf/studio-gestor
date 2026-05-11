using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioGestor.Domain.Entities
{
    public class Cliente
    {
        public Guid Id { get; private set; }
        public Guid EmpresaId { get; private set; }


        public string Nome { get; private set; } = null!;
        public string Telefone { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public DateTime? DataNascimento { get; private set; }

        // relacionamentos
        public Empresa Empresa { get; private set; } = null!;
        public ICollection<Agendamento> Agendamentos { get; private set; } = [];

        protected Cliente() { }
        public Cliente(Guid empresaId, string nome, string telefone, string email, DateTime? dataNascimento)
        {
            Id = Guid.NewGuid();
            EmpresaId = empresaId;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
        }
    }
}