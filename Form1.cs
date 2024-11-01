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

        // Draws the pie chart and the legend
        private void BtnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                //Parse values and labels from text boxes
                var values = txtValues.Text.Split(',')
                    .Select(x => float.Parse(char.Trim()))
                    .ToList();

                var labels = txtFruits.Text.Split(',')
                    .Select(x => x.Trim())
                    .ToList();

                if (values.Count != labels.Count)
                {
                    MessageBox.Show("Please make sure the number of labels matches the number of values.",)
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        // Method to add a legend label with a color box for each slice
        private void AddLegendLabel(string label, Color color, int index)
        {
           
        }
    }
}
