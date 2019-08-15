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
    public class AddTravelAgencyModel : PageModel
    {
        readonly IAgencyCollection _agencyList;
        readonly ITourCollection _tourList;

        public AddTravelAgencyModel(IAgencyCollection agencies, ITourCollection tours)
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

        public void OnGet(string userId)
        {
            UserId = userId;
            ViewData["userId"] = userId;
        }

        public IActionResult OnPostOk()
        {
            if (ModelState.IsValid)
            {
                if (Agency.ToursId == null)
                    Agency.ToursId = new List<string>();
                Agency.Id = ObjectId.GenerateNewId().ToString();
                _tourList.SynchronizeAdding(Agency);
                _agencyList.Add(Agency);
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