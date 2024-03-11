using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CategoryManager : IGenericService<Category>
{
    private readonly IGenericDal<Category> _genericDal;

    public CategoryManager(IGenericDal<Category> genericDal)
    {
        _genericDal = genericDal;
    }
    
    public void Add(Category entity)
    {
        _genericDal.Add(entity);
    }

    public Category Delete(Category entity)
    {
        Category deletedCategory = _genericDal.Delete(entity);
        return deletedCategory;
    }

    public Category Update(Category entity)
    {
        Category updatedCategory = _genericDal.Update(entity);
        return updatedCategory;
    }

    public List<Category> GetAll()
    {
        return _genericDal.GetAll();
    }
}