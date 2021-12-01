using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet.Models
{
    public class Employee
    {
        [Key]
        public string? EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public string? PhoneNumber { get; set; }

    }
}