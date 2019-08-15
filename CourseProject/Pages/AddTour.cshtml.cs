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
    public class AddTourModel : PageModel
    {
        readonly IExcursionCollection _excursionList;
        readonly IAgencyCollection _agencyList;
        readonly ITourCollection _tourList;

        public AddTourModel( IExcursionCollection excursions, ITourCollection tours, IAgencyCollection agencies)
        {
            _excursionList = excursions;
            _tourList = tours;
            _agencyList = agencies;
            AgencySelectOptions = new SelectList(_agencyList.TravelAgencies, nameof(TravelAgency.Id), nameof(TravelAgency.Title));
            ExcursionSelectOptions = new SelectList(_excursionList.Excursions, nameof(Excursion.Id), nameof(Excursion.Title));
        }

        [BindProperty]
        public string UserId { get; set; }

        [BindProperty]
        public Tour Tour { get; set; }

        [BindProperty]
        public TourConverter Converter { get; set; }

        public SelectList ExcursionSelectOptions { get; set; }

        public SelectList AgencySelectOptions { get; set; }

        public void OnGet(string userId)
        {
            UserId = userId;
            ViewData["userId"] = userId;
        }

        public IActionResult OnPostOk()
        {
            if (ModelState.IsValid)
            {
                Tour.Id = ObjectId.GenerateNewId().ToString();
                Tour.Country = Converter.GetCountry();
                Tour.City = Converter.GetCity();
                Tour.Accomodation = Converter.GetAccomodation();
                Tour.AgenciesId = Converter.GetAgency();
                Tour.ExcursionsId = Converter.GetExcursion();
                _agencyList.SynchronizeAdding(Tour);
                _excursionList.SynchronizeAdding(Tour);
                _tourList.Add(Tour);
                return RedirectToPage("Tours", new { userId = UserId });
            }
            return Page();
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("Tours", new { userId = UserId });
        }
    }
}