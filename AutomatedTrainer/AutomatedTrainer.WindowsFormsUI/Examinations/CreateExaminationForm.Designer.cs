﻿using AutomatedTrainer.Models;


namespace AutomatedTrainer.WindowsFormsUI
{
    using AutomatedTrainer.Store;

    partial class CreateExaminationForm
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
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Type = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExaminationLabel = new System.Windows.Forms.Label();
            this.WhosExaminationLabel = new System.Windows.Forms.Label();
            this.PhysicalIndicatorsPicker = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(42, 117);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(327, 20);
            this.Date.TabIndex = 0;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(42, 46);
            this.Type.Multiline = true;
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(327, 53);
            this.Type.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(161, 266);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(87, 32);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Сохранить";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(39, 30);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(101, 13);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "Тип обследования";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(42, 102);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Исследуемые показатели";
            // 
            // ExaminationLabel
            // 
            this.ExaminationLabel.AutoSize = true;
            this.ExaminationLabel.Location = new System.Drawing.Point(70, 9);
            this.ExaminationLabel.Name = "ExaminationLabel";
            this.ExaminationLabel.Size = new System.Drawing.Size(84, 13);
            this.ExaminationLabel.TabIndex = 7;
            this.ExaminationLabel.Text = "Обследуемый: ";
            // 
            // WhosExaminationLabel
            // 
            this.WhosExaminationLabel.AutoSize = true;
            this.WhosExaminationLabel.Location = new System.Drawing.Point(163, 9);
            this.WhosExaminationLabel.Name = "WhosExaminationLabel";
            this.WhosExaminationLabel.Size = new System.Drawing.Size(35, 13);
            this.WhosExaminationLabel.TabIndex = 8;
            this.WhosExaminationLabel.Text = "label2";
            // 
            // PhysicalIndicatorsPicker
            // 
            this.PhysicalIndicatorsPicker.FormattingEnabled = true;
            this.PhysicalIndicatorsPicker.Location = new System.Drawing.Point(42, 158);
            this.PhysicalIndicatorsPicker.Name = "PhysicalIndicatorsPicker";
            this.PhysicalIndicatorsPicker.Size = new System.Drawing.Size(327, 94);
            this.PhysicalIndicatorsPicker.TabIndex = 4;
            // 
            // CreateExaminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 356);
            this.Controls.Add(this.WhosExaminationLabel);
            this.Controls.Add(this.ExaminationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.PhysicalIndicatorsPicker);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Date);
            this.Name = "CreateExaminationForm";
            this.Text = "CreateExaminationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExaminationLabel;
        private System.Windows.Forms.Label WhosExaminationLabel;
        private System.Windows.Forms.CheckedListBox PhysicalIndicatorsPicker;
    }
}