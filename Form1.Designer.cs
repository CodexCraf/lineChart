namespace lineChart
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtValues = new System.Windows.Forms.TextBox();
            this.txtFruits = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.legendPanel = new System.Windows.Forms.Panel();
            this.lblValues = new System.Windows.Forms.Label();
            this.lblFruits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValues
            // 
            this.txtValues.Location = new System.Drawing.Point(16, 37);
            this.txtValues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValues.Name = "txtValues";
            this.txtValues.Size = new System.Drawing.Size(399, 22);
            this.txtValues.TabIndex = 0;
            // 
            // txtFruits
            // 
            this.txtFruits.Location = new System.Drawing.Point(16, 92);
            this.txtFruits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFruits.Name = "txtFruits";
            this.txtFruits.Size = new System.Drawing.Size(399, 22);
            this.txtFruits.TabIndex = 1;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(424, 37);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(100, 28);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Draw Pie Chart";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // chartPanel
            // 
            this.chartPanel.Location = new System.Drawing.Point(1, 135);
            this.chartPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(621, 466);
            this.chartPanel.TabIndex = 3;
            // 
            // legendPanel
            // 
            this.legendPanel.Location = new System.Drawing.Point(620, 135);
            this.legendPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.legendPanel.Name = "legendPanel";
            this.legendPanel.Size = new System.Drawing.Size(210, 466);
            this.legendPanel.TabIndex = 4;
            // 
            // lblValues
            // 
            this.lblValues.AutoSize = true;
            this.lblValues.Location = new System.Drawing.Point(16, 18);
            this.lblValues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValues.Name = "lblValues";
            this.lblValues.Size = new System.Drawing.Size(315, 16);
            this.lblValues.TabIndex = 5;
            this.lblValues.Text = "Enter values (e.g., 25, 15, 50) separated by commas:";
            // 
            // lblFruits
            // 
            this.lblFruits.AutoSize = true;
            this.lblFruits.Location = new System.Drawing.Point(16, 74);
            this.lblFruits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFruits.Name = "lblFruits";
            this.lblFruits.Size = new System.Drawing.Size(398, 16);
            this.lblFruits.TabIndex = 6;
            this.lblFruits.Text = "Enter labels (e.g., Apple, Banana, Orange) separated by commas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 633);
            this.Controls.Add(this.lblValues);
            this.Controls.Add(this.lblFruits);
            this.Controls.Add(this.legendPanel);
            this.Controls.Add(this.chartPanel);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtFruits);
            this.Controls.Add(this.txtValues);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Pie Chart Drawer with Legend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtValues;
        private System.Windows.Forms.TextBox txtFruits;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.Panel legendPanel;
        private System.Windows.Forms.Label lblValues;
        private System.Windows.Forms.Label lblFruits;
    }
}
