using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioGestor.Domain.Entities
{
    public class Empresa
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; } = null!;
        public string Documento { get; private set; } = null!;
        public string Telefone { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public string Endereco { get; private set; } = null!;

        // Relacionamentos 
        public ICollection<Cliente> Clientes { get; private set; } = [];
        public ICollection<Profissional> Profissionais { get; private set; } = [];
        public ICollection<Servico> Servicos { get; private set; } = [];


        protected Empresa() { }
        public Empresa(string nome, string documento, string telefone, string email, string endereco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Documento = documento;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
        }
    }
}