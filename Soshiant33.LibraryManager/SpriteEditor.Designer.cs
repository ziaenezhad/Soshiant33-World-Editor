namespace Soshiant33.LibraryManager
{
    partial class SpriteEditor
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
            this.s33SpriteEditor1 = new Soshiant33.SpriteEditor.S33SpriteEditor();
            this.SuspendLayout();
            // 
            // s33SpriteEditor1
            // 
            this.s33SpriteEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s33SpriteEditor1.Location = new System.Drawing.Point(0, 0);
            this.s33SpriteEditor1.Name = "s33SpriteEditor1";
            this.s33SpriteEditor1.Size = new System.Drawing.Size(839, 554);
            this.s33SpriteEditor1.TabIndex = 0;
            // 
            // SpriteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 554);
            this.Controls.Add(this.s33SpriteEditor1);
            this.Name = "SpriteEditor";
            this.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Longhorn;
            this.ShowCaptionImage = false;
            this.ShowCaptionText = false;
            this.Text = "SpriteEditor";
            this.Load += new System.EventHandler(this.SpriteEditor_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpriteEditor_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Soshiant33.SpriteEditor.S33SpriteEditor s33SpriteEditor1;
    }
}