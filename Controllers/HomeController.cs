using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pokedex_MVC.Models;

namespace Pokedex_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public static List<Pokemon> ReadThingsFromCSV(string filePath)
    {
        List<Pokemon> Pokemons = new List<Pokemon>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            // Skip the header line if needed
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                string[] data = reader.ReadLine().Split('|');

                Pokemons.Add(new Pokemon { DexId = int.Parse(data[0]) });
            }
        }

        return Pokemons;
    }

    public static void InsertThingsIntoDatabase(List<Pokemon> Pokemons)
    {
        using (var context = new PokemonContext())
        {
            context.Pokemons.AddRange(Pokemons);
            context.SaveChanges();
        }


    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}