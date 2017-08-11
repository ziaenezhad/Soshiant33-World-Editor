namespace Soshiant_Sprite_Sheet_Builder
{
    partial class SpriteSheetBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpriteSheetBuilder));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.timeline = new Nevron.UI.WinForm.Controls.NGalleryPanel();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.btn_clear = new System.Windows.Forms.ToolStripButton();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_addFrames = new System.Windows.Forms.ToolStripButton();
            this.btn_removeFrames = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeline)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.timeline);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseMove);
            this.splitContainer1.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseDown);
            this.splitContainer1.Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseUp);
            this.splitContainer1.Panel2.SizeChanged += new System.EventHandler(this.splitContainer1_Panel2_SizeChanged);
            this.splitContainer1.Size = new System.Drawing.Size(799, 507);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 1;
            // 
            // timeline
            // 
            this.timeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeline.FillInfo.Gradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.timeline.FillInfo.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.timeline.ItemLayout = Nevron.UI.WinForm.Controls.GalleryPanelLayout.HorizontalStack;
            this.timeline.ItemSize = new Nevron.GraphicsCore.NSize(100, 120);
            this.timeline.Location = new System.Drawing.Point(0, 39);
            this.timeline.Name = "timeline";
            this.timeline.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Longhorn;
            this.timeline.ShadowInfo.Draw = false;
            this.timeline.Size = new System.Drawing.Size(797, 147);
            this.timeline.StrokeInfo.Rounding = 5;
            this.timeline.TabIndex = 3;
            this.timeline.Text = "nGalleryPanel1";
            this.timeline.ItemSelectionChanged += new Nevron.UI.WinForm.Controls.NGalleryItemSelectionChangedEventHandler(this.timeline_ItemSelectionChanged);
            // 
            // toolStrip4
            // 
            this.toolStrip4.BackColor = System.Drawing.Color.Silver;
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_clear,
            this.btn_save,
            this.toolStripSeparator7,
            this.btn_addFrames,
            this.btn_removeFrames,
            this.toolStripSeparator6});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip4.Size = new System.Drawing.Size(797, 39);
            this.toolStrip4.TabIndex = 2;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // btn_clear
            // 
            this.btn_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(36, 36);
            this.btn_clear.Text = "جدید";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_save.Enabled = false;
            this.btn_save.Image = global::Soshiant_Sprite_Sheet_Builder.Properties.Resources.save;
            this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(36, 36);
            this.btn_save.Text = "دخیره";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_addFrames
            // 
            this.btn_addFrames.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_addFrames.Image = ((System.Drawing.Image)(resources.GetObject("btn_addFrames.Image")));
            this.btn_addFrames.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_addFrames.Name = "btn_addFrames";
            this.btn_addFrames.Size = new System.Drawing.Size(36, 36);
            this.btn_addFrames.Text = "قاب جدبد";
            this.btn_addFrames.Click += new System.EventHandler(this.btn_addFrames_Click);
            // 
            // btn_removeFrames
            // 
            this.btn_removeFrames.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_removeFrames.Enabled = false;
            this.btn_removeFrames.Image = ((System.Drawing.Image)(resources.GetObject("btn_removeFrames.Image")));
            this.btn_removeFrames.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_removeFrames.Name = "btn_removeFrames";
            this.btn_removeFrames.Size = new System.Drawing.Size(36, 36);
            this.btn_removeFrames.Text = "حذف قاب";
            this.btn_removeFrames.Click += new System.EventHandler(this.btn_removeFrames_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "[...]";
            this.openFileDialog1.Filter = "PNG file |*.png|JPEG file|*.jpg|BMP file |*.bmp";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(799, 31);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(81, 26);
            this.toolStripStatusLabel1.Text = "نقطه مرکز [0,0]";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripProgressBar1.Size = new System.Drawing.Size(600, 25);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "*.sht";
            this.saveFileDialog1.Filter = "Soshiant SpriteSheet File (.sht)|*.png";
            // 
            // SpriteSheetBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 507);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SpriteSheetBuilder";
            this.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Longhorn;
            this.ShowCaptionImage = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soshiant Sprite Sheet Builder";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeline)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Nevron.UI.WinForm.Controls.NGalleryPanel timeline;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton btn_addFrames;
        private System.Windows.Forms.ToolStripButton btn_removeFrames;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btn_save;
        private System.Windows.Forms.ToolStripButton btn_clear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;

    }
}

