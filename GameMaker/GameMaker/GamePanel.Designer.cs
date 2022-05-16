namespace GameMaker
{
    partial class GamePanel
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
            this.PanelGame = new System.Windows.Forms.Panel();
            this.KolizjaLabel = new System.Windows.Forms.Label();
            this.FPSLabel = new System.Windows.Forms.Label();
            this.GamePictureBox = new System.Windows.Forms.PictureBox();
            this.FPSTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.LicznikLabel = new System.Windows.Forms.Label();
            this.PanelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelGame
            // 
            this.PanelGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelGame.Controls.Add(this.KolizjaLabel);
            this.PanelGame.Controls.Add(this.FPSLabel);
            this.PanelGame.Controls.Add(this.GamePictureBox);
            this.PanelGame.Location = new System.Drawing.Point(-2, -1);
            this.PanelGame.Name = "PanelGame";
            this.PanelGame.Size = new System.Drawing.Size(66, 64);
            this.PanelGame.TabIndex = 0;
            // 
            // KolizjaLabel
            // 
            this.KolizjaLabel.AutoSize = true;
            this.KolizjaLabel.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KolizjaLabel.Location = new System.Drawing.Point(3, 37);
            this.KolizjaLabel.Name = "KolizjaLabel";
            this.KolizjaLabel.Size = new System.Drawing.Size(0, 27);
            this.KolizjaLabel.TabIndex = 2;
            // 
            // FPSLabel
            // 
            this.FPSLabel.AutoSize = true;
            this.FPSLabel.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPSLabel.Location = new System.Drawing.Point(3, 10);
            this.FPSLabel.Name = "FPSLabel";
            this.FPSLabel.Size = new System.Drawing.Size(79, 27);
            this.FPSLabel.TabIndex = 1;
            this.FPSLabel.Text = "FPS: ";
            // 
            // GamePictureBox
            // 
            this.GamePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.GamePictureBox.Location = new System.Drawing.Point(0, 0);
            this.GamePictureBox.Name = "GamePictureBox";
            this.GamePictureBox.Size = new System.Drawing.Size(350, 320);
            this.GamePictureBox.TabIndex = 0;
            this.GamePictureBox.TabStop = false;
            // 
            // FPSTimer
            // 
            this.FPSTimer.Enabled = true;
            this.FPSTimer.Interval = 1000;
            this.FPSTimer.Tick += new System.EventHandler(this.FPSTimer_Tick);
            // 
            // MoveTimer
            // 
            this.MoveTimer.Enabled = true;
            this.MoveTimer.Interval = 1;
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // RenderTimer
            // 
            this.RenderTimer.Enabled = true;
            this.RenderTimer.Interval = 1;
            this.RenderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // LicznikLabel
            // 
            this.LicznikLabel.AutoSize = true;
            this.LicznikLabel.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicznikLabel.Location = new System.Drawing.Point(1, 66);
            this.LicznikLabel.Name = "LicznikLabel";
            this.LicznikLabel.Size = new System.Drawing.Size(114, 27);
            this.LicznikLabel.TabIndex = 3;
            this.LicznikLabel.Text = "Licznik: ";
            this.LicznikLabel.Visible = false;
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(185, 152);
            this.Controls.Add(this.LicznikLabel);
            this.Controls.Add(this.PanelGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GamePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.GamePanel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePanel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GamePanel_KeyUp);
            this.PanelGame.ResumeLayout(false);
            this.PanelGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelGame;
        private System.Windows.Forms.PictureBox GamePictureBox;
        private System.Windows.Forms.Label FPSLabel;
        private System.Windows.Forms.Timer FPSTimer;
        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.Label KolizjaLabel;
        private System.Windows.Forms.Label LicznikLabel;
    }
}