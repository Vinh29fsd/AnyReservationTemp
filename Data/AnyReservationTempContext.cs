using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnyReservationTemp.Domain;
using AnyReservationTemp.Components.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AnyReservationTemp.Data
{
    public class AnyReservationTempContext : DbContext
    {
        public AnyReservationTempContext (DbContextOptions<AnyReservationTempContext> options)
            : base(options)
        {
        }

        public DbSet<AnyReservationTemp.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.Order> Order { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.OrderDetail> OrderDetail { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.Product> Product { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.ProductCategory> ProductCategory { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.Progress> Progress { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.Reservation> Reservation { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.ReservedTableDetail> ReservedTableDetail { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.Restaurant> Restaurant { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.RestaurantProductCategory> RestaurantProductCategory { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.RestaurantTable> RestaurantTable { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.RestaurantType> RestaurantType { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.Review> Review { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.Staff> Staff { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.Status> Status { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CustomerSeed());
            builder.ApplyConfiguration(new StaffSeed());
            builder.ApplyConfiguration(new RestaurantSeed());
            builder.ApplyConfiguration(new ReservationSeed());
        }
    }
}
