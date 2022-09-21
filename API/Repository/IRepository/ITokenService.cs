using API.Entities;

namespace API.Repository.IRepository
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}