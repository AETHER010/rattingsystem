namespace WindowsFormsApp1
{
    partial class reports
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
            this.customerReviewGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.adminPanel = new System.Windows.Forms.Button();
            this.SortUpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerReviewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerReviewGrid
            // 
            this.customerReviewGrid.AllowUserToAddRows = false;
            this.customerReviewGrid.AllowUserToDeleteRows = false;
            this.customerReviewGrid.AllowUserToResizeColumns = false;
            this.customerReviewGrid.AllowUserToResizeRows = false;
            this.customerReviewGrid.BackgroundColor = System.Drawing.Color.Snow;
            this.customerReviewGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerReviewGrid.ColumnHeadersHeight = 29;
            this.customerReviewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customerReviewGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customerReviewGrid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.customerReviewGrid.Location = new System.Drawing.Point(23, 59);
            this.customerReviewGrid.Margin = new System.Windows.Forms.Padding(4);
            this.customerReviewGrid.MultiSelect = false;
            this.customerReviewGrid.Name = "customerReviewGrid";
            this.customerReviewGrid.ReadOnly = true;
            this.customerReviewGrid.RowHeadersWidth = 51;
            this.customerReviewGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customerReviewGrid.Size = new System.Drawing.Size(1667, 405);
            this.customerReviewGrid.TabIndex = 0;
            this.customerReviewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerReviewGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Reviews";
            // 
            // adminPanel
            // 
            this.adminPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adminPanel.BackColor = System.Drawing.SystemColors.Window;
            this.adminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.adminPanel.Location = new System.Drawing.Point(1591, 489);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(4);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(100, 36);
            this.adminPanel.TabIndex = 10;
            this.adminPanel.Text = "ADMIN";
            this.adminPanel.UseVisualStyleBackColor = false;
            this.adminPanel.Click += new System.EventHandler(this.adminPanel_Click);
            // 
            // SortUpBtn
            // 
            this.SortUpBtn.BackColor = System.Drawing.SystemColors.Window;
            this.SortUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.SortUpBtn.Location = new System.Drawing.Point(620, 481);
            this.SortUpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SortUpBtn.Name = "SortUpBtn";
            this.SortUpBtn.Size = new System.Drawing.Size(126, 45);
            this.SortUpBtn.TabIndex = 11;
            this.SortUpBtn.Text = "SORT";
            this.SortUpBtn.UseVisualStyleBackColor = false;
            this.SortUpBtn.Click += new System.EventHandler(this.SortUpBtn_Click);
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1716, 539);
            this.Controls.Add(this.SortUpBtn);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerReviewGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerReviewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerReviewGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminPanel;
        private System.Windows.Forms.Button SortUpBtn;
    }
}