﻿// <auto-generated />
using System;
using MiSalud.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MiSalud.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiagnosticoHistoriaClinica", b =>
                {
                    b.Property<int>("DiagnosticosId")
                        .HasColumnType("int");

                    b.Property<int>("HistoriasClinicasId")
                        .HasColumnType("int");

                    b.HasKey("DiagnosticosId", "HistoriasClinicasId");

                    b.HasIndex("HistoriasClinicasId");

                    b.ToTable("DiagnosticoHistoriaClinica");
                });

            modelBuilder.Entity("FormulaHistoriaClinica", b =>
                {
                    b.Property<int>("FormulaId")
                        .HasColumnType("int");

                    b.Property<int>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.HasKey("FormulaId", "HistoriaClinicaId");

                    b.HasIndex("HistoriaClinicaId");

                    b.ToTable("FormulaHistoriaClinica");
                });

            modelBuilder.Entity("FormulaMedicamento", b =>
                {
                    b.Property<int>("FormulaId")
                        .HasColumnType("int");

                    b.Property<int>("MedicamentoId")
                        .HasColumnType("int");

                    b.HasKey("FormulaId", "MedicamentoId");

                    b.HasIndex("MedicamentoId");

                    b.ToTable("FormulaMedicamento");
                });

            modelBuilder.Entity("MiSalud.API.Models.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Hora")
                        .HasColumnType("time");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("MiSalud.API.Models.Diagnostico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.ToTable("Diagnosticos");
                });

            modelBuilder.Entity("MiSalud.API.Models.Formula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("Formulas");
                });

            modelBuilder.Entity("MiSalud.API.Models.HistoriaClinica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("HistoriasClinicas");
                });

            modelBuilder.Entity("MiSalud.API.Models.Medicamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Dosis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frecuencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medicamentos");
                });

            modelBuilder.Entity("MiSalud.API.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistroId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator().HasValue("Persona");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MiSalud.API.Models.Medico", b =>
                {
                    b.HasBaseType("MiSalud.API.Models.Persona");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("MiSalud.API.Models.Paciente", b =>
                {
                    b.HasBaseType("MiSalud.API.Models.Persona");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("MiSalud.API.Models.Secretaria", b =>
                {
                    b.HasBaseType("MiSalud.API.Models.Persona");

                    b.HasDiscriminator().HasValue("Secretaria");
                });

            modelBuilder.Entity("DiagnosticoHistoriaClinica", b =>
                {
                    b.HasOne("MiSalud.API.Models.Diagnostico", null)
                        .WithMany()
                        .HasForeignKey("DiagnosticosId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MiSalud.API.Models.HistoriaClinica", null)
                        .WithMany()
                        .HasForeignKey("HistoriasClinicasId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("FormulaHistoriaClinica", b =>
                {
                    b.HasOne("MiSalud.API.Models.Formula", null)
                        .WithMany()
                        .HasForeignKey("FormulaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MiSalud.API.Models.HistoriaClinica", null)
                        .WithMany()
                        .HasForeignKey("HistoriaClinicaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("FormulaMedicamento", b =>
                {
                    b.HasOne("MiSalud.API.Models.Formula", null)
                        .WithMany()
                        .HasForeignKey("FormulaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MiSalud.API.Models.Medicamento", null)
                        .WithMany()
                        .HasForeignKey("MedicamentoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("MiSalud.API.Models.Cita", b =>
                {
                    b.HasOne("MiSalud.API.Models.Medico", "Medico")
                        .WithMany("Citas")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MiSalud.API.Models.Paciente", "Paciente")
                        .WithMany("Citas")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("MiSalud.API.Models.Diagnostico", b =>
                {
                    b.HasOne("MiSalud.API.Models.Medico", "Medico")
                        .WithMany("Diagnosticos")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("MiSalud.API.Models.Formula", b =>
                {
                    b.HasOne("MiSalud.API.Models.Paciente", "Paciente")
                        .WithMany("Formulas")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("MiSalud.API.Models.HistoriaClinica", b =>
                {
                    b.HasOne("MiSalud.API.Models.Paciente", "Paciente")
                        .WithMany("HistoriasClinicas")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("MiSalud.API.Models.Medico", b =>
                {
                    b.Navigation("Citas");

                    b.Navigation("Diagnosticos");
                });

            modelBuilder.Entity("MiSalud.API.Models.Paciente", b =>
                {
                    b.Navigation("Citas");

                    b.Navigation("Formulas");

                    b.Navigation("HistoriasClinicas");
                });
#pragma warning restore 612, 618
        }
    }
}
