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
    [Migration("20220820033602_Teste")]
    partial class Teste
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Email", b =>
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

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Endereco", b =>
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

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Matricula", b =>
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

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Mensalidade", b =>
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

                    b.Property<int>("ValoresModalidadeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMatricula");

                    b.HasIndex("ValoresModalidadeId");

                    b.ToTable("Mensalidades");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Pessoa", b =>
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

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("ProductId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Telefone", b =>
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

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Email", b =>
                {
                    b.HasOne("ProjetoVillaBeach.Entities.Pessoa", "Pessoa")
                        .WithMany("Email")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Endereco", b =>
                {
                    b.HasOne("ProjetoVillaBeach.Entities.Pessoa", "Pessoa")
                        .WithMany("Enderecos")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Matricula", b =>
                {
                    b.HasOne("ProjetoVillaBeach.Entities.Course", "Modalidade")
                        .WithMany("Matriculas")
                        .HasForeignKey("IdModalidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoVillaBeach.Entities.Pessoa", "Pessoa")
                        .WithMany("Matriculas")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modalidade");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Mensalidade", b =>
                {
                    b.HasOne("ProjetoVillaBeach.Entities.Matricula", "Matricula")
                        .WithMany("Mensalidades")
                        .HasForeignKey("IdMatricula")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoVillaBeach.Entities.Price", "ValoresModalidade")
                        .WithMany()
                        .HasForeignKey("ValoresModalidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Matricula");

                    b.Navigation("ValoresModalidade");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Price", b =>
                {
                    b.HasOne("ProjetoVillaBeach.Entities.Course", null)
                        .WithMany("Prices")
                        .HasForeignKey("CourseId");

                    b.HasOne("ProjetoVillaBeach.Entities.Product", null)
                        .WithMany("Prices")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Telefone", b =>
                {
                    b.HasOne("ProjetoVillaBeach.Entities.Pessoa", "Pessoa")
                        .WithMany("Telefones")
                        .HasForeignKey("IdPessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Course", b =>
                {
                    b.Navigation("Matriculas");

                    b.Navigation("Prices");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Matricula", b =>
                {
                    b.Navigation("Mensalidades");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Pessoa", b =>
                {
                    b.Navigation("Email");

                    b.Navigation("Enderecos");

                    b.Navigation("Matriculas");

                    b.Navigation("Telefones");
                });

            modelBuilder.Entity("ProjetoVillaBeach.Entities.Product", b =>
                {
                    b.Navigation("Prices");
                });
#pragma warning restore 612, 618
        }
    }
}
