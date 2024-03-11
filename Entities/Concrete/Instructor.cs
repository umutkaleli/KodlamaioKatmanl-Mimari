using Entities.Abstract;

namespace Entities.Concrete;

public class Instructor : BaseEntity
{
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}