namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Models.Scores;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class GolfController : ControllerBase
{
    private IScoreService _scoreService;
    private ICourseService _courseService;
    private IMapper _mapper;

    public GolfController(
        IScoreService scoreService,
        ICourseService courseService,
        IMapper mapper)
    {
        _scoreService = scoreService;
        _courseService = courseService;
        _mapper = mapper;
    }

    [HttpGet("scorecard/{scoreid}")]
    public IActionResult GetById(int scoreid)
    {
        var score = _scoreService.GetById(scoreid);
        var scoreList = score.getScoreList();
        var course = _courseService.GetById(score.Courseid);
        var parList = course.getParList();
        var scorecard = new Scorecard(course.Name, score.date, scoreList, parList);



        return Ok(scorecard);
    }
}