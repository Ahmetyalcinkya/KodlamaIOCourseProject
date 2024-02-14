using Business.Abstract;
using DataAccess;
using DataTransferObjects;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly CategoryRepository _categoryRepository;

    public CategoryManager(CategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }


    public void DeleteCategory(int id)
    {
        _categoryRepository.DeleteCategory(id);
    }

    public List<Category> GetAllCategories()
    {
        return _categoryRepository.GetAllCategories();
    }

    public Category GetCategory(int id)
    {
        return _categoryRepository.GetCategory(id);
    }

    public void SaveCategory(CategorySaveRequest categorySaveRequest)
    {
       _categoryRepository.SaveCategory(categorySaveRequest);
    }

    public void UpdateCategory(CategoryUpdateRequest categoryUpdateRequest)
    {
        _categoryRepository.UpdateCategory(categoryUpdateRequest);
    }
}
