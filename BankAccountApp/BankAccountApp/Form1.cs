using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        private UserPriv User;
        private AdminPriv Admin;


        public Form1()
        {
            InitializeComponent();
            DatabaseAccess Account = new DatabaseAccess("Admin", "Password1", true);
            int attempts = 3;
            while (attempts != 0)
            {
                string inputName = Interaction.InputBox("UserName?");
                string inputPassword = Interaction.InputBox("Password?");
                if ((Account.getName() == inputName.ToUpper()) && (Account.getPassword() == inputPassword))
                {
                    if (Account.getAdminBool() == true)
                    {
                        btnAdminSearch.Enabled = true;
                        btnChangeName.Enabled = true;
                    }
                    else if (Account.getAdminBool() == false)
                    {
                        btnUserSearch.Enabled = false;
                    }
                    break;
                }
                else
                {
                    attempts--;
                }
            }
            if (attempts == 0)
            {
                Close();
            }

            User = new UserPriv(Account);
            Admin = new AdminPriv(Account);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUserSearch_Click(object sender, EventArgs e)
        {
            if (User.SearchForAccount(Interaction.InputBox("Seach For User")))
            {
                MessageBox.Show("Account Found");
            }
            else { MessageBox.Show("Account Not Found"); }
        }

        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            if(Admin.SearchForAccount(Interaction.InputBox("Seach For User")))
            {
                MessageBox.Show("Account Found");
            }
            else{ MessageBox.Show("Account Not Found"); }
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            Admin.ChangeAccountName(Interaction.InputBox("Enter New User Name"));
        }
    }
}
