using System;

namespace CoreSchool.Entities
{
    public class Course
    {
        public string UniqueId { get; private set; }
       public string NameCourse { get; set; }
       public SchoolDayTypes SchoolDay { get; set; }

       public Course() => UniqueId = Guid.NewGuid().ToString();
    }
}