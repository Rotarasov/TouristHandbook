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
    public class ViewTravelAgencyModel : PageModel
    {
        readonly IAgencyCollection _agencyList;
        readonly ITourCollection _tourList;

        public ViewTravelAgencyModel(IAgencyCollection agencies, ITourCollection tours)
        {
            _agencyList = agencies;
            _tourList = tours;
        }

        [BindProperty]
        public string UserId { get; set; }

        [BindProperty]
        public TravelAgency Agency { get; set; }

        [BindProperty]
        public string InitialPage { get; set; }

        public List<Tour> ChosenTours
        {
            get => Agency.ToursId?.Select(id => _tourList.Tours.SingleOrDefault(x => x.Id == id)).ToList() ?? new List<Tour>();
        }

        public void OnGet(string userId, string agencyId, string initPage)
        {
            UserId = userId;
            ViewData["userId"] = userId;
            Agency = _agencyList.TravelAgencies.SingleOrDefault(x => x.Id == agencyId);
            InitialPage = initPage;
        }

        public IActionResult OnPost()
        {
            return RedirectToPage(InitialPage, new { userId = UserId });
        }
    }
}