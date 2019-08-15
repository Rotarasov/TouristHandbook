using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using CourseProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CourseProject.Pages
{
    public class UpdateExcursionModel : PageModel
    {
        readonly IExcursionCollection _excursionList;
        readonly ITourCollection _tourList;

        public UpdateExcursionModel(IExcursionCollection excursions, ITourCollection tours)
        {
            _excursionList = excursions;
            _tourList = tours;
            SelectOptions = new SelectList(_tourList.Tours, nameof(Tour.Id), nameof(Tour.Title));
        }

        [BindProperty]
        public string UserId { get; set; }

        [BindProperty]
        public Excursion Excursion { get; set; }

        public SelectList SelectOptions { get; set; }

        public void OnGet(string userId, string excId)
        {
            UserId = userId; 
            ViewData["userId"] = userId;
            Excursion = _excursionList.Excursions.SingleOrDefault(x => x.Id == excId);
        }

        public IActionResult OnPostOk()
        {
            if (ModelState.IsValid)
            {
                if (Excursion.ToursId == null)
                    Excursion.ToursId = new List<string>();
                _tourList.SynchronizeUpdating(Excursion);
                _excursionList.Update(Excursion);
                return RedirectToPage("Excursions", new { userId = UserId });
            }
            return Page();
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("Excursions", new { userId = UserId });
        }
    }
}