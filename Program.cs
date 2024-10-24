using System;
using System.Collections.Generic;
using System.Linq;

namespace CnLINQ_Projection
{
  class Student
  {
    public string Neptun;
    public string Name;
    public string email;
    public double Average;
    public Student(string Neptun, string Name, string email,
     double Average)
    {
      this.Neptun = Neptun;
      this.Name = Name;
      this.email = email;
      this.Average = Average;
    }
  }
  class ProjectionProgram
  {
    static List<Student> Students = new List<Student>();
    static void Seed()
    {
      Students.Add(new Student("ACRESC", "A B", "x@net.hu", 2.25));
      Students.Add(new Student("ZHU234", "C B", "y@net.hu", 4.25));
      Students.Add(new Student("DBGTRZ", "D B", "z@net.hu", 3.45));
      Students.Add(new Student("RFCMJW", "E B", "t@net.hu", 3.55));
    }
    static void Main(string[] args)
    {
      Seed();
     
      var H = from x in Students
              where x.Average > 3.5
              orderby x.Name ascending
              select new { x.Name, x.Neptun };
    
      Console.WriteLine("Students with an average greater than 3.5:\n");
      foreach (var y in H)
      {
        Console.WriteLine(y.Neptun + "\t" + y.Name);
      }
      Console.ReadLine();
    }
  }

}
