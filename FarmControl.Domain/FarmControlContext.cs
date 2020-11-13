using FarmControl.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Linq;

namespace FarmControl.Domain
{
	public class FarmControlContext : FarmControlDevelopmentContext
	{
		public static string ConnectionString
		{
			get { return ConfigurationManager.ConnectionStrings["Database"].ConnectionString; }
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(ConnectionString);
		}

		public IQueryable<T> Repository<T>() where T : class
		{
			return Set<T>().AsQueryable();
		}
	}
}
