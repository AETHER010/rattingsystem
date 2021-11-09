using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.btnCriteria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GridAdmin = new System.Windows.Forms.DataGridView();
            this.adminBtn = new System.Windows.Forms.Button();
            this.homeAdmin = new System.Windows.Forms.Button();
            this.overAllReportGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overAllReportGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add criteria";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtCriteria);
            this.panel1.Controls.Add(this.btnCriteria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 370);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(169, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Charts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCriteria
            // 
            this.txtCriteria.AutoCompleteCustomSource.AddRange(new string[] {
            "Food Quality",
            "Cleanliness",
            "Value Of Money",
            "Staff Friendliness",
            "Restaurant Ambiance"});
            this.txtCriteria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCriteria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriteria.Location = new System.Drawing.Point(169, 27);
            this.txtCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(331, 34);
            this.txtCriteria.TabIndex = 7;
            // 
            // btnCriteria
            // 
            this.btnCriteria.BackColor = System.Drawing.SystemColors.Window;
            this.btnCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCriteria.Location = new System.Drawing.Point(169, 87);
            this.btnCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriteria.Name = "btnCriteria";
            this.btnCriteria.Size = new System.Drawing.Size(100, 28);
            this.btnCriteria.TabIndex = 6;
            this.btnCriteria.Text = "ADD";
            this.btnCriteria.UseVisualStyleBackColor = false;
            this.btnCriteria.Click += new System.EventHandler(this.btnCriteria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Blackadder ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criteria";
            // 
            // GridAdmin
            // 
            this.GridAdmin.AllowUserToAddRows = false;
            this.GridAdmin.AllowUserToDeleteRows = false;
            this.GridAdmin.AllowUserToResizeColumns = false;
            this.GridAdmin.AllowUserToResizeRows = false;
            this.GridAdmin.BackgroundColor = System.Drawing.Color.Gray;
            this.GridAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAdmin.Location = new System.Drawing.Point(670, 54);
            this.GridAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.GridAdmin.Name = "GridAdmin";
            this.GridAdmin.ReadOnly = true;
            this.GridAdmin.RowHeadersWidth = 51;
            this.GridAdmin.Size = new System.Drawing.Size(667, 370);
            this.GridAdmin.TabIndex = 4;
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.SystemColors.Window;
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminBtn.Location = new System.Drawing.Point(959, 445);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(4);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(123, 52);
            this.adminBtn.TabIndex = 5;
            this.adminBtn.Text = "DONE";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click_1);
            // 
            // homeAdmin
            // 
            this.homeAdmin.Location = new System.Drawing.Point(0, 0);
            this.homeAdmin.Name = "homeAdmin";
            this.homeAdmin.Size = new System.Drawing.Size(75, 23);
            this.homeAdmin.TabIndex = 14;
            // 
            // overAllReportGrid
            // 
            this.overAllReportGrid.AllowUserToAddRows = false;
            this.overAllReportGrid.AllowUserToDeleteRows = false;
            this.overAllReportGrid.AllowUserToResizeColumns = false;
            this.overAllReportGrid.AllowUserToResizeRows = false;
            this.overAllReportGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.overAllReportGrid.BackgroundColor = System.Drawing.Color.Snow;
            this.overAllReportGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.overAllReportGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.overAllReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overAllReportGrid.Location = new System.Drawing.Point(1449, 130);
            this.overAllReportGrid.Margin = new System.Windows.Forms.Padding(4);
            this.overAllReportGrid.Name = "overAllReportGrid";
            this.overAllReportGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.overAllReportGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.overAllReportGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overAllReportGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.overAllReportGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.overAllReportGrid.Size = new System.Drawing.Size(488, 164);
            this.overAllReportGrid.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1443, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Report";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(55, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1827, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.overAllReportGrid);
            this.Controls.Add(this.GridAdmin);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.homeAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overAllReportGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridAdmin;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button btnCriteria;
        private System.Windows.Forms.Button homeAdmin;

        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.DataGridView overAllReportGrid;
        private System.Windows.Forms.Label label2;
        private Button button1;
        private Button button2;

        public KeyPressEventHandler txtCriteria_KeyPress { get; private set; }
    }
}