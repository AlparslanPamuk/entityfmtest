using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        db_schoolEntities db;

        void fill()
        {
            db = new db_schoolEntities();
            dataGridView1.DataSource = db.Students.ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fill();
            this.Text = "Mustafa Alparslan Pamuk Program";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Student newstudent = new Student();
            newstudent.No = Convert.ToInt32(txtno.Text);
            newstudent.Name = txtname.Text;
            newstudent.Surname = txtsurname.Text;
            db.Students.Add(newstudent);
            db.SaveChanges();
            fill();


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int update = Convert.ToInt32(txtno.Text);
            var updatedstudent = db.Students.Where(w => w.No == update).FirstOrDefault();
            updatedstudent.Name = txtname.Text;
            updatedstudent.Surname = txtsurname.Text;
            db.SaveChanges();
            fill();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            int deleted = Convert.ToInt32(txtno.Text);
            var deletedstudent = db.Students.Where(w => w.No == deleted).FirstOrDefault();
            db.Students.Remove(deletedstudent);
            db.SaveChanges();
            fill();
        }
    }
}
