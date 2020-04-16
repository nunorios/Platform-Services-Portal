using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platform_Services_Portal.Models
{
    public class PortalMetricsContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public PortalMetricsContext(DbContextOptions<PortalMetricsContext> options)
           : base(options)
        { }

        public DbSet<PortalMetrics> Metric { get; set; }
    }
}
