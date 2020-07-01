using System;
using System.Collections.Generic;

namespace CoreSchool.Entities {
  public class School {

    public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
    string name;
    public string Name {
      get { return "Copy: " + name; }
      set { name  = value.ToUpper(); }
    }

    public int StablishYear {get; set;}

    public string Country { get; set; }

    public string City { get; set; }

    public SchoolTypes SchoolType { get; set; } // autoimplemented method

    public List<Course> Courses { get; set; }

    // Constructor 
    // public School(string name, int anio)
    // {
    //   this.name = name;
    //   StablishYear = anio;
    // }

    // Constructor 
    // public School(string name, int anio) => (Name, StablishYear) = (name, anio);

    // Constructor
     public School(
       string name,
       int anio,
       SchoolTypes types, 
       string country="", 
       string city ="") {
         (Name, StablishYear) = (name, anio);
         Country = country;
         City = city;  // <-- Method sign
     }

    public override string ToString()
    {
      return $"Name: \"{Name}\"\nType: {SchoolType} {System.Environment.NewLine}Country: {Country}\nCity: {City}";
    }
  }
}