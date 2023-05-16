

namespace KProject
{
    public interface IDataBase
    {
        bool UpdateLastUserData(string? phone, string? password);
        List<Order> GetAwaiableOrders();

        User? GetUserById(long uid);
        User? GetUserByPhone(string phone);
        User? GetUserByEmail(string email);
        bool UserExists(string phone, string email);
        List<Order> GetOrdersByPhone(string phone);

        bool SaveOrder(Order order);
        public bool SaveUser(User user);
    }
}
