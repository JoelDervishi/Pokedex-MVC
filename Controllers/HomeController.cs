using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Pokedex_MVC.Models;

namespace Pokedex_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) {
        _logger = logger;
    }

    public static List<Move> ReadThingsFromCSV(string filePath) {
        List<Move> things = new List<Move>();

        using (StreamReader reader = new StreamReader(filePath)) {
            // Skip the header line if needed
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                string[] data = reader.ReadLine()!.Split('|');
                for(int i = 0; i < data.Length; i++){
                    data[i] = data[i].Trim();
                }

                things.Add(new Move {
                    Id = int.Parse(data[0]),
                    Name = data[1],
                    Description = data[2]
                    });
            }
        }
        return things;
    }

    public static void InsertThingsIntoDatabase(List<Move> things) {
        using (var context = new PokemonContext()) {
            context.Moves.AddRange(things);
            context.SaveChanges();
        }
    }

    public IActionResult Index() {
        return View();
    }

    [HttpPost]
    public IActionResult InsertBaseCSV() {
        InsertThingsIntoDatabase(ReadThingsFromCSV("./CSV/Move.csv"));
        Console.WriteLine("done");
        return RedirectToAction("Index", "Home");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() { return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }); }
}