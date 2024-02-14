using DataTransferObjects;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public interface CategoryRepository
{
    void SaveCategory(CategorySaveRequest categorySaveRequest);
    void UpdateCategory(CategoryUpdateRequest categorySaveRequest);
    void DeleteCategory(int id);
    List<Category> GetAllCategories();
    Category GetCategory(int id);
}
