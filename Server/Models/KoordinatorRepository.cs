using System;
using semester_projekt.Shared.Models;

namespace semester_projekt.Server.Models
{
	public class KoordinatorRepository : IKoordinatorRepository
	{
		FestivalDBContext db = new FestivalDBContext(); // skal denne linje være ligesom mini-projekt?

		/*
		public List<Vagt> GetAlleVagter()
        {
            Console.WriteLine("getAlleVagter koordinatorRepository");
			// kode; Find.ToList eller noget i den dur
		}
		*/
		
		public void AddVagt(Vagt vagt)
        {
            Console.WriteLine("addVagt koordinatoRepository");
			// kode; insertOne(vagt)
        }


		public void UpdateVagt(int id)
		{
			Console.WriteLine("addVagt koordinatoRepository");
			// kode; updateOne(id)
		}

		public void DeleteVagt(int id)
		{
			Console.WriteLine("addVagt koordinatoRepository");
			// kode; deleteOne(id) tror jeg, eller skal det være sql queries?
		}

		/*
		public List<Vagt> GetAlleFrivillige()
        {
			Console.WriteLine("getAlleFrivillige koordinatoRepository");
			// kode; find.ToList tror jeg eller skal det være sql queries?
		}
		*/


		public KoordinatorRepository()
		{
		}
	}
}

