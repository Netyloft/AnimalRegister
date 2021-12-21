using System;
using System.Collections.Generic;
using AnimalRegister.MVVM.Model.Mappers;
using AnimalRegister.MVVM.Model.Validators;

namespace AnimalRegister.MVVM.Model.Controllers
{
    public class LoginController
    {
        private readonly LoginService _service = new LoginService();
        
        public Dictionary<string, string> Login(Dictionary<string, string> data)
        {
            var isValid = LoginValidator.Validate(data);

            if (isValid["validationStatus"].Equals("INVALID"))
                return isValid;
            
            var user = LoginMapper.GetUser(data);
            user = _service.Login(user);
            
            if (user.Id != 0)
            {
                var authorizedUser = new AuthorizedUser(user);
                return LoginMapper.GetResult(user);
            }

            return isValid;
        }
    }
}