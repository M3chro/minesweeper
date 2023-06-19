namespace Minesweeper2
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.Normal = new System.Windows.Forms.RadioButton();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Width = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.NumericUpDown();
            this.Custom = new System.Windows.Forms.RadioButton();
            this.GoBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PickColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Mines = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mines)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Difficulty";
            // 
            // Easy
            // 
            this.Easy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Easy.AutoSize = true;
            this.Easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Easy.ForeColor = System.Drawing.Color.White;
            this.Easy.Location = new System.Drawing.Point(94, 101);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(83, 33);
            this.Easy.TabIndex = 1;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            // 
            // Normal
            // 
            this.Normal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Normal.AutoSize = true;
            this.Normal.Checked = true;
            this.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Normal.ForeColor = System.Drawing.Color.White;
            this.Normal.Location = new System.Drawing.Point(94, 132);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(110, 33);
            this.Normal.TabIndex = 2;
            this.Normal.TabStop = true;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            // 
            // Hard
            // 
            this.Hard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Hard.AutoSize = true;
            this.Hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Hard.ForeColor = System.Drawing.Color.White;
            this.Hard.Location = new System.Drawing.Point(94, 166);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(83, 33);
            this.Hard.TabIndex = 3;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            // 
            // Width
            // 
            this.Width.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Width.Enabled = false;
            this.Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Width.Location = new System.Drawing.Point(335, 109);
            this.Width.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Width.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(44, 29);
            this.Width.TabIndex = 4;
            this.Width.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(276, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Custom difficulty";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(279, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(275, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Height";
            // 
            // Height
            // 
            this.Height.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Height.Enabled = false;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Height.Location = new System.Drawing.Point(335, 141);
            this.Height.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Height.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(44, 29);
            this.Height.TabIndex = 8;
            this.Height.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Custom
            // 
            this.Custom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Custom.AutoSize = true;
            this.Custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Custom.ForeColor = System.Drawing.Color.White;
            this.Custom.Location = new System.Drawing.Point(94, 197);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(113, 33);
            this.Custom.TabIndex = 9;
            this.Custom.Text = "Custom";
            this.Custom.UseVisualStyleBackColor = true;
            this.Custom.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // GoBack
            // 
            this.GoBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoBack.ForeColor = System.Drawing.Color.Black;
            this.GoBack.Location = new System.Drawing.Point(85, 237);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(477, 77);
            this.GoBack.TabIndex = 10;
            this.GoBack.Text = "Go back";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(400, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Theme picker";
            // 
            // PickColor
            // 
            this.PickColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PickColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PickColor.ForeColor = System.Drawing.Color.Black;
            this.PickColor.Location = new System.Drawing.Point(405, 150);
            this.PickColor.Name = "PickColor";
            this.PickColor.Size = new System.Drawing.Size(152, 41);
            this.PickColor.TabIndex = 12;
            this.PickColor.Text = "Pick color";
            this.PickColor.UseVisualStyleBackColor = true;
            this.PickColor.Click += new System.EventHandler(this.PickColor_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(279, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mines";
            // 
            // Mines
            // 
            this.Mines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mines.Enabled = false;
            this.Mines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mines.Location = new System.Drawing.Point(335, 174);
            this.Mines.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Mines.Name = "Mines";
            this.Mines.Size = new System.Drawing.Size(44, 29);
            this.Mines.TabIndex = 14;
            this.Mines.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 381);
            this.Controls.Add(this.Mines);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PickColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.Custom);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Easy;
        private System.Windows.Forms.RadioButton Normal;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.NumericUpDown Width;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Height;
        private System.Windows.Forms.RadioButton Custom;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button PickColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Mines;
    }
}