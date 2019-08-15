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
    public class DeleteExcursionModel : PageModel
    {
        readonly IExcursionCollection _excursionList;
        readonly ITourCollection _tourList;

        public DeleteExcursionModel(IExcursionCollection excursions, ITourCollection tours)
        {
            _excursionList = excursions;
            _tourList = tours;
        }

        [BindProperty]
        public string UserId { get; set; }

        [BindProperty]
        public Excursion Excursion { get; set; }

        public SelectList SelectOptions { get; set; }

        public List<Tour> ChosenTours
        {
            get => Excursion.ToursId?.Select(id => _tourList.Tours.SingleOrDefault(x => x.Id == id)).ToList() ?? new List<Tour>();
        }

        public void OnGet(string userId, string excId)
        {
            UserId = userId;
            ViewData["userId"] = userId;
            Excursion = _excursionList.Excursions.SingleOrDefault(x => x.Id == excId);
            SelectOptions = new SelectList(ChosenTours, nameof(Tour.Id), nameof(Tour.Title));
        }

        public IActionResult OnPostDelete()
        {
            _tourList.SynchronizeDeleting(Excursion);
            _excursionList.Delete(Excursion);
            return RedirectToPage("Excursions", new { userId = UserId });
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("Excursions", new { userId = UserId });
        }
    }
}