using System;
namespace PokemonReviewApp.Models
{
	public class PkemonOwner
	{

        public int PokemonId { get; set; }

        public int OwnerId { get; set; }

        public Pokemon Pokemon { get; set; }

        public Owner Owner { get; set; }
    }
}

