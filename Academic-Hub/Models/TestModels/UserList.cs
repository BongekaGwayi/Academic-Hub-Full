using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Academic_Hub.Models.TestModels
{
    public class UserList
    {
        private static List<User> _users = new List<User>()
        {
                new User()
                {
                    Id = 1001,
                    Username = "Parent",
                    Password = "Parent#123",
                    Role = "Parent"
                },
                new User()
            {
                Id = 1001,
                Username = "HOD",
                Password = "SuperUser",
                Role = "HOD"
            }
    };
        private static List<ParentUser> _parents = new List<ParentUser>()
        {
            new ParentUser()
            {
                Id = 1001,
                ParentId = 1001,
                FirstName = "Bongeka",
                LastName = "Gwayi",
                Email = "bongeka.gwayi@mail.com",
                PhoneNumber = "0820000000",
            },
            
        };
        private static List<TeacherUser> _teachers = new List<TeacherUser>()
        {
            new TeacherUser()
            {
                TeacherId = 2001,
                FirstName = "Odirile",
                LastName = "Mabovu",
                Email = "odirile.mabovu@mail.com",
                PhoneNumber = "0870000000",
            },
            new TeacherUser()
            {
                TeacherId = 2002,
                FirstName = "Anathi",
                LastName = "Wecu",
                Email = "anathi.wethu@mail.com",
                PhoneNumber = "0860000000",
            },
            new TeacherUser()
            {
                TeacherId = 2003,
                FirstName = "Xolile",
                LastName = "Skhosana",
                Email = "xskhosan@mail.com",
                PhoneNumber = "0760000000",
            },
            new TeacherUser()
            {
                TeacherId = 2004,
                FirstName = "Owethu",
                LastName = "Dlamini",
                Email = "dlaminiwethu@mail.com",
                PhoneNumber = "0770000000",
            }
        };
        static UserList()
        {
            
        }
        public static List<User> GetUsers()
        {
            return _users;
        }
        public static List<ParentUser> GetParents()
        {
            return _parents;
        }
        public static TeacherUser GetTeacher(int id)
        {
            return _teachers.Find(x => x.TeacherId == id);
        }
    }
}
