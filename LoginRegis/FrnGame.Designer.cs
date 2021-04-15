
namespace LoginRegis
{
    partial class FrnGame
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.numHP = new System.Windows.Forms.Label();
            this.healthTheBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Image = global::LoginRegis.Properties.Resources.Hero;
            this.Player.Location = new System.Drawing.Point(266, 150);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(259, 150);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // numHP
            // 
            this.numHP.AutoSize = true;
            this.numHP.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.numHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numHP.Location = new System.Drawing.Point(655, 18);
            this.numHP.Name = "numHP";
            this.numHP.Size = new System.Drawing.Size(49, 18);
            this.numHP.TabIndex = 10;
            this.numHP.Text = "%100";
            // 
            // healthTheBar
            // 
            this.healthTheBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.healthTheBar.Location = new System.Drawing.Point(563, 9);
            this.healthTheBar.Name = "healthTheBar";
            this.healthTheBar.Size = new System.Drawing.Size(225, 34);
            this.healthTheBar.TabIndex = 9;
            this.healthTheBar.Value = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(440, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Здоровье :";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtScore.Location = new System.Drawing.Point(244, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(56, 18);
            this.txtScore.TabIndex = 7;
            this.txtScore.Text = "Счёт :";
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAmmo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtAmmo.Location = new System.Drawing.Point(12, 9);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(87, 18);
            this.txtAmmo.TabIndex = 6;
            this.txtAmmo.Text = "Патроны :";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // FrnGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numHP);
            this.Controls.Add(this.healthTheBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.Player);
            this.Name = "FrnGame";
            this.Text = "FrnGame";
            this.Load += new System.EventHandler(this.FrnGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label numHP;
        private System.Windows.Forms.ProgressBar healthTheBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Timer timer1;
    }
}