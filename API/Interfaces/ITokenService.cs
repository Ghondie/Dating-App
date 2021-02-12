using API.Entities;

namespace API.Interfaces

// Interface dosent any inplementation logic only functionality

{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}