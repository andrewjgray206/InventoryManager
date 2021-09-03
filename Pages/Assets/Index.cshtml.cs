using System;
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
    public class IndexModel : PageModel
    {
        private readonly InvenManager.Data.InvenManagerContext _context;

        public IndexModel(InvenManager.Data.InvenManagerContext context)
        {
            _context = context;
        }

        public IList<AssetModel> AssetModel { get;set; }

        public async Task OnGetAsync()
        {
            AssetModel = await _context.AssetModel.ToListAsync();
        }
    }
}
