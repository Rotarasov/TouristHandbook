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
    public class DeleteTourModel : PageModel
    {
        readonly IExcursionCollection _excursionList;
        readonly IAgencyCollection _agencyList;
        readonly ITourCollection _tourList;

        public DeleteTourModel(IExcursionCollection excursions, ITourCollection tours, IAgencyCollection agencies)
        {
            _excursionList = excursions;
            _tourList = tours;
            _agencyList = agencies;
        }

        [BindProperty]
        public string UserId { get; set; }

        [BindProperty]
        public Tour Tour { get; set; }

        [BindProperty]
        public TourConverter Converter { get; set; } = new TourConverter();

        [BindProperty]
        public List<TravelAgency> ChosenAgency
        {
            get => Tour.AgenciesId?.Select(id => _agencyList.TravelAgencies.SingleOrDefault(x => x.Id == id)).ToList() ?? new List<TravelAgency>();
        }

        public SelectList AgencySelectOptions { get; set; }

        [BindProperty]
        public List<Excursion> ChosenExcursions
        {
            get => Tour.ExcursionsId?.Select(id => _excursionList.Excursions.SingleOrDefault(x => x.Id == id)).ToList() ?? new List<Excursion>();
        }

        public SelectList ExcursionSelectOptions { get; set; }

        public void OnGet(string userId, string tourId)
        {
            UserId = userId;
            ViewData["userId"] = userId;
            Tour = _tourList.Tours.SingleOrDefault(x => x.Id == tourId);
            AgencySelectOptions = new SelectList(ChosenAgency, nameof(TravelAgency.Id), nameof(TravelAgency.Title));
            ExcursionSelectOptions = new SelectList(ChosenExcursions, nameof(Excursion.Id), nameof(Excursion.Title));
            Converter.SetCountry(Tour.Country);
            Converter.SetCity(Tour.City);
            Converter.SetAccomodation(Tour.Accomodation);
        }

        public IActionResult OnPostDelete()
        {
            _agencyList.SynchronizeDeleting(Tour);
            _excursionList.SynchronizeDeleting(Tour);
            _tourList.Delete(Tour);
            return RedirectToPage("Tours", new { userId = UserId });
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("Tours", new { userId = UserId });
        }
    }
}