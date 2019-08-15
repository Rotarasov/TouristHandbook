using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Services
{
    public class DateGreaterThanAttribute : ValidationAttribute
    {
        public DateGreaterThanAttribute(string dateToCompareFieldName, string durationFieldName)
        {
            DateToCompareToFieldName = dateToCompareFieldName;
            DurationFieldName = durationFieldName;
        }

        public string DateToCompareToFieldName { get; set; }

        public string DurationFieldName { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                DateTime earlierDate = (DateTime)value;
                DateTime laterDate = (DateTime)validationContext.ObjectType.GetProperty(DateToCompareToFieldName).GetValue(validationContext.ObjectInstance, null);
                int duration = (int)validationContext.ObjectType.GetProperty(DurationFieldName).GetValue(validationContext.ObjectInstance, null);
                if (laterDate.Day - earlierDate.Day == duration - 1)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("The difference betwen the Start date and the End date should be equal to the Duration");
                }
            }
            catch (Exception)
            {
                return ValidationResult.Success;
            }
        }
    }
}
