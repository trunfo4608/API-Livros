using LivrosAPP.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrosAPP.Service.Mapping
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("LIVRO");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.Id)
                .HasColumnName("ID");


            builder.Property(l => l.Genero)
                .HasColumnName("GENERO")
                .HasMaxLength(50)
                .IsRequired();


            builder.Property(l => l.Editora)
                .HasColumnName("EDITORA")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(l => l.Titulo)
                .HasColumnName("TITULO")
                .HasMaxLength(100)
                .IsRequired();


            builder.Property(l => l.Valor)
                .HasColumnName("VAlOR")
                .HasColumnType("decimal(10,2)")
                .IsRequired();


            builder.Property(l => l.AutorId)
                .HasColumnName("AUTORID")
                .IsRequired();

        }
    }
}
