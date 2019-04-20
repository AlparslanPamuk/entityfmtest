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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        HospitalProjectEntities hpe = new HospitalProjectEntities();


        private void doktorlist()
        {
            var liste = hpe.Tbl_Doctors.ToList();
            cmbdoctor.DataSource = liste;
            cmbdoctor.ValueMember = "docid";

            cmbdoctor.DisplayMember = "docname";


        }

        private void list()
        {
            var list = (from a in hpe.Tbl_Appointments
                        join d in hpe.Tbl_Doctors on a.appointmentdoctor equals d.docid
                        select new
                        {
                            a.appointmentdate,
                            a.appointmenttime,
                            a.appointmentbranch,
                            d.docname,
                            d.docsurname,
                            a.appointmentstate,
                            a.patienttc,
                            a.patientcomplaint

                        }).ToList();

            dataGridView1.DataSource = list;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            doktorlist();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selected = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedrow = dataGridView1.Rows[selected];

                    lblid.Text = Convert.ToString(selectedrow.Cells["appointmentdoctor"].Value);

                    int a = Convert.ToInt32(lblid.Text);
                    var one = hpe.Tbl_Appointments.Where(x => x.appointmentdoctor == a).SingleOrDefault();

                    //dateTimePickerdate.Text = one.appointmentdate;
                    //msktime.Text = one.appointmenttime;
                    //txtbranch.Text = one.appointmentbranch;
                    ////cmbdoctor.Text = one.appointmentdoctor;
                    ////chechboxstate.Checked =one.appointmentstate.ToString();
                    ////msktc.Text = one.appointmentid;
                    //rchcomplaint.Text = one.patientcomplaint;



                    //dateTimePickerdate.Text = Convert.ToString(selectedrow.Cells["appointmentdate"].Value);
                    //msktime.Text = Convert.ToString(selectedrow.Cells["appointmenttime"].Value);
                    //txtbranch.Text = Convert.ToString(selectedrow.Cells["appointmentbranch"].Value);
                    //cmbdoctor.Text = selectedrow.Cells["appointmentdoctor"].Value;
                    //chechboxstate.Checked =    ;
                    //msktc.Text = Convert.ToString(selectedrow.Cells["patienttc"].Value);
                    //rchcomplaint.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();

                    //int a = Convert.ToInt32(lblid.Text);
                    //var one = hpe.Tbl_Doctors.Where(x => x.docid == a).SingleOrDefault();
                    //txtname.Text = one.docname;
                    //txtsurname.Text = one.docsurname;
                    //txtbranch.Text = one.docbranch;
                    //txttc.Text = one.doctc;
                    //txtpassword.Text = one.docpassword;


                    // int selected = dataGridView1.SelectedCells[0].RowIndex;
                    //rchcomplaint.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                lblid.Text = ex.Message;
            }
        }

        private void btnlist_Click(object sender, EventArgs e)
        {

            list();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            try
            {
                hpe.Tbl_Appointments.Add(new Tbl_Appointments
                {
                    appointmentdate = dateTimePickerdate.Value,

                    appointmenttime = msktime.Text,
                    appointmentbranch = txtbranch.Text,
                    appointmentdoctor = Convert.ToInt32(cmbdoctor.SelectedValue),
                    appointmentstate = chechboxstate.Checked,
                    patienttc = msktc.Text,
                    patientcomplaint = rchcomplaint.Text

                });
                hpe.SaveChanges();
                list();
            }
            catch (Exception)
            {


            }
            

        }
    }
}
