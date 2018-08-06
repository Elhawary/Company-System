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
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-5J830KR\SQLSERVER;Initial Catalog=Etisalat;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sqlcon.Open();

            string showData = "select  employeeName ,employeeAddress ,employeePhone ,salary ,department_name ,postionName from Employees , Postion ,Department where postionID = postion_fk and  department_fk = department_id; ";


            SqlDataAdapter SDA1 = new SqlDataAdapter(showData, sqlcon);
            DataTable dt = new DataTable();
            SDA1.Fill(dt);
            grid_ShaowData.DataSource = dt;
            sqlcon.Close();
        }
    }
}
