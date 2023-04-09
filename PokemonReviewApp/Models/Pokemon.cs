using System;
namespace PokemonReviewApp.Models
{
	public class Pokemon
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string BirthDate{ get; set; }

		public ICollection<Review> Reviews { get; set; }

        public ICollection<PkemonOwner> PkemonOwners { get; set; }

        public ICollection<PkemonCategory> PkemonCategories { get; set; }
    }
}

