using SantasWishlist.Models;
using SantasWishlist.Models.DTO;

namespace SantasWishlist.Converters
{
    public class PersonConverter
    {
        public List<PersonDTO> ToDTO(List<Person> personList)
        {
            List<PersonDTO> persons = new();
            personList.ForEach(person => persons.Add(ToDTO(person)));
            return persons;
        }

        public PersonDTO ToDTO(Person person)
        {
            return new PersonDTO
            {
                Name = person.Name,
                Country = person.Country,
                KindnessTier = ConvertKindnessRating(person.KindnessRating)
            };
        }

        public Person ToDbModel(PersonDTO person)
        {
            return new Person
            {
                Name = person.Name,
                Country = person.Country,
                KindnessRating = Int32.Parse(person.KindnessTier),
                Id = RandomString(32)
            };
        }

        private Random random = new Random();

        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string ConvertKindnessRating(int rating)
        {
            if (rating < 33)
                return "Bad";
            else if (rating > 67)
                return "Good";
            else
                return "Average";
        }

    }
}
