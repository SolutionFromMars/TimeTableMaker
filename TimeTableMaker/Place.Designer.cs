namespace TimeTableMaker
{
    partial class Place
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
            selectTheme = new ComboBox();
            selectSize = new ComboBox();
            SuspendLayout();
            // 
            // selectTheme
            // 
            selectTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            selectTheme.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectTheme.FormattingEnabled = true;
            selectTheme.Location = new Point(35, 30);
            selectTheme.Name = "selectTheme";
            selectTheme.Size = new Size(200, 25);
            selectTheme.TabIndex = 0;
            // 
            // selectSize
            // 
            selectSize.DropDownStyle = ComboBoxStyle.DropDownList;
            selectSize.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectSize.FormattingEnabled = true;
            selectSize.Location = new Point(35, 65);
            selectSize.Name = "selectSize";
            selectSize.Size = new Size(200, 25);
            selectSize.TabIndex = 1;
            // 
            // Place
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(selectSize);
            Controls.Add(selectTheme);
            Name = "Place";
            Text = "Создатель расписаний";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox selectTheme;
        private ComboBox selectSize;
    }
}