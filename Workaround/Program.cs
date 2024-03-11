using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace Workaround;

class Program
{
    static void Main(string[] args)
    {
        Category category1 = new Category
        {
            Id = "1",
            Name = "Programming"
        };
        Category category2 = new Category
        {
            Id = "2",
            Name = "All"
        };

        Instructor ınstructor1 = new Instructor
        {
            Id = "1",
            Name = "Engin Demiroğ",
            ImageUrl = "https:/lfaflaf.com",
            Description = ""
        };
        Instructor ınstructor2 = new Instructor
        {
            Id = "2",
            Name = "Umut Kaleli",
            ImageUrl = "https:/fadglald.com",
            Description = ""
        };

        Course course1 = new Course
        {
            Id = "1",
            Name = "C# Yazılım Geliştirme",
            Description = "En iyi kurs",
            Category = category1,
            Instructor = ınstructor1,
            ImageUrl = "https:/lrshgslkag.com",
            Price = 0,
            CourseProgram = ""
        };
        Course course2 = new Course
        {
            Id = "2",
            Name = "JAVA Yazılım Geliştirme",
            Description = "En iyi Java kursu",
            Category = category1,
            Instructor = ınstructor1,
            ImageUrl = "https:/fakgljlagja.com",
            Price = 0,
            CourseProgram = ""
        };

        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        
        categoryManager.Add(category1);
        categoryManager.Add(category2);

        CourseManager courseManager = new CourseManager(new CourseDal());
        
        courseManager.Add(course1);
        courseManager.Add(course2);
        Console.WriteLine(courseManager.GetAll());

        InstructorManager ınstructorManager = new InstructorManager(new InstructorDal());
        ınstructorManager.Add(ınstructor1);
        ınstructorManager.Add(ınstructor2);
    }
}