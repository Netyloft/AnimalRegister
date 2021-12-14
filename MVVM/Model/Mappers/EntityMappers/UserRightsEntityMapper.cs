using FluentNHibernate.Mapping;

namespace AnimalRegister.MVVM.Model
{
    public class UserRightsEntityMapper:ClassMap<UserRights>
    {
        public UserRightsEntityMapper()
        {
            Id(x => x.Id).Column("Id");
            Map(x => x.Name).Column("Name");
            Table("UserRights");
        }
    }
}