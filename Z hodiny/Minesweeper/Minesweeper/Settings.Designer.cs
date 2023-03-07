namespace Minesweeper
{
    partial class Settings
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
            this.Easy = new System.Windows.Forms.RadioButton();
            this.Normal = new System.Windows.Forms.RadioButton();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Easy
            // 
            this.Easy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Easy.AutoSize = true;
            this.Easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Easy.Location = new System.Drawing.Point(53, 12);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(69, 28);
            this.Easy.TabIndex = 1;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            // 
            // Normal
            // 
            this.Normal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Normal.AutoSize = true;
            this.Normal.Checked = true;
            this.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Normal.Location = new System.Drawing.Point(53, 46);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(89, 28);
            this.Normal.TabIndex = 2;
            this.Normal.TabStop = true;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            // 
            // Hard
            // 
            this.Hard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Hard.AutoSize = true;
            this.Hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Hard.Location = new System.Drawing.Point(53, 80);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(69, 28);
            this.Hard.TabIndex = 3;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back.Location = new System.Drawing.Point(12, 114);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(170, 35);
            this.Back.TabIndex = 4;
            this.Back.Text = "Go back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 161);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Easy);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Easy;
        private System.Windows.Forms.RadioButton Normal;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.Button Back;
    }
}