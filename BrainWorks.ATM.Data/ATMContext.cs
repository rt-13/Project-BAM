using Microsoft.EntityFrameworkCore;

namespace BrainWorks.ATM.Data
{
	public class ATMContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = @"Data Source=RT-ADEPTUS\SQLEXPRESS15;Initial Catalog=MyShop;Integrated Security=True";
			optionsBuilder.UseSqlServer(connectionString);
		}
	}
}
