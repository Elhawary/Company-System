using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Etisalat
{
    public partial class Etisalat_Egypt : Form
    {
        public Etisalat_Egypt()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Find_Employee move = new Find_Employee();
               move.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Etisalat_Egypt_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            addEmployee frm2 = new addEmployee();
               frm2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_POSTION add = new ADD_POSTION();
            add.Show();
        }

        private void addDepartment_Click(object sender, EventArgs e)
        {
            Add_Department add = new Add_Department();
            add.Show();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-5J830KR\SQLSERVER;Initial Catalog=Etisalat;Integrated Security=True");
        private void view_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            string showData = "select employeeID, employeeName ,employeeAddress ,employeePhone ,salary ,department_name ,postionName from ((Employees join Postion on postionID = postion_fk  ) join Department on  department_fk = department_id)";


            SqlDataAdapter SDA1 = new SqlDataAdapter(showData, sqlcon);
            DataTable dt = new DataTable();
            SDA1.Fill(dt);
            dataGridView.DataSource = dt;
            sqlcon.Close();
        }
    }
}
