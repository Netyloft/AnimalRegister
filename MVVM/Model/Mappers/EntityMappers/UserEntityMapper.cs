using FluentNHibernate.Mapping;

namespace AnimalRegister.MVVM.Model
{
    public class UserEntityMapper:ClassMap<User>
    {
        public UserEntityMapper()
        {
            Id(x => x.Id).Column("Id");
            Map(x => x.Name).Column("Name");
            Map(x => x.Login).Column("Login");
            Map(x => x.Password).Column("Password");
            References(x => x.RightsId).Column("RoleId").Fetch.Join();
            References(x => x.OrganizationId).Column("OrganizationId").Fetch.Join();
            References(x => x.MunicipalityId).Column("LocalGovernmentId").Fetch.Join();
            Table("Userss");
        }
    }
}