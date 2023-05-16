
using KProject;

namespace TestProject
{
    [TestClass]
    public class PersonUnitTest
    {
        
        [TestMethod]
        public void PersonSetAndGetName()
        {
            // Arrange
            Person person = new("Person name", "1212");

            // Act
            person.Name = "Person name 2";

            // Assert
            Assert.AreNotEqual("Person name", person.Name);
            Assert.AreEqual("Person name 2", person.Name);
        }

        [TestMethod]
        public void NewEmptyPersonNameIsNullOrEmpty()
        {
            // Arrange
            Person person = new("", "");

            // Act
            bool isEmpty = string.IsNullOrEmpty(person.Name);

            // Assert
            Assert.IsTrue(isEmpty);
        }
    }
}
