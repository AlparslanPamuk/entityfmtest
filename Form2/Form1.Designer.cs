namespace Form2
{
    partial class Form1
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
            this.cmbdoctor = new System.Windows.Forms.ComboBox();
            this.txtbranch = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.chechboxstate = new System.Windows.Forms.CheckBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerdate = new System.Windows.Forms.DateTimePicker();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblbranch = new System.Windows.Forms.Label();
            this.lbldoctor = new System.Windows.Forms.Label();
            this.lblstate = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblcomplaint = new System.Windows.Forms.Label();
            this.rchcomplaint = new System.Windows.Forms.RichTextBox();
            this.msktime = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbdoctor
            // 
            this.cmbdoctor.FormattingEnabled = true;
            this.cmbdoctor.Location = new System.Drawing.Point(122, 148);
            this.cmbdoctor.Name = "cmbdoctor";
            this.cmbdoctor.Size = new System.Drawing.Size(192, 24);
            this.cmbdoctor.TabIndex = 0;
            // 
            // txtbranch
            // 
            this.txtbranch.Location = new System.Drawing.Point(122, 116);
            this.txtbranch.Name = "txtbranch";
            this.txtbranch.Size = new System.Drawing.Size(192, 22);
            this.txtbranch.TabIndex = 1;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(34, 51);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(38, 17);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date";
            // 
            // chechboxstate
            // 
            this.chechboxstate.AutoSize = true;
            this.chechboxstate.Location = new System.Drawing.Point(124, 177);
            this.chechboxstate.Name = "chechboxstate";
            this.chechboxstate.Size = new System.Drawing.Size(98, 21);
            this.chechboxstate.TabIndex = 3;
            this.chechboxstate.Text = "checkBox1";
            this.chechboxstate.UseVisualStyleBackColor = true;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(122, 204);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(192, 22);
            this.msktc.TabIndex = 4;
            this.msktc.ValidatingType = typeof(int);
            // 
            // dateTimePickerdate
            // 
            this.dateTimePickerdate.Location = new System.Drawing.Point(122, 46);
            this.dateTimePickerdate.Name = "dateTimePickerdate";
            this.dateTimePickerdate.Size = new System.Drawing.Size(192, 22);
            this.dateTimePickerdate.TabIndex = 5;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(34, 83);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(39, 17);
            this.lbltime.TabIndex = 6;
            this.lbltime.Text = "Time";
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.Location = new System.Drawing.Point(34, 116);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(53, 17);
            this.lblbranch.TabIndex = 7;
            this.lblbranch.Text = "Branch";
            // 
            // lbldoctor
            // 
            this.lbldoctor.AutoSize = true;
            this.lbldoctor.Location = new System.Drawing.Point(34, 148);
            this.lbldoctor.Name = "lbldoctor";
            this.lbldoctor.Size = new System.Drawing.Size(50, 17);
            this.lbldoctor.TabIndex = 8;
            this.lbldoctor.Text = "Doctor";
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Location = new System.Drawing.Point(34, 181);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(41, 17);
            this.lblstate.TabIndex = 9;
            this.lblstate.Text = "State";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(34, 209);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(26, 17);
            this.lbltc.TabIndex = 10;
            this.lbltc.Text = "TC";
            // 
            // lblcomplaint
            // 
            this.lblcomplaint.AutoSize = true;
            this.lblcomplaint.Location = new System.Drawing.Point(34, 238);
            this.lblcomplaint.Name = "lblcomplaint";
            this.lblcomplaint.Size = new System.Drawing.Size(70, 17);
            this.lblcomplaint.TabIndex = 11;
            this.lblcomplaint.Text = "Complaint";
            // 
            // rchcomplaint
            // 
            this.rchcomplaint.Location = new System.Drawing.Point(122, 238);
            this.rchcomplaint.Name = "rchcomplaint";
            this.rchcomplaint.Size = new System.Drawing.Size(192, 133);
            this.rchcomplaint.TabIndex = 12;
            this.rchcomplaint.Text = "";
            // 
            // msktime
            // 
            this.msktime.Location = new System.Drawing.Point(122, 80);
            this.msktime.Mask = "00:00";
            this.msktime.Name = "msktime";
            this.msktime.Size = new System.Drawing.Size(192, 22);
            this.msktime.TabIndex = 13;
            this.msktime.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 325);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1141, 410);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbdoctor;
        private System.Windows.Forms.TextBox txtbranch;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.CheckBox chechboxstate;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.DateTimePicker dateTimePickerdate;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.Label lbldoctor;
        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblcomplaint;
        private System.Windows.Forms.RichTextBox rchcomplaint;
        private System.Windows.Forms.MaskedTextBox msktime;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

