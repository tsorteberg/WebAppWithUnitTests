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

        [Fact]
        public void TestAgeThisYearFail()
        {
            //ARRANGE
            DateTime birthDate = new DateTime(1977, 10, 30);
            FRWAModel testObject = new FRWAModel
            {
                Name = "Tom Sorteberg",
                BirthDate = birthDate
            };

            //ACT
            double age = 42;

            //ASSERT
            Assert.NotEqual(age, testObject.AgeThisYear());
        }

        [Fact]
        public void TestGetNameSuccess()
        {
            DateTime birthDate = new DateTime(1977, 10, 30);
            FRWAModel testObject = new FRWAModel
            {
                Name = "Tom Sorteberg",
                BirthDate = birthDate
            };

            //ACT
            string name = "Tom Sorteberg";

            //ASSERT
            Assert.Equal(name, testObject.Name);
        }
    }
}
