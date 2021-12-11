using AnimalRegister.MVVM.Model.Mappers;

namespace AnimalRegister.MVVM.Model.Repositories
{
    class ScheduleRepository
    {
        private readonly ScheduleCardEntityMapper _scheduleCardEntityMapper = new ScheduleCardEntityMapper();
        //todo Реализовать SheduleRepository
        public ScheduleCard GetId(long id)
        {
   
        }

        public List<ScheduleCard> GetCards(string sort, string filters)
        {

        }

        public void Create(ScheduleCard scheduleCard)
        {

        }

        public void Update(ScheduleCard scheduleCard)
        {

        }

        public void Delete(long id)
        {

        }

        public void AddFile(File file, long id)
        {

        }
    }
}
