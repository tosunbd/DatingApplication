using API.Entities.DTOs;
using API.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UsersController : BaseApiController
    {         
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;                     
        }

        // api/users
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            var users = await _userRepository.GetUsersAsync();

            var usersToReturn = _mapper.Map<IEnumerable<MemberDto>>(users);

            return Ok(usersToReturn);
        }

        // api/user/GetUserById/6
        
        [HttpGet("GetUserById/{id}")]
        public async Task<ActionResult<MemberDto>> GetUserById(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);

            var userToReturn = _mapper.Map<MemberDto>(user);

            return userToReturn;
        }

          // api/user/GetUserByUsername/efaz

        [HttpGet("GetUserByUsername/{username}")]
        public async Task<ActionResult<MemberDto>> GetUserByUsername(string username)
        {
             var user = await _userRepository.GetUserByUsernameAsync(username);

            var userToReturn = _mapper.Map<MemberDto>(user);

            return userToReturn;
        }

         // api/users/
        
        [HttpGet("GetMembers")]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetMembers()
        {
            var users = await _userRepository.GetMembersAsync();

            return Ok(users);
        }

        // api/user/GetMemberById/6
        
        [HttpGet("GetMemberById/{id}")]
        public async Task<ActionResult<MemberDto>> GetMemberById(int id)
        {
            return await _userRepository.GetMemberByIdAsync(id);
        }

          // api/user/GetMemberByUsername/efaz

        [HttpGet("GetMemberByUsername/{username}")]
        public async Task<ActionResult<MemberDto>> GetMemberByUsername(string username)
        {
            return await _userRepository.GetMemberByUsernameAsync(username);
        }

    }
}