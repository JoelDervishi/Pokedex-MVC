using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Pokedex_MVC.Models;

namespace Pokedex_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) {
        _logger = logger;
    }

    public static List<Pokemon> ReadThingsFromCSV(string filePath) {
        List<Pokemon> things = new List<Pokemon>();

        using (StreamReader reader = new StreamReader(filePath)) {
            // Skip the header line if needed
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                string[] data = reader.ReadLine()!.Split('|');
                for(int i = 0; i < data.Length; i++){
                    data[i] = data[i].Trim();
                }

                things.Add(new Pokemon {
                    DexId = int.Parse(data[0])
                    });
            }
        }
        return things;
    }
    public static void ReadRelationsFromCSV(string filePath) {
        List<Pokemon_Move> things = new List<Pokemon_Move>();

        using (StreamReader reader = new StreamReader(filePath)) {
            // Skip the header line if needed
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                string[] data = reader.ReadLine()!.Split('|');
                for(int i = 0; i < data.Length; i++){
                    data[i] = data[i].Trim();
                }

                things.Add(new Pokemon_Move {
                    PokemonDexId = int.Parse(data[0]),
                    MoveId = int.Parse(data[1])
                    });
            }
        }
        foreach (var e in things) {
        using (var context = new PokemonContext()) {
            var first = context.Pokemons.SingleOrDefault(a => a.DexId == e.PokemonDexId);
            var second = context.Moves.SingleOrDefault(b => b.Id == e.MoveId);

            if (first != null && second != null) {
                // Avoid adding duplicate entries
                var existingRelation = context.Set<Pokemon_Move>()
                    .SingleOrDefault(pa => pa.PokemonDexId == e.PokemonDexId && pa.MoveId == e.MoveId);

                if (existingRelation == null) {
                    // Attach entities to the context if not already tracked
                    context.Entry(first).State = EntityState.Unchanged;
                    context.Entry(second).State = EntityState.Unchanged;

                    e.Pokemon = first;
                    e.Move = second;

                    context.Add(e);
                    context.SaveChanges();
                    }
                }
            }
        }
    }

    public static void InsertThingsIntoDatabase(List<Pokemon> things) {
        using (var context = new PokemonContext()) {
            context.Pokemons.AddRange(null!); //things
            context.SaveChanges();
        }
    }

    public IActionResult Index() {
        return View();
    }

    [HttpPost]
    public IActionResult InsertBaseCSV() {
        //InsertThingsIntoDatabase(ReadThingsFromCSV("./CSV/Pokemon.csv"));
        ReadRelationsFromCSV("./CSV/Pokemon_Move.csv");
        Console.WriteLine("done");
        return RedirectToAction("Index", "Home");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() { return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }); }
}