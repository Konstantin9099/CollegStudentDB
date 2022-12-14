
namespace CollegStudentDB
{
    partial class EditGroup
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupNumber_tb = new System.Windows.Forms.TextBox();
            this.teachers_cmb = new System.Windows.Forms.ComboBox();
            this.speciality_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(42, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 37);
            this.button2.TabIndex = 66;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(327, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 37);
            this.button1.TabIndex = 65;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Куратор:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Специальность:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "№ группы:";
            // 
            // GroupNumber_tb
            // 
            this.GroupNumber_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GroupNumber_tb.Location = new System.Drawing.Point(42, 45);
            this.GroupNumber_tb.Name = "GroupNumber_tb";
            this.GroupNumber_tb.Size = new System.Drawing.Size(221, 26);
            this.GroupNumber_tb.TabIndex = 58;
            // 
            // teachers_cmb
            // 
            this.teachers_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.teachers_cmb.FormattingEnabled = true;
            this.teachers_cmb.Location = new System.Drawing.Point(42, 146);
            this.teachers_cmb.Name = "teachers_cmb";
            this.teachers_cmb.Size = new System.Drawing.Size(506, 28);
            this.teachers_cmb.TabIndex = 67;
            // 
            // speciality_tb
            // 
            this.speciality_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.speciality_tb.Location = new System.Drawing.Point(42, 96);
            this.speciality_tb.Name = "speciality_tb";
            this.speciality_tb.Size = new System.Drawing.Size(506, 26);
            this.speciality_tb.TabIndex = 68;
            // 
            // EditGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 262);
            this.Controls.Add(this.speciality_tb);
            this.Controls.Add(this.teachers_cmb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupNumber_tb);
            this.Name = "EditGroup";
            this.Text = "Профиль: группа";
            this.Load += new System.EventHandler(this.EditGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GroupNumber_tb;
        private System.Windows.Forms.ComboBox teachers_cmb;
        private System.Windows.Forms.TextBox speciality_tb;
    }
}