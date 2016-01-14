using Liberty.Infrastructure.UnitOfWork;
using Liberty.Models.Users;
using Liberty.Services.Interfaces;
using Liberty.Services.Messagings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberty.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private IUnitOfWork _uow;

        public UserService(
            IUserRepository userRepository,
            IUnitOfWork uow)
        {
            _userRepository = userRepository;
            _uow = uow;
        }

        public bool UserValidation(LogOnRequest request)
        {
            return _userRepository.IsAuthentication(request.UserName, request.Password);
        }

        public void LogOut()
        { }

        public bool Registration(RegisterRequest request)
        {
            try
            {
                User newUser = new User();
                newUser.Username = request.UserName;
                newUser.Password = request.Password;
                newUser.LastLogin = null;
                newUser.DisplayName = request.DisplayName;
                _userRepository.Create(newUser);
                _uow.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void SetLastLogin(string username)
        {
            var user = _userRepository.FindByUserName(username);
            user.LastLogin = DateTime.Now;
            _uow.Commit();
        }
    }
}
