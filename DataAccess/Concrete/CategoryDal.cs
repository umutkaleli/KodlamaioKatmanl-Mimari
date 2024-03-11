using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class CategoryDal : IGenericDal<Category>
{
    List<Category> categories = new List<Category>();
    
    public void Add(Category entity)
    {
        categories.Add(entity);
    }

    public Category Delete(Category entity)
    {
        Category deleteCategory = categories.SingleOrDefault(x => x.Id == entity.Id);

        if (deleteCategory != null)
        {
            categories.Remove(deleteCategory);
        }

        return deleteCategory;
    }

    public Category Update(Category entity)
    {
        Category updateCategory = categories.SingleOrDefault(x => x.Id == entity.Id);

        if (updateCategory != null)
        {
            updateCategory.Name = entity.Name;
            return updateCategory;
        }
        else
        {
            return null;
        }
    }

    public List<Category> GetAll()
    {
        return categories;
    }
}