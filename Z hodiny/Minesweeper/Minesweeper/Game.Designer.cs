namespace Minesweeper
{
    partial class Game
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Platno = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FlagLabel = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Platno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Platno
            // 
            this.Platno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Platno.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Platno.Location = new System.Drawing.Point(-2, 65);
            this.Platno.Name = "Platno";
            this.Platno.Size = new System.Drawing.Size(780, 780);
            this.Platno.TabIndex = 0;
            this.Platno.TabStop = false;
            this.Platno.Paint += new System.Windows.Forms.PaintEventHandler(this.Platno_Paint);
            this.Platno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Platno_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 51);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // FlagLabel
            // 
            this.FlagLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlagLabel.AutoSize = true;
            this.FlagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlagLabel.Location = new System.Drawing.Point(76, 19);
            this.FlagLabel.Name = "FlagLabel";
            this.FlagLabel.Size = new System.Drawing.Size(26, 29);
            this.FlagLabel.TabIndex = 5;
            this.FlagLabel.Text = "0";
            this.FlagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Restart
            // 
            this.Restart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Restart.Location = new System.Drawing.Point(294, 8);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(184, 48);
            this.Restart.TabIndex = 6;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(597, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerLabel
            // 
            this.TimerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimerLabel.Location = new System.Drawing.Point(678, 17);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(26, 29);
            this.TimerLabel.TabIndex = 8;
            this.TimerLabel.Text = "0";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 845);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.FlagLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Platno);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            ((System.ComponentModel.ISupportInitialize)(this.Platno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Platno;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label FlagLabel;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer Timer;
    }
}

