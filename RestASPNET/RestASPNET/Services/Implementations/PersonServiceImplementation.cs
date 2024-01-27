using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestASPNET.Model;

namespace RestASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public Person Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            throw new NotImplementedException();
        }

        public Person FindByID(long id)
        {
            throw new NotImplementedException();
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}