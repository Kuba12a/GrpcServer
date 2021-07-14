using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testt.Model;

namespace testt.Service
{
    public class DBService : IDBService
    {
        private readonly MyDBContext _context;

        public DBService(MyDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> Get()
        {
            return _context.Person.ToList();

        }

        public async Task<Person> AddPerson(PersonDto personDto)
        {
            var person = new Person
            {
                FirstName = personDto.FirstName,
                LastName = personDto.LastName
            };
            _context.Person.Add(person);
            _context.SaveChanges();

            return person;

        }

        public bool ChangeData(int id, PersonDto personDto)
        {

            var person = _context.Person.SingleOrDefault(b => b.Id == id);
            if (person == null)
            {
                return false;
            }

            person.FirstName = personDto.FirstName;
            person.LastName = personDto.LastName;
            _context.SaveChanges();
            return true;

        }

        public bool DeleteData(int id)
        {
            var person = _context.Person.SingleOrDefault(b => b.Id == id);
            if (person == null)
            {
                return false;
            }

            _context.Person.Remove(person);
            _context.SaveChanges();
            return true;
        }
    }
}
