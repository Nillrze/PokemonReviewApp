using System;
namespace PokemonReviewApp.Models
{
	public class Category
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<PkemonCategory> PkemonCategories { get; set; }
    }
}

