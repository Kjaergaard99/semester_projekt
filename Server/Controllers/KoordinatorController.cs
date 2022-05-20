using System;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using semester_projekt.Shared.Models;
using semester_projekt.Server.Models;
using System;
using Dapper;
using Npgsql;
using semester_projekt.Client.Services;
using System.Net.Http;
using Microsoft.Net.Http;

namespace semester_projekt.Server.Controllers
{
    [ApiController]
    [Route("api/vagter")]

    public class KoordinatorController : ControllerBase
    {
        private readonly IKoordinatorRepository Vagter = new KoordinatorRepository();

        public KoordinatorController(IKoordinatorRepository koordinatorRepository)
        {
            if (Vagter == null && koordinatorRepository != null)
            {
                Vagter = koordinatorRepository;
                Console.WriteLine("Repository initialized");
            }
        }

        [HttpGet]
        public async Task<IEnumerable<Vagt>> GetAlleVagter()
        {
            Console.WriteLine("getAlleVagter - koordinatorController");
            return await Vagter.GetAlleVagter();
        }

        [HttpGet]
        public async Task<IEnumerable<Bruger>> GetAlleFrivillige()
        {
            Console.WriteLine("getAlleFrivillige - koordinatorController");
            return await Vagter.GetAlleFrivillige();
        }

    }
}