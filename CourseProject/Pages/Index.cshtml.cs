using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CourseProject.Models;
using CourseProject.Services;

namespace CourseProject.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        readonly IUserCollection _userList;
        public IndexModel(IUserCollection collection)
        {
            _userList = collection;
        }

        public User CurrentUser { get; set; }

        public bool IsAdmin { get; set; }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                CurrentUser = _userList.Users.SingleOrDefault(x => x.Email == CurrentUser.Email && x.Password == CurrentUser.Password);
                if (CurrentUser != null)
                    return RedirectToPage("Home", new { userId = CurrentUser.Id });
            }
            return Page();
        }
    }
}
