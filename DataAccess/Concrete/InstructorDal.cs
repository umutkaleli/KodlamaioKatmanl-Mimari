using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class InstructorDal : IGenericDal<Instructor>
{
    List<Instructor> instructors = new List<Instructor>();
    
    public void Add(Instructor entity)
    {
        instructors.Add(entity);
    }

    public Instructor Delete(Instructor entity)
    {
        Instructor deleteInstructor = instructors.SingleOrDefault(x => x.Id == entity.Id);
        if (deleteInstructor != null)
        {
            instructors.Remove(entity);
            return deleteInstructor;
        }
        else
        {
            return null;
        }
    }

    public Instructor Update(Instructor entity)
    {
        Instructor updateInstructor = instructors.SingleOrDefault(x => x.Id == entity.Id);
        if (updateInstructor != null)
        {
            updateInstructor.Description = entity.Description;
            updateInstructor.ImageUrl = entity.ImageUrl;
            updateInstructor.Name = entity.Name;
            return updateInstructor;
        }
        else
        {
            return null;
        }
        
    }

    public List<Instructor> GetAll()
    {
        return instructors;
    }
}