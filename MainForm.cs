using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using TypeingTest.EFCore;

namespace TypeingTest
{
    public partial class MainForm : Form
    {
        //private TypeingDBContext? dbContext;
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //this.dbContext = new TypeingDBContext();

            //// Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            //this.dbContext.Database.EnsureCreated();

            //this.dbContext.Roles.Load();

         //   this.categoryBindingSource.DataSource = dbContext.Roles.Local.ToBindingList();

           // this.dbContext.Products.Load();
          //  this.productBindingSource.DataSource = dbContext.Products.Local.ToBindingList();

          //  this.dbContext.UserDetail.Load();
        //    this.userDetailBindingSource.DataSource = dbContext.UserDetail.Local.ToBindingList();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

          //  this.dbContext?.Dispose();
          //  this.dbContext = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
          //  this.dbContext!.SaveChanges();

          //  this.dataGridViewCategories.Refresh();
          //  this.dataGridViewProducts.Refresh();
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            //this.dbContext!.SaveChanges();

            //this.dbContext!.Roles.Add(new EFCore.Model.Role { RoleId = 11, Name = "ddd" });
           // dbContext.SaveChanges();
         //   this.dataGridViewCategories.Refresh();
          //  this.dataGridViewProducts.Refresh();
        }
    }
}