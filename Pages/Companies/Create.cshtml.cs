using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatNarangdk.Data;
using RecruitCatNarangdk.Models;

namespace RecruitCatNarangdk.Pages.Companies
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
        ViewData["IndustryId"] = new SelectList(_context.Set<Industry>(), "IndustryId", "IndustryName");
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Company.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
