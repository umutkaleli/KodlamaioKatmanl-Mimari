using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class InstructorManager : IGenericService<Instructor>
{
    private readonly IGenericDal<Instructor> _genericDal;

    public InstructorManager(IGenericDal<Instructor> genericDal)
    {
        _genericDal = genericDal;
    }
    
    public void Add(Instructor entity)
    {
        _genericDal.Add(entity);
    }

    public Instructor Delete(Instructor entity)
    {
        Instructor deletedInstructor = _genericDal.Delete(entity);
        return deletedInstructor;
    }

    public Instructor Update(Instructor entity)
    {
        Instructor updatedInstructor = _genericDal.Update(entity);
        return updatedInstructor;
    }

    public List<Instructor> GetAll()
    {
        return _genericDal.GetAll();
    }
}