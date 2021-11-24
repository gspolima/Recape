﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recape.Data;

#nullable disable

namespace Recape.Data.Migrations
{
    [DbContext(typeof(RecapeDbContext))]
    [Migration("20211124201953_Extend_IdentityUser_Usuario")]
    partial class Extend_IdentityUser_Usuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Recape.Models.Agendamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHorario")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.Property<string>("PacienteId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("Recape.Models.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OrdemDeServicoId")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("OrdemDeServicoId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("Recape.Models.Especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Especialidades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Pediatria"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Cardiologia"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Pneumologia"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Clínica Geral"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Oftalmologia"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Ortopedia"
                        });
                });

            modelBuilder.Entity("Recape.Models.Horario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<TimeOnly>("HoraDoDia")
                        .HasColumnType("time(6)");

                    b.HasKey("Id");

                    b.ToTable("Horarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HoraDoDia = new TimeOnly(8, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            HoraDoDia = new TimeOnly(9, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            HoraDoDia = new TimeOnly(10, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            HoraDoDia = new TimeOnly(11, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            HoraDoDia = new TimeOnly(12, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            HoraDoDia = new TimeOnly(13, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            HoraDoDia = new TimeOnly(14, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            HoraDoDia = new TimeOnly(15, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            HoraDoDia = new TimeOnly(16, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            HoraDoDia = new TimeOnly(17, 0, 0)
                        });
                });

            modelBuilder.Entity("Recape.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EspecialidadeId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadeId");

                    b.ToTable("Medicos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EspecialidadeId = 1,
                            Nome = "Dra. Adama Cadaval"
                        },
                        new
                        {
                            Id = 2,
                            EspecialidadeId = 2,
                            Nome = "Dr. Raúl Abelho"
                        },
                        new
                        {
                            Id = 3,
                            EspecialidadeId = 4,
                            Nome = "Dr. Ismael Veleda"
                        },
                        new
                        {
                            Id = 4,
                            EspecialidadeId = 2,
                            Nome = "Dr. Alberto Mourão"
                        },
                        new
                        {
                            Id = 5,
                            EspecialidadeId = 6,
                            Nome = "Dr. Teófilo Saldanha"
                        },
                        new
                        {
                            Id = 6,
                            EspecialidadeId = 7,
                            Nome = "Dr. Rúben Medeiros"
                        },
                        new
                        {
                            Id = 7,
                            EspecialidadeId = 2,
                            Nome = "Dra. Adriana Rosário"
                        },
                        new
                        {
                            Id = 8,
                            EspecialidadeId = 5,
                            Nome = "Dr. Arthur Nazário"
                        });
                });

            modelBuilder.Entity("Recape.Models.OrdemDeServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Avaliado")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Cancelado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("ClienteId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateOnly>("Data")
                        .HasColumnType("date");

                    b.Property<bool>("Finalizado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<int>("HorarioId")
                        .HasColumnType("int");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.Property<string>("Total")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("HorarioId");

                    b.HasIndex("ServicoId");

                    b.ToTable("OrdensDeServico");
                });

            modelBuilder.Entity("Recape.Models.Poltrona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("tinyint(1)");

                    b.Property<byte>("Numero")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("ViagemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ViagemId");

                    b.ToTable("Poltronas");
                });

            modelBuilder.Entity("Recape.Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClienteId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("PoltronaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PoltronaId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Recape.Models.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal>("Valor")
                        .HasPrecision(7, 2)
                        .HasColumnType("decimal(7,2)");

                    b.HasKey("Id");

                    b.ToTable("Servicos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Troca de Óleo",
                            Valor = 249.99m
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Alinhamento",
                            Valor = 129.99m
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Funilaria",
                            Valor = 199.99m
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Pintura",
                            Valor = 179.99m
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Serviços de Reparo Geral",
                            Valor = 309.99m
                        });
                });

            modelBuilder.Entity("Recape.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Recape.Models.Viagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPartida")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<float>("DuracaoEmHoras")
                        .HasColumnType("float");

                    b.Property<string>("Origem")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Viagens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataPartida = new DateTime(2021, 12, 25, 16, 20, 0, 0, DateTimeKind.Unspecified),
                            Destino = "Recife",
                            DuracaoEmHoras = 28f,
                            Origem = "Fortaleza",
                            Preco = 120.0
                        },
                        new
                        {
                            Id = 2,
                            DataPartida = new DateTime(2022, 10, 23, 6, 0, 0, 0, DateTimeKind.Unspecified),
                            Destino = "Juazeiro do Norte",
                            DuracaoEmHoras = 20f,
                            Origem = "Fortaleza",
                            Preco = 90.0
                        },
                        new
                        {
                            Id = 3,
                            DataPartida = new DateTime(2022, 11, 2, 22, 30, 0, 0, DateTimeKind.Unspecified),
                            Destino = "Belo Horizonte",
                            DuracaoEmHoras = 24f,
                            Origem = "Salvador",
                            Preco = 100.0
                        },
                        new
                        {
                            Id = 4,
                            DataPartida = new DateTime(2022, 2, 15, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            Destino = "Brasília",
                            DuracaoEmHoras = 36f,
                            Origem = "Porto Alegre",
                            Preco = 180.0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Recape.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Recape.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recape.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Recape.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Recape.Models.Agendamento", b =>
                {
                    b.HasOne("Recape.Models.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recape.Models.Usuario", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Recape.Models.Comentario", b =>
                {
                    b.HasOne("Recape.Models.OrdemDeServico", "OrdemDeServico")
                        .WithMany("Comentarios")
                        .HasForeignKey("OrdemDeServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrdemDeServico");
                });

            modelBuilder.Entity("Recape.Models.Medico", b =>
                {
                    b.HasOne("Recape.Models.Especialidade", "Especialidade")
                        .WithMany()
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidade");
                });

            modelBuilder.Entity("Recape.Models.OrdemDeServico", b =>
                {
                    b.HasOne("Recape.Models.Usuario", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Recape.Models.Horario", "Horario")
                        .WithMany()
                        .HasForeignKey("HorarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Recape.Models.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Horario");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("Recape.Models.Poltrona", b =>
                {
                    b.HasOne("Recape.Models.Viagem", "Viagem")
                        .WithMany("Poltronas")
                        .HasForeignKey("ViagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Viagem");
                });

            modelBuilder.Entity("Recape.Models.Reserva", b =>
                {
                    b.HasOne("Recape.Models.Usuario", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Recape.Models.Poltrona", "Poltrona")
                        .WithMany()
                        .HasForeignKey("PoltronaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Poltrona");
                });

            modelBuilder.Entity("Recape.Models.OrdemDeServico", b =>
                {
                    b.Navigation("Comentarios");
                });

            modelBuilder.Entity("Recape.Models.Viagem", b =>
                {
                    b.Navigation("Poltronas");
                });
#pragma warning restore 612, 618
        }
    }
}
