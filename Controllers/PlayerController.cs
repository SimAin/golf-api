namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Players;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{
    private IPlayerService _playerService;
    private IMapper _mapper;

    public PlayerController(
        IPlayerService playerService,
        IMapper mapper)
    {
        _playerService = playerService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var players = _playerService.GetAll();
        return Ok(players);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var player = _playerService.GetById(id);
        return Ok(player);
    }

    //[HttpPost]
    //public IActionResult Create(CreateRequest model)
    //{
    //    _playerService.Create(model);
    //    return Ok(new { message = "Player created" });
    //}

    //[HttpPut("{id}")]
    //public IActionResult Update(int id, UpdateRequest model)
    //{
    //    _playerService.Update(id, model);
    //    return Ok(new { message = "Player updated" });
    //}

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _playerService.Delete(id);
        return Ok(new { message = "Player deleted" });
    }
}