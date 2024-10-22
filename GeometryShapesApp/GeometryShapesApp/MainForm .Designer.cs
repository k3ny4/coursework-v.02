using System.Windows.Forms;

namespace GeometryShapesApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelShape;
        private ComboBox comboBoxShapes;
        private Label labelParam1;
        private TextBox textBoxParam1;
        private Label labelParam2;
        private TextBox textBoxParam2;
        private Button buttonCalculate;
        private Label labelResult;
        private PictureBox pictureBox;

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
            this.labelShape = new System.Windows.Forms.Label();
            this.comboBoxShapes = new System.Windows.Forms.ComboBox();
            this.labelParam1 = new System.Windows.Forms.Label();
            this.textBoxParam1 = new System.Windows.Forms.TextBox();
            this.labelParam2 = new System.Windows.Forms.Label();
            this.textBoxParam2 = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelShape
            // 
            this.labelShape.AutoSize = true;
            this.labelShape.Location = new System.Drawing.Point(20, 20);
            this.labelShape.Name = "labelShape";
            this.labelShape.Size = new System.Drawing.Size(74, 13);
            this.labelShape.TabIndex = 0;
            this.labelShape.Text = "Select Shape:";
            // 
            // comboBoxShapes
            // 
            this.comboBoxShapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShapes.FormattingEnabled = true;
            this.comboBoxShapes.Items.AddRange(new object[] {
            "Cube",
            "Sphere",
            "Cone"});
            this.comboBoxShapes.Location = new System.Drawing.Point(20, 50);
            this.comboBoxShapes.Name = "comboBoxShapes";
            this.comboBoxShapes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShapes.TabIndex = 1;
            // 
            // labelParam1
            // 
            this.labelParam1.AutoSize = true;
            this.labelParam1.Location = new System.Drawing.Point(20, 100);
            this.labelParam1.Name = "labelParam1";
            this.labelParam1.Size = new System.Drawing.Size(0, 13);
            this.labelParam1.TabIndex = 2;
            // 
            // textBoxParam1
            // 
            this.textBoxParam1.Location = new System.Drawing.Point(20, 130);
            this.textBoxParam1.Name = "textBoxParam1";
            this.textBoxParam1.Size = new System.Drawing.Size(100, 20);
            this.textBoxParam1.TabIndex = 3;
            // 
            // labelParam2
            // 
            this.labelParam2.AutoSize = true;
            this.labelParam2.Location = new System.Drawing.Point(20, 160);
            this.labelParam2.Name = "labelParam2";
            this.labelParam2.Size = new System.Drawing.Size(0, 13);
            this.labelParam2.TabIndex = 4;
            this.labelParam2.Visible = false;
            // 
            // textBoxParam2
            // 
            this.textBoxParam2.Location = new System.Drawing.Point(20, 190);
            this.textBoxParam2.Name = "textBoxParam2";
            this.textBoxParam2.Size = new System.Drawing.Size(100, 20);
            this.textBoxParam2.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(20, 220);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(121, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate Volume";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(20, 260);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(45, 13);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Volume:";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(200, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Height";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Width";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxParam2);
            this.Controls.Add(this.labelParam2);
            this.Controls.Add(this.textBoxParam1);
            this.Controls.Add(this.labelParam1);
            this.Controls.Add(this.comboBoxShapes);
            this.Controls.Add(this.labelShape);
            this.Name = "MainForm";
            this.Text = "Geometry Shapes Volume Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
    }
}
