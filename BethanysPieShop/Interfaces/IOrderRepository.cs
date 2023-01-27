using BethanysPieShop.Models;

namespace BethanysPieShop.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order Order);
    }
}
