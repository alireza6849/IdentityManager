using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityManagerServer.Data
{
	public class AppDbContext(DbContextOptions options) : IdentityDbContext<ApplicationUser>(options)
	{
	
	}
}
