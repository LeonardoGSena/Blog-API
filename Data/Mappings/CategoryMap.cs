using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        //Tabela
        builder.ToTable("Category");

        //Chave primaria
        builder.HasKey(x => x.Id);

        //Identity
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn(); //primary key identity(1, 1)

        //Propriedades

        builder.Property(x => x.Name)
            .IsRequired() //notnull in database
            .HasColumnName("Name")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.Slug)
            .IsRequired() //notnull in database
            .HasColumnName("Slug")
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        //Índices
        builder.HasIndex(x => x.Slug, "IX_Category_Slug")
            .IsUnique();
    }
}