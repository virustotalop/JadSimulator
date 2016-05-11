namespace JadSimulator
{
    partial class JadSimulatorMain
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
            this.mageButton = new System.Windows.Forms.Button();
            this.rangeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mageButton
            // 
            this.mageButton.BackColor = System.Drawing.Color.Transparent;
            this.mageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mageButton.ForeColor = System.Drawing.Color.Transparent;
            this.mageButton.Location = new System.Drawing.Point(67, 157);
            this.mageButton.Name = "mageButton";
            this.mageButton.Size = new System.Drawing.Size(32, 32);
            this.mageButton.TabIndex = 2;
            this.mageButton.UseVisualStyleBackColor = false;
            this.mageButton.Click += new System.EventHandler(this.mageButton_Click);
            // 
            // rangeButton
            // 
            this.rangeButton.BackColor = System.Drawing.Color.Transparent;
            this.rangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rangeButton.ForeColor = System.Drawing.Color.Transparent;
            this.rangeButton.Location = new System.Drawing.Point(104, 157);
            this.rangeButton.Name = "rangeButton";
            this.rangeButton.Size = new System.Drawing.Size(32, 32);
            this.rangeButton.TabIndex = 1;
            this.rangeButton.UseVisualStyleBackColor = false;
            this.rangeButton.Click += new System.EventHandler(this.rangeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mageButton);
            this.panel1.Controls.Add(this.rangeButton);
            this.panel1.Location = new System.Drawing.Point(307, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 335);
            this.panel1.TabIndex = 3;
            // 
            // JadSimulatorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 340);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JadSimulatorMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JadSimulator";
            this.Load += new System.EventHandler(this.JadSimulatorMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mageButton;
        private System.Windows.Forms.Button rangeButton;
        private System.Windows.Forms.Panel panel1;

    }
}

