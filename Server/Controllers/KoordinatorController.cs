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
    [Route("api/koordinator")]

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


        [HttpPost]
        public void AddVagt(Vagt vagt)
        {
            Console.WriteLine("addVagt - koordinatorController");
            Vagter.AddVagt(vagt);
        }

        [HttpPost]
        public void UpdateVagt(int vagtId, Vagt vagt)
        {
            Console.WriteLine("updateVagt - koordinatorController");
            Vagter.UpdateVagt(vagtId, vagt);
        }

        [HttpDelete]
        public void DeleteVagt(int vagtId)
        {
            Console.WriteLine("deleteVagt - koordinatorController");
            Vagter.DeleteVagt(vagtId);
        }

        [HttpPost]
        public void AddOpgave(Opgave opgave)
        {
            Console.WriteLine("addOpgave - koordinatorController");
        }

        [HttpGet]
        public async Task<IEnumerable<Bruger>> GetAlleFrivillige()
        {
            Console.WriteLine("getAlleFrivillige - koordinatorController");
            return await Vagter.GetAlleFrivillige();
        }

    }
}