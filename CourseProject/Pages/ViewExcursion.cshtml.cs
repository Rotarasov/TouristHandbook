using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using CourseProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseProject.Pages
{
    public class ViewExcursionModel : PageModel
    {
        readonly IExcursionCollection _excursionList;
        readonly ITourCollection _tourList;

        public ViewExcursionModel(IExcursionCollection excursions, ITourCollection tours)
        {
            _excursionList = excursions;
            _tourList = tours;
        }

        [BindProperty]
        public string UserId { get; set; }

        [BindProperty]
        public Excursion Excursion { get; set; }

        [BindProperty]
        public string InitialPage { get; set; }

        public List<Tour> ChosenTours
        {
            get => Excursion.ToursId?.Select(id => _tourList.Tours.SingleOrDefault(x => x.Id == id)).ToList() ?? new List<Tour>();
        }

        public void OnGet(string initPage, string userId, string excId)
        {
            UserId = userId;
            ViewData["userId"] = userId;
            Excursion = _excursionList.Excursions.SingleOrDefault(x => x.Id == excId);
            InitialPage = initPage;
        }

        public IActionResult OnPost()
        {
            return RedirectToPage(InitialPage, new { userId = UserId });
        }
    }
}