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
    public partial class addEmployee : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-5J830KR\SQLSERVER;Initial Catalog=Etisalat;Integrated Security=True");
        EtisalatEntities db = new EtisalatEntities();
        public addEmployee()
        {

            InitializeComponent();

            //List<Postion> lists = db.Postions.ToList();
          
            List<Department> list = db.Departments.ToList();
            foreach (var item in list)
            {
                com_department.Items.Add(item.department_name);
            }

           
        }
       
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            db.add_employee(txt_name.Text,txt_address.Text,int.Parse(txt_phone.Text),com_positions.Text ,com_department.Text);
             MessageBox.Show("Isertion Success");
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addEmployee_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void com_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var departId = (from com in db.Departments
            //                where com.department_name == com_department.Text
            //                select new { com.department_id});

            //int depat = (int)departId;
            //int departmentname=int.Parse(com_department.Text);
            //List<Postion> lists = (from com in db.Postions
            //                       where com.department_fk == (int)departId
            //                       select com).ToList();
            //foreach (var it in lists)
            //{
            //    com_positions.Items.Add(it.postionName);
            //}
        }

        private void com_position_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
