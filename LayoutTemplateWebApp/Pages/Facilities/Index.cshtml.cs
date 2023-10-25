using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LayoutTemplateWebApp.Data;
using LayoutTemplateWebApp.Model;

namespace LayoutTemplateWebApp.EventosTemp
{
    public class IndexModel : PageModel
    {
        private readonly LayoutTemplateWebApp.Data.ApplicationDbContext _context;

        public IndexModel(LayoutTemplateWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Facility> Facility { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Facility != null)
            {
                Facility = await _context.Facility
                .Include(f => f.FacilityAdministrator)
                .Include(f => f.FacilityType)
                .Include(f => f.Image)
                .Include(f => f.Location).ToListAsync();
            }
        }
    }
}
