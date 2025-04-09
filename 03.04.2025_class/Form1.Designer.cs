namespace _03._04._2025_class
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lable_name = new Label();
            textBox_name = new TextBox();
            label_selary = new Label();
            textBox_selary = new TextBox();
            Calendar_of_emp = new MonthCalendar();
            label_cal_of_emp = new Label();
            Button_Create_empl = new Button();
            listBox_empls = new ListBox();
            chenge_selary = new Button();
            textBox_change_selary = new TextBox();
            numbs_woring_time = new Button();
            lable_working_time = new Label();
            SuspendLayout();
            // 
            // lable_name
            // 
            lable_name.AutoSize = true;
            lable_name.Location = new Point(15, 19);
            lable_name.Name = "lable_name";
            lable_name.Size = new Size(74, 15);
            lable_name.TabIndex = 0;
            lable_name.Text = "введите имя";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(17, 40);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(100, 23);
            textBox_name.TabIndex = 1;
            // 
            // label_selary
            // 
            label_selary.AutoSize = true;
            label_selary.Location = new Point(19, 83);
            label_selary.Name = "label_selary";
            label_selary.Size = new Size(64, 15);
            label_selary.TabIndex = 2;
            label_selary.Text = "введите зп";
            // 
            // textBox_selary
            // 
            textBox_selary.Location = new Point(19, 110);
            textBox_selary.Name = "textBox_selary";
            textBox_selary.Size = new Size(100, 23);
            textBox_selary.TabIndex = 3;
            // 
            // Calendar_of_emp
            // 
            Calendar_of_emp.Location = new Point(22, 202);
            Calendar_of_emp.Name = "Calendar_of_emp";
            Calendar_of_emp.TabIndex = 4;
            Calendar_of_emp.DateChanged += Calendar_of_emp_DateChanged;
            // 
            // label_cal_of_emp
            // 
            label_cal_of_emp.AutoSize = true;
            label_cal_of_emp.Location = new Point(24, 174);
            label_cal_of_emp.Name = "label_cal_of_emp";
            label_cal_of_emp.Size = new Size(127, 15);
            label_cal_of_emp.TabIndex = 5;
            label_cal_of_emp.Text = "Дата трудоустройства";
            // 
            // Button_Create_empl
            // 
            Button_Create_empl.Location = new Point(26, 378);
            Button_Create_empl.Name = "Button_Create_empl";
            Button_Create_empl.Size = new Size(160, 23);
            Button_Create_empl.TabIndex = 6;
            Button_Create_empl.Text = "Зарегестрировать";
            Button_Create_empl.UseVisualStyleBackColor = true;
            Button_Create_empl.Click += Button_Create_empl_Click;
            // 
            // listBox_empls
            // 
            listBox_empls.FormattingEnabled = true;
            listBox_empls.ItemHeight = 15;
            listBox_empls.Location = new Point(304, 19);
            listBox_empls.Name = "listBox_empls";
            listBox_empls.Size = new Size(400, 94);
            listBox_empls.TabIndex = 7;
            listBox_empls.SelectedIndexChanged += listBox_empls_SelectedIndexChanged;
            // 
            // chenge_selary
            // 
            chenge_selary.Location = new Point(305, 136);
            chenge_selary.Name = "chenge_selary";
            chenge_selary.Size = new Size(113, 23);
            chenge_selary.TabIndex = 8;
            chenge_selary.Text = "поменять зп";
            chenge_selary.UseVisualStyleBackColor = true;
            chenge_selary.Click += chenge_selary_Click;
            // 
            // textBox_change_selary
            // 
            textBox_change_selary.Location = new Point(305, 166);
            textBox_change_selary.Name = "textBox_change_selary";
            textBox_change_selary.Size = new Size(113, 23);
            textBox_change_selary.TabIndex = 9;
            // 
            // numbs_woring_time
            // 
            numbs_woring_time.Location = new Point(445, 136);
            numbs_woring_time.Name = "numbs_woring_time";
            numbs_woring_time.Size = new Size(115, 23);
            numbs_woring_time.TabIndex = 10;
            numbs_woring_time.Text = "расчитать стаж";
            numbs_woring_time.UseVisualStyleBackColor = true;
            numbs_woring_time.Click += numbs_woring_time_Click;
            // 
            // lable_working_time
            // 
            lable_working_time.AutoSize = true;
            lable_working_time.Location = new Point(445, 169);
            lable_working_time.Name = "lable_working_time";
            lable_working_time.Size = new Size(0, 15);
            lable_working_time.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lable_working_time);
            Controls.Add(numbs_woring_time);
            Controls.Add(textBox_change_selary);
            Controls.Add(chenge_selary);
            Controls.Add(listBox_empls);
            Controls.Add(Button_Create_empl);
            Controls.Add(label_cal_of_emp);
            Controls.Add(Calendar_of_emp);
            Controls.Add(textBox_selary);
            Controls.Add(label_selary);
            Controls.Add(textBox_name);
            Controls.Add(lable_name);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lable_name;
        private TextBox textBox_name;
        private Label label_selary;
        private TextBox textBox_selary;
        private MonthCalendar Calendar_of_emp;
        private Label label_cal_of_emp;
        private Button Button_Create_empl;
        private ListBox listBox_empls;
        private Button chenge_selary;
        private TextBox textBox_change_selary;
        private Button numbs_woring_time;
        private Label lable_working_time;
    }
}