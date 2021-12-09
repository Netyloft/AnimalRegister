using System;
using System.Collections.Generic;
using AnimalRegister.MVVM.Model.Repositories;

namespace AnimalRegister.MVVM.Model.Controllers
{
    public class LoginService
    {
        private readonly UserRepository _userRepository = new UserRepository();
        public User Login(User user)
        {
            return _userRepository.GetUser(user);
        }
    }
}