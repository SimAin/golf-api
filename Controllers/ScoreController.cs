namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Scores;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class ScoreController : ControllerBase
{
    private IScoreService _scoreService;
    private IMapper _mapper;

    public ScoreController(
        IScoreService scoreService,
        IMapper mapper)
    {
        _scoreService = scoreService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var scores = _scoreService.GetAll();
        return Ok(scores);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var score = _scoreService.GetById(id);
        return Ok(score);
    }

    [HttpPost]
    public IActionResult Create(CreateRequest model)
    {
        _scoreService.Create(model);
        return Ok(new { message = "Score created" });
    }

    //[HttpPut("{id}")]
    //public IActionResult Update(int id, UpdateRequest model)
    //{
    //    _scoreService.Update(id, model);
    //    return Ok(new { message = "Score updated" });
    //}

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _scoreService.Delete(id);
        return Ok(new { message = "Score deleted" });
    }
}