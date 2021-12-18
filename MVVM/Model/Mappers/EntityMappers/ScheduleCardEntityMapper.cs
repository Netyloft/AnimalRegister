using FluentNHibernate.Mapping;

namespace AnimalRegister.MVVM.Model
{
    public class ScheduleCardEntityMapper:ClassMap<ScheduleCard>
    {
        public ScheduleCardEntityMapper()
        {
            Id(x => x.Id).Column("Id");
            Map(x => x.Status).Column("Status");
            Map(x => x.Date).Column("Date");
            Map(x => x.Locality).Column("Locality");
            Map(x => x.StatusDate).Column("StatusDate");
            Map(x => x.District).Column("District");
            References(x => x.MunicipalitiesId).Column("LocalGovernmentId").Fetch.Join();
            References(x => x.OrganizationId).Column("OrganizationId").Fetch.Join();
            Table("ScheduleCard");
        }
    }
}