using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;

public class Instructor
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }
    public List<Course> Courses { get; }

    public Instructor(int id, string firstName, string lastName, double salary)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
        Courses = new List<Course>();
    }
}
