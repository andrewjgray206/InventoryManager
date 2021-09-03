﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InvenManager.Data;
using InvenManager.wwwroot.Models;

namespace InvenManager.Pages.Assets
{
    public class DetailsModel : PageModel
    {
        private readonly InvenManager.Data.InvenManagerContext _context;

        public DetailsModel(InvenManager.Data.InvenManagerContext context)
        {
            _context = context;
        }

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
    }
}
