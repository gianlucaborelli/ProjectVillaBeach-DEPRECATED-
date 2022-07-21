﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoVillaBeach.Classes;

namespace ProjetoVillaBeach.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Email", b =>
                {
                    b.Property<int>("IdEmail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdEmail");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cep")
                        .HasColumnType("longtext");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int");

                    b.Property<string>("Localidade")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<string>("Obs")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Uf")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.HasKey("IdEndereco");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Matricula", b =>
                {
                    b.Property<int>("IdMatricula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdModalidade")
                        .HasColumnType("int");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int");

                    b.HasKey("IdMatricula");

                    b.HasIndex("IdModalidade");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Mensalidade", b =>
                {
                    b.Property<int>("IdMensalidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataGerada")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdMatricula")
                        .HasColumnType("int");

                    b.Property<int>("IdValorModalidade")
                        .HasColumnType("int");

                    b.HasKey("IdMensalidade");

                    b.HasIndex("IdMatricula");

                    b.HasIndex("IdValorModalidade");

                    b.ToTable("Mensalidades");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Modalidade", b =>
                {
                    b.Property<int>("IdModalidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFinal")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataInicial")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Observacao")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdModalidade");

                    b.ToTable("Modalidades");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Pessoa", b =>
                {
                    b.Property<int>("IdPessoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataDeNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Filiacao1")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Filiacao2")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<ulong?>("NumeroCpf")
                        .IsRequired()
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("NumeroRg")
                        .HasColumnType("longtext");

                    b.HasKey("IdPessoa");

                    b.HasIndex("NumeroCpf")
                        .IsUnique();

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Telefone", b =>
                {
                    b.Property<int>("IdTelefone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdTelefone");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.ValoresModalidade", b =>
                {
                    b.Property<int>("IdValoresModalidades")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdModalidade")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("IdValoresModalidades");

                    b.HasIndex("IdModalidade");

                    b.ToTable("ValoresModalidades");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Email", b =>
                {
                    b.HasOne("ProjetoVillaBeach.Classes.Pessoa", "Pessoa")
                        .WithMany("Email")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Endereco", b =>
                {
                    b.HasOne("ProjetoVillaBeach.Classes.Pessoa", "Pessoa")
                        .WithMany("Enderecos")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Matricula", b =>
                {
                    b.HasOne("ProjetoVillaBeach.Classes.Modalidade", "Modalidade")
                        .WithMany("Matriculas")
                        .HasForeignKey("IdModalidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoVillaBeach.Classes.Pessoa", "Pessoa")
                        .WithMany("Matriculas")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modalidade");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Mensalidade", b =>
                {
                    b.HasOne("ProjetoVillaBeach.Classes.Matricula", "Matricula")
                        .WithMany("Mensalidades")
                        .HasForeignKey("IdMatricula")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoVillaBeach.Classes.ValoresModalidade", "ValoresModalidade")
                        .WithMany("Mensalidades")
                        .HasForeignKey("IdValorModalidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Matricula");

                    b.Navigation("ValoresModalidade");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Telefone", b =>
                {
                    b.HasOne("ProjetoVillaBeach.Classes.Pessoa", "Pessoa")
                        .WithMany("Telefones")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.ValoresModalidade", b =>
                {
                    b.HasOne("ProjetoVillaBeach.Classes.Modalidade", "Modalidade")
                        .WithMany("ValoresModalidades")
                        .HasForeignKey("IdModalidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modalidade");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Matricula", b =>
                {
                    b.Navigation("Mensalidades");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Modalidade", b =>
                {
                    b.Navigation("Matriculas");

                    b.Navigation("ValoresModalidades");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Pessoa", b =>
                {
                    b.Navigation("Email");

                    b.Navigation("Enderecos");

                    b.Navigation("Matriculas");

                    b.Navigation("Telefones");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.ValoresModalidade", b =>
                {
                    b.Navigation("Mensalidades");
                });
#pragma warning restore 612, 618
        }
    }
}
