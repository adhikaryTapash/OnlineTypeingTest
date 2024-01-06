using ExcelDataReader;
using System.Data;
using TypeingTest.EFCore.Models;
namespace TypeingTest
{
    public partial class AdminForm : Form
    {
        private OnlineTestContext _onlineTypeingTextDbContext { get; set; }
        public AdminForm()
        {
            InitializeComponent();
            _onlineTypeingTextDbContext = new OnlineTestContext();
            examDataGridView.DataSource = _onlineTypeingTextDbContext.Exammasters.ToList();
            studentDataGridView.DataSource = _onlineTypeingTextDbContext.Studentdetails.ToList();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
      
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        // Auto-detect format, supports:
                        //  - Binary Excel files (2.0-2003 format; *.xls)
                        //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            // Choose one of either 1 or 2:
                            // 1. Use the reader methods
                            do
                            {
                                while (reader.Read())
                                {
                                    // reader.GetDouble(0);
                                }
                            } while (reader.NextResult());
                            // 2. Use the AsDataSet extension method
                            var result = reader.AsDataSet();
                            var empList = result.Tables[0].AsEnumerable();

                            var skip = true;
                            var list = new List<Studentdetail>();
                            foreach (DataRow emp in empList)
                            {
                                if (!skip && emp!=null)
                                {
                                    var student = new Studentdetail
                                    {
                                        Name = emp[0].ToString(),
                                        RollNo = emp[1].ToString(),
                                        ContactNo = Convert.ToInt32(emp[2])
                                    };
                                    list.Add(student);
                                }
                                skip = false;
                            }
                            AddStudent(list);
                        }
                    }
                }
            }
        }

        private void AddStudent(List<Studentdetail> students)
        {
            if (students.Any())
            {
                foreach (var item in students)
                {
                    var user = new Userdetail
                    {
                        Username = item.RollNo,
                        Password = item.RollNo
                    };

                    _onlineTypeingTextDbContext.Userdetails.Add(user);
                    _onlineTypeingTextDbContext.SaveChanges();


                }
            }
        }
    }
}
