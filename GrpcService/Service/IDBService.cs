using System.Collections.Generic;
using System.Threading.Tasks;
using testt.Model;

namespace testt.Service
{
    public interface IDBService
    {
        public IEnumerable<Person> Get();

        public Task<Person> AddPerson(PersonDto person);

        public bool ChangeData(int id, PersonDto person);

        public bool DeleteData(int id);
    }
}
