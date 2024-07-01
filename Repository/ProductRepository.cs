using _24h_Code_Challenge.Data;
using _24h_Code_Challenge.Entities;

namespace _24h_Code_Challenge.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _dbContext;

        public ProductRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void InsertProduct(PizzaType product)
        {
            _dbContext.Add(product);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
