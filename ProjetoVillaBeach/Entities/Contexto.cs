using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProjetoVillaBeach.Entities.Base;
using ProjetoVillaBeach.Entities.Documents;
using ProjetoVillaBeach.Classes.Documents;

namespace ProjetoVillaBeach.Entities
{
    internal class Contexto : DbContext
    {
        public DbSet<Person> Peoples { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Mensalidade> Mensalidades { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cpf> Cpfs { get; set; }
        public DbSet<Rg> Rgs { get; set; }
        public DbSet<CivilRegistrationNew> CivilRegistrationNews { get; set; }
        public DbSet<CivilRegistrationOld> CivilRegistrationOlds { get; set; }


        //private string connectionString = ConfigurationManager.ConnectionStrings["Conection"].ConnectionString;

        private readonly string connectionString = "server =localhost;port=3306;database=EFCoreMySQL;user=root;password=1234";

        public Contexto()
        {
            ChangeTracker.StateChanged += OnEntityStateChanged;
            ChangeTracker.Tracked += OnTracked;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MariaDbServerVersion(new Version(10, 6, 7));
            optionsBuilder.UseMySql(connectionString, serverVersion);
            optionsBuilder.ConfigureWarnings(w => w.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning));
            optionsBuilder.UseLazyLoadingProxies();
        }

        private void OnTracked(object? sender, EntityTrackedEventArgs? e)
        {
            var baseClass = (BaseClass)e.Entry.Entity;

            switch (baseClass.ObjectState)
            {
                case EntityObjectState.Added:
                    e.Entry.State = EntityState.Added;
                    break;
                case EntityObjectState.Modified:
                    e.Entry.State = EntityState.Modified;
                    break;
                case EntityObjectState.Deleted:
                    e.Entry.State = EntityState.Deleted;
                    break;
                default:
                    e.Entry.State = EntityState.Unchanged;
                    break;
            }
        }

        private void OnEntityStateChanged(object? sender, EntityStateChangedEventArgs? e)
        {
            var baseClass = (BaseClass)e.Entry.Entity;

            switch (e.NewState)
            {
                case EntityState.Added:
                    baseClass.ObjectState = EntityObjectState.Added;
                    break;
                case EntityState.Modified:
                    baseClass.ObjectState = EntityObjectState.Modified;
                    break;
                case EntityState.Deleted:
                    baseClass.ObjectState = EntityObjectState.Deleted;
                    break;
                case EntityState.Unchanged:
                    baseClass.ObjectState = EntityObjectState.Unchanged;
                    break;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Pessoa

            modelBuilder.Entity<Person>()
                .HasMany<Endereco>(c => c.Enderecos)
                    .WithOne(e => e.Pessoa)
                        .HasForeignKey(e => e.Id);

            modelBuilder.Entity<Person>()
                .HasMany<Email>(c => c.Email)
                    .WithOne(e => e.Pessoa)
                        .HasForeignKey(e => e.IdPessoa);

            modelBuilder.Entity<Person>()
                .HasMany<Telefone>(c => c.Telefones)
                    .WithOne(e => e.Pessoa)
                        .HasForeignKey(e => e.IdPessoa);

            modelBuilder.Entity<Person>()
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
               .HasOne<Person>(e => e.Pessoa)
                    .WithMany(c => c.Email)
                        .HasForeignKey(e => e.IdPessoa);

            // Telefone
            modelBuilder.Entity<Telefone>()
               .HasOne<Person>(e => e.Pessoa)
                    .WithMany(c => c.Telefones)
                        .HasForeignKey(e => e.IdPessoa);

            // Matricula
            modelBuilder.Entity<Matricula>()
               .HasOne<Person>(e => e.Pessoa)
                    .WithMany(c => c.Matriculas)
                        .HasForeignKey(e => e.IdPessoa);

            modelBuilder.Entity<Matricula>()
               .HasOne<Course>(e => e.Modalidade)
                    .WithMany(c => c.Matriculas)
                        .HasForeignKey(e => e.IdModalidade);

            modelBuilder.Entity<Matricula>()
               .HasMany<Mensalidade>(c => c.Mensalidades)
                    .WithOne(e => e.Matricula)
                        .HasForeignKey(e => e.Id);


            // Price
            modelBuilder.Entity<Price>()
               .Property(p => p.Value)
                    .HasPrecision(10, 2);


            // Mensalidade
            modelBuilder.Entity<Mensalidade>()
               .HasOne<Matricula>(c => c.Matricula)
                    .WithMany(e => e.Mensalidades)
                        .HasForeignKey(c => c.IdMatricula);
        }
    }
}
