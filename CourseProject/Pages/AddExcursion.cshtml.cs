using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using CourseProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDB.Bson;

namespace CourseProject.Pages
{
    public class AddExcursionModel : PageModel
    {
        readonly IExcursionCollection _excursionList;
        readonly ITourCollection _tourList;

        public AddExcursionModel(IExcursionCollection excursions, ITourCollection tours)
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

        public void OnGet(string userId)
        {
            UserId = userId;
            ViewData["userId"] = userId;
        }

        public IActionResult OnPostOk()
        {
            if (ModelState.IsValid)
            {
                if (Excursion.ToursId == null)
                    Excursion.ToursId = new List<string>();
                Excursion.Id = ObjectId.GenerateNewId().ToString();
                _tourList.SynchronizeAdding(Excursion);
                _excursionList.Add(Excursion);
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