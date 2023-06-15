namespace WebApi.Services;

using AutoMapper;
using BCrypt.Net;
using WebApi.Entities;
using WebApi.Helpers;
//using WebApi.Models.Courses;

public interface ICourseService
{
    IEnumerable<Course> GetAll();
    Course GetById(int id);
    //void Create(CreateRequest model);
    //void Update(int id, UpdateRequest model);
    void Delete(int id);
}

public class CourseService : ICourseService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public CourseService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<Course> GetAll()
    {
        return _context.course;
    }

    public Course GetById(int id)
    {
        return getCourse(id);
    }

    //public void Create(CreateRequest model)
    //{
    //    // validate
    //    if (_context.Courses.Any(x => x.Email == model.Email))
    //        throw new AppException("Course with the email '" + model.Email + "' already exists");

    //    // map model to new course object
    //    var course = _mapper.Map<Course>(model);

    //    // hash password
    //    course.PasswordHash = BCrypt.HashPassword(model.Password);

    //    // save course
    //    _context.Courses.Add(course);
    //    _context.SaveChanges();
    //}

    //public void Update(int id, UpdateRequest model)
    //{
    //    var course = getCourse(id);

    //    // validate
    //    if (model.Email != course.Email && _context.Courses.Any(x => x.Email == model.Email))
    //        throw new AppException("Course with the email '" + model.Email + "' already exists");

    //    // hash password if it was entered
    //    if (!string.IsNullOrEmpty(model.Password))
    //        course.PasswordHash = BCrypt.HashPassword(model.Password);

    //    // copy model to course and save
    //    _mapper.Map(model, course);
    //    _context.Courses.Update(course);
    //    _context.SaveChanges();
    //}

    public void Delete(int id)
    {
        var course = getCourse(id);
        _context.course.Remove(course);
        _context.SaveChanges();
    }

    // helper methods

    private Course getCourse(int id)
    {
        var course = _context.course.Find(id);
        if (course == null) throw new KeyNotFoundException("Course not found");
        return course;
    }
}