using System;

namespace Vehicle_Fleet_factory.BLL
{
    [Serializable]
    public class Date
    {
        // Private attributes of the class
        private int year;
        private int month;
        private int day;

        // Flags to check whether month and day were explicitly provided
        private bool hasMonth;
        private bool hasDay;

        // Default constructor: sets date to 1900-01-01
        public Date()
        {
            this.year = 1900;
            this.month = 1;
            this.day = 1;
            this.hasMonth = true;
            this.hasDay = true;
        }

        // Constructor with only year: defaults month and day to 1
        // Flags: hasMonth = false, hasDay = false
        public Date(int year)
        {
            this.year = year;
            this.month = 1;
            this.day = 1;
            this.hasMonth = false;
            this.hasDay = false;
        }

        // Constructor with year and month: defaults day to 1
        // Flags: hasMonth = true, hasDay = false
        public Date(int year, int month)
        {
            this.year = year;
            this.month = month;
            this.day = 1;
            this.hasMonth = true;
            this.hasDay = false;
        }

        // Constructor with full date (year, month, day)
        // Flags: hasMonth = true, hasDay = true
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hasMonth = true;
            this.hasDay = true;
        }

        // Property for Year with validation (between 1900 and current year)
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException("Year must be between 1900 and the current year.");
                }
                year = value;
            }
        }

        // Property for Month with validation (1 to 12)
        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("Month must be between 1 and 12.");
                }
                month = value;
                hasMonth = true;
            }
        }

        // Property for Day with validation based on year and month
        public int Day
        {
            get { return day; }
            set
            {
                if (value < 1 || value > DateTime.DaysInMonth(year, month))
                {
                    throw new ArgumentOutOfRangeException($"Day must be between 1 and {DateTime.DaysInMonth(year, month)} for the given month.");
                }
                day = value;
                hasDay = true;
            }
        }

        // ToString() returns the formatted date string
        // Output depends on whether month and day were explicitly provided
        public override string ToString()
        {
            if (!hasMonth)
            {
                return $"{year:D4}"; // Only year
            }
            else if (!hasDay)
            {
                return $"{year:D4}-{month:D2}"; // Year and month
            }
            else
            {
                return $"{year:D4}-{month:D2}-{day:D2}"; // Full date
            }
        }
    }
}
