using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Data.Entities
{
    public partial class worldtrainer : DbContext
    {
        public worldtrainer()
            : base("name=worldtrainer")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Trainer_Details> Trainer_Details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Skill>()
                .Property(e => e.Skills)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .HasMany(e => e.Skills)
                .WithOptional(e => e.Trainer)
                .HasForeignKey(e => e.Trainer_Id);

            modelBuilder.Entity<Trainer>()
                .HasMany(e => e.Trainer_Details)
                .WithOptional(e => e.Trainer)
                .HasForeignKey(e => e.Trainer_Id);

            modelBuilder.Entity<Trainer_Details>()
                .Property(e => e.Qualification)
                .IsUnicode(false);
        }
    }
}
