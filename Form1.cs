using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lineChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  Daniel and lovely
        // Draws the pie chart and the legend
        private void BtnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse values and labels from text boxes
                var values = txtValues.Text.Split(',')
                                           .Select(x => float.Parse(x.Trim()))
                                           .ToList();

                var labels = txtFruits.Text.Split(',')
                                           .Select(x => x.Trim())
                                           .ToList();

                if (values.Count != labels.Count)
                {
                    MessageBox.Show(
                        "Please make sure the number of labels matches the number of values.",
                        "Input Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                // Calculate total for percentages
                float total = values.Sum();
                float startAngle = 0; // Starting angle for the first slice
                Random rand = new Random(); // For generating random colors

                // Clear previous drawings
                using (Graphics g = chartPanel.CreateGraphics())
                {
                    g.Clear(chartPanel.BackColor);
                    legendPanel.Controls.Clear(); // Clear legend panel

                    // Loop through values to draw each pie slice
                    for (int i = 0; i < values.Count; i++)
                    {
                        // Calculate angle for each slice
                        float sweepAngle = (values[i] / total) * 360f;

                        // Generate random color for each slice
                        Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                        Brush brush = new SolidBrush(color);

                        // Draw the pie slice
                        g.FillPie(brush, 10, 10, 300, 300, startAngle, sweepAngle);
                        startAngle += sweepAngle;

                        // Add legend label with color box
                        AddLegendLabel(labels[i], color, i);
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                    "Please make sure the number of labels matches the number of values.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        // Gary
        // Method to add a legend label with a color box for each slice
        private void AddLegendLabel(string label, Color color, int index)
        {
          // Create a small color box
          Panel colorBox = new Panel
          {
             Size = new Size(15, 15),
             BackColor = color,
             Location = new Point(5, index * 25 + 5)
          };

          // Create label for text next to color box
          Label legendLabel = new Label
          {
             Text = label,
             AutoSize = true,
             Location = new Point(25, index * 25),
             Font = new Font("Arial", 10, FontStyle.Bold)
          };

          // Add color box and label to the legend panel
          legendPanel.Controls.Add(colorBox);
          legendPanel.Controls.Add(legendLabel);
           
           
        }
    }
}
