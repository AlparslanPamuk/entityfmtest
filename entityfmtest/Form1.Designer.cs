namespace entityfmtest
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.txtDoktorAdi = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lbldocname = new System.Windows.Forms.Label();
            this.lbldocsurname = new System.Windows.Forms.Label();
            this.lbldocbranch = new System.Windows.Forms.Label();
            this.lbldoctc = new System.Windows.Forms.Label();
            this.lbldocpassword = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtbranch = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.btnform2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(910, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(864, 231);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(98, 51);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List All";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtDoktorAdi
            // 
            this.txtDoktorAdi.Location = new System.Drawing.Point(487, 91);
            this.txtDoktorAdi.Name = "txtDoktorAdi";
            this.txtDoktorAdi.Size = new System.Drawing.Size(183, 22);
            this.txtDoktorAdi.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(703, 90);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 26);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lbldocname
            // 
            this.lbldocname.AutoSize = true;
            this.lbldocname.Location = new System.Drawing.Point(56, 94);
            this.lbldocname.Name = "lbldocname";
            this.lbldocname.Size = new System.Drawing.Size(45, 17);
            this.lbldocname.TabIndex = 4;
            this.lbldocname.Text = "Name";
            // 
            // lbldocsurname
            // 
            this.lbldocsurname.AutoSize = true;
            this.lbldocsurname.Location = new System.Drawing.Point(56, 120);
            this.lbldocsurname.Name = "lbldocsurname";
            this.lbldocsurname.Size = new System.Drawing.Size(65, 17);
            this.lbldocsurname.TabIndex = 5;
            this.lbldocsurname.Text = "Surname";
            // 
            // lbldocbranch
            // 
            this.lbldocbranch.AutoSize = true;
            this.lbldocbranch.Location = new System.Drawing.Point(56, 149);
            this.lbldocbranch.Name = "lbldocbranch";
            this.lbldocbranch.Size = new System.Drawing.Size(53, 17);
            this.lbldocbranch.TabIndex = 6;
            this.lbldocbranch.Text = "Branch";
            // 
            // lbldoctc
            // 
            this.lbldoctc.AutoSize = true;
            this.lbldoctc.Location = new System.Drawing.Point(56, 180);
            this.lbldoctc.Name = "lbldoctc";
            this.lbldoctc.Size = new System.Drawing.Size(26, 17);
            this.lbldoctc.TabIndex = 7;
            this.lbldoctc.Text = "TC";
            // 
            // lbldocpassword
            // 
            this.lbldocpassword.AutoSize = true;
            this.lbldocpassword.Location = new System.Drawing.Point(56, 212);
            this.lbldocpassword.Name = "lbldocpassword";
            this.lbldocpassword.Size = new System.Drawing.Size(69, 17);
            this.lbldocpassword.TabIndex = 8;
            this.lbldocpassword.Text = "Password";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(149, 94);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(183, 22);
            this.txtname.TabIndex = 9;
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(149, 122);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(183, 22);
            this.txtsurname.TabIndex = 10;
            // 
            // txtbranch
            // 
            this.txtbranch.Location = new System.Drawing.Point(149, 150);
            this.txtbranch.Name = "txtbranch";
            this.txtbranch.Size = new System.Drawing.Size(183, 22);
            this.txtbranch.TabIndex = 11;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(149, 177);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(183, 22);
            this.txttc.TabIndex = 12;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(149, 205);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(183, 22);
            this.txtpassword.TabIndex = 13;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(369, 94);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(93, 33);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(369, 133);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(93, 33);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(369, 172);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(93, 33);
            this.btnupdate.TabIndex = 16;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(56, 65);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 17);
            this.lblid.TabIndex = 17;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(35, 251);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(46, 17);
            this.lblstatus.TabIndex = 18;
            this.lblstatus.Text = "label1";
            // 
            // btnform2
            // 
            this.btnform2.Location = new System.Drawing.Point(957, 12);
            this.btnform2.Name = "btnform2";
            this.btnform2.Size = new System.Drawing.Size(93, 33);
            this.btnform2.TabIndex = 19;
            this.btnform2.Text = "Form2";
            this.btnform2.UseVisualStyleBackColor = true;
            this.btnform2.Click += new System.EventHandler(this.btnform2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.btnform2);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.txtbranch);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbldocpassword);
            this.Controls.Add(this.lbldoctc);
            this.Controls.Add(this.lbldocbranch);
            this.Controls.Add(this.lbldocsurname);
            this.Controls.Add(this.lbldocname);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtDoktorAdi);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtDoktorAdi;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lbldocname;
        private System.Windows.Forms.Label lbldocsurname;
        private System.Windows.Forms.Label lbldocbranch;
        private System.Windows.Forms.Label lbldoctc;
        private System.Windows.Forms.Label lbldocpassword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtbranch;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btnform2;
    }
}

