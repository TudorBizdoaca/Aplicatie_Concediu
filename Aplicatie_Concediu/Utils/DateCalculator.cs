using System;

namespace Aplicatie_Concediu.Utils
{
    public static class DateCalculator
    {


        public static int bussinessDaysBetween(DateTime firstDay, DateTime lastDay)
        {

            {
                firstDay = firstDay.Date;
                lastDay = lastDay.Date;

                if (firstDay > lastDay)
                    throw new ArgumentException("Incorrect last day " + lastDay);

                TimeSpan span = lastDay - firstDay;
                int businessDays = span.Days + 1;
                int fullWeekCount = businessDays / 7;
                //find out if there are weekends during the time exceedng the full weeks
                if (businessDays > fullWeekCount * 7)
                {

                    int firstDayOfWeek = firstDay.DayOfWeek == DayOfWeek.Sunday
               ? 7 : (int)firstDay.DayOfWeek;
                    int lastDayOfWeek = lastDay.DayOfWeek == DayOfWeek.Sunday
                        ? 7 : (int)lastDay.DayOfWeek;
                    if (lastDayOfWeek < firstDayOfWeek)
                        lastDayOfWeek += 7;
                    if (firstDayOfWeek <= 6)
                    {
                        if (lastDayOfWeek >= 7)// Both Saturday and Sunday are in the remaining time interval
                            businessDays -= 2;
                        else if (lastDayOfWeek >= 6)// Only Saturday is in the remaining time interval
                            businessDays -= 1;
                    }
                    else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)// Only Sunday is in the remaining time interval
                        businessDays -= 1;
                }

                // subtract the weekends during the full weeks in the interval
                businessDays -= fullWeekCount + fullWeekCount;



                return businessDays;
            }
        }





    }
}

