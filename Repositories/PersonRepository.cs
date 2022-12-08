using SantasWishlist.Database;
using SantasWishlist.Models;

namespace SantasWishlist.Repositories
{
    public class PersonRepository : IRepository<Person>
    {
        private readonly CommonDbContext _context;

        public PersonRepository(CommonDbContext context)
        {
            _context = context;
        }

        public Person Create(Person entity)
        {
            _context.Person.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(string id)
        {
            _context.Person.Remove(Read(id));
            _context.SaveChanges();
        }

        public Person Read(string id) => _context.Person.FirstOrDefault(x => x.Id == id);

        public List<Person> ReadAll() => _context.Person.ToList();
        

        public Person Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
