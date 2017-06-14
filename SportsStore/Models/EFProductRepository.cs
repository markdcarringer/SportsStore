using System.Collections.Generic;
using SportsStore.Models;

namespace SportsStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        // Map the Products property defined by IProductRepository onto the Products 
        // property defined by the ApplicationDbContext class.
        public IEnumerable<Product> Products => context.Products;
    }
}
