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
    }
}
