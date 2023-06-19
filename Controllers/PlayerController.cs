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

    [HttpGet("{playerid}")]
    public IActionResult GetById(int playerid)
    {
        var player = _playerService.GetById(playerid);
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

    [HttpDelete("{playerid}")]
    public IActionResult Delete(int playerid)
    {
        _playerService.Delete(playerid);
        return Ok(new { message = "Player deleted" });
    }
}