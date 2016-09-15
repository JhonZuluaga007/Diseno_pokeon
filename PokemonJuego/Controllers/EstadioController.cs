using PokemonJuego.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokemonJuego.Controllers
{

    public class EstadioController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Ataques
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAtaques(string nombre, string img,int vida , int power)
        {
            Random a = new Random();
            int s = a.Next(1,3);


            string nombres = nombre;
            string img2 = img;
            int Power = power;
            int Life = vida;
            var stores = db.Pokemons.Where( c=> c.pokemon_id == s).ToList();
            
            stores.ToList();
            ViewData["nombre"] = nombre;
            ViewData["img2"] = img2;
            ViewData["vida"] = vida;
            ViewData["store"] = stores;
            ViewData["d"] = power;
           return View(stores.ToList());
        }
       
    }
}