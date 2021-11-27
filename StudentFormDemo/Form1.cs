using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFormDemo
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students Studentsinformation = new Students();
            Studentsinformation.StudentName = studentname.Text;
            Studentsinformation.StudentAge = Convert.ToInt32(studentage.Text);
            Studentsinformation.StudentCourse = studentCource.Text;
            Studentsinformation frm = new Studentsinformation();
            frm.label5.Text = Studentsinformation.StudentName;
            frm.label6.Text = Studentsinformation.StudentAge.ToString();
            frm.label7.Text = Studentsinformation.StudentCourse;
            frm.ShowDialog();



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
 