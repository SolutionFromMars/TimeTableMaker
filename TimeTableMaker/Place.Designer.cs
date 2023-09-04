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
            editData = new Button();
            saveImage = new Button();
            representsImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)representsImage).BeginInit();
            SuspendLayout();
            // 
            // selectTheme
            // 
            selectTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            selectTheme.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectTheme.FormattingEnabled = true;
            selectTheme.Location = new Point(12, 38);
            selectTheme.Name = "selectTheme";
            selectTheme.Size = new Size(200, 25);
            selectTheme.TabIndex = 0;
            selectTheme.SelectionChangeCommitted += SelectedChanged;
            // 
            // selectSize
            // 
            selectSize.DropDownStyle = ComboBoxStyle.DropDownList;
            selectSize.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectSize.FormattingEnabled = true;
            selectSize.Location = new Point(10, 102);
            selectSize.Name = "selectSize";
            selectSize.Size = new Size(200, 25);
            selectSize.TabIndex = 1;
            selectSize.SelectionChangeCommitted += SelectedChanged;
            // 
            // editData
            // 
            editData.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            editData.Location = new Point(10, 164);
            editData.Name = "editData";
            editData.Size = new Size(200, 35);
            editData.TabIndex = 2;
            editData.Text = "Редактировать";
            editData.UseVisualStyleBackColor = true;
            editData.Click += OpenRedactor;
            // 
            // saveImage
            // 
            saveImage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            saveImage.Location = new Point(10, 233);
            saveImage.Name = "saveImage";
            saveImage.Size = new Size(200, 35);
            saveImage.TabIndex = 3;
            saveImage.Text = "Сохранить";
            saveImage.UseVisualStyleBackColor = true;
            saveImage.Click += saveImage_Click;
            // 
            // representsImage
            // 
            representsImage.BackColor = Color.LightSalmon;
            representsImage.BackgroundImageLayout = ImageLayout.None;
            representsImage.BorderStyle = BorderStyle.Fixed3D;
            representsImage.Location = new Point(238, 12);
            representsImage.Name = "representsImage";
            representsImage.Size = new Size(550, 550);
            representsImage.SizeMode = PictureBoxSizeMode.Zoom;
            representsImage.TabIndex = 4;
            representsImage.TabStop = false;
            // 
            // Place
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 571);
            Controls.Add(representsImage);
            Controls.Add(saveImage);
            Controls.Add(editData);
            Controls.Add(selectSize);
            Controls.Add(selectTheme);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Place";
            ShowIcon = false;
            Text = "Создатель расписаний";
            Load += Place_Load;
            ((System.ComponentModel.ISupportInitialize)representsImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal ComboBox selectTheme;
        internal ComboBox selectSize;
        private Button editData;
        private Button saveImage;
        internal PictureBox representsImage;
    }
}