using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpartaIMSEng24.Models;

namespace SpartaIMSEng24.Models
{
    public class SpartaIMSEng24Context : DbContext
    {
        public SpartaIMSEng24Context (DbContextOptions<SpartaIMSEng24Context> options)
            : base(options)
        {
        }

        public DbSet<SpartaIMSEng24.Models.Cohort> Cohort { get; set; }

        public DbSet<SpartaIMSEng24.Models.JobRole> JobRole { get; set; }

        public DbSet<SpartaIMSEng24.Models.Specialisation> Specialisation { get; set; }
    }
}
