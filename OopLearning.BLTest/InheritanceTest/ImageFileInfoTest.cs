using OopLearning.BL.Inheritance;
using System;
using Xunit;

namespace OopLearning.BLTest.InheritanceTest
{
    public class ImageFileInfoTest
    {
        [Fact]
        public void IsFileSizeTooLargge_ValidValuesShouldReturnFalse()
        {
            //Arrange
            ImageFileInfo imageFile = new ImageFileInfo("TestImage", 30, new DateTime(2019, 05, 29), 500, 500);

            
            //Act

            //Assert
            Assert.False(imageFile.IsSizeTooLarge());
        }

        [Fact]
        public void IsFileSizeTooLargge_InvalidValuesShouldReturnTrue()
        {
            //Arrange
            ImageFileInfo imageFile = new ImageFileInfo("TestImage", 50, new DateTime(2019, 05, 29), 500, 500);


            //Act

            //Assert
            Assert.True(imageFile.IsSizeTooLarge());
        }

        [Theory]
        [InlineData(500)]
        [InlineData(1910)]
        [InlineData(369)]
        [InlineData(188)]
        public void IsFileSizeTooLargge_ValidWidthShouldReturnTrue(int width)
        {
            //Arrange
            ImageFileInfo imageFile = new ImageFileInfo("TestImage", 30, new DateTime(2019, 05, 29), width, 500);


            //Act

            //Assert
            Assert.False(imageFile.IsSizeTooLarge());
        }

        [Theory]
        [InlineData(2000)]
        [InlineData(1990)]
        [InlineData(36912)]
        [InlineData(18846)]
        public void IsFileSizeTooLargge_InvalidWidthShouldReturnTrue(int width)
        {
            //Arrange
            ImageFileInfo imageFile = new ImageFileInfo("TestImage", 30, new DateTime(2019, 05, 29), width, 500);


            //Act

            //Assert
            Assert.True(imageFile.IsSizeTooLarge());
        }

        [Theory]
        [InlineData(500)]
        [InlineData(1000)]
        [InlineData(369)]
        [InlineData(188)]
        public void IsFileSizeTooLargge_ValidHeigthShouldReturnTrue(int heigth)
        {
            //Arrange
            ImageFileInfo imageFile = new ImageFileInfo("TestImage", 30, new DateTime(2019, 05, 29), 500, heigth);


            //Act

            //Assert
            Assert.False(imageFile.IsSizeTooLarge());
        }

        [Theory]
        [InlineData(2000)]
        [InlineData(1990)]
        [InlineData(36912)]
        [InlineData(18846)]
        public void IsFileSizeTooLargge_InvalidHeigthShouldReturnTrue(int width)
        {
            //Arrange
            ImageFileInfo imageFile = new ImageFileInfo("TestImage", 30, new DateTime(2019, 05, 29), width, 500);


            //Act

            //Assert
            Assert.True(imageFile.IsSizeTooLarge());
        }

    }
}
