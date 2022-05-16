namespace GameMaker
{
    partial class InsertObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertObject));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TypLabel = new System.Windows.Forms.Label();
            this.SzerokoscLabel = new System.Windows.Forms.Label();
            this.WysokoscLabel = new System.Windows.Forms.Label();
            this.NazwaTextBox = new System.Windows.Forms.TextBox();
            this.NazwaLabel = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonImport = new System.Windows.Forms.Button();
            this.Podglad = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Podglad)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.LightGray;
            this.MainPanel.Controls.Add(this.comboBox1);
            this.MainPanel.Controls.Add(this.TypLabel);
            this.MainPanel.Controls.Add(this.SzerokoscLabel);
            this.MainPanel.Controls.Add(this.WysokoscLabel);
            this.MainPanel.Controls.Add(this.NazwaTextBox);
            this.MainPanel.Controls.Add(this.NazwaLabel);
            this.MainPanel.Controls.Add(this.ButtonOK);
            this.MainPanel.Controls.Add(this.ButtonImport);
            this.MainPanel.Location = new System.Drawing.Point(528, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(359, 500);
            this.MainPanel.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Przenikanie",
            "Sciana",
            "Znikacz",
            "Przejscie"});
            this.comboBox1.Location = new System.Drawing.Point(107, 310);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 37);
            this.comboBox1.TabIndex = 15;
            // 
            // TypLabel
            // 
            this.TypLabel.AutoSize = true;
            this.TypLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypLabel.Location = new System.Drawing.Point(16, 304);
            this.TypLabel.Name = "TypLabel";
            this.TypLabel.Size = new System.Drawing.Size(95, 40);
            this.TypLabel.TabIndex = 14;
            this.TypLabel.Text = "Typ:";
            // 
            // SzerokoscLabel
            // 
            this.SzerokoscLabel.AutoSize = true;
            this.SzerokoscLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SzerokoscLabel.Location = new System.Drawing.Point(3, 75);
            this.SzerokoscLabel.Name = "SzerokoscLabel";
            this.SzerokoscLabel.Size = new System.Drawing.Size(173, 34);
            this.SzerokoscLabel.TabIndex = 13;
            this.SzerokoscLabel.Text = "Szerokosc:";
            // 
            // WysokoscLabel
            // 
            this.WysokoscLabel.AutoSize = true;
            this.WysokoscLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WysokoscLabel.Location = new System.Drawing.Point(3, 139);
            this.WysokoscLabel.Name = "WysokoscLabel";
            this.WysokoscLabel.Size = new System.Drawing.Size(169, 34);
            this.WysokoscLabel.TabIndex = 12;
            this.WysokoscLabel.Text = "Wysokosc:";
            // 
            // NazwaTextBox
            // 
            this.NazwaTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NazwaTextBox.Location = new System.Drawing.Point(155, 11);
            this.NazwaTextBox.Name = "NazwaTextBox";
            this.NazwaTextBox.Size = new System.Drawing.Size(192, 50);
            this.NazwaTextBox.TabIndex = 11;
            this.NazwaTextBox.Text = "Object";
            // 
            // NazwaLabel
            // 
            this.NazwaLabel.AutoSize = true;
            this.NazwaLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaLabel.Location = new System.Drawing.Point(3, 16);
            this.NazwaLabel.Name = "NazwaLabel";
            this.NazwaLabel.Size = new System.Drawing.Size(157, 44);
            this.NazwaLabel.TabIndex = 10;
            this.NazwaLabel.Text = "Nazwa:";
            // 
            // ButtonOK
            // 
            this.ButtonOK.AutoSize = true;
            this.ButtonOK.BackColor = System.Drawing.Color.Gray;
            this.ButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOK.Location = new System.Drawing.Point(33, 384);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(304, 79);
            this.ButtonOK.TabIndex = 5;
            this.ButtonOK.Text = "Dodaj obiekt!";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonImport
            // 
            this.ButtonImport.AutoSize = true;
            this.ButtonImport.BackColor = System.Drawing.Color.Gray;
            this.ButtonImport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonImport.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonImport.Location = new System.Drawing.Point(33, 194);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(314, 59);
            this.ButtonImport.TabIndex = 4;
            this.ButtonImport.Text = "Importuj obraz";
            this.ButtonImport.UseVisualStyleBackColor = false;
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // Podglad
            // 
            this.Podglad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Podglad.Location = new System.Drawing.Point(2, 3);
            this.Podglad.Name = "Podglad";
            this.Podglad.Size = new System.Drawing.Size(500, 500);
            this.Podglad.TabIndex = 0;
            this.Podglad.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // WstawObiekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(904, 511);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Podglad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WstawObiekt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wstaw";
            this.Load += new System.EventHandler(this.WstawObiekt_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Podglad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox Podglad;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonImport;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox NazwaTextBox;
        private System.Windows.Forms.Label NazwaLabel;
        private System.Windows.Forms.Label SzerokoscLabel;
        private System.Windows.Forms.Label WysokoscLabel;
        private System.Windows.Forms.Label TypLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}