using System;
using System.Collections.Generic;
using CoreSchool.Entities;
using CoreSchool.Util;
using static System.Console;

namespace CoreSchool
{
  class Program
  {
    static void Main(string[] args)
    {
      var engine = new SchoolEngine();

      engine.Initialize();
      Printer.WriteTitle("Welcome to the School");
      Printer.Beep(10000, amounTime:10);

      // // otherCollection.Clear();
      // Course temp = new Course { NameCourse = "Vacations-101", SchoolDay = SchoolDayTypes.Night };

      // school.Courses.AddRange(otherCollection);
      // // school.Courses.Add(temp);
      // printSchoolCourses(school);
      // // WriteLine("Course.Hash" + temp.GetHashCode());
      // // Predicate<Course> miAlgorithm = predicate;
      // // school.Courses.RemoveAll(Predicate);
      // // school.Courses.RemoveAll(delegate(Course cur) { return cur.NameCourse == "301"; } );
      // school.Courses.RemoveAll((cur) => cur.NameCourse == "301" );
      // school.Courses.RemoveAll((cur) => cur.NameCourse == "501" && cur.SchoolDay == SchoolDayTypes.Afternoon );

      //school.Courses.Remove(temp);

      // school.Courses = new Course[] {
      //   new Course() { NameCourse = "101", },
      //   new Course() { NameCourse = "201", },
      //   new Course() { NameCourse = "301", },
      // };

      // school.Courses = null;

      printSchoolCourses(engine.School);

      // Console.WriteLine(school);
      // System.Console.WriteLine("----------------------");
      // Console.WriteLine(course1.NameCourse + ", " + course1.UniqueId);
      // Console.WriteLine($"{course2.NameCourse}, {course2.UniqueId}");
      // Console.WriteLine($"{course3.NameCourse}, {course3.UniqueId}");
      // printCoursesWhile(coursesArray);
      // System.Console.WriteLine("----------------------");
      // printCoursesDoWhile(coursesArray);
      // System.Console.WriteLine("----------------------");
      // printCoursesFor(coursesArray);
      // System.Console.WriteLine("----------------------");
      // printCoursesForEach(coursesArray);
    }

    private static bool Predicate(Course courseObj)
    {
      return courseObj.NameCourse == "301";
    }

    private static void printSchoolCourses(School school)
    {
      // Printer.DrawLine(20);
      // WriteLine("School Courses");
      // Printer.DrawLine(20);
      Printer.WriteTitle("School Courses");
      // if (school != null && school.Courses != null)
      if (school?.Courses != null)
      {
        foreach (var course in school.Courses)
        {
          WriteLine($"Name: {course.NameCourse} Id: {course.UniqueId} SchoolDay: {course.SchoolDay}");
        }
      }
    }

    private static void printCoursesWhile(Course[] coursesArray)
    {
      int contador = 0;
      while (contador < coursesArray.Length)
      {
        Console.WriteLine($"Name: {coursesArray[contador].NameCourse} Id: {coursesArray[contador].UniqueId}");
        contador++;
      }
    }

    private static void printCoursesDoWhile(Course[] coursesArray)
    {
      int contador = 0;
      do
      {
        Console.WriteLine($"Name: {coursesArray[contador].NameCourse} Id: {coursesArray[contador].UniqueId}");
        contador++;
      } while (contador < coursesArray.Length);
    }
    private static void printCoursesFor(Course[] coursesArray)
    {
      for (int course = 0; course < coursesArray.Length; course++)
      {
        Console.WriteLine($"Name: {coursesArray[course].NameCourse} Id: {coursesArray[course].UniqueId}");
      }
    }
    private static void printCoursesForEach(Course[] coursesArray)
    {
      foreach (var course in coursesArray)
      {
        Console.WriteLine($"Name: {course.NameCourse} Id: {course.UniqueId}");
      }
    }
  }
}
