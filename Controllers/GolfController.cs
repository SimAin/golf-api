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

    [HttpGet("scorecard/score/{scoreid}")]
    public IActionResult GetByScoreId(int scoreid)
    {
        var score = _scoreService.GetById(scoreid);
        var scoreList = score.getScoreList();
        var course = _courseService.GetById(score.Courseid);
        var parList = course.getParList();
        var scorecard = new Scorecard(course, score, scoreList, parList);

        return Ok(scorecard);
    }

    [HttpGet("scorecard/course/{courseid}")]
    public IActionResult GetByCourseId(int courseid)
    {
        var scores = _scoreService.GetByCourseId(courseid);
        var course = _courseService.GetById(courseid);
        var scorecards = new List<Scorecard> ();

        foreach (var score in scores)
        {
            var scoreList = score.getScoreList();
            var parList = course.getParList();
            var scorecard = new Scorecard(course, score, scoreList, parList);
            scorecards.Add(scorecard);
        }

        return Ok(scorecards);
    }
}