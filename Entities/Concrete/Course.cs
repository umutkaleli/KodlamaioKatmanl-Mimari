using Entities.Abstract;

namespace Entities.Concrete;

public class Course : BaseEntity
{
    public Instructor Instructor { get; set; }
    public Category Category { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public double Price { get; set; }
    public string CourseProgram { get; set; }
}
