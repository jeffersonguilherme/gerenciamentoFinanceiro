using Microsoft.EntityFrameworkCore;

namespace GerenciamentoFinanceiro.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}