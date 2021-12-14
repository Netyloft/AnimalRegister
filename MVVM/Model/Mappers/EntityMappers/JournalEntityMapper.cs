using FluentNHibernate.Mapping;

namespace AnimalRegister.MVVM.Model
{
    public class JournalEntityMapper : ClassMap<Journal>
    {
        public JournalEntityMapper()
        {
            Id(x => x.Id).Column("Id");
            Map(x => x.Date).Column("Date");
            Map(x => x.Status).Column("Status");
            Map(x => x.Operation).Column("Operation");
            References(x => x.UserId).Column("UserId").Fetch.Join();
            Table("Journal");
        }
    }
}