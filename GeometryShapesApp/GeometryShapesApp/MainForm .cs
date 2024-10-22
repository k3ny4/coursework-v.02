using System;
using System.Drawing;
using System.Windows.Forms;
using GeometryShapes;

namespace GeometryShapesApp
{
    public partial class MainForm : Form
    {
        private SolidShape currentShape;

        public MainForm()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxShapes.SelectedItem.ToString())
                {
                    case "Cube":
                        currentShape = new Cube(double.Parse(textBoxParam1.Text));
                        break;
                    case "Sphere":
                        currentShape = new Sphere(double.Parse(textBoxParam1.Text));
                        break;
                    case "Cone":
                        currentShape = new Cone(double.Parse(textBoxParam1.Text), double.Parse(textBoxParam2.Text));
                        break;
                }
                labelResult.Text = "Volume: " + currentShape.CalculateVolume().ToString();
                pictureBox.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (currentShape != null)
            {
                currentShape.Draw(e.Graphics, pictureBox.ClientRectangle);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
