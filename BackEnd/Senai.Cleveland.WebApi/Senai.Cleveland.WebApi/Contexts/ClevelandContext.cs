using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Senai.Cleveland.WebApi.Domains
{
    public partial class ClevelandContext : DbContext
    {
        public ClevelandContext()
        {
        }

        public ClevelandContext(DbContextOptions<ClevelandContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Medicos> Medicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=Cleveland;User Id=sa;Pwd=132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medicos>(entity =>
            {
                entity.HasKey(e => e.IdMedico);

                entity.HasIndex(e => e.Crm)
                    .HasName("UQ__Medicos__D836F7D188622D2D")
                    .IsUnique();

                entity.Property(e => e.Crm).HasColumnName("crm");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(99)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Ativo')");

                entity.Property(e => e.Nascimento)
                    .HasColumnName("nascimento")
                    .HasColumnType("date");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });
        }
    }
}
