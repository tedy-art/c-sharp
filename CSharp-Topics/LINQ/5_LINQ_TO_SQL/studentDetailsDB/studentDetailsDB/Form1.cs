using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace studentDetailsDB
{
    public partial class Form1 : Form
    {
        StudentDBDataContext db;
        List<student> std_list;
        int index_no = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // creating an object for getting conn to DB
            StudentDBDataContext db1 = new StudentDBDataContext();

            // retrieving all data at once
            //dataGridView1.DataSource = db.students;
            Table<student> std_tb1 = db1.students;
            dataGridView1.DataSource = std_tb1;
            

            db = new StudentDBDataContext();
            std_list = db.students.ToList();
            DisplayData();
        }

        private void DisplayData()
        {
            IDtextBox.Text = std_list[index_no].Id.ToString();
            NAMEtextBox.Text = std_list[index_no].name;
            GENDERtextBox.Text = std_list[index_no].gender;
            AGEtextBox.Text = std_list[index_no].age.ToString();
            CLASStextBox.Text = std_list[index_no].standard.ToString();
        }

        private void NEXTbutton_Click(object sender, EventArgs e)
        {
            if(index_no < std_list.Count() -1)
            {
                index_no += 1;
                DisplayData();
            }
            else
            {
                MessageBox.Show("This is last Record!");
            }
            
        }

        private void PREVIOUSbutton_Click(object sender, EventArgs e)
        {
            if(index_no > 0)
            {
                index_no -= 1;
                DisplayData();
            }
            else
            {
                MessageBox.Show("This is the first record!");
            }
        }
    }
}
