using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using CourseProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Bson;

namespace CourseProject.Pages
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        readonly IUserCollection userList;

        public RegisterModel(IUserCollection collection)
        {
            userList = collection;
        }

        public UserContext Context { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    FirstName = Context.FirstName,
                    LastName = Context.LastName,
                    Email = Context.Email,
                    Password = Context.Password,
                    IsAdmin = false
                };
                userList.Add(user);
                return RedirectToPage("Home", new { userId = user.Id });
            }
            return Page();
        }
    }
}