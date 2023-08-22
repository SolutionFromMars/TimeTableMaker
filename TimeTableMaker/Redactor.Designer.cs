namespace TimeTableMaker
{
    partial class Redactor
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
            saveTable = new Button();
            noSaveTable = new Button();
            groupBox1 = new GroupBox();
            textMonday = new TextBox();
            groupBox2 = new GroupBox();
            textTuesday = new TextBox();
            groupBox3 = new GroupBox();
            textWednesday = new TextBox();
            groupBox4 = new GroupBox();
            textThursday = new TextBox();
            groupBox5 = new GroupBox();
            textFriday = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // saveTable
            // 
            saveTable.Location = new Point(145, 417);
            saveTable.Name = "saveTable";
            saveTable.Size = new Size(75, 23);
            saveTable.TabIndex = 0;
            saveTable.Text = "Сохранить";
            saveTable.UseVisualStyleBackColor = true;
            saveTable.Click += saveTable_Click;
            // 
            // noSaveTable
            // 
            noSaveTable.Location = new Point(478, 432);
            noSaveTable.Name = "noSaveTable";
            noSaveTable.Size = new Size(131, 23);
            noSaveTable.TabIndex = 1;
            noSaveTable.Text = "Не сохранить";
            noSaveTable.UseVisualStyleBackColor = true;
            noSaveTable.Click += noSaveTable_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textMonday);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 184);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textMonday
            // 
            textMonday.BackColor = SystemColors.Control;
            textMonday.BorderStyle = BorderStyle.None;
            textMonday.Location = new Point(6, 22);
            textMonday.Multiline = true;
            textMonday.Name = "textMonday";
            textMonday.Size = new Size(188, 156);
            textMonday.TabIndex = 0;
            textMonday.TextChanged += textChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textTuesday);
            groupBox2.Location = new Point(285, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 184);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // textTuesday
            // 
            textTuesday.BackColor = SystemColors.Control;
            textTuesday.BorderStyle = BorderStyle.None;
            textTuesday.Location = new Point(6, 22);
            textTuesday.Multiline = true;
            textTuesday.Name = "textTuesday";
            textTuesday.Size = new Size(188, 156);
            textTuesday.TabIndex = 0;
            textTuesday.TextChanged += textChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textWednesday);
            groupBox3.Location = new Point(515, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 184);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // textWednesday
            // 
            textWednesday.BackColor = SystemColors.Control;
            textWednesday.BorderStyle = BorderStyle.None;
            textWednesday.Location = new Point(6, 22);
            textWednesday.Multiline = true;
            textWednesday.Name = "textWednesday";
            textWednesday.Size = new Size(188, 156);
            textWednesday.TabIndex = 0;
            textWednesday.TextChanged += textChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textThursday);
            groupBox4.Location = new Point(99, 212);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 184);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // textThursday
            // 
            textThursday.BackColor = SystemColors.Control;
            textThursday.BorderStyle = BorderStyle.None;
            textThursday.Location = new Point(6, 22);
            textThursday.Multiline = true;
            textThursday.Name = "textThursday";
            textThursday.Size = new Size(188, 156);
            textThursday.TabIndex = 0;
            textThursday.TextChanged += textChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textFriday);
            groupBox5.Location = new Point(409, 212);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 184);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // textFriday
            // 
            textFriday.BackColor = SystemColors.Control;
            textFriday.BorderStyle = BorderStyle.None;
            textFriday.Location = new Point(6, 22);
            textFriday.Multiline = true;
            textFriday.Name = "textFriday";
            textFriday.Size = new Size(188, 156);
            textFriday.TabIndex = 0;
            textFriday.TextChanged += textChanged;
            // 
            // Redactor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 478);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(noSaveTable);
            Controls.Add(saveTable);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Redactor";
            Text = "Redactor";
            Load += Redactor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button saveTable;
        private Button noSaveTable;
        private GroupBox groupBox1;
        private TextBox textMonday;
        private GroupBox groupBox2;
        private TextBox textTuesday;
        private GroupBox groupBox3;
        private TextBox textWednesday;
        private GroupBox groupBox4;
        private TextBox textThursday;
        private GroupBox groupBox5;
        private TextBox textFriday;
    }
}