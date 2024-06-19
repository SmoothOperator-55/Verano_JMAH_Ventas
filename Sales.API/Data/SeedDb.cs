using Microsoft.EntityFrameworkCore;
using Sales.Shared.Entities;

namespace Sales.API.Data
{
	public class SeedDb
	{
		private readonly DataContext _context;

		public SeedDb(DataContext contex)
		{
			_context = contex;
		}

		public async Task SeedAsync()
		{
			await _context.Database.EnsureCreatedAsync();

			await CheckCountriesAync();
		}

		private async Task CheckCountriesAync()
		{
			if (!_context.Countries.Any())
			{
				_context.Countries.Add(new Country { Name = "México" });
				_context.Countries.Add(new Country { Name = "Rusia" });
				_context.Countries.Add(new Country { Name = "China" });
				_context.Countries.Add(new Country { Name = "Irán" });
				await _context.SaveChangesAsync();
			}

		}
	}
}