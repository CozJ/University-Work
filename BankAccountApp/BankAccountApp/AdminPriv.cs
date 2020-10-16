using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    class AdminPriv
    {
        private DatabaseAccess NameDao;

        public AdminPriv(DatabaseAccess NameDao)
        {
            this.NameDao = NameDao;
        }

        public void ChangeAccountName(string newName)
        {
            this.NameDao.ChangeAccountName(newName);
        }

        public bool SearchForAccount(string query)
        {
            return (NameDao.SearchForAccount(query));
        }
    }
}
