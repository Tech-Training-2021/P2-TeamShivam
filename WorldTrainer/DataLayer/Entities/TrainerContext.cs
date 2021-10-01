using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class TrainerContext : DbContext
    {
        public TrainerContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Trainer> trainer { get; set; }
        public DbSet<TrainerDetails> trainerdetails { get; set; }

        public DbSet<Skill> skill { get; set; }

    }
}
