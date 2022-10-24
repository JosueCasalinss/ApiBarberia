using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiBarberia.Core.Validaciones
{
    public class RangeDateAtribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var dateHour = Convert.ToDateTime(value).Hour;
            var dateMinute = Convert.ToDateTime(value).Minute;

            if(!(dateHour >= 9 && dateHour <= 20))
            {
                return false;
            }

            if (!(dateHour == 20 &&  dateMinute != 0))
            {
                return false;
            }

            return true;
            
        }

    }

    public class ValidateRangeMinuteAtribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {

            var dateMinute = Convert.ToDateTime(value).Minute;

            if (!(dateMinute == 0 || dateMinute == 30))
            {
                return false;
            }
            return true;
        }

    }

    public class ValidateHourAtribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {

            var date = DateTime.Now.AddHours(3);

            if (!(date <= Convert.ToDateTime(value)))
            {
                return false;
            }
            return false;
        }

    }




}
