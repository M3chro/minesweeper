namespace Minesweeper2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minesweeper";
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Start.Location = new System.Drawing.Point(102, 155);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(376, 105);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Settings
            // 
            this.Settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Settings.Location = new System.Drawing.Point(102, 295);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(376, 105);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Quit
            // 
            this.Quit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Quit.Location = new System.Drawing.Point(102, 433);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(376, 105);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(593, 569);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Quit;
    }
}