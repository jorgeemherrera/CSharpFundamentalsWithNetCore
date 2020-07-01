using System;
using System.Collections.Generic;
using CoreSchool.Entities;

namespace CoreSchool
{
  public class SchoolEngine
  {
    public School School { get; set; }

    public SchoolEngine()
    {

    }

    public void Initialize()
    {
      School = new School("George School", 2020, SchoolTypes.Elementary, city: "Medellín", country: "Colombia");

      LoadCourses();
      LoadStudents();
      LoadSignatures();
      LoadTest();
    }

    private void LoadTest()
    {
      throw new NotImplementedException();
    }

    private void LoadSignatures()
    {
      foreach(var course in School.Courses){}
    }

    private void LoadStudents()
    {
      throw new NotImplementedException();
    }

    private void LoadCourses()
    {
      School.Courses = new List<Course>()
      {
        new Course() { NameCourse = "101", SchoolDay = SchoolDayTypes.Morning },
        new Course() { NameCourse = "201", SchoolDay = SchoolDayTypes.Morning },
        new Course() { NameCourse = "301", SchoolDay = SchoolDayTypes.Morning },
        new Course(){ NameCourse = "401", SchoolDay = SchoolDayTypes.Afternoon},
        new Course(){ NameCourse = "501", SchoolDay = SchoolDayTypes.Afternoon},
      };
    }
  }
}