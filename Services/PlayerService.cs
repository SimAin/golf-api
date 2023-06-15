namespace WebApi.Services;

using AutoMapper;
using BCrypt.Net;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Players;

public interface IPlayerService
{
    IEnumerable<Player> GetAll();
    Player GetById(int id);
    //void Create(CreateRequest model);
    //void Update(int id, UpdateRequest model);
    void Delete(int id);
}

public class PlayerService : IPlayerService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public PlayerService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<Player> GetAll()
    {
        return _context.player;
    }

    public Player GetById(int id)
    {
        return getPlayer(id);
    }

    //public void Create(CreateRequest model)
    //{
    //    // validate
    //    if (_context.player.Any(x => x.Email == model.Email))
    //        throw new AppException("Player with the email '" + model.Email + "' already exists");

    //    // map model to new player object
    //    var player = _mapper.Map<Player>(model);

    //    // hash password
    //    player.PasswordHash = BCrypt.HashPassword(model.Password);

    //    // save player
    //    _context.player.Add(player);
    //    _context.SaveChanges();
    //}

    //public void Update(int id, UpdateRequest model)
    //{
    //    var player = getPlayer(id);

    //    // validate
    //    if (model.Email != player.Email && _context.player.Any(x => x.Email == model.Email))
    //        throw new AppException("Player with the email '" + model.Email + "' already exists");

    //    // hash password if it was entered
    //    if (!string.IsNullOrEmpty(model.Password))
    //        player.PasswordHash = BCrypt.HashPassword(model.Password);

    //    // copy model to player and save
    //    _mapper.Map(model, player);
    //    _context.player.Update(player);
    //    _context.SaveChanges();
    //}

    public void Delete(int id)
    {
        var player = getPlayer(id);
        _context.player.Remove(player);
        _context.SaveChanges();
    }

    // helper methods

    private Player getPlayer(int id)
    {
        var player = _context.player.Find(id);
        if (player == null) throw new KeyNotFoundException("Player not found");
        return player;
    }
}