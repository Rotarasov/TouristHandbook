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
    [BindProperties]
    public class ToursModel : PageModel
    {
        readonly ITourCollection _tourList;
        readonly IUserCollection _userList;

        public ToursModel(IUserCollection users, ITourCollection tours)
        {
            _userList = users;
            _tourList = tours;
        }

        public User CurrentUser { get; set; }

        public List<Tour> Tours
        {
            get => _tourList.Tours;
        }

        public void OnGet(string userId)
        {
            CurrentUser = _userList.Users.SingleOrDefault(x => x.Id == userId);
            ViewData["userId"] = userId;
        }
    }
}