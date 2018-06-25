using Microsoft.EntityFrameworkCore;
using StandardTemplateConstruct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandardTemplateConstruct.Data
{
    public class StandardTemplateConstructDbContext : DbContext
    {
        public StandardTemplateConstructDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<ArmyList> ArmyLists { get; set; }
    }
}
