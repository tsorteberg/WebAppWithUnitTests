using System;
using Xunit;
using FirstResponsiveWebAppSorteberg.Models;

namespace FRWASortebergTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestAgeThisYear()
        {
            //ARRANGE
            DateTime birthDate = new DateTime(1978, 10, 30);
            FRWAModel testObject = new FRWAModel
            {
                Name = "Tom Sorteberg",
                BirthDate = birthDate
            };

            //ACT
            double age = 42;

            //ASSERT
            Assert.Equal(age, testObject.AgeThisYear());
        }
    }
}
