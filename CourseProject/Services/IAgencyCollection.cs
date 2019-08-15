using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Services
{
    public interface IAgencyCollection : ITouristCollection<TravelAgency>
    {
        List<TravelAgency> TravelAgencies { get; }
    }
}
