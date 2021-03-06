using OopLearning.BL;
using System;
using System.Collections.Generic;
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
            correctName.Name = "Daniel Efternavn";

            //Act
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

        [Fact]
        public void ValidateCpr_ValidValuesShouldReturnTrue()
        {
            // Arrange
            string correctCpr = "2108761353";

            // Act
            (bool isValid, string errMsg) = Person.ValidateCpr(correctCpr);

            //Assert
            Assert.True(isValid, $"{correctCpr} should be valid");
        }

        [Fact]
        public void ValidCpr_InvalidValuesShouldReturnFalse()
        {
            // Arrange
            string incorrectCpr = "21761353";

            // Act
            (bool isValid, string errMsg) = Person.ValidateCpr(incorrectCpr);

            //Assert
            Assert.False(isValid, $"{incorrectCpr} should be valid");
        }

        [Fact]
        public void SetCpr_ValidValuesShouldNotBeChanged()
        {
            //Arrange
            Person correctCpr = new Person();
            correctCpr.Cpr = "2108761353";

            //Act
            string expectedCpr = correctCpr.Cpr;

            //Assert
            Assert.Equal(expectedCpr, correctCpr.Cpr);
        }

        [Fact]
        public void SetCpr_InvalidValuesShouldCastArgumentException()
        {
            //Arrange
            Person incorrectCpr = new Person();

            //Act
            Assert.Throws<ArgumentException>(() => incorrectCpr.Cpr = "218761353");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("000876135320")]
        [InlineData("0008761353")]
        [InlineData("210 8761353")]
        [InlineData("2108221353")]
        public void SetCpr_AllInvalidValuesShouldCastArgumentException(string cpr)
        {
            //Arrange
            Person incorrectCpr = new Person();

            //Act
            Assert.Throws<ArgumentException>(() => incorrectCpr.Cpr = cpr);
        }

        [Fact]
        public void IsWoman_ValidCprShouldReturnTrue()
        {
            //Arrange
            Person correctCprForWoman = new Person();
            correctCprForWoman.Cpr = "2108761354";

            //Act

            //Assert
            Assert.True(correctCprForWoman.IsWoman);
        }

        [Fact]
        public void IsWoman_InvalidCprShouldReturnFalse()
        {
            //Arrange
            Person incorrectCprForWoman = new Person();
            incorrectCprForWoman.Cpr = "2108761353";

            //Act

            //Assert
            Assert.False(incorrectCprForWoman.IsWoman);
        }

        [Fact]
        public void CompareTo_RandomListOfNameShouldReturnSortedList()
        {
            //Arrange
            List<Person> personList = new List<Person>()
            {
                new Person("Kian Hiphurra", "0102001599"),
                new Person("Jens Larsen", "2105805326"),            
                new Person("Ib Jensen", "0508001548"),
                new Person("Kian Hiphurra", "0101001599"),
                new Person("Anton S�vning", "0202025564"),
                new Person("Morten juul", "2108761353")
            };

            //Act
            List<Person> expectedList = new List<Person>()
            {
                new Person("Anton S�vning", "0202025564"),
                new Person("Ib Jensen", "0508001548"),
                new Person("Jens Larsen", "2105805326"),
                new Person("Kian Hiphurra", "0101001599"),
                new Person("Kian Hiphurra", "0102001599"),
                new Person("Morten juul", "2108761353")
            };
            personList.Sort();

            //Assert
            Assert.Equal(expectedList, personList);
        }
    }
}
