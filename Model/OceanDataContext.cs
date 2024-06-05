using Microsoft.EntityFrameworkCore;
using OceanObservationAPI.Models;

using System.Collections.Generic;

namespace OceanObservationAPI.Data
{
    public class OceanDataContext : DbContext
    {
        public OceanDataContext(DbContextOptions<OceanDataContext> options)
        : base(options)
        {
        }

        public DbSet<OceanObservation> OceanObservations { get; set; }
    }
}
