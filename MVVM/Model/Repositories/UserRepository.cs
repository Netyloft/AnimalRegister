using AnimalRegister.MVVM.Model.Mappers;

namespace AnimalRegister.MVVM.Model.Repositories
{
    public class UserRepository
    {
        private readonly UserEntityMapper _userEntityMapper = new UserEntityMapper();
        
        //todo Реализовать репозиторий
        public User GetUser(User user)
        {
            var result = new User();
            return _userEntityMapper.ToDto();
        }
    }
}