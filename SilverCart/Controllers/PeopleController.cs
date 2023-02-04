using LinqToDB;
using Microsoft.AspNetCore.Mvc;
using SilverCart.Data;
using SilverCart.Entities;

namespace SilverCart.Controllers
{
    public class PeopleController : Controller
    {
        private readonly AppDataConnection _connection;

        public PeopleController(AppDataConnection connection)
        {
            _connection = connection;
        }

        [HttpGet("ListPeople")]
        public Task<Person[]> ListPeople()
        {
            return _connection.People.ToArrayAsync();
        }

        [HttpGet("{id}")]
        public Task<Person?> GetPerson(Guid id)
        {
            return _connection.People.SingleOrDefaultAsync(person => person.Id == id);
        }

        [HttpDelete("{id}")]
        public Task<int> DeletePerson(Guid id)
        {
            return _connection.People.Where(person => person.Id == id).DeleteAsync();
        }

        [HttpPut("addPerson")]
        public async Task<int> AddPerson(Person person)
        {
            return await  _connection.InsertAsync(person);
        }

        [HttpPatch]
        public Task<int> UpdatePerson(Person person)
        {
            return _connection.UpdateAsync(person);
        }

        [HttpPatch("{id}/new-name")]
        public Task<int> UpdatePersonName(Guid id, string newName)
        {
            return _connection.People.Where(person => person.Id == id)
                .Set(person => person.Name, newName)
                .UpdateAsync();
        }

        [HttpPut]
        public Task<int> InsertPerson(Person person)
        {
            return _connection.InsertAsync(person);
        }
    }
}
