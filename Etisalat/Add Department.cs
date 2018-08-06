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
    
    public partial class Add_Department : Form
    {
        EtisalatEntities db = new EtisalatEntities();
        public Add_Department()
        {
            InitializeComponent();
           
        }

        private void Add_Department_Load(object sender, EventArgs e)
        {

           

        }

        private void addDepartment_Click(object sender, EventArgs e)
        {
            db.add_department(departmentName.Text);

            MessageBox.Show("Successfully");
           Etisalat_Egypt move = new Etisalat_Egypt();
           move.Show();
        }
          
    }
}
