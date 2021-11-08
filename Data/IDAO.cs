using CalcolatoreCFWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcolatoreCFWeb.Data
{
    public interface IDAO
    {

        public List<User> GetAll();

        public void Add(User u);
        public bool Delete(string ssn);


    }
}
