namespace GUI
{
    partial class Form1
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
            this.SimulationButton = new System.Windows.Forms.Button();
            this.SimulationView = new System.Windows.Forms.PictureBox();
            this.AerofoilBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReynoldsNumBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ViscosityCheck = new System.Windows.Forms.CheckBox();
            this.VelocityBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GraphsOpenButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AlphaBox = new System.Windows.Forms.TextBox();
            this.TextOutput = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ImageChoice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationView)).BeginInit();
            this.SuspendLayout();
            // 
            // SimulationButton
            // 
            this.SimulationButton.Location = new System.Drawing.Point(13, 401);
            this.SimulationButton.Name = "SimulationButton";
            this.SimulationButton.Size = new System.Drawing.Size(100, 50);
            this.SimulationButton.TabIndex = 0;
            this.SimulationButton.Text = "Launch Simulation";
            this.SimulationButton.UseVisualStyleBackColor = true;
            // 
            // SimulationView
            // 
            this.SimulationView.Location = new System.Drawing.Point(13, 13);
            this.SimulationView.Name = "SimulationView";
            this.SimulationView.Size = new System.Drawing.Size(350, 350);
            this.SimulationView.TabIndex = 1;
            this.SimulationView.TabStop = false;
            // 
            // AerofoilBox
            // 
            this.AerofoilBox.FormattingEnabled = true;
            this.AerofoilBox.Location = new System.Drawing.Point(423, 52);
            this.AerofoilBox.Name = "AerofoilBox";
            this.AerofoilBox.Size = new System.Drawing.Size(121, 21);
            this.AerofoilBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose NACA Aerofoil";
            // 
            // ReynoldsNumBox
            // 
            this.ReynoldsNumBox.Location = new System.Drawing.Point(423, 234);
            this.ReynoldsNumBox.Name = "ReynoldsNumBox";
            this.ReynoldsNumBox.Size = new System.Drawing.Size(100, 20);
            this.ReynoldsNumBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Reynolds Number";
            // 
            // ViscosityCheck
            // 
            this.ViscosityCheck.AutoSize = true;
            this.ViscosityCheck.Location = new System.Drawing.Point(423, 187);
            this.ViscosityCheck.Name = "ViscosityCheck";
            this.ViscosityCheck.Size = new System.Drawing.Size(88, 17);
            this.ViscosityCheck.TabIndex = 6;
            this.ViscosityCheck.Text = "Viscous Flow";
            this.ViscosityCheck.UseVisualStyleBackColor = true;
            // 
            // VelocityBox
            // 
            this.VelocityBox.Location = new System.Drawing.Point(423, 106);
            this.VelocityBox.Name = "VelocityBox";
            this.VelocityBox.Size = new System.Drawing.Size(100, 20);
            this.VelocityBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start Velocity (m/s):";
            // 
            // GraphsOpenButton
            // 
            this.GraphsOpenButton.Location = new System.Drawing.Point(423, 401);
            this.GraphsOpenButton.Name = "GraphsOpenButton";
            this.GraphsOpenButton.Size = new System.Drawing.Size(100, 50);
            this.GraphsOpenButton.TabIndex = 12;
            this.GraphsOpenButton.Text = "View Graphs";
            this.GraphsOpenButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Alpha (angle of attack)";
            // 
            // AlphaBox
            // 
            this.AlphaBox.Location = new System.Drawing.Point(425, 157);
            this.AlphaBox.Name = "AlphaBox";
            this.AlphaBox.Size = new System.Drawing.Size(100, 20);
            this.AlphaBox.TabIndex = 14;
            // 
            // TextOutput
            // 
            this.TextOutput.Location = new System.Drawing.Point(397, 263);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.Size = new System.Drawing.Size(175, 100);
            this.TextOutput.TabIndex = 15;
            this.TextOutput.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Graphical Representation:";
            // 
            // ImageChoice
            // 
            this.ImageChoice.FormattingEnabled = true;
            this.ImageChoice.Location = new System.Drawing.Point(150, 370);
            this.ImageChoice.Name = "ImageChoice";
            this.ImageChoice.Size = new System.Drawing.Size(121, 21);
            this.ImageChoice.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.ImageChoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.AlphaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GraphsOpenButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VelocityBox);
            this.Controls.Add(this.ViscosityCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReynoldsNumBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AerofoilBox);
            this.Controls.Add(this.SimulationView);
            this.Controls.Add(this.SimulationButton);
            this.Name = "Form1";
            this.Text = "Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.SimulationView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SimulationButton;
        private System.Windows.Forms.PictureBox SimulationView;
        private System.Windows.Forms.ComboBox AerofoilBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReynoldsNumBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ViscosityCheck;
        private System.Windows.Forms.TextBox VelocityBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GraphsOpenButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AlphaBox;
        private System.Windows.Forms.RichTextBox TextOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ImageChoice;
    }
}

