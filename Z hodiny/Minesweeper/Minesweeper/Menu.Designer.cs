namespace Minesweeper
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
            this.Play = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Play.Location = new System.Drawing.Point(10, 12);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(313, 67);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Settings
            // 
            this.Settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Settings.Location = new System.Drawing.Point(10, 95);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(313, 67);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Quit
            // 
            this.Quit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Quit.Location = new System.Drawing.Point(10, 177);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(313, 67);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 256);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Play);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Quit;
    }
}