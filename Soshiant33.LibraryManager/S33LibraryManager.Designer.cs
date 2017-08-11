namespace Soshiant33.LibraryManager
{
    partial class S33LibraryManager
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nTabControl3 = new Nevron.UI.WinForm.Controls.NTabControl();
            this.tab_TimeLine = new Nevron.UI.WinForm.Controls.NTabPage();
            this.sceneLib_browser = new Soshiant33.LibraryManager.S33LibraryBrowser();
            this.tab_ActionEditor = new Nevron.UI.WinForm.Controls.NTabPage();
            this.sharedLib_browser = new Soshiant33.LibraryManager.S33LibraryBrowser();
            this.nTabControl3.SuspendLayout();
            this.tab_TimeLine.SuspendLayout();
            this.tab_ActionEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // nTabControl3
            // 
            this.nTabControl3.Controls.Add(this.tab_TimeLine);
            this.nTabControl3.Controls.Add(this.tab_ActionEditor);
            this.nTabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTabControl3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nTabControl3.Location = new System.Drawing.Point(0, 0);
            this.nTabControl3.Margin = new System.Windows.Forms.Padding(0);
            this.nTabControl3.Name = "nTabControl3";
            this.nTabControl3.Padding = new System.Windows.Forms.Padding(4, 484, 4, 4);
            this.nTabControl3.Palette.ControlLight = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.nTabControl3.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Longhorn;
            this.nTabControl3.Selectable = true;
            this.nTabControl3.SelectedIndex = 0;
            this.nTabControl3.Size = new System.Drawing.Size(240, 480);
            this.nTabControl3.TabIndex = 1;
            // 
            // tab_TimeLine
            // 
            this.tab_TimeLine.Controls.Add(this.sceneLib_browser);
            this.tab_TimeLine.Location = new System.Drawing.Point(4, 484);
            this.tab_TimeLine.Margin = new System.Windows.Forms.Padding(0);
            this.tab_TimeLine.Name = "tab_TimeLine";
            this.tab_TimeLine.Size = new System.Drawing.Size(232, 0);
            this.tab_TimeLine.TabIndex = 1;
            this.tab_TimeLine.Text = "صحنه";
            // 
            // sceneLib_browser
            // 
            this.sceneLib_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sceneLib_browser.Location = new System.Drawing.Point(0, 0);
            this.sceneLib_browser.Name = "sceneLib_browser";
            this.sceneLib_browser.Size = new System.Drawing.Size(232, 0);
            this.sceneLib_browser.TabIndex = 0;
            // 
            // tab_ActionEditor
            // 
            this.tab_ActionEditor.Controls.Add(this.sharedLib_browser);
            this.tab_ActionEditor.Location = new System.Drawing.Point(4, 484);
            this.tab_ActionEditor.Name = "tab_ActionEditor";
            this.tab_ActionEditor.Size = new System.Drawing.Size(232, 0);
            this.tab_ActionEditor.TabIndex = 2;
            this.tab_ActionEditor.Text = "اشتراکی";
            // 
            // sharedLib_browser
            // 
            this.sharedLib_browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sharedLib_browser.Location = new System.Drawing.Point(0, 0);
            this.sharedLib_browser.Name = "sharedLib_browser";
            this.sharedLib_browser.Size = new System.Drawing.Size(232, 0);
            this.sharedLib_browser.TabIndex = 1;
            // 
            // S33LibraryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nTabControl3);
            this.Name = "S33LibraryManager";
            this.Size = new System.Drawing.Size(240, 480);
            this.nTabControl3.ResumeLayout(false);
            this.tab_TimeLine.ResumeLayout(false);
            this.tab_ActionEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Nevron.UI.WinForm.Controls.NTabControl nTabControl3;
        private Nevron.UI.WinForm.Controls.NTabPage tab_TimeLine;
        private Nevron.UI.WinForm.Controls.NTabPage tab_ActionEditor;
        private Soshiant33.LibraryManager.S33LibraryBrowser sceneLib_browser;
        private S33LibraryBrowser sharedLib_browser;

    }
}
