using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Services
{
    public interface ITourCollection : ITouristCollection<Tour>
    {
        List<Tour> Tours { get; }
    }
}
