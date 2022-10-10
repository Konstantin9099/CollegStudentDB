
namespace CollegStudentDB
{
    partial class MainWindow
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
            this.label8 = new System.Windows.Forms.Label();
            this.add_student_btn = new System.Windows.Forms.Button();
            this.add_group_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_teacher_btn = new System.Windows.Forms.Button();
            this.menu_bt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(14, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Кураторы:";
            // 
            // add_student_btn
            // 
            this.add_student_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.add_student_btn.Location = new System.Drawing.Point(338, 21);
            this.add_student_btn.Name = "add_student_btn";
            this.add_student_btn.Size = new System.Drawing.Size(160, 34);
            this.add_student_btn.TabIndex = 38;
            this.add_student_btn.Text = "Студент";
            this.add_student_btn.UseVisualStyleBackColor = true;
            this.add_student_btn.Click += new System.EventHandler(this.add_student_btn_Click);
            // 
            // add_group_btn
            // 
            this.add_group_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.add_group_btn.Location = new System.Drawing.Point(172, 21);
            this.add_group_btn.Name = "add_group_btn";
            this.add_group_btn.Size = new System.Drawing.Size(160, 34);
            this.add_group_btn.TabIndex = 40;
            this.add_group_btn.Text = "Группа";
            this.add_group_btn.UseVisualStyleBackColor = true;
            this.add_group_btn.Click += new System.EventHandler(this.add_group_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_teacher_btn);
            this.groupBox1.Controls.Add(this.add_student_btn);
            this.groupBox1.Controls.Add(this.add_group_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 653);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 68);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить:";
            // 
            // add_teacher_btn
            // 
            this.add_teacher_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.add_teacher_btn.Location = new System.Drawing.Point(6, 21);
            this.add_teacher_btn.Name = "add_teacher_btn";
            this.add_teacher_btn.Size = new System.Drawing.Size(160, 34);
            this.add_teacher_btn.TabIndex = 40;
            this.add_teacher_btn.Text = "Преподаватель";
            this.add_teacher_btn.UseVisualStyleBackColor = true;
            this.add_teacher_btn.Click += new System.EventHandler(this.add_teacher_btn_Click);
            // 
            // menu_bt
            // 
            this.menu_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.menu_bt.Location = new System.Drawing.Point(817, 674);
            this.menu_bt.Name = "menu_bt";
            this.menu_bt.Size = new System.Drawing.Size(100, 34);
            this.menu_bt.TabIndex = 42;
            this.menu_bt.Text = "Menu";
            this.menu_bt.UseVisualStyleBackColor = true;
            this.menu_bt.Click += new System.EventHandler(this.menu_bt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(905, 266);
            this.dataGridView1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Студенты:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 342);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(905, 296);
            this.dataGridView2.TabIndex = 47;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 733);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menu_bt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Списки студентов и кураторов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add_student_btn;
        private System.Windows.Forms.Button add_group_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add_teacher_btn;
        private System.Windows.Forms.Button menu_bt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}