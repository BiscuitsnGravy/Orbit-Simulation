namespace Trost_HW3
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
            this.components = new System.ComponentModel.Container();
            this.Simulation_Para = new System.Windows.Forms.GroupBox();
            this.CreateAPlanet = new System.Windows.Forms.RadioButton();
            this.CenterOfGravity = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Change_Radius = new System.Windows.Forms.NumericUpDown();
            this.PlanetScreen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Simulation_Para.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Change_Radius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // Simulation_Para
            // 
            this.Simulation_Para.Controls.Add(this.CreateAPlanet);
            this.Simulation_Para.Controls.Add(this.CenterOfGravity);
            this.Simulation_Para.Controls.Add(this.label1);
            this.Simulation_Para.Controls.Add(this.Change_Radius);
            this.Simulation_Para.Location = new System.Drawing.Point(13, 13);
            this.Simulation_Para.Name = "Simulation_Para";
            this.Simulation_Para.Size = new System.Drawing.Size(502, 99);
            this.Simulation_Para.TabIndex = 0;
            this.Simulation_Para.TabStop = false;
            this.Simulation_Para.Text = "Simulation Parameters";
            // 
            // CreateAPlanet
            // 
            this.CreateAPlanet.AutoSize = true;
            this.CreateAPlanet.Location = new System.Drawing.Point(86, 76);
            this.CreateAPlanet.Name = "CreateAPlanet";
            this.CreateAPlanet.Size = new System.Drawing.Size(127, 17);
            this.CreateAPlanet.TabIndex = 8;
            this.CreateAPlanet.TabStop = true;
            this.CreateAPlanet.Text = "Click to Create Planet";
            this.CreateAPlanet.UseVisualStyleBackColor = true;
            // 
            // CenterOfGravity
            // 
            this.CenterOfGravity.AutoSize = true;
            this.CenterOfGravity.Location = new System.Drawing.Point(86, 56);
            this.CenterOfGravity.Name = "CenterOfGravity";
            this.CenterOfGravity.Size = new System.Drawing.Size(176, 17);
            this.CenterOfGravity.TabIndex = 6;
            this.CenterOfGravity.TabStop = true;
            this.CenterOfGravity.Text = "Click to Create Center of Gravity";
            this.CenterOfGravity.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Center of Gravity Radius (Pixels):";
            // 
            // Change_Radius
            // 
            this.Change_Radius.Location = new System.Drawing.Point(240, 30);
            this.Change_Radius.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Change_Radius.Name = "Change_Radius";
            this.Change_Radius.Size = new System.Drawing.Size(256, 20);
            this.Change_Radius.TabIndex = 0;
            this.Change_Radius.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // PlanetScreen
            // 
            this.PlanetScreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlanetScreen.Location = new System.Drawing.Point(13, 118);
            this.PlanetScreen.Name = "PlanetScreen";
            this.PlanetScreen.Size = new System.Drawing.Size(502, 378);
            this.PlanetScreen.TabIndex = 9;
            this.PlanetScreen.TabStop = false;
            this.PlanetScreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlanetScreen_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 508);
            this.Controls.Add(this.PlanetScreen);
            this.Controls.Add(this.Simulation_Para);
            this.Name = "Form1";
            this.Text = "Orbit Simulation";
            this.Simulation_Para.ResumeLayout(false);
            this.Simulation_Para.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Change_Radius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlanetScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Simulation_Para;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Change_Radius;
        private System.Windows.Forms.RadioButton CenterOfGravity;
        private System.Windows.Forms.RadioButton CreateAPlanet;
        private System.Windows.Forms.PictureBox PlanetScreen;
        private System.Windows.Forms.Timer timer1;
    }
}

