namespace GameMaker
{
    partial class EditorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorWindow));
            this.PanelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CoordsLabel = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NarzedzieLabel = new System.Windows.Forms.Label();
            this.ListOfObjects = new System.Windows.Forms.ListView();
            this.ButtonWstaw = new System.Windows.Forms.Button();
            this.Info1 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonTlo = new System.Windows.Forms.Button();
            this.ButtonSkaluj = new System.Windows.Forms.Button();
            this.ButtonPrzesun = new System.Windows.Forms.Button();
            this.ButtonPedzel = new System.Windows.Forms.Button();
            this.PictureBoxEditor = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.PanelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.Transparent;
            this.PanelMain.Controls.Add(this.panel2);
            this.PanelMain.Controls.Add(this.Panel1);
            this.PanelMain.Controls.Add(this.NarzedzieLabel);
            this.PanelMain.Controls.Add(this.ListOfObjects);
            this.PanelMain.Controls.Add(this.ButtonWstaw);
            this.PanelMain.Controls.Add(this.Info1);
            this.PanelMain.Controls.Add(this.ButtonSave);
            this.PanelMain.Controls.Add(this.ButtonTlo);
            this.PanelMain.Controls.Add(this.ButtonSkaluj);
            this.PanelMain.Controls.Add(this.ButtonPrzesun);
            this.PanelMain.Controls.Add(this.ButtonPedzel);
            this.PanelMain.Controls.Add(this.PictureBoxEditor);
            this.PanelMain.Location = new System.Drawing.Point(2, 2);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1508, 624);
            this.PanelMain.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CoordsLabel);
            this.panel2.Location = new System.Drawing.Point(1019, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 47);
            this.panel2.TabIndex = 18;
            // 
            // CoordsLabel
            // 
            this.CoordsLabel.AutoSize = true;
            this.CoordsLabel.BackColor = System.Drawing.Color.Transparent;
            this.CoordsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CoordsLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CoordsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CoordsLabel.Location = new System.Drawing.Point(2, 7);
            this.CoordsLabel.Name = "CoordsLabel";
            this.CoordsLabel.Size = new System.Drawing.Size(94, 35);
            this.CoordsLabel.TabIndex = 15;
            this.CoordsLabel.Text = "X: Y:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.comboBox1);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.textBox1);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Location = new System.Drawing.Point(1030, 267);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(223, 215);
            this.Panel1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 43);
            this.comboBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(-5, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Obiekt sterowany:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 43);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Nowa gra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nazwa gry:";
            // 
            // NarzedzieLabel
            // 
            this.NarzedzieLabel.AutoSize = true;
            this.NarzedzieLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NarzedzieLabel.Location = new System.Drawing.Point(1014, 53);
            this.NarzedzieLabel.Name = "NarzedzieLabel";
            this.NarzedzieLabel.Size = new System.Drawing.Size(253, 28);
            this.NarzedzieLabel.TabIndex = 16;
            this.NarzedzieLabel.Text = "Narzędzie: Przesuń";
            // 
            // ListOfObjects
            // 
            this.ListOfObjects.Location = new System.Drawing.Point(1269, 43);
            this.ListOfObjects.Name = "ListOfObjects";
            this.ListOfObjects.Size = new System.Drawing.Size(212, 569);
            this.ListOfObjects.TabIndex = 14;
            this.ListOfObjects.UseCompatibleStateImageBehavior = false;
            this.ListOfObjects.SelectedIndexChanged += new System.EventHandler(this.ListOfObjects_SelectedIndexChanged);
            // 
            // ButtonWstaw
            // 
            this.ButtonWstaw.AutoSize = true;
            this.ButtonWstaw.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonWstaw.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonWstaw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonWstaw.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonWstaw.Location = new System.Drawing.Point(1021, 488);
            this.ButtonWstaw.Name = "ButtonWstaw";
            this.ButtonWstaw.Size = new System.Drawing.Size(242, 60);
            this.ButtonWstaw.TabIndex = 13;
            this.ButtonWstaw.Text = "Wstaw obiekt";
            this.ButtonWstaw.UseVisualStyleBackColor = false;
            this.ButtonWstaw.Click += new System.EventHandler(this.ButtonWstaw_Click);
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Info1.Location = new System.Drawing.Point(1265, 11);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(210, 29);
            this.Info1.TabIndex = 12;
            this.Info1.Text = "Lista obiektów:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = true;
            this.ButtonSave.BackColor = System.Drawing.Color.Gray;
            this.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSave.Location = new System.Drawing.Point(1021, 554);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(242, 57);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "Zapisz i wyjdź";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonTlo
            // 
            this.ButtonTlo.AutoSize = true;
            this.ButtonTlo.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonTlo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonTlo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonTlo.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonTlo.Location = new System.Drawing.Point(1148, 89);
            this.ButtonTlo.Name = "ButtonTlo";
            this.ButtonTlo.Size = new System.Drawing.Size(115, 77);
            this.ButtonTlo.TabIndex = 8;
            this.ButtonTlo.Text = "Tło";
            this.ButtonTlo.UseVisualStyleBackColor = false;
            this.ButtonTlo.Click += new System.EventHandler(this.ButtonTlo_Click);
            // 
            // ButtonSkaluj
            // 
            this.ButtonSkaluj.AutoSize = true;
            this.ButtonSkaluj.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonSkaluj.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonSkaluj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSkaluj.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSkaluj.Location = new System.Drawing.Point(1148, 184);
            this.ButtonSkaluj.Name = "ButtonSkaluj";
            this.ButtonSkaluj.Size = new System.Drawing.Size(115, 77);
            this.ButtonSkaluj.TabIndex = 6;
            this.ButtonSkaluj.Text = "Skaluj";
            this.ButtonSkaluj.UseVisualStyleBackColor = false;
            // 
            // ButtonPrzesun
            // 
            this.ButtonPrzesun.AutoSize = true;
            this.ButtonPrzesun.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonPrzesun.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonPrzesun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonPrzesun.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPrzesun.Location = new System.Drawing.Point(1019, 89);
            this.ButtonPrzesun.Name = "ButtonPrzesun";
            this.ButtonPrzesun.Size = new System.Drawing.Size(124, 77);
            this.ButtonPrzesun.TabIndex = 5;
            this.ButtonPrzesun.Text = "Przesuń";
            this.ButtonPrzesun.UseVisualStyleBackColor = false;
            this.ButtonPrzesun.Click += new System.EventHandler(this.ButtonZmianaNarzedzia_Click);
            // 
            // ButtonPedzel
            // 
            this.ButtonPedzel.AutoSize = true;
            this.ButtonPedzel.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonPedzel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonPedzel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonPedzel.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPedzel.Location = new System.Drawing.Point(1019, 184);
            this.ButtonPedzel.Name = "ButtonPedzel";
            this.ButtonPedzel.Size = new System.Drawing.Size(124, 77);
            this.ButtonPedzel.TabIndex = 3;
            this.ButtonPedzel.Text = "Pędzel";
            this.ButtonPedzel.UseVisualStyleBackColor = false;
            this.ButtonPedzel.Click += new System.EventHandler(this.ButtonZmianaNarzedzia_Click);
            // 
            // PictureBoxEditor
            // 
            this.PictureBoxEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxEditor.Location = new System.Drawing.Point(15, 11);
            this.PictureBoxEditor.Name = "PictureBoxEditor";
            this.PictureBoxEditor.Size = new System.Drawing.Size(1000, 600);
            this.PictureBoxEditor.TabIndex = 0;
            this.PictureBoxEditor.TabStop = false;
            this.PictureBoxEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxEditor_MouseDown);
            this.PictureBoxEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxEditor_MouseMove);
            this.PictureBoxEditor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxEditor_MouseUp);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // EditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1501, 626);
            this.Controls.Add(this.PanelMain);
            this.Name = "EditorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorWindow";
            this.Load += new System.EventHandler(this.EditorWindow_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.PictureBox PictureBoxEditor;
        private System.Windows.Forms.Button ButtonTlo;
        private System.Windows.Forms.Button ButtonSkaluj;
        private System.Windows.Forms.Button ButtonPrzesun;
        private System.Windows.Forms.Button ButtonPedzel;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonWstaw;
        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.ListView ListOfObjects;
        private System.Windows.Forms.Label CoordsLabel;
        private System.Windows.Forms.Label NarzedzieLabel;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
    }
}