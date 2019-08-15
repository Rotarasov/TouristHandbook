using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Services
{
    public class DataGreaterThanNowAttribute : ValidationAttribute
    {
        public DataGreaterThanNowAttribute()
        {

        }

        public override bool IsValid(object value)
        {
            if (value != null)
            {
                DateTime time = (DateTime)value;
                if (time < DateTime.Now)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }
}
