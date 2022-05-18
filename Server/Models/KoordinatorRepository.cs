using System;
using semester_projekt.Shared.Models;

namespace semester_projekt.Server.Models
{
	public class KoordinatorRepository : IKoordinatorRepository
	{
		FestivalDBContext db = new FestivalDBContext();

		public List<Vagt> GetAlleVagter()
        {
            Console.WriteLine("getAlleVagter koordinatorRepository");
			// kode; find.toList
        }

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
			// kode; deleteOne(id)
		}



		public KoordinatorRepository()
		{
		}
	}
}

