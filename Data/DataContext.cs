using LivrosAPP.Model;
using LivrosAPP.Service.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LivrosAPP.Service.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Autor> Autores {  get; set; }
        public DbSet<Livro> Livros { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LivroApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorMap());
            modelBuilder.ApplyConfiguration(new LivroMap());
        }
    }
}
