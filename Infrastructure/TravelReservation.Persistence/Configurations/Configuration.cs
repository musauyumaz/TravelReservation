﻿using Microsoft.Extensions.Configuration;

namespace TravelReservation.Persistence.Configurations
{
    public static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/TravelReservation.MVC"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("TravelReservationDB");
            }
        }
    }
}
