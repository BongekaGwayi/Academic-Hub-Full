using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Academic_Hub.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; }
        public bool RememberMe { get; set; }
    }
    public class ParentUser : User
    {
        public int ParentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public int ParentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public int Grade { get; set; }

    }
    public class TeacherUser : User
    {
        public int TeacherId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }

    public class HOD : User
    {

    }
}
