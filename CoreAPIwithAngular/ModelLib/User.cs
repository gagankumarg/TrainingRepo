using System;

namespace ModelLib
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime InitOn { get; }
        public DateTime LastLoggedIn { get; }
    }
}
