using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CourseManager : IGenericService<Course>
{
    private readonly IGenericDal<Course> _genericDal;

    public CourseManager(IGenericDal<Course> genericDal)
    {
        _genericDal = genericDal;
    }
    
    public void Add(Course entity)
    {
        _genericDal.Add(entity);
    }

    public Course Delete(Course entity)
    {
        Course deletedCourse = _genericDal.Delete(entity);
        return deletedCourse;
    }

    public Course Update(Course entity)
    {
        Course updatedCourse = _genericDal.Update(entity);
        return updatedCourse;
    }

    public List<Course> GetAll()
    {
        return _genericDal.GetAll();
    }
}