using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etisalat
{
    public partial class ADD_POSTION : Form
    {
        EtisalatEntities db = new EtisalatEntities();
        public ADD_POSTION()
        {
            InitializeComponent();
           List<Department> list= db.Departments.ToList();
            foreach (var item in list)
            {
                com_depart.Items.Add(item.department_name);
            }
        }

        private void AddPosition_Click(object sender, EventArgs e)
        {
            db.add_position(txt_position.Text, com_depart.Text, int.Parse(txt_salary.Text));
            MessageBox.Show("Successfully");
        }

        private void com_depart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
