
namespace CollegStudentDB
{
    partial class Teachers
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
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.print_bt = new System.Windows.Forms.Button();
            this.menu_bt = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_line_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.middle_name_tb = new System.Windows.Forms.TextBox();
            this.first_name_tb = new System.Windows.Forms.TextBox();
            this.last_name_tb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 251);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edit_btn.Location = new System.Drawing.Point(483, 74);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(110, 38);
            this.edit_btn.TabIndex = 20;
            this.edit_btn.Text = "Изменить";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.add_btn.Location = new System.Drawing.Point(483, 24);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(110, 38);
            this.add_btn.TabIndex = 19;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // print_bt
            // 
            this.print_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.print_bt.Location = new System.Drawing.Point(493, 496);
            this.print_bt.Name = "print_bt";
            this.print_bt.Size = new System.Drawing.Size(100, 38);
            this.print_bt.TabIndex = 26;
            this.print_bt.Text = "Печать";
            this.print_bt.UseVisualStyleBackColor = true;
            this.print_bt.Click += new System.EventHandler(this.print_bt_Click);
            // 
            // menu_bt
            // 
            this.menu_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.menu_bt.Location = new System.Drawing.Point(372, 496);
            this.menu_bt.Name = "menu_bt";
            this.menu_bt.Size = new System.Drawing.Size(100, 38);
            this.menu_bt.TabIndex = 34;
            this.menu_bt.Text = "Menu";
            this.menu_bt.UseVisualStyleBackColor = true;
            this.menu_bt.Click += new System.EventHandler(this.menu_bt_Click);
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.search_btn.Location = new System.Drawing.Point(372, 451);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(221, 30);
            this.search_btn.TabIndex = 36;
            this.search_btn.Text = "Выполнить поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_line_tb
            // 
            this.search_line_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.search_line_tb.Location = new System.Drawing.Point(12, 453);
            this.search_line_tb.Name = "search_line_tb";
            this.search_line_tb.Size = new System.Drawing.Size(349, 26);
            this.search_line_tb.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(251, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Фамилия:";
            // 
            // middle_name_tb
            // 
            this.middle_name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.middle_name_tb.Location = new System.Drawing.Point(12, 136);
            this.middle_name_tb.Name = "middle_name_tb";
            this.middle_name_tb.Size = new System.Drawing.Size(221, 26);
            this.middle_name_tb.TabIndex = 39;
            // 
            // first_name_tb
            // 
            this.first_name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.first_name_tb.Location = new System.Drawing.Point(12, 86);
            this.first_name_tb.Name = "first_name_tb";
            this.first_name_tb.Size = new System.Drawing.Size(221, 26);
            this.first_name_tb.TabIndex = 38;
            // 
            // last_name_tb
            // 
            this.last_name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.last_name_tb.Location = new System.Drawing.Point(12, 36);
            this.last_name_tb.Name = "last_name_tb";
            this.last_name_tb.Size = new System.Drawing.Size(221, 26);
            this.last_name_tb.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(255, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(483, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 45;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.middle_name_tb);
            this.Controls.Add(this.first_name_tb);
            this.Controls.Add(this.last_name_tb);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_line_tb);
            this.Controls.Add(this.menu_bt);
            this.Controls.Add(this.print_bt);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преподаватели";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Teachers_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button print_bt;
        private System.Windows.Forms.Button menu_bt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_line_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox middle_name_tb;
        private System.Windows.Forms.TextBox first_name_tb;
        private System.Windows.Forms.TextBox last_name_tb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}