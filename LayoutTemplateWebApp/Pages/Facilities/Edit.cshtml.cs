using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LayoutTemplateWebApp.Data;
using LayoutTemplateWebApp.Model;

namespace LayoutTemplateWebApp.EventosTemp
{
    public class EditModel : PageModel
    {
        private readonly LayoutTemplateWebApp.Data.ApplicationDbContext _context;

        public EditModel(LayoutTemplateWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Facility Facility { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Facility == null)
            {
                return NotFound();
            }

            var facility =  await _context.Facility.FirstOrDefaultAsync(m => m.idFacility == id);
            if (facility == null)
            {
                return NotFound();
            }
            Facility = facility;
           ViewData["idFacilityAdministrator"] = new SelectList(_context.FacilityAdministrator, "idFacilityAdministrator", "email");
           ViewData["idFacilityType"] = new SelectList(_context.FacilityType, "idFacilityType", "idFacilityType");
           ViewData["idImage"] = new SelectList(_context.Image, "idImage", "alternative_text");
           ViewData["idLocation"] = new SelectList(_context.Location, "idLocation", "description");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            // Esto es un hack porque cuentan como errores
            // que los objetos no se hayan creado.
            if (ModelState.ErrorCount<5)
            {
                return Page();
            }

            _context.Attach(Facility).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacilityExists(Facility.idFacility))
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

        private bool FacilityExists(int id)
        {
          return (_context.Facility?.Any(e => e.idFacility == id)).GetValueOrDefault();
        }
    }
}
