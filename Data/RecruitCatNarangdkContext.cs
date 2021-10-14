using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatNarangdk.Models;

namespace RecruitCatNarangdk.Data
{
    public class RecruitCatNarangdkContext : DbContext
    {
        public RecruitCatNarangdkContext (DbContextOptions<RecruitCatNarangdkContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatNarangdk.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatNarangdk.Models.Company> Company { get; set; }

        public DbSet<RecruitCatNarangdk.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatNarangdk.Models.JobTitle> JobTitle { get; set; }
    }
}
