using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorizations
{
    public class StubUserRepository
    {
        private readonly Dictionary<string, string> _validUsers;

        public StubUserRepository()
        {
            _validUsers = new Dictionary<string, string>
            {
                { "Admin", "Admin123" },
                { "Manager", "Manager123" },
                { "UserFirst", "UserFirst123" }
            };
        }

        public bool Authenticate(string login, string password)
        {
            return _validUsers.TryGetValue(login, out var storedPassword) && storedPassword == password;
        }
    }
}
