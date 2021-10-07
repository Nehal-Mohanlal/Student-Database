using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yeayeay
{
    public partial class dgv : Form
    {
        public dgv()
        {
            InitializeComponent();
        }
        Datahandler dh = new Datahandler();


        private void btnPopulate_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.DisplayStudents(); 

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex>= 0)
            {
                DataGridViewRow dgvr = this.dataGridView1.Rows[e.RowIndex]; 


                string id = dgvr.Cells["StudentID"].Value.ToString();
                string name = dgvr.Cells["StudentFname"].Value.ToString();
                string lname = dgvr.Cells["StudentLname"].Value.ToString();
                string course = dgvr.Cells["Course"].Value.ToString();


                txtStudId.Text = id;
                txtName.Text = name;
                txtSurname.Text = lname;
                TxtCourse.Text = course; 



            }
        }
    }
}
