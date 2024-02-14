using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects;

public class InstructorSaveRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }
}
