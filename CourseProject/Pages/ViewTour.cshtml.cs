using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using CourseProject.Models;
using CourseProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseProject.Pages
{
    public class ViewTourModel : PageModel
    {
        readonly IUserCollection _userList;
        readonly IExcursionCollection _excursionList;
        readonly IAgencyCollection _agencyList;
        readonly ITourCollection _tourList;

        public ViewTourModel(IUserCollection users, IExcursionCollection excursions, ITourCollection tours, IAgencyCollection agencies)
        {
            _userList = users;
            _excursionList = excursions;
            _tourList = tours;
            _agencyList = agencies;
        }

        [BindProperty]
        public User CurrentUser { get; set; }

        [BindProperty]
        public Tour Tour { get; set; }

        [BindProperty]
        public TourConverter Converter { get; set; } = new TourConverter();

        [BindProperty]
        public List<TravelAgency> TourAgency { get; set; }

        [BindProperty]
        public List<Excursion> TourExcursions { get; set; }

        [BindProperty]
        public string InitialPage { get; set; }

        [BindProperty]
        public Email Mail { get; set; }

        public void OnGet(string userId, string tourId, string initPage)
        {
            CurrentUser = _userList.Users.SingleOrDefault(x => x.Id == userId);
            ViewData["userId"] = userId;
            Tour = _tourList.Tours.SingleOrDefault(x => x.Id == tourId);
            TourAgency = Tour.AgenciesId.Select(id => _agencyList.TravelAgencies.SingleOrDefault(x => x.Id == id)).ToList();
            TourExcursions = Tour.ExcursionsId.Select(id => _excursionList.Excursions.SingleOrDefault(x => x.Id == id)).ToList();
            Converter.SetCountry(Tour.Country);
            Converter.SetCity(Tour.City);
            Converter.SetAccomodation(Tour.Accomodation);
            InitialPage = initPage;
        }

        public IActionResult OnPostReturn()
        {
            return RedirectToPage(InitialPage, new { userId = CurrentUser.Id });
        }

        public void OnPost()
        {
            CurrentUser = _userList.Users.SingleOrDefault(x => x.Id == CurrentUser.Id);
            Tour = _tourList.Tours.SingleOrDefault(x => x.Id == Tour.Id);
            Mail = new Email()
            {
                To = CurrentUser.Email,
                From = "touristhandbook@nure.ua",
                Subject = Tour.Title,
                Body = $"Dear {CurrentUser.FirstName} !!! You were interseted in this tour so we decided to send you our contacts for further details. \nContact +380961234567 - Roman"
            };
            using (var smtp = new SmtpClient())
            {
                smtp.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                smtp.PickupDirectoryLocation = @"H:\II семестр\OOP\CourseProject\Project\MyMails";
                var msg = new MailMessage()
                {
                    Body = Mail.Body,
                    Subject = Mail.Subject,
                    From = new MailAddress(Mail.From)
                };
                msg.To.Add(Mail.To);
                smtp.SendMailAsync(msg);
            }
        }
    }
}