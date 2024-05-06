using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)        {
            
        }

        public DbSet<EmprestimosModel> Emprestimos { get; set; }
    }
}
