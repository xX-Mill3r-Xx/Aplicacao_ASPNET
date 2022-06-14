using Microsoft.EntityFrameworkCore;
using WebLearn.Models;

namespace WebLearn.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Cadastro> Cadastros { get; set; }
    }
}
