using System;

namespace Properties
{
    public class Student
    {
        public Student(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public DateTime BirthDate { set; get; }

        public int Age
        {
            get
            {
                var timespan = DateTime.Now - BirthDate;
                var years = timespan.Days / 365;
                return years;
            }
        }
    }
}