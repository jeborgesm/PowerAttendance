namespace PowerAttendance
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AttendanceRegistryModel : DbContext
    {
        public AttendanceRegistryModel()
            : base("name=AttendanceRegistryContext")
        {
        }

        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.LastName1)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.LastName2)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .HasMany(e => e.Attendances)
                .WithRequired(e => e.Member)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Amount)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Season>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
