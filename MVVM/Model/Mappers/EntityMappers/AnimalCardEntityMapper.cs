using AnimalRegister.MVVM.Model.Filters;
using FluentNHibernate.Mapping;

namespace AnimalRegister.MVVM.Model
{
    public class AnimalCardEntityMapper : ClassMap<AnimalCard>
    {
        public AnimalCardEntityMapper()
        {
            Id(x => x.Id).Column("Id");
            Map(x => x.Status).Column("Status");
            Map(x => x.Category).Column("Category");
            Map(x => x.Name).Column("Name");
            Map(x => x.Size).Column("Size");
            Map(x => x.TypeOfWool).Column("TypeOfWool");
            Map(x => x.Gender).Column("Gender");
            Map(x => x.DateOfCatch).Column("DateOfCatch");
            Map(x => x.Locality).Column("Locality");
            Map(x => x.StatusDate).Column("StatusDate");
            Map(x => x.Executor).Column("Executor");
            Map(x => x.Conclusion).Column("Conclusion");
            Map(x => x.Validity).Column("Validity");
            Map(x => x.MCNumber).Column("MCNumber");
            References(x => x.MunicipalityId).Column("MunicipalityId").Fetch.Join();
            References(x => x.OrganizationId).Column("OrganizationId").Fetch.Join();
            ApplyFilter<AnimalNameFilter>("Name = :Name");
            Table("AnimalCard");
        }
    }
}