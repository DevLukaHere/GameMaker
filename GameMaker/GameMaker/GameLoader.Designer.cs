namespace GameMaker
{
    partial class GameLoader
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.ButtonEditor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 41;
            this.Lista.Location = new System.Drawing.Point(0, 0);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(425, 373);
            this.Lista.TabIndex = 0;
            // 
            // ButtonEditor
            // 
            this.ButtonEditor.BackColor = System.Drawing.Color.SaddleBrown;
            this.ButtonEditor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonEditor.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditor.ForeColor = System.Drawing.Color.Black;
            this.ButtonEditor.Location = new System.Drawing.Point(66, 410);
            this.ButtonEditor.Name = "ButtonEditor";
            this.ButtonEditor.Size = new System.Drawing.Size(298, 91);
            this.ButtonEditor.TabIndex = 3;
            this.ButtonEditor.Text = "Wczytaj";
            this.ButtonEditor.UseVisualStyleBackColor = false;
            this.ButtonEditor.Click += new System.EventHandler(this.ButtonEditor_Click);
            // 
            // GameLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 508);
            this.Controls.Add(this.ButtonEditor);
            this.Controls.Add(this.Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameLoader";
            this.Load += new System.EventHandler(this.GameLoader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button ButtonEditor;
    }
}