using CalcolatoreCFWeb.Data;
using CalcolatoreCFWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcolatoreCFWeb.Controllers
{
    public class UsersController : Controller
    {


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
            
            Console.WriteLine(u.Ssn);

            if (u.Ssn.Length == 16)
            {
                return Content(u.Ssn.ToUpper());
            }
            else
            {
                return BadRequest("Parametri Errati");
            }
        }




    }
}
