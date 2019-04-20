namespace entityfmtest
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.msktime = new System.Windows.Forms.MaskedTextBox();
            this.rchcomplaint = new System.Windows.Forms.RichTextBox();
            this.lblcomplaint = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblstate = new System.Windows.Forms.Label();
            this.lbldoctor = new System.Windows.Forms.Label();
            this.lblbranch = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.dateTimePickerdate = new System.Windows.Forms.DateTimePicker();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.chechboxstate = new System.Windows.Forms.CheckBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtbranch = new System.Windows.Forms.TextBox();
            this.cmbdoctor = new System.Windows.Forms.ComboBox();
            this.btnlist = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 325);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // msktime
            // 
            this.msktime.Location = new System.Drawing.Point(96, 67);
            this.msktime.Mask = "00:00";
            this.msktime.Name = "msktime";
            this.msktime.Size = new System.Drawing.Size(192, 22);
            this.msktime.TabIndex = 28;
            this.msktime.ValidatingType = typeof(System.DateTime);
            // 
            // rchcomplaint
            // 
            this.rchcomplaint.Location = new System.Drawing.Point(96, 225);
            this.rchcomplaint.Name = "rchcomplaint";
            this.rchcomplaint.Size = new System.Drawing.Size(192, 133);
            this.rchcomplaint.TabIndex = 27;
            this.rchcomplaint.Text = "";
            // 
            // lblcomplaint
            // 
            this.lblcomplaint.AutoSize = true;
            this.lblcomplaint.Location = new System.Drawing.Point(8, 225);
            this.lblcomplaint.Name = "lblcomplaint";
            this.lblcomplaint.Size = new System.Drawing.Size(70, 17);
            this.lblcomplaint.TabIndex = 26;
            this.lblcomplaint.Text = "Complaint";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(8, 196);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(26, 17);
            this.lbltc.TabIndex = 25;
            this.lbltc.Text = "TC";
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Location = new System.Drawing.Point(8, 168);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(41, 17);
            this.lblstate.TabIndex = 24;
            this.lblstate.Text = "State";
            // 
            // lbldoctor
            // 
            this.lbldoctor.AutoSize = true;
            this.lbldoctor.Location = new System.Drawing.Point(8, 135);
            this.lbldoctor.Name = "lbldoctor";
            this.lbldoctor.Size = new System.Drawing.Size(50, 17);
            this.lbldoctor.TabIndex = 23;
            this.lbldoctor.Text = "Doctor";
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.Location = new System.Drawing.Point(8, 103);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(53, 17);
            this.lblbranch.TabIndex = 22;
            this.lblbranch.Text = "Branch";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(8, 70);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(39, 17);
            this.lbltime.TabIndex = 21;
            this.lbltime.Text = "Time";
            // 
            // dateTimePickerdate
            // 
            this.dateTimePickerdate.Location = new System.Drawing.Point(96, 33);
            this.dateTimePickerdate.Name = "dateTimePickerdate";
            this.dateTimePickerdate.Size = new System.Drawing.Size(192, 22);
            this.dateTimePickerdate.TabIndex = 20;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(96, 191);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(192, 22);
            this.msktc.TabIndex = 19;
            this.msktc.ValidatingType = typeof(int);
            // 
            // chechboxstate
            // 
            this.chechboxstate.AutoSize = true;
            this.chechboxstate.Location = new System.Drawing.Point(98, 164);
            this.chechboxstate.Name = "chechboxstate";
            this.chechboxstate.Size = new System.Drawing.Size(98, 21);
            this.chechboxstate.TabIndex = 18;
            this.chechboxstate.Text = "checkBox1";
            this.chechboxstate.UseVisualStyleBackColor = true;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(8, 38);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(38, 17);
            this.lbldate.TabIndex = 17;
            this.lbldate.Text = "Date";
            // 
            // txtbranch
            // 
            this.txtbranch.Location = new System.Drawing.Point(96, 103);
            this.txtbranch.Name = "txtbranch";
            this.txtbranch.Size = new System.Drawing.Size(192, 22);
            this.txtbranch.TabIndex = 16;
            // 
            // cmbdoctor
            // 
            this.cmbdoctor.FormattingEnabled = true;
            this.cmbdoctor.Location = new System.Drawing.Point(96, 135);
            this.cmbdoctor.Name = "cmbdoctor";
            this.cmbdoctor.Size = new System.Drawing.Size(192, 24);
            this.cmbdoctor.TabIndex = 15;
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(143, 376);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(73, 39);
            this.btnlist.TabIndex = 30;
            this.btnlist.Text = "List All";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(378, 387);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 17);
            this.lblid.TabIndex = 31;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(430, 382);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(93, 33);
            this.btnupdate.TabIndex = 34;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(262, 379);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(93, 33);
            this.btndelete.TabIndex = 33;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(44, 382);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(93, 33);
            this.btnsave.TabIndex = 32;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 427);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.msktime);
            this.Controls.Add(this.rchcomplaint);
            this.Controls.Add(this.lblcomplaint);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.lblstate);
            this.Controls.Add(this.lbldoctor);
            this.Controls.Add(this.lblbranch);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.dateTimePickerdate);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.chechboxstate);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.txtbranch);
            this.Controls.Add(this.cmbdoctor);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox msktime;
        private System.Windows.Forms.RichTextBox rchcomplaint;
        private System.Windows.Forms.Label lblcomplaint;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.Label lbldoctor;
        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.DateTimePicker dateTimePickerdate;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.CheckBox chechboxstate;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txtbranch;
        private System.Windows.Forms.ComboBox cmbdoctor;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
    }
}