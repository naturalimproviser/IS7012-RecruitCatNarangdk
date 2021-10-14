using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatNarangdk.Data;
using RecruitCatNarangdk.Models;

namespace RecruitCatNarangdk.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatNarangdk.Data.RecruitCatNarangdkContext _context;

        public IndexModel(RecruitCatNarangdk.Data.RecruitCatNarangdkContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company
                .Include(c => c.Industry).ToListAsync();
        }
    }
}
