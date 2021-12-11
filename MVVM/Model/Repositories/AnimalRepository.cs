using AnimalRegister.MVVM.Model.Mappers;

namespace AnimalRegister.MVVM.Model.Repositories
{
    class AnimalRepository
    {
        private readonly AnimalCardEntityMapper _animalCardEntityMapper = new AnimalCardEntityMapper();
        //todo Реализовать Animal репозиторий
        public AnimalCard GetId(long id)
        {

        }

        public List<AnimalCard> GetCards(string sort, string filters)
        {

        }

        public void Create(AnimalCard animalCard)
        {

        }

        public void Update(AnimalCard animalCard)
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
