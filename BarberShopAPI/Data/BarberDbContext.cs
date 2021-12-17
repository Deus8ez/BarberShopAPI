using BarberShopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BarberShopAPI.Data
{
    public class BarberDbContext : DbContext
    {
        public BarberDbContext(DbContextOptions<BarberDbContext> options)
        : base(options)
        {
        }
        public DbSet<Barber> Barbers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Barber>().HasData(
                new Barber { Id = 1, Name = "Иван", Mastery = "Мастер 1 категории"},
                new Barber { Id = 2, Name = "Влад", Mastery = "Мастер 2 категории" },
                new Barber { Id = 3, Name = "Игорь", Mastery = "Мастер 3 категории"}
            );

            builder.Entity<Service>().HasData(
                new Service { Id = 1, Name = "Стрижка головы", Price = 600},
                new Service { Id = 2, Name = "Стрижка бороды", Price = 300}
            );
        }
    }
}
