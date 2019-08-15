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
    public class TravelAgenciesModel : PageModel
    {
        readonly IAgencyCollection _agencyList;
        readonly IUserCollection _userList;

        public TravelAgenciesModel(IUserCollection users, IAgencyCollection agencies)
        {
            _userList = users;
            _agencyList = agencies;
        }
        public User CurrentUser { get; set; }

        public List<TravelAgency> TravelAgencies
        {
            get => _agencyList.TravelAgencies;
        }


        public void OnGet(string userId)
        {
            CurrentUser = _userList.Users.SingleOrDefault(x => x.Id == userId);
            ViewData["userId"] = userId;
        }
    }
}