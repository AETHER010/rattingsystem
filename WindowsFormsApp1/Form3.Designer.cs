namespace WindowsFormsApp1
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.custGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtContactNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 382);
            this.panel1.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(107, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(309, 26);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Blackadder ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(162, 116);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(254, 26);
            this.txtContactNumber.TabIndex = 6;
            this.txtContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Blackadder ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contact Number:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(162, 29);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(254, 26);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Blackadder ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Font = new System.Drawing.Font("Mistral", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(145, 472);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 34);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // custGrid
            // 
            this.custGrid.AllowUserToAddRows = false;
            this.custGrid.AllowUserToDeleteRows = false;
            this.custGrid.AllowUserToResizeColumns = false;
            this.custGrid.AllowUserToResizeRows = false;
            this.custGrid.BackgroundColor = System.Drawing.Color.DarkGray;
            this.custGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.custGrid.ColumnHeadersHeight = 29;
            this.custGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.custGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.custGrid.GridColor = System.Drawing.Color.White;
            this.custGrid.Location = new System.Drawing.Point(550, 25);
            this.custGrid.Name = "custGrid";
            this.custGrid.RowHeadersWidth = 51;
            this.custGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.custGrid.Size = new System.Drawing.Size(815, 382);
            this.custGrid.TabIndex = 8;
            this.custGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custGrid_CellClick);
            this.custGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custGrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "main";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1391, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.custGrid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Feedback Form";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView custGrid;
        private System.Windows.Forms.Button button1;
    }
}

