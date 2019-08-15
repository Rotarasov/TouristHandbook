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
    public class DeleteTravelAgencyModel : PageModel
    {
        readonly IAgencyCollection _agencyList;
        readonly ITourCollection _tourList;

        public DeleteTravelAgencyModel(IAgencyCollection agencies, ITourCollection tours)
        {
            _agencyList = agencies;
            _tourList = tours;
        }

        [BindProperty]
        public string UserId { get; set; }

        [BindProperty]
        public TravelAgency Agency { get; set; }

        public SelectList SelectOptions { get; set; }

        public List<Tour> ChosenTours
        {
            get => Agency.ToursId?.Select(id => _tourList.Tours.SingleOrDefault(x => x.Id == id)).ToList() ?? new List<Tour>();
        }

        public void OnGet(string userId, string agencyId)
        {
            UserId = userId;
            ViewData["userId"] = userId;
            Agency = _agencyList.TravelAgencies.SingleOrDefault(x => x.Id == agencyId);
            SelectOptions = new SelectList(ChosenTours, nameof(Tour.Id), nameof(Tour.Title));
        }

        public IActionResult OnPostDelete()
        {
            _tourList.SynchronizeDeleting(Agency);
            _agencyList.Delete(Agency);
            return RedirectToPage("TravelAgencies", new { userId = UserId });
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("TravelAgencies", new { userId = UserId });
        }
    }
}