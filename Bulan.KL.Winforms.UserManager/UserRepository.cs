using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulan.KL.Winforms.UserManager
{
    public class UserRepository
    {
        public bool Add(User user)
        {
            return true;
        }
        public List<User> GetAll()
        {
            return new List<User>();
        }
        public User Get(int id)
        {
            return new User("DummyFullname", "DummyUsername", "DummyPassword");
        }
    }
}
