using OopLearning.BL.Inheritance;
using System;
using Xunit;

namespace OopLearning.BLTest.InheritanceTest
{
    
    public class VideoFileInfoTest
    {
        [Fact]
        public void IsFileSizeTooLargge_ValidValuesShouldReturnFalse()
        {
            //Arrange
            VideoFileInfo document = new VideoFileInfo("TestImage", 30, new DateTime(2019, 05, 29), 500, 500,300);

            //Act

            //Assert
            Assert.False(document.IsSizeTooLarge());
        }

        [Fact]
        public void IsFileSizeTooLargge_invalidValuesShouldReturnTrue()
        {
            //Arrange
            VideoFileInfo document = new VideoFileInfo("TestImage", 60, new DateTime(2019, 05, 29), 500, 500, 300);

            //Act

            //Assert
            Assert.True(document.IsSizeTooLarge());
        }
    }
}
