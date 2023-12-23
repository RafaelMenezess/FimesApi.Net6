using FimesApi.Net6.Models;
using Microsoft.EntityFrameworkCore;

namespace FimesApi.Net6.Data;

public class FilmeContext : DbContext
{
	public FilmeContext(DbContextOptions<FilmeContext> opts)
		: base(opts)
	{

	}
    public DbSet<Filme> Filmes { get; set; }
}
