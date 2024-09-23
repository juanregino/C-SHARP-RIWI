
using AutoMapper;
using C__RIWI.src.Api.Dtos.Request;
using C__RIWI.src.Api.Dtos.Response.BasicResponse;
using C__RIWI.src.Domain.Entities;
using C__RIWI.src.Domain.Repositories.Abstract_Repositories;
using C__RIWI.src.Infraestructure.Abstract_Services;

namespace C__RIWI.src.Infraestructure.Services
{
    public class UserService : IUserService<UserResponse, UserRequest>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService( IUserRepository userRepository , IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        

        public async Task<UserResponse> Create(UserRequest request)
        {
            var user = _mapper.Map<User>(request);

            await _userRepository.Add(user);

            await _userRepository.SaveChanges();
            return _mapper.Map<UserResponse>(user);
            
        }

        public async Task Delete(int id)
        {
            var user = await  _userRepository.GetById(id);
            if (user == null) throw new Exception("User not found");
            _userRepository.Delete(user);

            await _userRepository.SaveChanges();

            
        }
           
        public async Task<IEnumerable<UserResponse>> GetAll()
        { 
            var users =  await _userRepository.GetAll();
            return _mapper.Map<IEnumerable<UserResponse>>(users);
            
        }

        public async Task<UserResponse> GetById(int id)
        {
            var user = await _userRepository.GetById(id);
            return _mapper.Map<UserResponse>(user);
            
        }

        public async Task<UserResponse> Update(int id, UserRequest request)
        {
            var user = await _userRepository.GetById(id);
            if (user == null)  throw new Exception("User not found");

            user = _mapper.Map<User>(request);

            _userRepository.Update(user);

            await _userRepository.SaveChanges();

            return _mapper.Map<UserResponse>(user);
        } 
    }   
}