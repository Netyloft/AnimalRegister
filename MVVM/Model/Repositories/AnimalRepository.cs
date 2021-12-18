using System.Collections.Generic;
using AnimalRegister.MVVM.Model.Mappers;
using AnimalRegister.MVVM.Model.NHibernate;
using NHibernate;

namespace AnimalRegister.MVVM.Model.Repositories
{
    class AnimalRepository
    {
        //todo реализовать выгрузку списка с фильтрами
        // public List<AnimalCard> GetCards(string sort, string filters)
        // {
        //
        // }

        public List<AnimalCard> GetAll()
        {
            using ISession session = NHibernateHelper.OpenSession();
            return new List<AnimalCard>(session.CreateCriteria(typeof(AnimalCard)).List<AnimalCard>());
        }
        
        public AnimalCard Get(long id)
        {
            using ISession session = NHibernateHelper.OpenSession();
            return  session.QueryOver<AnimalCard>().Where(x => x.Id == id).SingleOrDefault();
        }
        

        public void CreateOrUpdate(AnimalCard animalCard)
        {
            using ISession session = NHibernateHelper.OpenSession();
            using ITransaction transaction = session.BeginTransaction();
            session.SaveOrUpdate(animalCard);
            transaction.Commit();
        }

        public void Delete(AnimalCard animalCard)
        {
            using ISession session = NHibernateHelper.OpenSession();
            using ITransaction transaction = session.BeginTransaction();
            session.Delete(animalCard);
            transaction.Commit();

        }
    }
}
