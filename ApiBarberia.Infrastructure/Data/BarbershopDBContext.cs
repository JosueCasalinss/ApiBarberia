using ApiBarberia.Core.Entity;
using Microsoft.EntityFrameworkCore;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiBarberia.Infrastructure.Data
{
    public partial class BarbershopDBContext : DbContext
    {
        public BarbershopDBContext()
        {
        }

        public BarbershopDBContext(DbContextOptions<BarbershopDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Departament> Departament { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Headquarter> Headquarter { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoicedDetail> InvoicedDetail { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<ReservationDetail> ReservationDetail { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<TypeDocument> TypeDocument { get; set; }
        public virtual DbSet<TypeRole> TypeRole { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdDepartamentNavigation)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.IdDepartament)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_Departament");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Departament>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.Departament)
                    .HasForeignKey(d => d.IdCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Departament_Country");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Headquarter>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Headquarter)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Headquarter_City");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.IdBarberNavigation)
                    .WithMany(p => p.InvoiceIdBarberNavigation)
                    .HasForeignKey(d => d.IdBarber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_Invoice_People");

                entity.HasOne(d => d.IdCostumerNavigation)
                    .WithMany(p => p.InvoiceIdCostumerNavigation)
                    .HasForeignKey(d => d.IdCostumer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_Invoice_People");

                entity.HasOne(d => d.IdHeadquarterNavigation)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.IdHeadquarter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK3_Invoice_Headquarter");
            });

            modelBuilder.Entity<InvoicedDetail>(entity =>
            {
                entity.HasOne(d => d.IdInvoiceNavigation)
                    .WithMany(p => p.InvoicedDetail)
                    .HasForeignKey(d => d.IdInvoice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoicedDetail_Invoice");

                entity.HasOne(d => d.IdServiceNavigation)
                    .WithMany(p => p.InvoicedDetail)
                    .HasForeignKey(d => d.IdService)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoicedDetail_Service1");
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.DocumentNumber).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.HasOne(d => d.IdGenderNavigation)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.IdGender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_People_Gender");

                entity.HasOne(d => d.IdTypeDocumentNavigation)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.IdTypeDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_People_TypeDocument");

                entity.HasOne(d => d.IdTypeRoleNavigation)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.IdTypeRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK3_People_TypeRole");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.IdBarberNavigation)
                    .WithMany(p => p.ReservationIdBarberNavigation)
                    .HasForeignKey(d => d.IdBarber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_Reservation_People");

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.ReservationIdCustomerNavigation)
                    .HasForeignKey(d => d.IdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_Reservation_People");

                entity.HasOne(d => d.IdHeadquarterNavigation)
                    .WithMany(p => p.Reservation)
                    .HasForeignKey(d => d.IdHeadquarter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservation_Headquarter");
            });

            modelBuilder.Entity<ReservationDetail>(entity =>
            {
                entity.HasOne(d => d.IdReservationNavigation)
                    .WithMany(p => p.ReservationDetail)
                    .HasForeignKey(d => d.IdReservation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReservationDetail_Reservation");

                entity.HasOne(d => d.IdServiceNavigation)
                    .WithMany(p => p.ReservationDetail)
                    .HasForeignKey(d => d.IdService)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReservationDetail_Service");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TypeDocument>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TypeRole>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
