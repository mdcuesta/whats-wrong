using System.Linq;

namespace Sampler.Codes
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class Database
    {
        public IQueryable<Person> Persons { get; set; }
    }

    public class SampleRepository
    {
        private readonly Database database;

        public SampleRepository(Database database)
        {
            this.database = database;
        }

        public Person Get(int id)
        {
            return this.database.Persons.FirstOrDefault(p => p.Id == id);
        }

        public IQueryable<Person> GetAll()
        {
            return this.database.Persons;
        }
    }
}
