using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioGestor.Domain.Entities
{
    public class Servico
    {
        public Guid Id { get; private set; }
        public Guid EmpresaId { get; private set; }

        public string Nome { get; private set; } = null!;
        public string Descricao { get; private set; } = null!;
        public decimal Valor { get; private set; } = 0;
        public int? DuracaoMinutos { get; private set; }
        public bool Ativo { get; private set; }


        public Empresa Empresa { get; private set; } = null!;

        protected Servico() { }
        public Servico(Guid empresaId, string nome, string descricao, decimal valor, int duracaoMinutos)
        {
            Id = Guid.NewGuid();
            EmpresaId = empresaId;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            DuracaoMinutos = duracaoMinutos;
            Ativo = true;
        }

        public void Inativar()
        {
            Ativo = false;
        }

        public void AlterarValor(decimal novoValor)
        {
            Valor = novoValor;
        }
    }
}