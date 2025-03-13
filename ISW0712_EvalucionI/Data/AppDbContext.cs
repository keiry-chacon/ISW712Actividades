using ISW0712_EvalucionI.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace ISW0712_EvalucionI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<AppEventLog> EventLogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppEventLog>().ToTable("EventLogs"); 

            modelBuilder.Entity<Estudiante>()
                .ToTable("estudiante", "evaluacion1");

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Cedula)
                .HasColumnName("cedula");

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Nombre)
                .HasColumnName("nombre");

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Apellido1)
                .HasColumnName("apellido1");

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Apellido2)
                .HasColumnName("apellido2");

            // Configuración para el enum Sexo
            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Sexo)
                .HasColumnName("sexo")
                .HasConversion<string>();

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Estado)
                .HasColumnName("estado")
                 .HasConversion<string>();

            modelBuilder.Entity<Estudiante>()
                .HasKey(e => e.Id)
                .HasName("pk_estudiante");

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

            // Configuración para la entidad Matricula
            modelBuilder.Entity<Matricula>()
                .ToTable("matricula", "evaluacion1");

            modelBuilder.Entity<Matricula>()
                .Property(m => m.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Matricula>()
                .Property(m => m.Fecha)
                .HasColumnName("fecha");

            modelBuilder.Entity<Matricula>()
                .Property(m => m.EstudianteId)
                .HasColumnName("estudiante_id");

            modelBuilder.Entity<Matricula>()
                .HasKey(m => m.Id)
                .HasName("pk_matricula");

            modelBuilder.Entity<Matricula>()
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            // Configuración de la relación entre Matricula y Estudiante
            modelBuilder.Entity<Matricula>()
                .HasOne(m => m.Estudiante)
                .WithMany()
                .HasForeignKey(m => m.EstudianteId)
                .HasConstraintName("fk_matricula_estudiante");
        }
    }
}
