namespace WindowsFormsApp1
{
    partial class Chart1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.criteriaSearch = new System.Windows.Forms.Button();
            this.comChart = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(630, 12);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Customers";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(674, 486);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart1";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Blackadder ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Criteria:";
            // 
            // criteriaSearch
            // 
            this.criteriaSearch.BackColor = System.Drawing.SystemColors.Window;
            this.criteriaSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.criteriaSearch.Location = new System.Drawing.Point(216, 225);
            this.criteriaSearch.Margin = new System.Windows.Forms.Padding(4);
            this.criteriaSearch.Name = "criteriaSearch";
            this.criteriaSearch.Size = new System.Drawing.Size(123, 32);
            this.criteriaSearch.TabIndex = 17;
            this.criteriaSearch.Text = "SEARCH";
            this.criteriaSearch.UseVisualStyleBackColor = false;
            this.criteriaSearch.Click += new System.EventHandler(this.criteriaSearch_Click);
            // 
            // comChart
            // 
            this.comChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comChart.FormattingEnabled = true;
            this.comChart.Items.AddRange(new object[] {
            "Food Quality",
            "Staff Friendliness",
            "Restaurant Ambiance",
            "Value Of Money",
            "Order Accuracy",
            "Cleanliness"});
            this.comChart.Location = new System.Drawing.Point(169, 105);
            this.comChart.Margin = new System.Windows.Forms.Padding(4);
            this.comChart.Name = "comChart";
            this.comChart.Size = new System.Drawing.Size(267, 32);
            this.comChart.TabIndex = 16;
            // 
            // Chart1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1343, 531);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.criteriaSearch);
            this.Controls.Add(this.comChart);
            this.Controls.Add(this.chart2);
            this.Name = "Chart1";
            this.Text = "Chart1";
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button criteriaSearch;
        private System.Windows.Forms.ComboBox comChart;
    }
}