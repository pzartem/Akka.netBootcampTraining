﻿namespace ChartApp
{
    partial class Main
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
			this.sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.btnDisck = new System.Windows.Forms.Button();
			this.btnCPU = new System.Windows.Forms.Button();
			this.btnMemory = new System.Windows.Forms.Button();
			this.btnPause = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.sysChart)).BeginInit();
			this.SuspendLayout();
			// 
			// sysChart
			// 
			chartArea1.Name = "ChartArea1";
			this.sysChart.ChartAreas.Add(chartArea1);
			this.sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Name = "Legend1";
			this.sysChart.Legends.Add(legend1);
			this.sysChart.Location = new System.Drawing.Point(0, 0);
			this.sysChart.Name = "sysChart";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.sysChart.Series.Add(series1);
			this.sysChart.Size = new System.Drawing.Size(684, 446);
			this.sysChart.TabIndex = 0;
			this.sysChart.Text = "sysChart";
			// 
			// btnDisck
			// 
			this.btnDisck.Location = new System.Drawing.Point(576, 378);
			this.btnDisck.Name = "btnDisck";
			this.btnDisck.Size = new System.Drawing.Size(96, 44);
			this.btnDisck.TabIndex = 1;
			this.btnDisck.Text = "DISK (OFF)";
			this.btnDisck.UseVisualStyleBackColor = true;
			this.btnDisck.Click += new System.EventHandler(this.btnDisck_Click);
			// 
			// btnCPU
			// 
			this.btnCPU.Location = new System.Drawing.Point(576, 278);
			this.btnCPU.Name = "btnCPU";
			this.btnCPU.Size = new System.Drawing.Size(96, 44);
			this.btnCPU.TabIndex = 2;
			this.btnCPU.Text = "CPU (ON)";
			this.btnCPU.UseVisualStyleBackColor = true;
			this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
			// 
			// btnMemory
			// 
			this.btnMemory.Location = new System.Drawing.Point(576, 328);
			this.btnMemory.Name = "btnMemory";
			this.btnMemory.Size = new System.Drawing.Size(96, 44);
			this.btnMemory.TabIndex = 3;
			this.btnMemory.Text = "MEMORY (OFF)";
			this.btnMemory.UseVisualStyleBackColor = true;
			this.btnMemory.Click += new System.EventHandler(this.btnMemory_Click);
			// 
			// btnPause
			// 
			this.btnPause.Location = new System.Drawing.Point(576, 203);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(96, 44);
			this.btnPause.TabIndex = 4;
			this.btnPause.Text = "PAUSE II";
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 446);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.btnMemory);
			this.Controls.Add(this.btnCPU);
			this.Controls.Add(this.btnDisck);
			this.Controls.Add(this.sysChart);
			this.DoubleBuffered = true;
			this.Name = "Main";
			this.Text = "System Metrics";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.sysChart)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sysChart;
		private System.Windows.Forms.Button btnDisck;
		private System.Windows.Forms.Button btnCPU;
		private System.Windows.Forms.Button btnMemory;
		private System.Windows.Forms.Button btnPause;
	}
}

