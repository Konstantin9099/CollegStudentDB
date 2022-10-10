
namespace CollegStudentDB
{
    partial class Students
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
            this.last_name_tb = new System.Windows.Forms.TextBox();
            this.first_name_tb = new System.Windows.Forms.TextBox();
            this.middle_name_tb = new System.Windows.Forms.TextBox();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.student_card_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.print_bt = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_line_tb = new System.Windows.Forms.TextBox();
            this.menu_bt = new System.Windows.Forms.Button();
            this.group_cmb = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.telephone_mtb = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // last_name_tb
            // 
            this.last_name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.last_name_tb.Location = new System.Drawing.Point(12, 38);
            this.last_name_tb.Name = "last_name_tb";
            this.last_name_tb.Size = new System.Drawing.Size(221, 26);
            this.last_name_tb.TabIndex = 1;
            // 
            // first_name_tb
            // 
            this.first_name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.first_name_tb.Location = new System.Drawing.Point(12, 96);
            this.first_name_tb.Name = "first_name_tb";
            this.first_name_tb.Size = new System.Drawing.Size(221, 26);
            this.first_name_tb.TabIndex = 2;
            // 
            // middle_name_tb
            // 
            this.middle_name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.middle_name_tb.Location = new System.Drawing.Point(12, 154);
            this.middle_name_tb.Name = "middle_name_tb";
            this.middle_name_tb.Size = new System.Drawing.Size(221, 26);
            this.middle_name_tb.TabIndex = 3;
            // 
            // address_tb
            // 
            this.address_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.address_tb.Location = new System.Drawing.Point(247, 38);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(515, 26);
            this.address_tb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата рождения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(247, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Адрес местожительства:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(247, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Телефон:";
            // 
            // student_card_tb
            // 
            this.student_card_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.student_card_tb.Location = new System.Drawing.Point(247, 154);
            this.student_card_tb.Name = "student_card_tb";
            this.student_card_tb.Size = new System.Drawing.Size(221, 26);
            this.student_card_tb.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(247, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "№ студенческого билета:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(247, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "№ группы:";
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.delete_btn.Location = new System.Drawing.Point(652, 156);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(110, 38);
            this.delete_btn.TabIndex = 24;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edit_btn.Location = new System.Drawing.Point(652, 112);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(110, 38);
            this.edit_btn.TabIndex = 22;
            this.edit_btn.Text = "Изменить";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.add_btn.Location = new System.Drawing.Point(652, 68);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(110, 38);
            this.add_btn.TabIndex = 21;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // print_bt
            // 
            this.print_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.print_bt.Location = new System.Drawing.Point(662, 639);
            this.print_bt.Name = "print_bt";
            this.print_bt.Size = new System.Drawing.Size(100, 38);
            this.print_bt.TabIndex = 25;
            this.print_bt.Text = "Печать";
            this.print_bt.UseVisualStyleBackColor = true;
            this.print_bt.Click += new System.EventHandler(this.print_bt_Click);
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.search_btn.Location = new System.Drawing.Point(541, 603);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(221, 30);
            this.search_btn.TabIndex = 32;
            this.search_btn.Text = "Выполнить поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_line_tb
            // 
            this.search_line_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.search_line_tb.Location = new System.Drawing.Point(7, 605);
            this.search_line_tb.Name = "search_line_tb";
            this.search_line_tb.Size = new System.Drawing.Size(528, 26);
            this.search_line_tb.TabIndex = 31;
            // 
            // menu_bt
            // 
            this.menu_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.menu_bt.Location = new System.Drawing.Point(541, 639);
            this.menu_bt.Name = "menu_bt";
            this.menu_bt.Size = new System.Drawing.Size(100, 38);
            this.menu_bt.TabIndex = 33;
            this.menu_bt.Text = "Menu";
            this.menu_bt.UseVisualStyleBackColor = true;
            this.menu_bt.Click += new System.EventHandler(this.menu_bt_Click);
            // 
            // group_cmb
            // 
            this.group_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_cmb.FormattingEnabled = true;
            this.group_cmb.Location = new System.Drawing.Point(247, 210);
            this.group_cmb.Name = "group_cmb";
            this.group_cmb.Size = new System.Drawing.Size(222, 28);
            this.group_cmb.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 26);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // telephone_mtb
            // 
            this.telephone_mtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.telephone_mtb.Location = new System.Drawing.Point(247, 96);
            this.telephone_mtb.Mask = "+7 (000) 000-00-00";
            this.telephone_mtb.Name = "telephone_mtb";
            this.telephone_mtb.Size = new System.Drawing.Size(221, 26);
            this.telephone_mtb.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(652, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 46;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telephone_mtb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.group_cmb);
            this.Controls.Add(this.menu_bt);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_line_tb);
            this.Controls.Add(this.print_bt);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.student_card_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.middle_name_tb);
            this.Controls.Add(this.first_name_tb);
            this.Controls.Add(this.last_name_tb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студенты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Students_FormClosed);
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox last_name_tb;
        private System.Windows.Forms.TextBox first_name_tb;
        private System.Windows.Forms.TextBox middle_name_tb;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox student_card_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button print_bt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_line_tb;
        private System.Windows.Forms.Button menu_bt;
        private System.Windows.Forms.ComboBox group_cmb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox telephone_mtb;
        private System.Windows.Forms.Button button1;
    }
}