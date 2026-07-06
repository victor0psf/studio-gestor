using Microsoft.EntityFrameworkCore;
using StudioGestor.Domain;
using StudioGestor.Domain.Entities;

namespace StudioGestor.Data.Context;

public class StudioGestorDbContext : DbContext
{
    public StudioGestorDbContext(DbContextOptions<StudioGestorDbContext> options) : base(options) { }

    public DbSet<Empresa> Empresas { get; set; } = null!;
    public DbSet<Cliente> Clientes { get; set; } = null!;
    public DbSet<Profissional> Profissionais { get; set; } = null!;
    public DbSet<Servico> Servicos { get; set; } = null!;
    public DbSet<Agendamento> Agendamentos { get; set; } = null!;
    public DbSet<AgendamentoServico> AgendamentoServicos { get; set; } = null!;
    public DbSet<MovimentacaoFinanceira> MovimentacoesFinanceiras { get; set; } = null!;
    public DbSet<Plano> Planos { get; set; } = null!;
    public DbSet<Assinatura> Assinaturas { get; set; } = null!;

}


