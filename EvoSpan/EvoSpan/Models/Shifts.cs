using System;
using System.Collections.Generic;
using System.Text;

namespace EvoSpan.Models
{
    public class Shifts
    {
        private Dictionary<string, DateTime> shifts = new Dictionary<string, DateTime>();

        public Shifts(List<DateTime> time_start, List<DateTime> time_end)
        {
            int i = 0;
            foreach (DateTime time in time_start)
            {
                string day = (i == 0) ? "monday" : (i == 2) ? "wednesday" : (i == 4) ? "friday" : (i == 6) ? "sunday" : null;
                day = (i == 1) ? "tuesday" : (i == 3) ? "thursday" : (i == 5) ? "saturday" : null;
                day += "_start";

                if (day == null) throw new Exception("string null");

                if (time != null)
                    shifts.Add(day, new DateTime());
                else
                    shifts.Add(day, time);

                ++i;
            }

            i = 0;
            foreach (DateTime time in time_end)
            {
                string day = (i == 0) ? "monday" : (i == 2) ? "wednesday" : (i == 4) ? "friday" : (i == 6) ? "sunday" : null;
                day = (i == 1) ? "tuesday" : (i == 3) ? "thursday" : (i == 5) ? "saturday" : null;
                day += "_end";

                if (day == null) throw new Exception("string null");

                if (time != null)
                    shifts.Add(day, new DateTime());
                else
                    shifts.Add(day, time);

                ++i;
            }
        }
    }
}
