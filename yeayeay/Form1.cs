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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     

        }

        Datahandler dh = new Datahandler(); 

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dh.DisplayStudents().Rows)
            {
                ListViewItem item = new ListViewItem(dr["StudentID"].ToString());

                item.SubItems.Add(dr["StudentFname"].ToString());
                item.SubItems.Add(dr["StudentLname"].ToString());
                item.SubItems.Add(dr["Course"].ToString());

                listView1.Items.Add(item); 


            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string id = listView1.SelectedItems[0].SubItems[0].Text;
            string Fname = listView1.SelectedItems[0].SubItems[1].Text;
            string lname = listView1.SelectedItems[0].SubItems[2].Text;
            string Course = listView1.SelectedItems[0].SubItems[3].Text;

            txtStudId.Text = id;
            txtName.Text = Fname;
            txtSurname.Text = lname;
            TxtCourse.Text = Course; 



        }
    }
}
