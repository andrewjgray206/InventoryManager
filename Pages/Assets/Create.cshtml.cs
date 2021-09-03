using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InvenManager.Data;
using InvenManager.wwwroot.Models;

namespace InvenManager.Pages.Assets
{
    public class CreateModel : PageModel
    {
        private readonly InvenManager.Data.InvenManagerContext _context;

        public CreateModel(InvenManager.Data.InvenManagerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AssetModel AssetModel { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AssetModel.Add(AssetModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
