using DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Context;

public class GraphContext : DbContext
{
	public GraphContext(DbContextOptions<GraphContext> options) : base(options)
	{

	}

	public virtual DbSet<Group> Group { get; set; }

	public virtual DbSet<Product> Product { get; set; }
}
