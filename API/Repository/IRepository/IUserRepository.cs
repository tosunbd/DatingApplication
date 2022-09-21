using API.Entities;
using API.Entities.DTOs;

namespace API.Repository.IRepository
{
    public interface IUserRepository
    {                
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<IEnumerable<MemberDto>> GetMembersAsync();
        Task<MemberDto> GetMemberByIdAsync(int id);
        Task<MemberDto> GetMemberByUsernameAsync(string username);
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
    }
}