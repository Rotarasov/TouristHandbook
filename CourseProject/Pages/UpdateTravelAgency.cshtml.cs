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
    public class UpdateTravelAgencyModel : PageModel
    {
        readonly IAgencyCollection _agencyList;
        readonly ITourCollection _tourList;

        public UpdateTravelAgencyModel(IAgencyCollection agencies, ITourCollection tours)
        {
            _agencyList = agencies;
            _tourList = tours;
            SelectOptions = new SelectList(_tourList.Tours, nameof(Tour.Id), nameof(Tour.Title));
        }

        [BindProperty]
        public string UserId { get; set; }

        [BindProperty]
        public TravelAgency Agency { get; set; }

        public SelectList SelectOptions { get; set; }

        public void OnGet(string userId, string agencyId)
        {
            UserId = userId;
            ViewData["userId"] = userId;
            Agency = _agencyList.TravelAgencies.SingleOrDefault(x => x.Id == agencyId);
        }

        public IActionResult OnPostOk()
        {
            if (ModelState.IsValid)
            {
                if (Agency.ToursId == null)
                    Agency.ToursId = new List<string>();
                _tourList.SynchronizeUpdating(Agency);
                _agencyList.Update(Agency);
                return RedirectToPage("TravelAgencies", new { userId = UserId });
            }
            return Page();
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("TravelAgencies", new { userId = UserId });
        }
    }
}