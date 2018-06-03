using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Externos.ModelosNuevosBaseExterna
{
    public partial class Ejemplo94Context : DbContext
    {
        public virtual DbSet<Persona> Persona { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=Ejemplo94.mssql.somee.com;Database=Ejemplo94;User Id=Alex_Adriano_SQLLogin_1;password=thp94lf723;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.Property(e => e.Apelllidos)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres).HasColumnType("nchar(250)");
            });
        }
    }
}
