using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zad1_ProgZaaw_MarekGajda.Models;
namespace Zad1_ProgZaaw_MarekGajda.Data
{
    public class DevicesContext : DbContext
    {
            public DevicesContext (DbContextOptions<DevicesContext> options)
                : base(options)
        {

        }
        public DbSet<Devices> Device { get; set; }
    }
}
