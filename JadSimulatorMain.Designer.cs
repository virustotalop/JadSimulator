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
            this.mageButton = new MageButton();
            this.rangeButton = new RangeButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prayerLabel = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ping";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 5;
            // 
            // prayerLabel
            // 
            this.prayerLabel.AutoSize = true;
            this.prayerLabel.Location = new System.Drawing.Point(158, 13);
            this.prayerLabel.Name = "prayerLabel";
            this.prayerLabel.Size = new System.Drawing.Size(40, 13);
            this.prayerLabel.TabIndex = 6;
            this.prayerLabel.Text = "Prayer:";
            // 
            // JadSimulatorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 340);
            this.Controls.Add(this.prayerLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JadSimulatorMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JadSimulator";
            this.Load += new System.EventHandler(this.JadSimulatorMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MageButton mageButton;
        private RangeButton rangeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label prayerLabel;

    }
}

