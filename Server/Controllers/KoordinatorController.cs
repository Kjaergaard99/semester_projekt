using System;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using semester_projekt.Shared.Models;
using semester_projekt.Server.Models;


namespace semester_projekt.Server.Controllers
{
    [ApiController]
    [Route("api/allevagter")]
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


    }
}