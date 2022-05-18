using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using semester_projekt.Server.Data;
using semester_projekt.Shared.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace semester_projekt.Server.Controllers
{
    [Route("api/vagter")]

    public class TestController : Controller
    {
        private KoordinatorDbOperations vagter = new KoordinatorDbOperations();

        // GET: /<controller>/
        public IEnumerable<Vagt> GetAlleVagter()
        {
            return vagter.GetAlleVagter();
        }


    }
}

