using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entityfmtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HospitalProjectEntities hpe = new HospitalProjectEntities();

        

        private void btnList_Click(object sender, EventArgs e)
        {
            var liste = hpe.Tbl_Doctors.ToList(); //select * from blabla
            //var liste = hpe.Tbl_Doctors.Where(x => x.docsurname.Contains("Ahmet")).ToList();
            dataGridView1.DataSource = liste;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var bullistele = hpe.Tbl_Doctors.Where(doktor => doktor.docname.Contains(txtDoktorAdi.Text)).ToList();
            dataGridView1.DataSource = bullistele;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            hpe.Tbl_Doctors.Add(new Tbl_Doctors
            {
                docname = txtname.Text,
                docsurname = txtsurname.Text,
                docbranch = txtbranch.Text,
                doctc = txttc.Text,
                docpassword = txtpassword.Text

            });
            hpe.SaveChanges();
            var liste = hpe.Tbl_Doctors.ToList();
            dataGridView1.DataSource = liste;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(lblid.Text);
            var delid = hpe.Tbl_Doctors.Where(x => x.docid == a).SingleOrDefault();

            
                hpe.Tbl_Doctors.Attach(delid);
                hpe.Tbl_Doctors.Remove(delid);
            
            hpe.SaveChanges();
            list();

        }

        private void list()
        {
            var liste = hpe.Tbl_Doctors.ToList();
            dataGridView1.DataSource = liste;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selected = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedrow = dataGridView1.Rows[selected];

                    lblid.Text = Convert.ToString(selectedrow.Cells["docid"].Value);
                    int a =Convert.ToInt32(lblid.Text);
                    var one = hpe.Tbl_Doctors.Where(x => x.docid == a).SingleOrDefault();
                    txtname.Text = one.docname;
                    txtsurname.Text = one.docsurname;
                    txtbranch.Text = one.docbranch;
                    txttc.Text = one.doctc;
                    txtpassword.Text = one.docpassword;

                }
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(lblid.Text);
            var upid = hpe.Tbl_Doctors.Where(x => x.docid == a).SingleOrDefault();
            upid.docname = txtname.Text;
            upid.docsurname = txtsurname.Text;
            upid.docbranch = txtbranch.Text;
            upid.docpassword = txtpassword.Text;
            hpe.SaveChanges();
            list();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnform2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
