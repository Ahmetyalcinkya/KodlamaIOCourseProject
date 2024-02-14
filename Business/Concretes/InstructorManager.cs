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

public class InstructorManager : IInstructorService
{
    private readonly InstructorRepository _instructorRepository;

    public InstructorManager(InstructorRepository instructorRepository)
    {
        _instructorRepository = instructorRepository;
    }
    public void DeleteInstructor(int id)
    {
        _instructorRepository.DeleteInstructor(id);
    }

    public List<Instructor> GetAll()
    {
        return _instructorRepository.GetAll();
    }

    public void SaveInstructor(InstructorSaveRequest instructorSaveRequest)
    {
       _instructorRepository.SaveInstructor(instructorSaveRequest);
    }

    public void UpdateInstructor(InstructorUpdateRequest ınstructorUpdateRequest)
    {
        _instructorRepository.UpdateInstructor(ınstructorUpdateRequest);
    }
}
