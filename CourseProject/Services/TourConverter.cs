using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Services
{
    public class TourConverter
    {
        [Required]
        [RegularExpression(@"(\s*\w+;?)+", ErrorMessage = "You should use ';' to separate countries")]
        public string Country { get; set; }

        [Required]
        [RegularExpression(@"(\s*\w+;?)+", ErrorMessage = "You should use ';' to separate cities")]
        public string City { get; set; }

        [Required]
        [RegularExpression(@"(\s*\w+;?)+", ErrorMessage = "You should use ';' to separate accomodations")]
        public string Accomodation { get; set; }

        public List<string> AgencyId { get; set; }

        public List<string> ExcursionId { get; set; }

        public List<string> GetCountry()
        {
            return Country.Split(';').Select(x => x.Trim()).ToList();
        }

        public List<string> GetCity()
        {
            return City.Split(';').Select(x => x.Trim()).ToList();
        }

        public List<string> GetAccomodation()
        {
            return Accomodation.Split(';').Select(x => x.Trim()).ToList();
        }

        public List<string> GetExcursion()
        {
            return ExcursionId?.Where(x => x != null).ToList() ?? new List<string>();
        }

        public List<string> GetAgency()
        {
            return AgencyId?.Where(x => x != null).ToList() ?? new List<string>();
        }

        public void SetCountry(List<string> lst)
        {
            Country = string.Join("; ", lst);
        }

        public void SetCity(List<string> lst)
        {
            City = string.Join("; ", lst);
        }

        public void SetAccomodation(List<string> lst)
        {
            Accomodation = string.Join("; ", lst);
        }

        public void SetExcursion(List<string> lst)
        {
            ExcursionId = new List<string>();
            foreach (string s in lst)
                ExcursionId.Add(s);
        }

        public void SetAgency(List<string> lst)
        {
            AgencyId = new List<string>();
            foreach (string s in lst)
                AgencyId.Add(s);
        }
    }
}
