using SantasWishlist.Converters;
using SantasWishlist.Models;
using SantasWishlist.Models.DTO;
using SantasWishlist.Repositories;

namespace SantasWishlist.Services
{
    public class PersonService
    {

        private readonly PersonRepository _repo;
        private readonly PersonConverter _converter;

        public PersonService(PersonRepository repo, PersonConverter converter)
        {
            _repo = repo;
            _converter = converter;
        }

        public void Delete(string id)
        {
            _repo.Delete(id);
        }

        public PersonDTO Create(PersonDTO person)
        {
            Person dbPerson = _repo.Create(_converter.ToDbModel(person));
            return _converter.ToDTO(dbPerson);
        }

        public PersonDTO Read(string id)
        {
            Person dbPerson = _repo.Read(id);
            return _converter.ToDTO(dbPerson);
        }

        public List<PersonDTO> ReadAll()
        {
            List<Person> dbPersons = _repo.ReadAll();
            return _converter.ToDTO(dbPersons);
        }

    }
}
