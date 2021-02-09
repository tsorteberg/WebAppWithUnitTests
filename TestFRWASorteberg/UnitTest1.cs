/***************************************************************
* Name        : FRWAModel.cs
* Author      : Tom Sorteberg
* Created     : 02/08/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This unit test class file was created to test
*               the FirstResponsiveWebAppSorteberg project for 
*               CIS-174
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
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
            //ARRANGE
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

        [Fact]
        public void TestGetBirthDateSuccess()
        {
            //ARRANGE
            DateTime birthDate = new DateTime(1977, 10, 30);
            FRWAModel testObject = new FRWAModel
            {
                Name = "Tom Sorteberg",
                BirthDate = birthDate
            };

            //ACT
            DateTime birthDateTest = new DateTime(1977, 10, 30);

            //ASSERT
            Assert.Equal(birthDateTest, testObject.BirthDate);
        }

        [Fact]
        public void TestNullValueName()
        {
            //ARRANGE
            FRWAModel testObject = new FRWAModel();

            //ACT

            //ASSERT
            Assert.Null(testObject.Name);
        }

        [Fact]
        public void TestNullValueBirthDate()
        {
            //ARRANGE
            FRWAModel testObject = new FRWAModel();

            //ACT

            //ASSERT
            Assert.Null(testObject.BirthDate);
        }
    }
}
