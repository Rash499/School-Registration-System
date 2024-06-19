namespace School_registration_system
{
    partial class frmHome_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome_Admin));
            this.btnUpdateStudents = new System.Windows.Forms.Button();
            this.btnUpdateSubjects = new System.Windows.Forms.Button();
            this.btnUpdateTeachers = new System.Windows.Forms.Button();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHomeAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSkills = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateStudents
            // 
            this.btnUpdateStudents.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateStudents.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateStudents.Image")));
            this.btnUpdateStudents.Location = new System.Drawing.Point(71, 154);
            this.btnUpdateStudents.Name = "btnUpdateStudents";
            this.btnUpdateStudents.Size = new System.Drawing.Size(150, 150);
            this.btnUpdateStudents.TabIndex = 0;
            this.btnUpdateStudents.Text = "Students";
            this.btnUpdateStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateStudents.UseVisualStyleBackColor = false;
            this.btnUpdateStudents.Click += new System.EventHandler(this.btnUpdateStudents_Click);
            // 
            // btnUpdateSubjects
            // 
            this.btnUpdateSubjects.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateSubjects.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSubjects.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSubjects.Image")));
            this.btnUpdateSubjects.Location = new System.Drawing.Point(265, 154);
            this.btnUpdateSubjects.Name = "btnUpdateSubjects";
            this.btnUpdateSubjects.Size = new System.Drawing.Size(150, 150);
            this.btnUpdateSubjects.TabIndex = 1;
            this.btnUpdateSubjects.Text = "Subjects";
            this.btnUpdateSubjects.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateSubjects.UseVisualStyleBackColor = false;
            this.btnUpdateSubjects.Click += new System.EventHandler(this.btnUpdateSubjects_Click);
            // 
            // btnUpdateTeachers
            // 
            this.btnUpdateTeachers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateTeachers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTeachers.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTeachers.Image")));
            this.btnUpdateTeachers.Location = new System.Drawing.Point(71, 346);
            this.btnUpdateTeachers.Name = "btnUpdateTeachers";
            this.btnUpdateTeachers.Size = new System.Drawing.Size(150, 150);
            this.btnUpdateTeachers.TabIndex = 2;
            this.btnUpdateTeachers.Text = "Teachers";
            this.btnUpdateTeachers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateTeachers.UseVisualStyleBackColor = false;
            this.btnUpdateTeachers.Click += new System.EventHandler(this.btnUpdateTeachers_Click);
            // 
            // btnGrades
            // 
            this.btnGrades.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGrades.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrades.Image = ((System.Drawing.Image)(resources.GetObject("btnGrades.Image")));
            this.btnGrades.Location = new System.Drawing.Point(265, 346);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(150, 150);
            this.btnGrades.TabIndex = 3;
            this.btnGrades.Text = "Grades";
            this.btnGrades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrades.UseVisualStyleBackColor = false;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(397, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(70, 30);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(12, 515);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHomeAdmin
            // 
            this.lblHomeAdmin.AutoSize = true;
            this.lblHomeAdmin.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeAdmin.Location = new System.Drawing.Point(12, 9);
            this.lblHomeAdmin.Name = "lblHomeAdmin";
            this.lblHomeAdmin.Size = new System.Drawing.Size(115, 45);
            this.lblHomeAdmin.TabIndex = 6;
            this.lblHomeAdmin.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkills.Location = new System.Drawing.Point(126, 107);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(236, 33);
            this.lblSkills.TabIndex = 8;
            this.lblSkills.Text = "Skills Internationals";
            // 
            // frmHome_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHomeAdmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.btnUpdateTeachers);
            this.Controls.Add(this.btnUpdateSubjects);
            this.Controls.Add(this.btnUpdateStudents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome_Admin";
            this.Text = "Home_Admin";
            this.Load += new System.EventHandler(this.Home_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateStudents;
        private System.Windows.Forms.Button btnUpdateSubjects;
        private System.Windows.Forms.Button btnUpdateTeachers;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHomeAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSkills;
    }
}