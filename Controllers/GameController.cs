using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing;
using Modul10_103022400123.Models;

using System.Diagnostics;


namespace Modul10_103022400123.Controllers
{
    [ApiController]
    [Route("ApiBehaviour/[controller]")]
    public class GameController : ControllerBase
    {
        private static List<Game> games = new List<Game> {
            new Game {nama = "Valorant", developer = "Riot Games", tahunRilis = 2020, genre = "FPS", rating = 8.5, platform = new List<string> {"PC"}, mode = new List<string> {"Multiplayer"}, isOnline = “true”, harga = 0 }
            new Game {nama = "GTA V", developer = "Rockstar Games", tahunRilis = 2013, genre = "OpenWorld", rating = 9.5, platform = new List<string> {"PC", "PS4", "PS5", "Xbox"}, mode = new List<string> {"Singleplayer", "Multiplayer"}, isOnline = “true”, harga = 300000 }
            new Game {nama = "The Witcher 3", developer = "CD Projekt Red", tahunRilis = 2015, genre = "RPG", rating = 9.7, platform = new List<string> { "PC", "PS4", "PS5", "Xbox", "Switch"}, mode = new List<string> {"Singleplayer"}, isOnline = “false”, harga = 25000 }
        };
        [HttpGet]

    }
}
