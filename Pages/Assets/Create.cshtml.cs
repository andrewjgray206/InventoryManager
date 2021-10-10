using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InvenManager.wwwroot.Models;
using InvenManager.Models;

namespace InvenManager.Pages.Assets
{
    public class CreateModel : PageModel
    {

        public List<SelectListItem> Owners { get; set; }

        private readonly InvenManager.Data.InvenManagerContext _context;

        public CreateModel(InvenManager.Data.InvenManagerContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Owners = _context.Owner.Select(a =>
            new SelectListItem
            {
                Value = a.ID.ToString(),
                Text = a.name
            }).ToList();
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
