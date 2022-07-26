using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace ProjetoVillaBeach.Classes
{
    internal class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Mensalidade> Mensalidades { get; set; }
        public DbSet<ValoresModalidade> ValoresModalidades { get; set; }

        //private string connectionString = ConfigurationManager.ConnectionStrings["Conection"].ConnectionString;

        private string connectionString = "server =localhost;port=3306;database=EFCoreMySQL;user=root;password=1234";
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MariaDbServerVersion(new Version(10, 6, 7));
            optionsBuilder.UseMySql(connectionString, serverVersion);
            optionsBuilder.ConfigureWarnings(w => w.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning));
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Pessoa
            modelBuilder.Entity<Pessoa>()
                .HasIndex(u => u.NumeroCpf)
                   .IsUnique();

            modelBuilder.Entity<Pessoa>()
                .HasMany<Endereco>(c => c.Enderecos)
                    .WithOne(e => e.Pessoa)
                        .HasForeignKey(e => e.IdEndereco);

            modelBuilder.Entity<Pessoa>()
                .HasMany<Email>(c => c.Email)
                    .WithOne(e => e.Pessoa)
                        .HasForeignKey(e => e.IdPessoa);

            modelBuilder.Entity<Pessoa>()
                .HasMany<Telefone>(c => c.Telefones)
                    .WithOne(e => e.Pessoa)
                        .HasForeignKey(e => e.IdPessoa);

            modelBuilder.Entity<Pessoa>()
                .HasMany<Matricula>(c => c.Matriculas)
                    .WithOne(e => e.Pessoa)
                        .HasForeignKey(e => e.IdPessoa);

            // Endereço
            modelBuilder.Entity<Endereco>()
               .HasOne(e => e.Pessoa)
                    .WithMany(c => c.Enderecos)
                        .HasForeignKey(e => e.IdPessoa);

            // Email
            modelBuilder.Entity<Email>()
               .HasOne<Pessoa>(e => e.Pessoa)
                    .WithMany(c => c.Email)
                        .HasForeignKey(e => e.IdPessoa);

            // Telefone
            modelBuilder.Entity<Telefone>()
               .HasOne<Pessoa>(e => e.Pessoa)
                    .WithMany(c => c.Telefones)
                        .HasForeignKey(e => e.IdPessoa);

            // Matricula
            modelBuilder.Entity<Matricula>()
               .HasOne<Pessoa>(e => e.Pessoa)
                    .WithMany(c => c.Matriculas)
                        .HasForeignKey(e => e.IdPessoa);

            modelBuilder.Entity<Matricula>()
               .HasOne<Modalidade>(e => e.Modalidade)
                    .WithMany(c => c.Matriculas)                    
                        .HasForeignKey(e => e.IdModalidade);

            modelBuilder.Entity<Matricula>()
               .HasMany<Mensalidade>(c => c.Mensalidades)
                    .WithOne(e => e.Matricula)
                        .HasForeignKey(e => e.IdMensalidade);

            // Modalidade
            modelBuilder.Entity<Modalidade>()
               .HasMany<ValoresModalidade>(c => c.ValoresModalidades)
                    .WithOne(e => e.Modalidade)
                        .HasForeignKey(e => e.IdModalidade);

            // ValoresModalidade
            modelBuilder.Entity<ValoresModalidade>()
               .HasOne<Modalidade>(c => c.Modalidade)
                    .WithMany(e => e.ValoresModalidades)
                        .HasForeignKey(c => c.IdModalidade);

            // Mensalidade
            modelBuilder.Entity<Mensalidade>()
               .HasOne<Matricula>(c => c.Matricula)
                    .WithMany(e => e.Mensalidades)
                        .HasForeignKey(c => c.IdMatricula);

            modelBuilder.Entity<Mensalidade>()
               .HasOne<ValoresModalidade>(c => c.ValoresModalidade)
                    .WithMany(e => e.Mensalidades)
                        .HasForeignKey(c => c.IdValorModalidade);


        }
    }
}
