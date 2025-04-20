namespace Bank
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.create_bill = new System.Windows.Forms.Button();
            this.replinish_bill = new System.Windows.Forms.Button();
            this.remove_from_bill = new System.Windows.Forms.Button();
            this.textBox_replinish_bill = new System.Windows.Forms.TextBox();
            this.textBox_remove_from_bill = new System.Windows.Forms.TextBox();
            this.listBox_bank_accs = new System.Windows.Forms.ListBox();
            this.count_of_bills = new System.Windows.Forms.Button();
            this.label_count_of_bills = new System.Windows.Forms.Label();
            this.sum_of_maney = new System.Windows.Forms.Button();
            this.label_sum_money = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // create_bill
            // 
            this.create_bill.Location = new System.Drawing.Point(43, 63);
            this.create_bill.Name = "create_bill";
            this.create_bill.Size = new System.Drawing.Size(99, 34);
            this.create_bill.TabIndex = 0;
            this.create_bill.Text = "Создать счет";
            this.create_bill.UseVisualStyleBackColor = true;
            this.create_bill.Click += new System.EventHandler(this.create_bill_Click);
            // 
            // replinish_bill
            // 
            this.replinish_bill.Location = new System.Drawing.Point(43, 135);
            this.replinish_bill.Name = "replinish_bill";
            this.replinish_bill.Size = new System.Drawing.Size(99, 29);
            this.replinish_bill.TabIndex = 1;
            this.replinish_bill.Text = "пополнить счет";
            this.replinish_bill.UseVisualStyleBackColor = true;
            this.replinish_bill.Click += new System.EventHandler(this.replinish_bill_Click);
            // 
            // remove_from_bill
            // 
            this.remove_from_bill.Location = new System.Drawing.Point(43, 202);
            this.remove_from_bill.Name = "remove_from_bill";
            this.remove_from_bill.Size = new System.Drawing.Size(99, 35);
            this.remove_from_bill.TabIndex = 2;
            this.remove_from_bill.Text = "снять с счета";
            this.remove_from_bill.UseVisualStyleBackColor = true;
            this.remove_from_bill.Click += new System.EventHandler(this.remove_from_bill_Click);
            // 
            // textBox_replinish_bill
            // 
            this.textBox_replinish_bill.Location = new System.Drawing.Point(178, 143);
            this.textBox_replinish_bill.Name = "textBox_replinish_bill";
            this.textBox_replinish_bill.Size = new System.Drawing.Size(100, 20);
            this.textBox_replinish_bill.TabIndex = 3;
            // 
            // textBox_remove_from_bill
            // 
            this.textBox_remove_from_bill.Location = new System.Drawing.Point(178, 216);
            this.textBox_remove_from_bill.Name = "textBox_remove_from_bill";
            this.textBox_remove_from_bill.Size = new System.Drawing.Size(100, 20);
            this.textBox_remove_from_bill.TabIndex = 4;
            // 
            // listBox_bank_accs
            // 
            this.listBox_bank_accs.FormattingEnabled = true;
            this.listBox_bank_accs.Location = new System.Drawing.Point(329, 63);
            this.listBox_bank_accs.Name = "listBox_bank_accs";
            this.listBox_bank_accs.Size = new System.Drawing.Size(189, 173);
            this.listBox_bank_accs.TabIndex = 5;
            // 
            // count_of_bills
            // 
            this.count_of_bills.Location = new System.Drawing.Point(329, 264);
            this.count_of_bills.Name = "count_of_bills";
            this.count_of_bills.Size = new System.Drawing.Size(86, 33);
            this.count_of_bills.TabIndex = 6;
            this.count_of_bills.Text = "кол-во счетов";
            this.count_of_bills.UseVisualStyleBackColor = true;
            this.count_of_bills.Click += new System.EventHandler(this.count_of_bills_Click);
            // 
            // label_count_of_bills
            // 
            this.label_count_of_bills.AutoSize = true;
            this.label_count_of_bills.Location = new System.Drawing.Point(463, 274);
            this.label_count_of_bills.Name = "label_count_of_bills";
            this.label_count_of_bills.Size = new System.Drawing.Size(0, 13);
            this.label_count_of_bills.TabIndex = 7;
            // 
            // sum_of_maney
            // 
            this.sum_of_maney.Location = new System.Drawing.Point(329, 315);
            this.sum_of_maney.Name = "sum_of_maney";
            this.sum_of_maney.Size = new System.Drawing.Size(86, 31);
            this.sum_of_maney.TabIndex = 8;
            this.sum_of_maney.Text = "общая сумма";
            this.sum_of_maney.UseVisualStyleBackColor = true;
            this.sum_of_maney.Click += new System.EventHandler(this.sum_of_maney_Click);
            // 
            // label_sum_money
            // 
            this.label_sum_money.AutoSize = true;
            this.label_sum_money.Location = new System.Drawing.Point(463, 324);
            this.label_sum_money.Name = "label_sum_money";
            this.label_sum_money.Size = new System.Drawing.Size(0, 13);
            this.label_sum_money.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_sum_money);
            this.Controls.Add(this.sum_of_maney);
            this.Controls.Add(this.label_count_of_bills);
            this.Controls.Add(this.count_of_bills);
            this.Controls.Add(this.listBox_bank_accs);
            this.Controls.Add(this.textBox_remove_from_bill);
            this.Controls.Add(this.textBox_replinish_bill);
            this.Controls.Add(this.remove_from_bill);
            this.Controls.Add(this.replinish_bill);
            this.Controls.Add(this.create_bill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_bill;
        private System.Windows.Forms.Button replinish_bill;
        private System.Windows.Forms.Button remove_from_bill;
        private System.Windows.Forms.TextBox textBox_replinish_bill;
        private System.Windows.Forms.TextBox textBox_remove_from_bill;
        private System.Windows.Forms.ListBox listBox_bank_accs;
        private System.Windows.Forms.Button count_of_bills;
        private System.Windows.Forms.Label label_count_of_bills;
        private System.Windows.Forms.Button sum_of_maney;
        private System.Windows.Forms.Label label_sum_money;
    }
}

