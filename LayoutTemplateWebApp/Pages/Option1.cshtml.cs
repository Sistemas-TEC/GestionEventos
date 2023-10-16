using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore; 
using MyLayoutTemplateWebApp.DbContext;
using LayoutTemplateWebApp.DbModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LayoutTemplateWebApp.Pages
{
    public class Option1Model : PageModel
    {
        private readonly ApplicationDbContext _context; // Reemplaza "ApplicationDbContext" con el contexto de tu base de datos

        public List<Event> Events { get; set; }

        public Option1Model(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            // Recuperar eventos de la base de datos
            Events = _context.Events
                .Include(e => e.EventType) // Si tienes una relación con un tipo de evento, inclúyelo
                .Include(e => e.EventState) // Si tienes una relación con el estado del evento, inclúyelo
                .ToList();
        }
    }
}