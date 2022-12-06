using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TravelReservation.Domain.Entities;
using TravelReservation.Domain.Entities.Common;

namespace TravelReservation.Persistence.Contexts
{
    public class TravelReservationDb : DbContext
    {
        public TravelReservationDb(DbContextOptions options) : base(options) { }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Information> Informations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
               _ = data.State switch
               {
                   EntityState.Added => data.Entity.CreatedAt = DateTime.UtcNow,
                   EntityState.Modified => data.Entity.UpdatedAt= DateTime.UtcNow,
                   _ => DateTime.UtcNow
               };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
