using System;
using Microsoft.EntityFrameworkCore;
using semester_projekt.Shared.Models;


namespace semester_projekt.Server.Data
{
	public class KoordinatorContext : DbContext
	{
		public virtual DbSet<Vagt> crudVagt { get; set; }

		protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql
                    ("User ID=postgres;Password=qrm49zyp;Host=localhost;Port=5432;Database=2_semester_projekt;");
            }
        }

	}
}

