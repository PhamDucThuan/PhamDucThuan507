using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMovie.Models;

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMovie.Models.CompanyPDT507> CompanyPDT507 { get; set; }

        public DbSet<MVCMovie.Models.PDT0507> PDT0507 { get; set; }
    }
