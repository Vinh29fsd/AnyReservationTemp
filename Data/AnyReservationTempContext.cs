using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AnyReservationTemp.Data;
using AnyReservationTemp.Components.Entities;
using AnyReservationTemp.Domain;
using System.Reflection.Emit;

namespace AnyReservationTemp.Data
{
    public class AnyReservationTempContext(DbContextOptions<AnyReservationTempContext> options) : IdentityDbContext<AnyReservationTempUser>(options)
    {
        public DbSet<AnyReservationTemp.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<AnyReservationTemp.Domain.Member> Member { get; set; } = default!;
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
            builder.ApplyConfiguration(new MemberSeed());
            builder.ApplyConfiguration(new StaffSeed());
            builder.ApplyConfiguration(new RestaurantSeed());
            builder.ApplyConfiguration(new ReservationSeed());
            builder.ApplyConfiguration(new ReviewSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            
        }

    }
}
