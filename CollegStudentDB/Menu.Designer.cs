
namespace CollegStudentDB
{
    partial class Menu
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
            this.groups_btn = new System.Windows.Forms.Button();
            this.student_btn = new System.Windows.Forms.Button();
            this.teachers_btn = new System.Windows.Forms.Button();
            this.group_lists_btn = new System.Windows.Forms.Button();
            this.change_profile_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groups_btn
            // 
            this.groups_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groups_btn.Location = new System.Drawing.Point(56, 165);
            this.groups_btn.Name = "groups_btn";
            this.groups_btn.Size = new System.Drawing.Size(190, 50);
            this.groups_btn.TabIndex = 0;
            this.groups_btn.Text = "Группы";
            this.groups_btn.UseVisualStyleBackColor = true;
            this.groups_btn.Click += new System.EventHandler(this.groups_btn_Click);
            // 
            // student_btn
            // 
            this.student_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.student_btn.Location = new System.Drawing.Point(56, 232);
            this.student_btn.Name = "student_btn";
            this.student_btn.Size = new System.Drawing.Size(190, 50);
            this.student_btn.TabIndex = 1;
            this.student_btn.Text = "Студенты";
            this.student_btn.UseVisualStyleBackColor = true;
            this.student_btn.Click += new System.EventHandler(this.student_btn_Click);
            // 
            // teachers_btn
            // 
            this.teachers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.teachers_btn.Location = new System.Drawing.Point(56, 98);
            this.teachers_btn.Name = "teachers_btn";
            this.teachers_btn.Size = new System.Drawing.Size(190, 50);
            this.teachers_btn.TabIndex = 2;
            this.teachers_btn.Text = "Преподаватели";
            this.teachers_btn.UseVisualStyleBackColor = true;
            this.teachers_btn.Click += new System.EventHandler(this.teachers_btn_Click);
            // 
            // group_lists_btn
            // 
            this.group_lists_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.group_lists_btn.Location = new System.Drawing.Point(56, 31);
            this.group_lists_btn.Name = "group_lists_btn";
            this.group_lists_btn.Size = new System.Drawing.Size(190, 50);
            this.group_lists_btn.TabIndex = 3;
            this.group_lists_btn.Text = "Списки";
            this.group_lists_btn.UseVisualStyleBackColor = true;
            this.group_lists_btn.Click += new System.EventHandler(this.group_lists_btn_Click);
            // 
            // change_profile_btn
            // 
            this.change_profile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.change_profile_btn.Location = new System.Drawing.Point(56, 299);
            this.change_profile_btn.Name = "change_profile_btn";
            this.change_profile_btn.Size = new System.Drawing.Size(190, 50);
            this.change_profile_btn.TabIndex = 4;
            this.change_profile_btn.Text = "Профиль";
            this.change_profile_btn.UseVisualStyleBackColor = true;
            this.change_profile_btn.Click += new System.EventHandler(this.change_profile_btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 384);
            this.Controls.Add(this.change_profile_btn);
            this.Controls.Add(this.group_lists_btn);
            this.Controls.Add(this.teachers_btn);
            this.Controls.Add(this.student_btn);
            this.Controls.Add(this.groups_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button groups_btn;
        private System.Windows.Forms.Button student_btn;
        private System.Windows.Forms.Button teachers_btn;
        private System.Windows.Forms.Button group_lists_btn;
        private System.Windows.Forms.Button change_profile_btn;
    }
}