using Business.Abstracts;
using DataAccess;
using DataTransferObjects;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CourseManager : ICourseService
{
    private readonly CourseRepository _courseRepository;
    public CourseManager(CourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public void DeleteCourse(int courseId)
    {
        _courseRepository.DeleteCourse(courseId);
    }

    public List<Course> GetAllCourses()
    {
        return _courseRepository.GetAllCourses();
    }

    public void SaveCourse(CourseSaveRequest courseSaveRequest)
    {
        _courseRepository.SaveCourse(courseSaveRequest);
    }

    public void UpdateCourse(CourseUpdateRequest courseUpdateRequest)
    {
        _courseRepository.UpdateCourse(courseUpdateRequest);
    }
}
