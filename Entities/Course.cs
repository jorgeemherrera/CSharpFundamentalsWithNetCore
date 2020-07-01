using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class Course
    {
        public string UniqueId { get; private set; }
       public string NameCourse { get; set; }
       public SchoolDayTypes SchoolDay { get; set; }
       public List<Signature> Signatures {get; set;}
       public List<Student> Students {get; set;}


       public Course() => UniqueId = Guid.NewGuid().ToString();
    }
}