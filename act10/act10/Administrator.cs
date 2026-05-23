using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace UserNamespace
{
    public class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            admin_name = name;
        }

        public override void updatePassword(string newPassword)
        {
            user_password = newPassword;
        }

        public void updateAdminName(string name)
        {
            admin_name = name;
        }

        public string GetAdminName()
        {
            return admin_name;
        }
    }
}
