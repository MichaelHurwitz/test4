namespace test4
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            MonthComboBox = new ComboBox();
            YearComboBox = new ComboBox();
            DayOfMonthComboBox = new ComboBox();
            DayOfWeekComboBox = new ComboBox();
            SendButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(334, 32);
            label1.Name = "label1";
            label1.Size = new Size(200, 38);
            label1.TabIndex = 0;
            label1.Text = "כתיבת תאריך ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(649, 138);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "היום בשבוע";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 138);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 1;
            label3.Text = "היום בחודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 138);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 1;
            label4.Text = "חודש";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 138);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 1;
            label5.Text = "שנה";
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            MonthComboBox.Location = new Point(359, 178);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.Size = new Size(88, 33);
            MonthComboBox.TabIndex = 2;
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Items.AddRange(new object[] { "התשפ'ד", "התשפ'ה", "התשפ'ו", "התשפ'ז", "התשפ'ח", "התשפ'ט", "התש'צ", "התשצ'א", "התשצ'ב", "התשצ'ג" });
            YearComboBox.Location = new Point(217, 178);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.Size = new Size(88, 33);
            YearComboBox.TabIndex = 2;
            // 
            // DayOfMonthComboBox
            // 
            DayOfMonthComboBox.FormattingEnabled = true;
            DayOfMonthComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            DayOfMonthComboBox.Location = new Point(491, 178);
            DayOfMonthComboBox.Name = "DayOfMonthComboBox";
            DayOfMonthComboBox.Size = new Size(88, 33);
            DayOfMonthComboBox.TabIndex = 2;
            // 
            // DayOfWeekComboBox
            // 
            DayOfWeekComboBox.FormattingEnabled = true;
            DayOfWeekComboBox.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            DayOfWeekComboBox.Location = new Point(620, 178);
            DayOfWeekComboBox.Name = "DayOfWeekComboBox";
            DayOfWeekComboBox.Size = new Size(88, 33);
            DayOfWeekComboBox.TabIndex = 2;
            // 
            // SendButton
            // 
            SendButton.Location = new Point(21, 178);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(112, 34);
            SendButton.TabIndex = 3;
            SendButton.Text = "שלח\r\n";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += OnSendButtonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SendButton);
            Controls.Add(DayOfWeekComboBox);
            Controls.Add(DayOfMonthComboBox);
            Controls.Add(YearComboBox);
            Controls.Add(MonthComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox MonthComboBox;
        private ComboBox YearComboBox;
        private ComboBox DayOfMonthComboBox;
        private ComboBox DayOfWeekComboBox;
        private Button SendButton;
    }
}
