using CalcolatoreCFWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcolatoreCFWeb.Data
{
    public class DAOUsers : IDAO
    {
        
        //Grazie al pattern Dependency Injection, invocheremo il
        //pattern singleton all'interno dello Startup.cs e non qui


        public List<User> Users { get; set; }

        public void Add(User u)
        {
            u.CreateSsn();
            Users.Add(u);
        }

        public bool Delete(string ssn)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return Users;
        }
    }
}
