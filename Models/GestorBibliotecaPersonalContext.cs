using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstScaffold.Models;

public partial class GestorBibliotecaPersonalContext : DbContext
{
    public GestorBibliotecaPersonalContext()
    {
    }

    public GestorBibliotecaPersonalContext(DbContextOptions<GestorBibliotecaPersonalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<GbpAlmCatLibro> GbpAlmCatLibros { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=PostgresConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GbpAlmCatLibro>(entity =>
        {
            entity.HasKey(e => e.IdLibro).HasName("gbp_alm_cat_libros_pkey");

            entity.ToTable("gbp_alm_cat_libros", "gbp_almacen");

            entity.Property(e => e.IdLibro).HasColumnName("id_libro");
            entity.Property(e => e.Autor)
                .HasColumnType("character varying")
                .HasColumnName("autor");
            entity.Property(e => e.Edicion).HasColumnName("edicion");
            entity.Property(e => e.Isbn)
                .HasColumnType("character varying")
                .HasColumnName("isbn");
            entity.Property(e => e.Titulo)
                .HasColumnType("character varying")
                .HasColumnName("titulo");
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.ToTable("Generos", "gbp_almacen");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
