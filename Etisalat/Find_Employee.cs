using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Etisalat
{
    public partial class Find_Employee : Form
    {
        EtisalatEntities db = new EtisalatEntities();
        public Find_Employee()
        {
            InitializeComponent();
            lb_error.Visible = false;
        }

        private void Find_Employee_Load(object sender, EventArgs e)
        {

        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-5J830KR\SQLSERVER;Initial Catalog=Etisalat;Integrated Security=True");
        private void find_Click(object sender, EventArgs e)
        {
        

            if (txt_employeeID.Text == string.Empty)
            {
                lb_error.Visible = true;

            }
            else
            {
                lb_error.Visible = true;

                sqlcon.Open();

                string showData = "select  employeeName ,employeeAddress ,employeePhone ,salary ,department_name ,postionName from Employees , Postion ,Department where postionID = postion_fk and employeeID ='" + int.Parse(txt_employeeID.Text) + "' and department_fk = department_id";

                SqlDataAdapter SDA1 = new SqlDataAdapter(showData, sqlcon);
                DataTable dt = new DataTable();
                SDA1.Fill(dt);
                find_gridView.DataSource = dt;

                //***********************Delete Employee********************//
                DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                
                find_gridView.Columns.Add(delete);
                delete.HeaderText = "DELETE";
                find_gridView.Columns[6].Name = "DELETE";
                delete.Text = "delete";
                delete.Name = "btn";
                delete.UseColumnTextForButtonValue = true;
                
                //******************Update Employee************************//
                
                DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                bcol.HeaderText = "UPDATE";
                bcol.Text = "update";
                bcol.Name = "update";
                bcol.UseColumnTextForButtonValue = true;
                find_gridView.Columns.Add(bcol);
               

            }
        }
        private void find_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string employeeName, employeeAddress, departmentName, postionName, employeePhone;

            if (e.ColumnIndex == 6)
            {
                   sqlcon.Open();
                   string deletEMployee = "delete Employees where employeeID='" + int.Parse(txt_employeeID.Text) + "'";
                   SqlDataAdapter SDA2 = new SqlDataAdapter(deletEMployee, sqlcon);
                   SDA2.SelectCommand.ExecuteNonQuery();
                   sqlcon.Close();
                  MessageBox.Show(" Employee Deleted Successfully");

            }else if(e.ColumnIndex == 7){

           string emName = null, empAddress = null, depName = null, posName = null, empPhone = null;

                for (int rows = 0; rows < find_gridView.Rows.Count; rows++)
                {
                    for (int col = 0; col < find_gridView.Rows[rows].Cells.Count; col++)
                    {

                        emName = find_gridView.Rows[rows].Cells[0].Value.ToString();
                        empAddress = find_gridView.Rows[rows].Cells[1].Value.ToString();
                        empPhone = find_gridView.Rows[rows].Cells[2].Value.ToString();
                        depName = find_gridView.Rows[rows].Cells[4].Value.ToString();
                        posName = find_gridView.Rows[rows].Cells[5].Value.ToString();
                        break;

                    }
                    break;
                }

                  db.updateEmployee(emName, empAddress, int.Parse(empPhone), depName,posName);
                   MessageBox.Show("Updated Successfully");
            
                }

            sqlcon.Close();
        }
        
    }
}
