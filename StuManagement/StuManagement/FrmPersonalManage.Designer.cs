namespace StuManagement
{
    partial class FrmPersonalManage
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
            this.txtSid = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butDel = new System.Windows.Forms.Button();
            this.GenderBut1 = new System.Windows.Forms.RadioButton();
            this.GenderBut2 = new System.Windows.Forms.RadioButton();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.butUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用人员管理";
            // 
            // txtSid
            // 
            this.txtSid.Font = new System.Drawing.Font("宋体", 11F);
            this.txtSid.Location = new System.Drawing.Point(223, 60);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(141, 28);
            this.txtSid.TabIndex = 1;
            this.txtSid.TextChanged += new System.EventHandler(this.txtSid_TextChanged);
            // 
            // txtSname
            // 
            this.txtSname.Font = new System.Drawing.Font("宋体", 11F);
            this.txtSname.Location = new System.Drawing.Point(223, 110);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(141, 28);
            this.txtSname.TabIndex = 2;
            this.txtSname.TextChanged += new System.EventHandler(this.txtSname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(110, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "学 号";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(110, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "姓 名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(110, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "性 别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(110, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "班 级";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(110, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "年 级";
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(264, 405);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(100, 30);
            this.butDel.TabIndex = 12;
            this.butDel.Text = "删除";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // GenderBut1
            // 
            this.GenderBut1.AutoSize = true;
            this.GenderBut1.Font = new System.Drawing.Font("宋体", 12F);
            this.GenderBut1.Location = new System.Drawing.Point(223, 162);
            this.GenderBut1.Name = "GenderBut1";
            this.GenderBut1.Size = new System.Drawing.Size(50, 24);
            this.GenderBut1.TabIndex = 13;
            this.GenderBut1.TabStop = true;
            this.GenderBut1.Text = "男";
            this.GenderBut1.UseVisualStyleBackColor = true;
            // 
            // GenderBut2
            // 
            this.GenderBut2.AutoSize = true;
            this.GenderBut2.Font = new System.Drawing.Font("宋体", 12F);
            this.GenderBut2.Location = new System.Drawing.Point(303, 162);
            this.GenderBut2.Name = "GenderBut2";
            this.GenderBut2.Size = new System.Drawing.Size(50, 24);
            this.GenderBut2.TabIndex = 14;
            this.GenderBut2.TabStop = true;
            this.GenderBut2.Text = "女";
            this.GenderBut2.UseVisualStyleBackColor = true;
            // 
            // cbClass
            // 
            this.cbClass.Font = new System.Drawing.Font("宋体", 12F);
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(223, 262);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(141, 28);
            this.cbClass.TabIndex = 15;
            // 
            // cbGrade
            // 
            this.cbGrade.Font = new System.Drawing.Font("宋体", 12F);
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Location = new System.Drawing.Point(223, 212);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(141, 28);
            this.cbGrade.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.butUpdate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbGrade);
            this.groupBox1.Controls.Add(this.cbClass);
            this.groupBox1.Controls.Add(this.GenderBut2);
            this.groupBox1.Controls.Add(this.GenderBut1);
            this.groupBox1.Controls.Add(this.butDel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSname);
            this.groupBox1.Controls.Add(this.txtSid);
            this.groupBox1.Location = new System.Drawing.Point(335, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 494);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生管理";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("宋体", 11F);
            this.txtAge.Location = new System.Drawing.Point(223, 308);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(141, 28);
            this.txtAge.TabIndex = 20;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(114, 405);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(100, 30);
            this.butUpdate.TabIndex = 19;
            this.butUpdate.Text = "更新";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(110, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "年 龄";
            // 
            // FrmPersonalManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1182, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPersonalManage";
            this.Text = "FrmPersonalManage";
            this.Load += new System.EventHandler(this.FrmPersonalManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.RadioButton GenderBut1;
        private System.Windows.Forms.RadioButton GenderBut2;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.TextBox txtAge;
    }
}