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
    public class ExcursionsModel : PageModel
    {
        readonly IExcursionCollection _excursionList;
        readonly IUserCollection _userList;

        public List<Excursion> Excursions
        {
            get => _excursionList.Excursions;
        }

        public User CurrentUser { get; set; }

        public ExcursionsModel(IUserCollection users, IExcursionCollection excursions)
        {
            _userList = users;
            _excursionList = excursions;
        }

        public void OnGet(string userId)
        {
            CurrentUser = _userList.Users.SingleOrDefault(x => x.Id == userId);
            ViewData["userId"] = userId;
        }
    }
}