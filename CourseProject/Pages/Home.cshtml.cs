using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using CourseProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace CourseProject.Pages
{
    public class HomeModel : PageModel
    {
        readonly IUserCollection _userList;
        readonly ITourCollection _tourList;
        readonly IAgencyCollection _agencyList;
        readonly IExcursionCollection _excursionList;
        public HomeModel(IUserCollection users, ITourCollection tours, IAgencyCollection agencies, IExcursionCollection excursions)
        {
            _userList = users;
            _tourList = tours;
            _agencyList = agencies;
            _excursionList = excursions;
        }

        [BindProperty]
        public User CurrentUser { get; set; }

        public void OnGet(string userId)
        {
            CurrentUser = _userList.Users.SingleOrDefault(x => x.Id == userId);
            ViewData["welcoming"] = $" Welcome {CurrentUser.FirstName} {CurrentUser.LastName}";
            ViewData["userId"] = userId;
        }

        public IActionResult OnGetTour(string value)
        {
            value = value.ToLower();
            List<Tour> tours = _tourList.Tours.FindAll(item => item.Title.ToLower().Contains(value) || item.Country.Any(x => x.ToLower().Contains(value)) || item.City.Any(x => x.ToLower().Contains(value)) || item.Accomodation.Any(x => x.ToLower().Contains(value)) || item.TravelStyle.ToLower().Contains(value));
            return new PartialViewResult
            {
                ViewName = "_SearchTourPartial",
                ViewData = new ViewDataDictionary<List<Tour>>(ViewData, tours)
            };
        }

        public IActionResult OnGetAgency(string value)
        {
            value = value.ToLower();
            List<TravelAgency> agencies = _agencyList.TravelAgencies.FindAll(item => item.Title.ToLower().Contains(value));
            return new PartialViewResult
            {
                ViewName = "_SearchAgencyPartial",
                ViewData = new ViewDataDictionary<List<TravelAgency>>(ViewData, agencies)
            };
        }

        public IActionResult OnGetExcursion(string value)
        {
            value = value.ToLower();
            List<Excursion> excursions = _excursionList.Excursions.FindAll(item => item.Title.ToLower().Contains(value));
            return new PartialViewResult
            {
                ViewName = "_SearchExcursionPartial",
                ViewData = new ViewDataDictionary<List<Excursion>>(ViewData, excursions)
            };
        }

    }
}