
using KProject.Form.SupportForm.Messages;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace KProject
{
    public class DataBase: IDataBase
    {
        private static readonly DataBase INSTANCE = new();

        public static DataBase GetInstance()
        {
            return INSTANCE;
        }

        private readonly Storage storage;

        public string? LastUserPhone { get => storage.LastUserPhone; }
        public string? LastUserPassword { get => storage.LastUserPassword; }

        public User? CurrentUser { get; set; }

        public bool UpdateLastUserData(string? phone, string? password)
        {
            storage.LastUserPhone = phone;
            storage.LastUserPassword = password;

            return storage.UpdateStorageFile();
        }

        private class Storage
        {
            private const string DATA_STORAGE_FILENAME = "storage";

            public ICollection<Order> Orders { get; set; } = new List<Order>();

            public ICollection<User> Users { get; set; } = new List<User>();

            public string? LastUserPhone { get; set; }

            public string? LastUserPassword { get; set; }

            public Storage() {
                if (!File.Exists(DATA_STORAGE_FILENAME))
                {
                    using FileStream fs = File.Create(DATA_STORAGE_FILENAME);
                    UpdateStorageFile();
                }
            }

            public bool UpdateStorageFile()
            {
                try { 
                    File.WriteAllText(DATA_STORAGE_FILENAME, JsonSerializer.Serialize(this, new JsonSerializerOptions
                    {
                        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                        WriteIndented = true
                    }));

                    return true;
                } catch (Exception)
                {
                    return false;
                }
            }

            public static Storage Create()
            {
                if (!File.Exists(DATA_STORAGE_FILENAME))
                {
                    return new Storage();
                }

                string json = File.ReadAllText(DATA_STORAGE_FILENAME);
                
                if (string.IsNullOrEmpty(json))
                    return new Storage();

                Storage? storage = JsonSerializer.Deserialize<Storage>(json);
                return storage ?? new Storage();
            }
        }

        private DataBase()
        {
            storage = Storage.Create();
        }

        public ICollection<Order> Orders { get => storage.Orders; }

        public List<Order> GetAwaiableOrders()
        {
            if (CurrentUser != null)
            {
                if (CurrentUser.UserType == UserType.DEFAULT)
                {
                    return storage.Orders
                        .Where(order => order.Recipient.Phone.Equals(CurrentUser.Phone) ||
                               order.Sender.Phone.Equals(CurrentUser.Phone))
                        .ToList();
                }

                return Orders.ToList();
            }

            return new List<Order>();
        }

        public User? GetUserById(long uid)
        {
            return storage.Users.FirstOrDefault(user => user.Id == uid);
        }

        public User? GetUserByPhone(string phone)
        {
            return storage.Users.FirstOrDefault(user => user.Phone.Equals(phone));
        }

        public User? GetUserByEmail(string email)
        {
            return storage.Users.FirstOrDefault(user => user.Email.Equals(email));
        }

        public bool UserExists(string phone, string email)
        {
            return GetUserByPhone(phone) != null || GetUserByEmail(email) != null;
        }

        public List<Order> GetOrdersByPhone(string phone)
        {
            if (CurrentUser == null || CurrentUser.UserType == UserType.DEFAULT)
            {
                return storage.Orders
                    .Where(order => order.Recipient.Phone.Contains(phone))
                    .ToList();
            }

            return storage.Orders
                .Where(order => order.Recipient.Phone.Contains(phone) || 
                                order.Sender.Phone.Contains(phone)).ToList();
        }

        public bool SaveOrder(Order order)
        {
            if (order.Id <= 0)
            {
                order.Id = storage.Orders.Count + 1;
                storage.Orders.Add(order);
            }

            return storage.UpdateStorageFile();
        }

        public bool SaveUser(User user)
        {
            if (user.Id <= 0) {
                user.Id = storage.Users.Count + 1;
                storage.Users.Add(user);
            }

            return storage.UpdateStorageFile();
        }
    }
}
