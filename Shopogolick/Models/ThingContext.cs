using Shop.Models;
using System.Data.Entity;


namespace Shopogolick.Models
{
    public class ThingContext: DbContext
    {
        public DbSet<Thing> Things { get; set; }
        public ThingContext() : base("ShopEntity")
        { }

    }
}