using FimesApi.Net6.Models;
using Microsoft.AspNetCore.Mvc;

namespace FimesApi.Net6.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 0;

    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {
        filme.Id = id++;
        filmes.Add(filme);

        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Duracao);
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperaFilme([FromQuery]int skip = 0, [FromQuery]int take = 50)
    {
        return filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public Filme? RecuperaFilmeId(int id)
    {
        return filmes.FirstOrDefault(filme => filme.Id == id);         
    }
}