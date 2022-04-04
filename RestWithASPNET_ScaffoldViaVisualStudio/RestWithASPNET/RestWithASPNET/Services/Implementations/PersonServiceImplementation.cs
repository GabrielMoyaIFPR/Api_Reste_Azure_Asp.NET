﻿using RestWithASPNET.Models;
using RestWithASPNET.Models.Context;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private MySQLContext _context;
        public PersonServiceImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Gabriel",
                LastName = "Moya",
                Address = "Paranavai - Paraná - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
