using AnimalRegister.MVVM.Model.Mappers;
using AnimalRegister.MVVM.Model.NHibernate;
using NHibernate;

namespace AnimalRegister.MVVM.Model.Repositories
{
    public class UserRepository
    {
        private readonly UserEntityMapper _userEntityMapper = new UserEntityMapper();

        //todo Реализовать репозиторий
        public User GetUser(User user)
        {
            using ISession session = NHibernateHelper.OpenSession();
            var res = session.QueryOver<User>().Where(x => x.Login == user.Login && x.Password == user.Password)
                .SingleOrDefault();

            return res ?? user;
        }

        public void CreateOrUpdate(User user)
        {
            using ISession session = NHibernateHelper.OpenSession();
            using ITransaction transaction = session.BeginTransaction();
            session.SaveOrUpdate(user);
            transaction.Commit();
        }
        
        public void Delete(User user)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(user);
                    transaction.Commit();
                }
            }
        }
    }
}