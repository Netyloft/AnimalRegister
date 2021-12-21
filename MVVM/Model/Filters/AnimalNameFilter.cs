using FluentNHibernate.Mapping;
using NHibernate;

namespace AnimalRegister.MVVM.Model.Filters
{
    public class AnimalNameFilter : FilterDefinition
    {
        public AnimalNameFilter()
        {
            WithName("Name"); 
            AddParameter("Name", NHibernateUtil.String);
        }
    }
}