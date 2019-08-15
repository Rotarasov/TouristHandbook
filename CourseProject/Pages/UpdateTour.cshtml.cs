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
    public class UpdateTourModel : PageModel
    {
        readonly IExcursionCollection _excursionList;
        readonly IAgencyCollection _agencyList;
        readonly ITourCollection _tourList;

        public UpdateTourModel(IExcursionCollection excursions, ITourCollection tours, IAgencyCollection agencies)
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
        public TourConverter Converter { get; set; } = new TourConverter();

        public SelectList ExcursionSelectOptions { get; set; }

        public SelectList AgencySelectOptions { get; set; }

        public void OnGet(string userId, string tourId)
        {
            UserId = userId;
            ViewData["userId"] = userId;
            Tour = _tourList.Tours.SingleOrDefault(x => x.Id == tourId);
            Converter.SetCountry(Tour.Country);
            Converter.SetCity(Tour.City);
            Converter.SetAccomodation(Tour.Accomodation);
            Converter.SetAgency(Tour.AgenciesId);
            Converter.SetExcursion(Tour.ExcursionsId);
        }

        public IActionResult OnPostOk()
        {
            if (ModelState.IsValid)
            {
                Tour.Country = Converter.GetCountry();
                Tour.City = Converter.GetCity();
                Tour.Accomodation = Converter.GetAccomodation();
                Tour.AgenciesId = Converter.GetAgency();
                Tour.ExcursionsId = Converter.GetExcursion();
                _agencyList.SynchronizeUpdating(Tour);
                _excursionList.SynchronizeUpdating(Tour);
                _tourList.Update(Tour);
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