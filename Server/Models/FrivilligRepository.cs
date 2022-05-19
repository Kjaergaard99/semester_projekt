using System;
using semester_projekt.Shared.Models;

namespace semester_projekt.Server.Models
{
	internal class FrivilligRepository : IFrivilligRepository
	{
		FestivalDBContext db = new FestivalDBContext(); // skal denne linje være ligesom mini-projekt?

		/*
		public List<Vagt> GetMineVagter()
        {
            Console.WriteLine("getMineVagter frivilligRepository");
			// kode; Find.ToList eller noget i den dur. Eller skal de være sql queries?
		}
		*/
		/*
		public List<Vagt> GetLedigeVagter()
        {
            Console.WriteLine("getLedigeVagter frivilligRepository");
			// kode; Find.ToList eller noget i den dur
        }
		*/

		public void BookVagt(Vagt vagt)
        {
            Console.WriteLine("bookVagt frivilligRepository");
        }



		public FrivilligRepository()
		{
		}
	}
}

