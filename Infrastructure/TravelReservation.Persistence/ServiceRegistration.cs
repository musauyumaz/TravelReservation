using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservation.Persistence.Configurations;
using TravelReservation.Persistence.Contexts;

namespace TravelReservation.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<TravelReservationDb>(options => options.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
