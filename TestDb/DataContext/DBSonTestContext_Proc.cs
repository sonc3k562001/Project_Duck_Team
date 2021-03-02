using Microsoft.EntityFrameworkCore;
using TestDb.DataContext.Entities;

namespace TestDb.DataContext
{
	public partial class DBSonTestContext : DbContext
	{

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
		{
		}
	}
}
