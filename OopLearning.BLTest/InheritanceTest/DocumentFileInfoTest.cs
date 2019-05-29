using OopLearning.BL.Inheritance;
using System;
using Xunit;

namespace OopLearning.BLTest.InheritanceTest
{
    public class DocumentFileInfoTest
    {
        [Fact]
        public void IsFileSizeTooLargge_ValidValuesShouldReturnFalse()
        {
            //Arrange
            DocumentFileInfo document = new DocumentFileInfo("TestDocument", 30, new DateTime(2019,05,29));
      
            //Act

            //Assert
            Assert.False(document.IsSizeTooLarge());
        }

        [Fact]
        public void IsFileSizeTooLargge_InvalidValuesShouldReturnTrue()
        {
            //Arrange
            DocumentFileInfo document = new DocumentFileInfo("TestDocument", 50, new DateTime(2019, 05, 29));

            //Act

            //Assert
            Assert.True(document.IsSizeTooLarge());
        }
    }
}
