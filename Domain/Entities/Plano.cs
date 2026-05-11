using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioGestor.Domain.Entities
{
    public class Plano
    {
        public Guid Id { get; private set; }

        public string Nome { get; private set; } = null!;
        public string Descricao { get; private set; } = null!;
        public decimal ValorMensal { get; private set; } = 0;

        public int LimiteClientes { get; private set; } = 0;
        public int LimiteProfissionais { get; private set; } = 0;
        public bool PermiteFinanceiro { get; private set; } = false;
        public bool PermiteRelatorios { get; private set; } = false;

        public bool Ativo { get; private set; }

        protected Plano() { }

        public Plano(string nome, string descricao, decimal valorMensal, int limiteClientes, int limiteProfissionais, bool permiteFinanceiro, bool permiteRelatorios)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Descricao = descricao;
            ValorMensal = valorMensal;
            LimiteClientes = limiteClientes;
            LimiteProfissionais = limiteProfissionais;
            PermiteFinanceiro = permiteFinanceiro;
            PermiteRelatorios = permiteRelatorios;
            Ativo = true;
        }
    }
}