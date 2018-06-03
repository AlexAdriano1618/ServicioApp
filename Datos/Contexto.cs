using Entidades.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Persona { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);



            //modelBuilder.Entity<Persona>(entity =>
            //{
            //    entity.HasKey(e => e.IdPersona);

            //    entity.Property(e => e.IdPersona).ValueGeneratedNever();

            //    entity.Property(e => e.Apellido)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Cedula)
            //        .IsRequired()
            //        .HasMaxLength(13)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Nombre)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);
            //});

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

                entity.Property(e => e.Nombres)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //if (!optionsBuilder.IsConfigured)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-O4FI1U6;Database=mibase;User Id=sa;password=16deenero2015;MultipleActiveResultSets=true");
        //}
        //}
        public void EnsureSeedData()
        {

        }
    }
}
