using System;
using System.Collections.Generic;
using System.Text;
using AnimalRegister.MVVM.Model.NHibernate;
using NHibernate;

namespace AnimalRegister.MVVM.Model.Repositories
{
    static class LogRepository
    {
        public static void AddLog(string action, string status)
        {
            var journal = new Journal()
            {
                UserId = AuthorizedUser.authorizedUser.user,
                Date = DateTime.Now,
                Operation = action,
                Status = status
            };
            using ISession session = NHibernateHelper.OpenSession();
            using ITransaction transaction = session.BeginTransaction();
            session.SaveOrUpdate(journal);
            transaction.Commit();
        }
    }
}