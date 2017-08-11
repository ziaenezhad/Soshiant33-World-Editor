namespace Soshiant33.Panel
{
    partial class S33Panel
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تابشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پرسپکتیوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اورتوگرافیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تابشToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // تابشToolStripMenuItem
            // 
            this.تابشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پرسپکتیوToolStripMenuItem,
            this.اورتوگرافیToolStripMenuItem});
            this.تابشToolStripMenuItem.Name = "تابشToolStripMenuItem";
            this.تابشToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.تابشToolStripMenuItem.Text = "تابش";
            // 
            // پرسپکتیوToolStripMenuItem
            // 
            this.پرسپکتیوToolStripMenuItem.CheckOnClick = true;
            this.پرسپکتیوToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.پرسپکتیوToolStripMenuItem.Name = "پرسپکتیوToolStripMenuItem";
            this.پرسپکتیوToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.پرسپکتیوToolStripMenuItem.Text = "پرسپکتیو";
            this.پرسپکتیوToolStripMenuItem.CheckedChanged += new System.EventHandler(this.پرسپکتیوToolStripMenuItem_CheckedChanged);
            // 
            // اورتوگرافیToolStripMenuItem
            // 
            this.اورتوگرافیToolStripMenuItem.CheckOnClick = true;
            this.اورتوگرافیToolStripMenuItem.Name = "اورتوگرافیToolStripMenuItem";
            this.اورتوگرافیToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.اورتوگرافیToolStripMenuItem.Text = "اورتوگرافی";
            this.اورتوگرافیToolStripMenuItem.CheckedChanged += new System.EventHandler(this.اورتوگرافیToolStripMenuItem_CheckedChanged);
            // 
            // S33Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "S33Panel";
            this.Size = new System.Drawing.Size(508, 259);
            this.Load += new System.EventHandler(this.Panel_Load);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseWeel);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Panel_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            this.SizeChanged += new System.EventHandler(this.Panel_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Panel_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تابشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem پرسپکتیوToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اورتوگرافیToolStripMenuItem;

    }
}
