using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PokemonJuego.Models
{
    public class Store
    {
        
        [Key]
        public int compra_id { get; set; }
        public int Pokemon_id { get; set; }
        [ForeignKey("Pokemon_id")]
        public virtual Pokemon Pokemon { get; set; }
        public string player { get; set; }

    }
}