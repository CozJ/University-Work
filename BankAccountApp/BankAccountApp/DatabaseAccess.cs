using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    class DatabaseAccess
    {
        private string name;
        private string password;
        private bool admin;


        public DatabaseAccess(string name, string password, bool admin)
        {
            this.name = name.ToUpper();
            this.password = password;
            this.admin = admin;
        }

        public string getName()
        {
            return name;
        }
        public string getPassword()
        {
            return password;
        }
        public bool getAdminBool()
        {
            return admin;
        }

        public void ChangeAccountName(string newName)
        {
            name = newName.ToUpper();
        }

        public bool SearchForAccount(string search)
        {
            if (name == search.ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
