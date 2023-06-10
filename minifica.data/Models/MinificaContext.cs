using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace minifica.data.Models
{
	public class MinificaContext : DbContext
	{
		public MinificaContext()
		{
		}

		public MinificaContext(DbContextOptions<MinificaContext> options)
			: base(options)
		{
		}

		public virtual DbSet<Action> Actions { get; set; }
		public virtual DbSet<Country> Countries { get; set; }
		public virtual DbSet<Module> Modules { get; set; }
		public virtual DbSet<ModuleAction> ModulesActions { get; set; }
		public virtual DbSet<Neighbourhood> Neighbourhoods { get; set; }
		public virtual DbSet<Profile> Profiles { get; set; }
		public virtual DbSet<State> States { get; set; }
		public virtual DbSet<Town> Towns { get; set; }
		public virtual DbSet<User> Users { get; set; }
	}
}
