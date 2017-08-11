namespace Soshaint33.WorldEditor
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.بندرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.resourceExplorer1 = new Soshiant33.ResourceExplorer.ResourceExplorer();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_selectedObject = new System.Windows.Forms.ToolStripLabel();
            this.nTabControl1 = new Nevron.UI.WinForm.Controls.NTabControl();
            this.tab_scene = new Nevron.UI.WinForm.Controls.NTabPage();
            this.s33SceneEditor1 = new Soshiant33.SceneEditor.S33SceneEditor();
            this.tab_sprite = new Nevron.UI.WinForm.Controls.NTabPage();
            this.tab_cmplxEntity = new Nevron.UI.WinForm.Controls.NTabPage();
            this.tab_particle = new Nevron.UI.WinForm.Controls.NTabPage();
            this.s33SpriteEditor1 = new Soshiant33.SpriteEditor.S33SpriteEditor();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.nTabControl1.SuspendLayout();
            this.tab_scene.SuspendLayout();
            this.tab_sprite.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بندرToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // بندرToolStripMenuItem
            // 
            this.بندرToolStripMenuItem.Name = "بندرToolStripMenuItem";
            this.بندرToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.بندرToolStripMenuItem.Text = "بندر";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.nTabControl1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(832, 517);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.resourceExplorer1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(173, 515);
            this.splitContainer2.SplitterDistance = 266;
            this.splitContainer2.TabIndex = 0;
            // 
            // resourceExplorer1
            // 
            this.resourceExplorer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceExplorer1.Location = new System.Drawing.Point(0, 0);
            this.resourceExplorer1.Name = "resourceExplorer1";
            this.resourceExplorer1.Size = new System.Drawing.Size(173, 266);
            this.resourceExplorer1.TabIndex = 0;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.propertyGrid.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.propertyGrid.HelpForeColor = System.Drawing.Color.White;
            this.propertyGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.propertyGrid.Location = new System.Drawing.Point(0, 25);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.propertyGrid.Size = new System.Drawing.Size(173, 220);
            this.propertyGrid.TabIndex = 3;
            this.propertyGrid.ToolbarVisible = false;
            this.propertyGrid.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.propertyGrid.ViewForeColor = System.Drawing.Color.White;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Silver;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripSeparator9,
            this.lbl_selectedObject});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(173, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel3.Text = "مشخصات";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_selectedObject
            // 
            this.lbl_selectedObject.Name = "lbl_selectedObject";
            this.lbl_selectedObject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_selectedObject.Size = new System.Drawing.Size(10, 22);
            this.lbl_selectedObject.Text = " ";
            // 
            // nTabControl1
            // 
            this.nTabControl1.Controls.Add(this.tab_scene);
            this.nTabControl1.Controls.Add(this.tab_sprite);
            this.nTabControl1.Controls.Add(this.tab_cmplxEntity);
            this.nTabControl1.Controls.Add(this.tab_particle);
            this.nTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTabControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nTabControl1.Location = new System.Drawing.Point(0, 0);
            this.nTabControl1.Name = "nTabControl1";
            this.nTabControl1.Padding = new System.Windows.Forms.Padding(4, 4, 29, 4);
            this.nTabControl1.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Longhorn;
            this.nTabControl1.Selectable = true;
            this.nTabControl1.SelectedIndex = 1;
            this.nTabControl1.Size = new System.Drawing.Size(651, 515);
            this.nTabControl1.TabAlign = Nevron.UI.WinForm.Controls.TabAlign.Right;
            this.nTabControl1.TabIndex = 0;
            // 
            // tab_scene
            // 
            this.tab_scene.Controls.Add(this.s33SceneEditor1);
            this.tab_scene.Location = new System.Drawing.Point(4, 4);
            this.tab_scene.Name = "tab_scene";
            this.tab_scene.Size = new System.Drawing.Size(618, 507);
            this.tab_scene.TabIndex = 1;
            this.tab_scene.Text = "صحنه";
            // 
            // s33SceneEditor1
            // 
            this.s33SceneEditor1.AllowDrop = true;
            this.s33SceneEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s33SceneEditor1.Location = new System.Drawing.Point(0, 0);
            this.s33SceneEditor1.Name = "s33SceneEditor1";
            this.s33SceneEditor1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.s33SceneEditor1.Size = new System.Drawing.Size(618, 507);
            this.s33SceneEditor1.TabIndex = 0;
            // 
            // tab_sprite
            // 
            this.tab_sprite.Controls.Add(this.s33SpriteEditor1);
            this.tab_sprite.Location = new System.Drawing.Point(4, 4);
            this.tab_sprite.Name = "tab_sprite";
            this.tab_sprite.Size = new System.Drawing.Size(618, 507);
            this.tab_sprite.TabIndex = 2;
            this.tab_sprite.Text = "موجود";
            // 
            // tab_cmplxEntity
            // 
            this.tab_cmplxEntity.Location = new System.Drawing.Point(4, 4);
            this.tab_cmplxEntity.Name = "tab_cmplxEntity";
            this.tab_cmplxEntity.Size = new System.Drawing.Size(618, 507);
            this.tab_cmplxEntity.TabIndex = 3;
            this.tab_cmplxEntity.Text = "موجود مرکب";
            // 
            // tab_particle
            // 
            this.tab_particle.Location = new System.Drawing.Point(4, 4);
            this.tab_particle.Name = "tab_particle";
            this.tab_particle.Size = new System.Drawing.Size(618, 507);
            this.tab_particle.TabIndex = 4;
            this.tab_particle.Text = "دستگاه ذرات";
            // 
            // s33SpriteEditor1
            // 
            this.s33SpriteEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s33SpriteEditor1.Location = new System.Drawing.Point(0, 0);
            this.s33SpriteEditor1.Name = "s33SpriteEditor1";
            this.s33SpriteEditor1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.s33SpriteEditor1.Size = new System.Drawing.Size(618, 507);
            this.s33SpriteEditor1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 541);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Longhorn;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowCaptionImage = false;
            this.Text = "Soshiant Scene Editor v0.2.2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.nTabControl1.ResumeLayout(false);
            this.tab_scene.ResumeLayout(false);
            this.tab_sprite.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Nevron.UI.WinForm.Controls.NTabControl nTabControl1;
        private Nevron.UI.WinForm.Controls.NTabPage tab_scene;
        private Nevron.UI.WinForm.Controls.NTabPage tab_sprite;
        private Nevron.UI.WinForm.Controls.NTabPage tab_cmplxEntity;
        private Nevron.UI.WinForm.Controls.NTabPage tab_particle;
        private System.Windows.Forms.ToolStripMenuItem بندرToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Soshiant33.ResourceExplorer.ResourceExplorer resourceExplorer1;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel lbl_selectedObject;
        private Soshiant33.SceneEditor.S33SceneEditor s33SceneEditor1;
        private Soshiant33.SpriteEditor.S33SpriteEditor s33SpriteEditor1;
    }
}

