
using KProject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace TestProject
{
    [TestClass]
    public class UserUnitTest
    {
        [TestMethod]
        public void UserPropertiesAreSetCorrectly()
        {
            // Arrange
            User user = new("test@gmail.com", "Password", UserType.DEFAULT, "Name", "123-123");

            // Assert
            Assert.AreEqual(0, user.Id);
            Assert.AreEqual("Name", user.Name);
            Assert.AreEqual("123-123", user.Phone);
            Assert.AreEqual("test@gmail.com", user.Email);
            Assert.AreEqual("Password", user.Password);
            Assert.AreEqual(UserType.DEFAULT, user.UserType);
        }

        [TestMethod]
        public void UserDefaultConstructorCreatesObject()
        {
            // Act
            User user = new("test@gmail.com", "Password", UserType.DEFAULT, "Name", "123-123");

            // Assert
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void UserSetAndGetId()
        {
            // Arrange
            User user = new("test@gmail.com", "Password", UserType.DEFAULT, "Name", "123-123");

            // Act
            user.Id = 1;

            // Assert
            Assert.AreEqual(1, user.Id);
        }
    }
}