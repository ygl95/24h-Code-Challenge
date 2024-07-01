using _24h_Code_Challenge.Entities;

namespace _24h_Code_Challenge.Repository
{
    public interface IProductRepository
    {
        void InsertProduct(PizzaType pizza);
        void Save();
    }
}
