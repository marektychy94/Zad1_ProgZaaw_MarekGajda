using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zad1_ProgZaaw_MarekGajda.Models;

namespace Zad1_ProgZaaw_MarekGajda.Data
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options)
          : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
    }

}