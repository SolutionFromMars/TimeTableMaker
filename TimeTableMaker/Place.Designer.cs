﻿namespace TimeTableMaker
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // selectTheme
            // 
            selectTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            selectTheme.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectTheme.FormattingEnabled = true;
            selectTheme.Items.AddRange(new object[] { "аты", "баты", "шли", "солдаты" });
            selectTheme.Location = new Point(10, 10);
            selectTheme.Name = "selectTheme";
            selectTheme.Size = new Size(200, 25);
            selectTheme.TabIndex = 0;
            // 
            // selectSize
            // 
            selectSize.DropDownStyle = ComboBoxStyle.DropDownList;
            selectSize.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            selectSize.FormattingEnabled = true;
            selectSize.Location = new Point(10, 45);
            selectSize.Name = "selectSize";
            selectSize.Size = new Size(200, 25);
            selectSize.TabIndex = 1;
            // 
            // editData
            // 
            editData.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            editData.Location = new Point(10, 85);
            editData.Name = "editData";
            editData.Size = new Size(200, 35);
            editData.TabIndex = 2;
            editData.Text = "Редактировать";
            editData.UseVisualStyleBackColor = true;
            // 
            // saveImage
            // 
            saveImage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            saveImage.Location = new Point(10, 135);
            saveImage.Name = "saveImage";
            saveImage.Size = new Size(200, 35);
            saveImage.TabIndex = 3;
            saveImage.Text = "Сохранить";
            saveImage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(225, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 165);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Place
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(saveImage);
            Controls.Add(editData);
            Controls.Add(selectSize);
            Controls.Add(selectTheme);
            Name = "Place";
            Text = "Создатель расписаний";
            Load += Place_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox selectTheme;
        private ComboBox selectSize;
        private Button editData;
        private Button saveImage;
        private PictureBox pictureBox1;
    }
}