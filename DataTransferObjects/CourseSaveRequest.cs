using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects;

public class CourseSaveRequest
{
    public string CourseName {  get; set; }
    public string CourseDescription { get; set; }
    public double CoursePrice { get; set; }
    public int CourseCategoryId { get; set; }
    public int CourseInstructorId { get; set; }
}
