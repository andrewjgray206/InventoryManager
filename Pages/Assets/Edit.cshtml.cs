using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InvenManager.Data;
using InvenManager.wwwroot.Models;

namespace InvenManager.Pages.Assets
{
    public class EditModel : PageModel
    {
        private readonly InvenManager.Data.InvenManagerContext _context;

        public EditModel(InvenManager.Data.InvenManagerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AssetModel AssetModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AssetModel = await _context.AssetModel.FirstOrDefaultAsync(m => m.ID == id);

            if (AssetModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AssetModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetModelExists(AssetModel.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AssetModelExists(int id)
        {
            return _context.AssetModel.Any(e => e.ID == id);
        }
    }
}
