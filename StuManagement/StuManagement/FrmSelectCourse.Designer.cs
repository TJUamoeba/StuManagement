namespace StuManagement
{
    partial class FrmSelectCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.butConf = new System.Windows.Forms.Button();
            this.labSid = new System.Windows.Forms.Label();
            this.labCourse = new System.Windows.Forms.Label();
            this.comBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用选课系统！";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(479, 400);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(659, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 530);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已选课程";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "年级";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(578, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(70, 475);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 25);
            this.txtSid.TabIndex = 6;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(273, 475);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(100, 25);
            this.txtCid.TabIndex = 7;
            // 
            // butConf
            // 
            this.butConf.Location = new System.Drawing.Point(456, 471);
            this.butConf.Name = "butConf";
            this.butConf.Size = new System.Drawing.Size(104, 29);
            this.butConf.TabIndex = 8;
            this.butConf.Text = "确认";
            this.butConf.UseVisualStyleBackColor = true;
            this.butConf.Click += new System.EventHandler(this.butConf_Click);
            // 
            // labSid
            // 
            this.labSid.AutoSize = true;
            this.labSid.Font = new System.Drawing.Font("宋体", 12F);
            this.labSid.Location = new System.Drawing.Point(15, 478);
            this.labSid.Name = "labSid";
            this.labSid.Size = new System.Drawing.Size(49, 20);
            this.labSid.TabIndex = 9;
            this.labSid.Text = "学号";
            // 
            // labCourse
            // 
            this.labCourse.AutoSize = true;
            this.labCourse.Font = new System.Drawing.Font("宋体", 12F);
            this.labCourse.Location = new System.Drawing.Point(187, 480);
            this.labCourse.Name = "labCourse";
            this.labCourse.Size = new System.Drawing.Size(69, 20);
            this.labCourse.TabIndex = 10;
            this.labCourse.Text = "课程号";
            // 
            // comBox1
            // 
            this.comBox1.FormattingEnabled = true;
            this.comBox1.Items.AddRange(new object[] {
            "16",
            "17",
            "全部"});
            this.comBox1.Location = new System.Drawing.Point(70, 24);
            this.comBox1.Name = "comBox1";
            this.comBox1.Size = new System.Drawing.Size(121, 23);
            this.comBox1.TabIndex = 12;
            this.comBox1.SelectedIndexChanged += new System.EventHandler(this.comBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comBox1);
            this.groupBox1.Controls.Add(this.labCourse);
            this.groupBox1.Controls.Add(this.labSid);
            this.groupBox1.Controls.Add(this.butConf);
            this.groupBox1.Controls.Add(this.txtCid);
            this.groupBox1.Controls.Add(this.txtSid);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 530);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "可选课程";
            // 
            // FrmSelectCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSelectCourse";
            this.Text = "CourseSelect";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Button butConf;
        private System.Windows.Forms.Label labSid;
        private System.Windows.Forms.Label labCourse;
        private System.Windows.Forms.ComboBox comBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}