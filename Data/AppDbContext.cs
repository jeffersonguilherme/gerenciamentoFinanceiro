using Microsoft.EntityFrameworkCore;

namespace gerenciamentoFinanceiro.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    
}