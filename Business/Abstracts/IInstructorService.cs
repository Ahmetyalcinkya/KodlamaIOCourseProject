using DataTransferObjects;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IInstructorService
{
    void SaveInstructor(InstructorSaveRequest instructorSaveRequest);
    void UpdateInstructor(InstructorUpdateRequest ınstructorUpdateRequest);
    void DeleteInstructor(int id);
    List<Instructor> GetAll();
}
