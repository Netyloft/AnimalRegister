using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace AnimalRegister.MVVM.Model.NHibernate
{
    public class NHibernateHelper
    {
        public NHibernateHelper()
        {
            InitializeSessionFactory();
        }

        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory();

                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            // _sessionFactory = Fluently.Configure().Database(
            //         MsSqlConfiguration.MsSql2008.ConnectionString(
            //             cs => 
            //                 cs.Server("DESKTOP-OGHSGCQ")
            //                     .Database("AnimalRegister")))
            //     .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateHelper>())
            //     .BuildSessionFactory();
            _sessionFactory = Fluently.Configure().Database(
                    MsSqlConfiguration.MsSql2008.ConnectionString("Data Source=DESKTOP-OGHSGCQ;Initial Catalog=AnimalRegister;Integrated Security=True"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateHelper>())
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}