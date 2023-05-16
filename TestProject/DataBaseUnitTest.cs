
using KProject;

namespace TestProject
{
    [TestClass]
    public class DataBaseUnitTest
    {
        [TestMethod]
        public void GetUserByIdReturnsCorrectUser()
        {
            // Arrange
            User testUser = new("user1@gmail.com", "Password", UserType.DEFAULT, "Name", "777777");

            DataBase database = DataBase.GetInstance();
            database.SaveUser(testUser);

            // Act
            User? result = database.GetUserById(testUser.Id);

            // Assert
            Assert.AreEqual(testUser, result);
        }

        [TestMethod]
        public void GetUserByPhoneReturnsCorrectUser()
        {
            // Arrange
            User test = new("user2@gmail.com", "Password", UserType.DEFAULT, "Name", "666666");

            DataBase database = DataBase.GetInstance();
            database.SaveUser(test);

            // Act
            User? result = database.GetUserByPhone(test.Phone);

            // Assert
            Assert.AreEqual(test, result);
        }

        [TestMethod]
        public void GetUserByEmailReturnsCorrectUser()
        {
            // Arrange
            User testUser = new("user3@gmail.com", "Password", UserType.DEFAULT, "Name", "555555");

            DataBase database = DataBase.GetInstance();
            database.SaveUser(testUser);

            // Act
            User? result = database.GetUserByEmail(testUser.Email);

            // Assert
            Assert.AreEqual(testUser, result);
        }

        [TestMethod]
        public void UserExistsReturnsTrueWhenUserExists()
        {
            // Arrange
            User testUser = new("user4@gmail.com", "Password", UserType.DEFAULT, "Name", "4444444");

            DataBase database = DataBase.GetInstance();
            database.SaveUser(testUser);

            // Act
            bool result = database.UserExists(testUser.Phone, testUser.Email);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SaveUserToDatabase()
        {
            // Arrange
            DataBase database = DataBase.GetInstance();

            User newUser = new("user5@gmail.com", "Password", UserType.ADMINISTRATOR, "Name", "333333");

            // Act
            bool result = database.SaveUser(newUser);
            User? resultUser = database.GetUserById(newUser.Id);

            // Assert
            Assert.IsTrue(result);
            Assert.IsNotNull(resultUser);
        }

        [TestMethod]
        public void SaveOrderAndGetOrdersByPhone()
        {
            // Arrange
            Order testOrder = new(new Person("Recipient", "1515"), new Person("Sender", "1616"))
            {
                UserId = 1,
                DepartureDate = DateTime.Now,
                Description = "Test",
                DepartureCity = "Харків",
                DeliveryCity = "Київ",
                Weight = 20,
                Payment = 2000,
                OrderType = OrderType.CREATED
            };

            DataBase database = DataBase.GetInstance();

            database.SaveOrder(testOrder);

            // Act
            List<Order> result = database.GetOrdersByPhone(testOrder.Recipient.Phone);

            // Assert
            Assert.IsTrue(result.Count > 0);
            Assert.IsTrue(result.Contains(testOrder));
        }

        [TestMethod]
        public void UpdateLastUserDataTest()
        {
            // Arrange
            DataBase database = DataBase.GetInstance();

            string phone = "333-222";
            string password = "password";

            // Act
            database.UpdateLastUserData(phone, password);

            // Assert
            Assert.AreEqual(phone, database.LastUserPhone);
            Assert.AreEqual(password, database.LastUserPassword);
        }
    }
}
