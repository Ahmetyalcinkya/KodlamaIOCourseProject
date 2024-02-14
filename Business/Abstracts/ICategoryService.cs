using DataTransferObjects;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface ICategoryService
{
    void SaveCategory(CategorySaveRequest categorySaveRequest);
    void UpdateCategory(CategoryUpdateRequest categoryUpdateRequest);
    void DeleteCategory(int id);
    List<Category> GetAllCategories();
    Category GetCategory(int id);
}
