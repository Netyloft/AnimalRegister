using FluentNHibernate.Mapping;

namespace AnimalRegister.MVVM.Model
{
    public class OrganizationEntityMapper:ClassMap<Organization>
    {
        public OrganizationEntityMapper()
        {
            Id(x => x.Id).Column("Id");
            Map(x => x.Name).Column("Name");
            Map(x => x.Address).Column("Address");
            Table("Organization");
        }
    }
}