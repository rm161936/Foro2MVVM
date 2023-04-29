using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronMVVM.Models
{
    internal class User
    {

        public string? UserName { get; }
        public bool  IsActive { get; }
        public bool IsRegister { get; }

        public User(string? userName, bool isActive, bool isRegister)
        {
            UserName = userName;
            IsActive = isActive;
            IsRegister = isRegister;
        }
    }
}
