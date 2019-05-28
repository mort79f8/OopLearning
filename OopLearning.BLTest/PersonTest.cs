using OopLearning.BL;
using System;
using Xunit;

namespace OopLearning.BLTest
{
    public class PersonTest
    {
        [Fact]
        public void ValidateName_ValidValuesShouldReturnTrue()
        {
            // Arrange
            string correctName = "Daniel efternavn";

            // Act
            (bool isValid, string errMsg) = Person.ValidateName(correctName);

            //Assert
            Assert.True(isValid, $"{correctName} should be valid");
        }

        [Fact]
        public void ValidateName_InvalidValuesShouldReturnFalse()
        {
            //Arrange
            string incorrectName = "Daniel";

            //Act
            (bool isValid, string errMsg) = Person.ValidateName(incorrectName);

            //Assert
            Assert.False(isValid, $"{incorrectName} should not be valid");
        }

        [Fact]
        public void SetName_ValidValuesShouldNoBeChanged()
        {
            //Arrange
            Person correctName = new Person();

            //Act
            correctName.Name = "Daniel Efternavn";
            string expectedName = correctName.Name;

            //Assert
            Assert.Equal(expectedName, correctName.Name);
        }

        [Fact]
        public void SetName_InvalidValuesShouldCastArgumentException()
        {
            //Arrange
            Person incorrectName = new Person();

            //Act
            Assert.Throws<ArgumentException>(() => incorrectName.Name = "Daniel");
        }

        [Theory]
        [InlineData("Daniel")]
        [InlineData(null)]
        [InlineData("    ")]
        [InlineData("b")]
        [InlineData("  ib ")]
        public void SetName_AllInvalidValueShouldCastArgumentException(string name)
        {
            //Arrange
            Person incorrectName = new Person();

            //Act - Assert
            Assert.Throws<ArgumentException>(() => incorrectName.Name = name );
        }

        [Fact]
        public void GetBirthday_CprAlreadySetShouldReturnCorrectBirthday()
        {
            //Arrange
            Person person = new Person();
            person.Cpr = "2108761353";
            DateTime expectedBirthday = new DateTime(1976, 08, 21);

            //Act
            DateTime actualBirthday = person.Birthday;

            //Assert
            Assert.Equal(expectedBirthday, actualBirthday);
        }

        [Fact]
        public void GetBirthday_CprNotSetShouldCastException()
        {
            //Arrange
            Person person = new Person();

            //Act - Assert
            Assert.Throws<ArgumentException>( () => person.Birthday);
        }
    }
}
