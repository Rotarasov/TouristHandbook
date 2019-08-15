using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Services
{
    public interface IUserCollection : ITouristCollection<User>
    {
        List<User> Users { get; }
    }
}
