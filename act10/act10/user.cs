using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    public abstract class User
    {
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            user_id = id;
            user_password = pass;
        }

        public bool verifyLogin(string id, string pass)
        {
            return user_id.Equals(id) && user_password.Equals(pass);
        }

        public abstract void updatePassword(string newPassword);
    }
}