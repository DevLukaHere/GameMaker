namespace GameMaker
{
    partial class GameMaker
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMaker));
            this.PictureBoxMain = new System.Windows.Forms.PictureBox();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.nutka1 = new System.Windows.Forms.PictureBox();
            this.nutka2 = new System.Windows.Forms.PictureBox();
            this.GameName = new System.Windows.Forms.Label();
            this.ButtonSterowanie = new System.Windows.Forms.Button();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.ButtonEnd = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonEditor = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).BeginInit();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nutka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutka2)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxMain
            // 
            this.PictureBoxMain.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxMain.BackgroundImage")));
            this.PictureBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxMain.Location = new System.Drawing.Point(22, 229);
            this.PictureBoxMain.Name = "PictureBoxMain";
            this.PictureBoxMain.Size = new System.Drawing.Size(1100, 600);
            this.PictureBoxMain.TabIndex = 0;
            this.PictureBoxMain.TabStop = false;
            // 
            // PanelMain
            // 
            this.PanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMain.BackgroundImage")));
            this.PanelMain.Controls.Add(this.nutka1);
            this.PanelMain.Controls.Add(this.nutka2);
            this.PanelMain.Controls.Add(this.GameName);
            this.PanelMain.Controls.Add(this.ButtonSterowanie);
            this.PanelMain.Controls.Add(this.ButtonPlay);
            this.PanelMain.Controls.Add(this.ButtonEnd);
            this.PanelMain.Controls.Add(this.ButtonLoad);
            this.PanelMain.Controls.Add(this.ButtonSave);
            this.PanelMain.Controls.Add(this.ButtonSettings);
            this.PanelMain.Controls.Add(this.ButtonEditor);
            this.PanelMain.Controls.Add(this.PictureBoxMain);
            this.PanelMain.Location = new System.Drawing.Point(0, 1);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1580, 861);
            this.PanelMain.TabIndex = 1;
            // 
            // nutka1
            // 
            this.nutka1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nutka1.BackgroundImage")));
            this.nutka1.Location = new System.Drawing.Point(1518, 794);
            this.nutka1.Name = "nutka1";
            this.nutka1.Size = new System.Drawing.Size(50, 50);
            this.nutka1.TabIndex = 12;
            this.nutka1.TabStop = false;
            this.nutka1.Click += new System.EventHandler(this.nutka1_Click);
            // 
            // nutka2
            // 
            this.nutka2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nutka2.BackgroundImage")));
            this.nutka2.Location = new System.Drawing.Point(1518, 794);
            this.nutka2.Name = "nutka2";
            this.nutka2.Size = new System.Drawing.Size(50, 50);
            this.nutka2.TabIndex = 11;
            this.nutka2.TabStop = false;
            this.nutka2.Click += new System.EventHandler(this.nutka2_Click);
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.BackColor = System.Drawing.Color.Peru;
            this.GameName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameName.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GameName.Location = new System.Drawing.Point(35, 148);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(312, 62);
            this.GameName.TabIndex = 10;
            this.GameName.Text = "Nazwa gry:";
            // 
            // ButtonSterowanie
            // 
            this.ButtonSterowanie.AutoSize = true;
            this.ButtonSterowanie.BackColor = System.Drawing.Color.SaddleBrown;
            this.ButtonSterowanie.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonSterowanie.Font = new System.Drawing.Font("MS Reference Sans Serif", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSterowanie.Location = new System.Drawing.Point(1154, 387);
            this.ButtonSterowanie.Name = "ButtonSterowanie";
            this.ButtonSterowanie.Size = new System.Drawing.Size(394, 121);
            this.ButtonSterowanie.TabIndex = 5;
            this.ButtonSterowanie.Text = "Sterowanie";
            this.ButtonSterowanie.UseVisualStyleBackColor = false;
            this.ButtonSterowanie.Click += new System.EventHandler(this.ButtonSterowanie_Click);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.AutoSize = true;
            this.ButtonPlay.BackColor = System.Drawing.Color.Lime;
            this.ButtonPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonPlay.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPlay.ForeColor = System.Drawing.Color.Black;
            this.ButtonPlay.Location = new System.Drawing.Point(540, 11);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(432, 118);
            this.ButtonPlay.TabIndex = 1;
            this.ButtonPlay.Text = "Zagraj!";
            this.ButtonPlay.UseVisualStyleBackColor = false;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // ButtonEnd
            // 
            this.ButtonEnd.AutoSize = true;
            this.ButtonEnd.BackColor = System.Drawing.Color.SaddleBrown;
            this.ButtonEnd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonEnd.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonEnd.Location = new System.Drawing.Point(1154, 670);
            this.ButtonEnd.Name = "ButtonEnd";
            this.ButtonEnd.Size = new System.Drawing.Size(394, 118);
            this.ButtonEnd.TabIndex = 6;
            this.ButtonEnd.Text = "Zakończ";
            this.ButtonEnd.UseVisualStyleBackColor = false;
            this.ButtonEnd.Click += new System.EventHandler(this.ButtonEnd_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.AutoSize = true;
            this.ButtonLoad.BackColor = System.Drawing.Color.Sienna;
            this.ButtonLoad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonLoad.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonLoad.Location = new System.Drawing.Point(1154, 148);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(394, 118);
            this.ButtonLoad.TabIndex = 3;
            this.ButtonLoad.Text = "Wczytaj ";
            this.ButtonLoad.UseVisualStyleBackColor = false;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = true;
            this.ButtonSave.BackColor = System.Drawing.Color.Sienna;
            this.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSave.Location = new System.Drawing.Point(1154, 11);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(394, 118);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Zapisz ";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.AutoSize = true;
            this.ButtonSettings.BackColor = System.Drawing.Color.SaddleBrown;
            this.ButtonSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonSettings.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSettings.Location = new System.Drawing.Point(1154, 532);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(394, 118);
            this.ButtonSettings.TabIndex = 4;
            this.ButtonSettings.Text = "Wyzeruj";
            this.ButtonSettings.UseVisualStyleBackColor = false;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonEditor
            // 
            this.ButtonEditor.AutoSize = true;
            this.ButtonEditor.BackColor = System.Drawing.Color.SaddleBrown;
            this.ButtonEditor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonEditor.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonEditor.ForeColor = System.Drawing.Color.Black;
            this.ButtonEditor.Location = new System.Drawing.Point(35, 11);
            this.ButtonEditor.Name = "ButtonEditor";
            this.ButtonEditor.Size = new System.Drawing.Size(352, 118);
            this.ButtonEditor.TabIndex = 0;
            this.ButtonEditor.Text = "Edytor";
            this.ButtonEditor.UseVisualStyleBackColor = false;
            this.ButtonEditor.Click += new System.EventHandler(this.ButtonEditor_Click);
            // 
            // GameMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1580, 857);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Maker ";
            this.Load += new System.EventHandler(this.GameMaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nutka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutka2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxMain;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button ButtonEditor;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonEnd;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonSterowanie;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.PictureBox nutka1;
        private System.Windows.Forms.PictureBox nutka2;
    }
}

