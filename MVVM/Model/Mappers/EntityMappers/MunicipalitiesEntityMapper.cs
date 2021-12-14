using FluentNHibernate.Mapping;

namespace AnimalRegister.MVVM.Model
{
    public class MunicipalitiesEntityMapper:ClassMap<Municipalities>
    {
        public MunicipalitiesEntityMapper()
        {
            Id(x => x.Id).Column("Id");
            Map(x => x.Name).Column("Name");
            Map(x => x.LocalGovernment).Column("LocalGovernment");
            Table("Municipalities");
        }
    }
}