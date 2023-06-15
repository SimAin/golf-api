namespace WebApi.Helpers;

using AutoMapper;
using WebApi.Entities;
using WebApi.Models.Scores;

public class ScoreProfile : Profile
{
    public ScoreProfile()
    {
        // CreateRequest -> Player
        CreateMap<CreateRequest, Score>();

        // UpdateRequest -> Player
        //CreateMap<UpdateRequest, Player>()
        //    .ForAllMembers(x => x.Condition(
        //        (src, dest, prop) =>
        //        {
        //            // ignore both null & empty string properties
        //            if (prop == null) return false;
        //            if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

        //            // ignore null role
        //            if (x.DestinationMember.Name == "Role" && src.Role == null) return false;

        //            return true;
        //        }
        //    ));
    }
}