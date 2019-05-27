namespace StuManagement
{
    partial class StuPersonalPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuPersonalPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.texCavg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textSavg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCname = new System.Windows.Forms.TextBox();
            this.textCid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCourseAvg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.Label();
            this.c2 = new System.Windows.Forms.Label();
            this.c3 = new System.Windows.Forms.Label();
            this.c4 = new System.Windows.Forms.Label();
            this.c5 = new System.Windows.Forms.Label();
            this.c6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 280);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 25);
            this.txtName.TabIndex = 1;
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(80, 246);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 25);
            this.txtSid.TabIndex = 2;
            this.txtSid.TextChanged += new System.EventHandler(this.txtSid_TextChanged);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(80, 311);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 25);
            this.txtClass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "学号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "班级";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(880, 235);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(249, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 279);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "我的成绩";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.texCavg);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textSavg);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtClass);
            this.groupBox2.Controls.Add(this.txtSid);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(13, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 529);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "个人信息";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "班级平均分";
            // 
            // texCavg
            // 
            this.texCavg.Location = new System.Drawing.Point(80, 457);
            this.texCavg.Name = "texCavg";
            this.texCavg.Size = new System.Drawing.Size(100, 25);
            this.texCavg.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 372);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "我的平均分";
            // 
            // textSavg
            // 
            this.textSavg.Location = new System.Drawing.Point(80, 390);
            this.textSavg.Name = "textSavg";
            this.textSavg.Size = new System.Drawing.Size(100, 25);
            this.textSavg.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(339, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "课程名称";
            // 
            // textCname
            // 
            this.textCname.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textCname.Location = new System.Drawing.Point(434, 313);
            this.textCname.Name = "textCname";
            this.textCname.Size = new System.Drawing.Size(117, 28);
            this.textCname.TabIndex = 7;
            this.textCname.TextChanged += new System.EventHandler(this.textCname_TextChanged);
            // 
            // textCid
            // 
            this.textCid.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textCid.Location = new System.Drawing.Point(672, 316);
            this.textCid.Name = "textCid";
            this.textCid.Size = new System.Drawing.Size(100, 28);
            this.textCid.TabIndex = 11;
            this.textCid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(577, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "课程编号";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textCourseAvg
            // 
            this.textCourseAvg.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textCourseAvg.Location = new System.Drawing.Point(937, 316);
            this.textCourseAvg.Name = "textCourseAvg";
            this.textCourseAvg.Size = new System.Drawing.Size(100, 28);
            this.textCourseAvg.TabIndex = 13;
            this.textCourseAvg.TextChanged += new System.EventHandler(this.textCourseAvg_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(822, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "课程平均分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(339, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "成绩分布";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(339, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "不及格";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(465, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "60-69";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(597, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "70-79";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(739, 449);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "80-89";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.Location = new System.Drawing.Point(872, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "90-99";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F);
            this.label13.Location = new System.Drawing.Point(996, 449);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "满分";
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Font = new System.Drawing.Font("宋体", 12F);
            this.c1.Location = new System.Drawing.Point(339, 496);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(39, 20);
            this.c1.TabIndex = 23;
            this.c1.Text = "0人";
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Font = new System.Drawing.Font("宋体", 12F);
            this.c2.Location = new System.Drawing.Point(465, 496);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(39, 20);
            this.c2.TabIndex = 24;
            this.c2.Text = "0人";
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.Font = new System.Drawing.Font("宋体", 12F);
            this.c3.Location = new System.Drawing.Point(606, 496);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(39, 20);
            this.c3.TabIndex = 25;
            this.c3.Text = "0人";
            // 
            // c4
            // 
            this.c4.AutoSize = true;
            this.c4.Font = new System.Drawing.Font("宋体", 12F);
            this.c4.Location = new System.Drawing.Point(749, 496);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(39, 20);
            this.c4.TabIndex = 26;
            this.c4.Text = "0人";
            // 
            // c5
            // 
            this.c5.AutoSize = true;
            this.c5.Font = new System.Drawing.Font("宋体", 12F);
            this.c5.Location = new System.Drawing.Point(892, 496);
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(39, 20);
            this.c5.TabIndex = 27;
            this.c5.Text = "0人";
            // 
            // c6
            // 
            this.c6.AutoSize = true;
            this.c6.Font = new System.Drawing.Font("宋体", 12F);
            this.c6.Location = new System.Drawing.Point(1006, 496);
            this.c6.Name = "c6";
            this.c6.Size = new System.Drawing.Size(39, 20);
            this.c6.TabIndex = 28;
            this.c6.Text = "0人";
            // 
            // StuPersonalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1182, 583);
            this.Controls.Add(this.c6);
            this.Controls.Add(this.c5);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textCourseAvg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textCid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StuPersonalPage";
            this.Text = "PersonalPage";
            this.Load += new System.EventHandler(this.StuPersonalPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCname;
        private System.Windows.Forms.TextBox textCid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox texCavg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textSavg;
        private System.Windows.Forms.TextBox textCourseAvg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label c1;
        private System.Windows.Forms.Label c2;
        private System.Windows.Forms.Label c3;
        private System.Windows.Forms.Label c4;
        private System.Windows.Forms.Label c5;
        private System.Windows.Forms.Label c6;
    }
}