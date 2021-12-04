using CalcolatoreCFWeb.Data;
using CalcolatoreCFWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using System.Reflection;
using log4net.Repository;
using System.IO;

namespace CalcolatoreCFWeb.Controllers
{
    public class UsersController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);





        public IActionResult Calcola(Dictionary<string, string> form)
        {


            // Load configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            User u = null;

            try
            {
                u = new User
                {
                    LastName = form["lastName"],
                    FirstName = form["firstName"],
                    Dob = DateTime.Parse(form["dob"]),
                    Gender = form["gender"],
                    Pob = form["pob"]
                };
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            finally
            {
                u.CreateSsn();
            }
           

           

            if (u.Ssn.Length == 16)
            {
                log.Info(new StringBuilder("SSN = ").Append(u.Ssn).ToString());
                return Content(u.Ssn.ToUpper());
            }
            else
            {
                log.Error("Codice Fiscale di caratteri inferiori a 16");
                return BadRequest("Parametri Errati");
            }
        }




    }
}
