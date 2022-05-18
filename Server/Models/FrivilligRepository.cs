using System;
using semester_projekt.Shared.Models;

namespace semester_projekt.Server.Models
{
	internal class FrivilligRepository : IFrivilligRepository
	{
		FestivalDBContext db = new FestivalDBContext();


		public void BookShelter(Vagt vagt)
        {
			
        }



		public FrivilligRepository()
		{
		}
	}
}

