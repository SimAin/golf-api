namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
//using WebApi.Models.Courses;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class CourseController : ControllerBase
{
    private ICourseService _courseService;
    private IMapper _mapper;

    public CourseController(
        ICourseService courseService,
        IMapper mapper)
    {
        _courseService = courseService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var courses = _courseService.GetAll();
        return Ok(courses);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var course = _courseService.GetById(id);
        return Ok(course);
    }

    //[HttpPost]
    //public IActionResult Create(CreateRequest model)
    //{
    //    _courseService.Create(model);
    //    return Ok(new { message = "Course created" });
    //}

    //[HttpPut("{id}")]
    //public IActionResult Update(int id, UpdateRequest model)
    //{
    //    _courseService.Update(id, model);
    //    return Ok(new { message = "Course updated" });
    //}

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _courseService.Delete(id);
        return Ok(new { message = "Course deleted" });
    }
}