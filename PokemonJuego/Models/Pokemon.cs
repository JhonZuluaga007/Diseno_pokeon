using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PokemonJuego.Models
{
    public class Pokemon
    {

        [Key]
        public int pokemon_id { get; set; }
        public string Name { get; set; }
        public int vida { get; set; }
        public int power { get; set; }
        public string Picture { get; set; }
    }
       
}
