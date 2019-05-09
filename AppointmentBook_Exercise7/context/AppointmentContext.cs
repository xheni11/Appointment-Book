namespace AppointmentBook_Exercise7
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppointmentContext : DbContext
    {
        public AppointmentContext()
            : base("name=AppointmentContext")
        {
        }

        public virtual DbSet<APPOINTMENT> APPOINTMENTs { get; set; }
        public virtual DbSet<ATTENDEES_APPOINTMENT> ATTENDEES_APPOINTMENT { get; set; }
        public virtual DbSet<LOCATION> LOCATIONs { get; set; }
        public virtual DbSet<REMINDER> REMINDERs { get; set; }
        public virtual DbSet<T> ROLEs { get; set; }
        public virtual DbSet<USER> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LOCATION>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LOCATION>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<T>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<T>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<USER>()
                .Property(e => e.Password)
                .IsFixedLength();
        }
    }
}
