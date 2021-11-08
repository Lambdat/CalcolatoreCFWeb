using CalcolatoreCFWeb.Data;
using CalcolatoreCFWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcolatoreCFWeb.Controllers
{
    public class UsersController : Controller
    {
        /*
        private readonly IDAO _data;

        public UsersController(IDAO data)
        {
            data = _data;
        }
        */
        public IActionResult Calcola(Dictionary<string,string> form)
        {
            User u = new User
            {
                LastName = form["lastName"],
                FirstName = form["firstName"],
                Dob = DateTime.Parse(form["dob"]),
                Gender = form["gender"],
                Pob = form["pob"]
            };

            u.CreateSsn();

            return Content(u.Ssn);

        }




    }
}
