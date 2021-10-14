using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatNarangdk.Data;
using RecruitCatNarangdk.Models;

namespace RecruitCatNarangdk.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatNarangdk.Data.RecruitCatNarangdkContext _context;

        public CreateModel(RecruitCatNarangdk.Data.RecruitCatNarangdkContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "CompanyId", "CompanyName");
        ViewData["IndustryId"] = new SelectList(_context.Set<Industry>(), "IndustryId", "IndustryName");
        ViewData["JobTitleId"] = new SelectList(_context.Set<JobTitle>(), "JobTitleId", "JobDescription");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
