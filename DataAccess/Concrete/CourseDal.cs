using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class CourseDal : IGenericDal<Course>
{
    List<Course> courses = new List<Course>();
    public void Add(Course entity)
    {
        courses.Add(entity);
    }

    public Course Delete(Course entity)
    {
        Course deleteCourse = courses.SingleOrDefault(x => x.Id == entity.Id);
        if (deleteCourse != null)
        {
            courses.Remove(entity);
            return deleteCourse;
        }
        else
        {
            return null;
        }
    }

    public Course Update(Course entity)
    {
        Course updateCourse = courses.SingleOrDefault(x => x.Id == entity.Id);
        if (updateCourse != null)
        {
            updateCourse.Description = entity.Description;
            updateCourse.Instructor = entity.Instructor;
            updateCourse.ImageUrl = entity.ImageUrl;
            updateCourse.CourseProgram = entity.CourseProgram;
            updateCourse.Category = entity.Category;
            updateCourse.Price = entity.Price;
            updateCourse.Name = entity.Name;
            return updateCourse;
        }
        else
        {
            return null;
        }
    }

    public List<Course> GetAll()
    {
        return courses;
    }
}