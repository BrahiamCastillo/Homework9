using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Homework9.Models
{
    public partial class vaccinesContext : DbContext
    {

        public vaccinesContext(DbContextOptions<vaccinesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Sangre> Sangre { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SangreId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.HasIndex(e => e.SangreId)
                    .HasName("fk_Persona_Sangre_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SangreId)
                    .HasColumnName("Sangre_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasColumnName("apellido")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasColumnName("cedula")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasColumnName("correo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Covid)
                    .HasColumnName("covid")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fecha_nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.Justificacion)
                    .IsRequired()
                    .HasColumnName("justificacion")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasColumnName("provincia")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.Sangre)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.SangreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Persona_Sangre");
            });

            modelBuilder.Entity<Sangre>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoSangre)
                    .IsRequired()
                    .HasColumnName("tipo_sangre")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                Id = 1,
                TipoSangre = "O+",
            }
            );

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                Id = 2,
                TipoSangre = "O-",
            }
            );

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                Id = 3,
                TipoSangre = "A+",
            }
            );

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                Id = 4,
                TipoSangre = "A-",
            }
            );

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                Id = 5,
                TipoSangre = "B+",
            }
            );

             modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                Id = 6,
                TipoSangre = "B-",
            }
            );

             modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                Id = 7,
                TipoSangre = "AB+",
            }
            );

            modelBuilder.Entity<Sangre>().HasData(
            new Sangre
            {
                Id = 8,
                TipoSangre = "AB-",
            }
            );

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
