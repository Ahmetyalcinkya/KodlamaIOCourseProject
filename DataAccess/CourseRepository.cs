using DataTransferObjects;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public interface CourseRepository
{
    void SaveCourse(CourseSaveRequest courseSaveRequest);
    void UpdateCourse(CourseUpdateRequest courseUpdateRequest);
    void DeleteCourse(int courseId);
    List<Course> GetAllCourses();
}
