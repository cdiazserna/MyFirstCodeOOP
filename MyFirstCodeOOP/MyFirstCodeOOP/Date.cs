using System;

namespace MyFirstCodeOOP
{
    public class Date
    {
        #region Properties
        private int _year;
        private int _month;
        private int _day;
        #endregion

        #region Constructor

        public Date(int year, int month, int day)
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(year, month, day);             
        }
        #endregion

        #region Methods

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            
            throw new YearException(String.Format("The year {0} is invalid.", year));
        }

        private int ValidateDay(int year, int month, int day)
        {
            if (month == 2 && day >= 1 && day <= 28)
            {
                return day;
            }

            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month  == 12)
            {
                if (day >= 1 && day <= 31)
                {
                    return day;
                }
                
            }
            else if (day >= 1 && day <= 30)
                {
                    return day;
                } 

            throw new DayException(String.Format("The day {0} doesn't exist for month {1}.", day, month));
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            throw new MonthException(String.Format("The month {0} is invalid.", month));
        }

        public override string ToString()
        {
            return String.Format("{0:00}/{1:00}/{2:00}", _year, _month, _day);
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 == 0;
        }
        #endregion
    }
}
