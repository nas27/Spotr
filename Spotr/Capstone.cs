namespace Spotr
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Capstone : DbContext
    {
        public Capstone()
            : base("name=Capstone")
        {
        }

        public virtual DbSet<Exercis> Exercises { get; set; }
        public virtual DbSet<Specialty> Specialties { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Workout> Workouts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Specialty>()
                .HasMany(e => e.Trainers)
                .WithRequired(e => e.Specialty1)
                .HasForeignKey(e => e.Specialties_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trainer>()
                .HasMany(e => e.Workouts)
                .WithRequired(e => e.Trainer)
                .HasForeignKey(e => e.Trainer_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Workouts)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Workout>()
                .HasMany(e => e.Exercises)
                .WithRequired(e => e.Workout)
                .HasForeignKey(e => e.Workout_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
