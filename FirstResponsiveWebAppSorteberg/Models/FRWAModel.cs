/***************************************************************
* Name        : FRWAModel.cs
* Author      : Tom Sorteberg
* Created     : 01/28/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This class file represents the model for an MVC
*               ASP.NET Core Web Application, which has been prepared
*               for the First Responsive Web App assignment.  This class
*               accepts attributes of Name, BirthDate, and then returns the 
*               age of the person based on today's date.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppSorteberg.Models
{
    public class FRWAModel
    {
        // Constants
        private const double YEAR = 365;

        // Name instance.
        [Required(ErrorMessage = "Please enter your full name.")]
        public string Name { get; set; }

        // BirthDate instance.
        [Required(ErrorMessage = "Please enter a valid date.")]
        public DateTime? BirthDate { get; set; }

        // Calculate age method.
        public double AgeThisYear()
        {
            DateTime EndDate = DateTime.Today;
            double Age = (EndDate - BirthDate).Value.TotalDays;
            Age /= YEAR;
            return Math.Truncate(Age);
        }
    }
}