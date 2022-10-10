
namespace CollegStudentDB
{
    partial class LearningGroup
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
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.group_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.print_bt = new System.Windows.Forms.Button();
            this.menu_bt = new System.Windows.Forms.Button();
            this.search_line_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.speciality_tb = new System.Windows.Forms.TextBox();
            this.teachers_cmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.add_btn.Location = new System.Drawing.Point(640, 9);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(110, 38);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edit_btn.Location = new System.Drawing.Point(640, 65);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(110, 38);
            this.edit_btn.TabIndex = 2;
            this.edit_btn.Text = "Изменить";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.refresh_btn.Location = new System.Drawing.Point(640, 121);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(110, 38);
            this.refresh_btn.TabIndex = 3;
            this.refresh_btn.Text = "Обновить";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "№ группы:";
            // 
            // group_tb
            // 
            this.group_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.group_tb.Location = new System.Drawing.Point(12, 31);
            this.group_tb.Name = "group_tb";
            this.group_tb.Size = new System.Drawing.Size(145, 26);
            this.group_tb.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Специальность:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Куратор:";
            // 
            // print_bt
            // 
            this.print_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.print_bt.Location = new System.Drawing.Point(650, 527);
            this.print_bt.Name = "print_bt";
            this.print_bt.Size = new System.Drawing.Size(100, 38);
            this.print_bt.TabIndex = 27;
            this.print_bt.Text = "Печать";
            this.print_bt.UseVisualStyleBackColor = true;
            this.print_bt.Click += new System.EventHandler(this.print_bt_Click);
            // 
            // menu_bt
            // 
            this.menu_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.menu_bt.Location = new System.Drawing.Point(529, 527);
            this.menu_bt.Name = "menu_bt";
            this.menu_bt.Size = new System.Drawing.Size(100, 38);
            this.menu_bt.TabIndex = 28;
            this.menu_bt.Text = "Menu";
            this.menu_bt.UseVisualStyleBackColor = true;
            this.menu_bt.Click += new System.EventHandler(this.menu_bt_Click);
            // 
            // search_line_tb
            // 
            this.search_line_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.search_line_tb.Location = new System.Drawing.Point(12, 486);
            this.search_line_tb.Name = "search_line_tb";
            this.search_line_tb.Size = new System.Drawing.Size(511, 26);
            this.search_line_tb.TabIndex = 29;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.search_btn.Location = new System.Drawing.Point(529, 484);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(221, 30);
            this.search_btn.TabIndex = 30;
            this.search_btn.Text = "Выполнить поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // speciality_tb
            // 
            this.speciality_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.speciality_tb.Location = new System.Drawing.Point(12, 81);
            this.speciality_tb.Name = "speciality_tb";
            this.speciality_tb.Size = new System.Drawing.Size(601, 26);
            this.speciality_tb.TabIndex = 19;
            // 
            // teachers_cmb
            // 
            this.teachers_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.teachers_cmb.FormattingEnabled = true;
            this.teachers_cmb.Location = new System.Drawing.Point(12, 131);
            this.teachers_cmb.Name = "teachers_cmb";
            this.teachers_cmb.Size = new System.Drawing.Size(601, 28);
            this.teachers_cmb.TabIndex = 31;
            // 
            // LearningGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 581);
            this.Controls.Add(this.teachers_cmb);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_line_tb);
            this.Controls.Add(this.menu_bt);
            this.Controls.Add(this.print_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.speciality_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.group_tb);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LearningGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учебные группы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LearningGroup_FormClosed);
            this.Load += new System.EventHandler(this.LearningGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox group_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button print_bt;
        private System.Windows.Forms.Button menu_bt;
        private System.Windows.Forms.TextBox search_line_tb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox speciality_tb;
        private System.Windows.Forms.ComboBox teachers_cmb;
    }
}