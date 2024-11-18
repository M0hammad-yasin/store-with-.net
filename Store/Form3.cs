using Store.BLL;
using Store.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        USER_BLL u = new USER_BLL();
        USER_DAL dal = new USER_DAL();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            u.firstname = textBox2.Text;
            u.lastname = textBox3.Text;
            u.email = textBox4.Text;
            u.contact = textBox7.Text;
            u.password = textBox6.Text;
            u.address = textBox8.Text;
            u.gender = comboBox1.Text;
            u.usertype = comboBox2.Text;
            u.added_date = DateTime.Now;
            // string loggeduser = Form3.loggedIn;
            // USER_BLL usr = dal.GetIDfromusername(loggeduser);
            // u.added_by = usr.id;
            Console.WriteLine("\n f n " + u.firstname + "\t user n " + u.username);
            bool success  = dal.INSERT(u);
            if (success == true) {
                MessageBox.Show("User Added Successfully");
            }
            else
            {
                MessageBox.Show("Failed to Add User");
            }
                
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
