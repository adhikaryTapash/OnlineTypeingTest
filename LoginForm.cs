using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeingTest.EFCore.Models;

namespace TypeingTest
{
    public partial class LoginForm : Form
    {
        private OnlineTestContext _onlineTypeingTextDbContext { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            _onlineTypeingTextDbContext = new OnlineTestContext();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            this.errorMsgLabl.Visible = false;
            var userName = userNameTxtBox.Text.Trim();
            var password = passwordTxtBox.Text.Trim();
            var user = _onlineTypeingTextDbContext.Userdetails.Include(r => r.Roles).FirstOrDefault(a => a.Username == userName && a.Password == password);
            if (user != null)
            {
                var role = user.Roles.Any() ? user.Roles.FirstOrDefault(t => t.Id.Equals(1)) : null;
                if (role?.Id==1)
                {
                    this.Hide();
                    var adminForm = new AdminForm();
                    adminForm.Show();
                }
            }
            this.errorMsgLabl.Visible = true;
        }
    }
}
