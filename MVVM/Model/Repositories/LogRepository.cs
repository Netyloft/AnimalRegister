using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalRegister.MVVM.Model.Repositories
{
    class LogRepository
    {
        public static void AddLog(Journal journal)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(journal); 
                    transaction.Commit();
                }
            }
        }
    }
}
