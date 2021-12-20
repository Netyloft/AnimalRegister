using System.Collections.Generic;
using AnimalRegister.MVVM.Model.Mappers;
using AnimalRegister.MVVM.Model.NHibernate;
using NHibernate;

namespace AnimalRegister.MVVM.Model.Repositories
{
    class ScheduleRepository
    {
        //todo реализовать выгрузку списка с фильтрами
        // public List<ScheduleCard> GetCards(string sort, string filters)
        // {
        //
        // }

        public List<ScheduleCard> GetAll()
        {
            using ISession session = NHibernateHelper.OpenSession();
            return new List<ScheduleCard>(session.CreateCriteria(typeof(ScheduleCard)).List<ScheduleCard>());
        }
        
        public ScheduleCard Get(long id)
        {
            using ISession session = NHibernateHelper.OpenSession();
            return session.QueryOver<ScheduleCard>().Where(x => x.Id == id).SingleOrDefault();
        }


        public void Create(ScheduleCard animalCard)
        {
            using ISession session = NHibernateHelper.OpenSession();
            using ITransaction transaction = session.BeginTransaction();
            session.Save(animalCard);
            transaction.Commit();
        }
        
        public void Update(ScheduleCard animalCard)
        {
            using ISession session = NHibernateHelper.OpenSession();
            using ITransaction transaction = session.BeginTransaction();
            session.Update(animalCard);
            transaction.Commit();
        }

        public void Delete(ScheduleCard animalCard)
        {
            using ISession session = NHibernateHelper.OpenSession();
            using ITransaction transaction = session.BeginTransaction();
            session.Delete(animalCard);
            transaction.Commit();
        }
    }
}