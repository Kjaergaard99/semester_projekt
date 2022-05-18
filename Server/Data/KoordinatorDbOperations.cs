using System;
using semester_projekt.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semester_projekt.Server.Data
{
	public class KoordinatorDbOperations
	{
		KoordinatorContext kc = new KoordinatorContext();

		public IEnumerable<Vagt> GetAlleVagter()
        {
			Console.WriteLine("getallevagter - repository");
			return kc.crudVagt.ToList();
		}




		public KoordinatorDbOperations()
		{
		}
	}
}

