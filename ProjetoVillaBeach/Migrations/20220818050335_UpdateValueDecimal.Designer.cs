﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoVillaBeach.Entities;

#nullable disable

namespace ProjetoVillaBeach.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220818050335_UpdateValueDecimal")]
    partial class UpdateValueDecimal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int");

                    b.Property<string>("Obs")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Endereco", b =>
                {
                    b.Property<int>("Id")
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

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Matricula", b =>
                {
                    b.Property<int>("Id")
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

                    b.HasKey("Id");

                    b.HasIndex("IdModalidade");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Mensalidade", b =>
                {
                    b.Property<int>("Id")
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

                    b.HasKey("Id");

                    b.HasIndex("IdMatricula");

                    b.HasIndex("IdValorModalidade");

                    b.ToTable("Mensalidades");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Modalidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFinal")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicial")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Observacao")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Modalidades");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataDeCadastro")
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
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("NumeroRg")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPessoa")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Obs")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdPessoa");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Classes.ValoresModalidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdModalidade")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

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
