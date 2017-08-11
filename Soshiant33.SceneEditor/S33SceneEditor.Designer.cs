namespace Soshiant33.SceneEditor
{
    partial class S33SceneEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S33SceneEditor));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.nTreeViewEx1 = new Nevron.UI.WinForm.Controls.NTreeViewEx();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_selectedObject = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.s33Panel1 = new Soshiant33.Panel.S33Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_clear = new System.Windows.Forms.ToolStripButton();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_playPouse = new System.Windows.Forms.ToolStripButton();
            this.btn_exe = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 600);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SizeChanged += new System.EventHandler(this.splitContainer1_SizeChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.nTreeViewEx1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer2.Size = new System.Drawing.Size(200, 600);
            this.splitContainer2.SplitterDistance = 286;
            this.splitContainer2.TabIndex = 0;
            // 
            // nTreeViewEx1
            // 
            this.nTreeViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTreeViewEx1.Location = new System.Drawing.Point(0, 0);
            this.nTreeViewEx1.Name = "nTreeViewEx1";
            this.nTreeViewEx1.Nodes.AddRange(new Nevron.UI.WinForm.Controls.NTreeNode[] {
            ((Nevron.UI.WinForm.Controls.NTreeNode)(resources.GetObject("nTreeViewEx1.Nodes"))),
            ((Nevron.UI.WinForm.Controls.NTreeNode)(resources.GetObject("nTreeViewEx1.Nodes1")))});
            this.nTreeViewEx1.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Longhorn;
            this.nTreeViewEx1.Size = new System.Drawing.Size(198, 284);
            this.nTreeViewEx1.TabIndex = 6;
            this.nTreeViewEx1.Text = "nTreeViewEx1";
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
            this.propertyGrid.Size = new System.Drawing.Size(198, 283);
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
            this.toolStrip2.Size = new System.Drawing.Size(198, 25);
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
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.s33Panel1);
            this.splitContainer3.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer3.Size = new System.Drawing.Size(596, 600);
            this.splitContainer3.SplitterDistance = 525;
            this.splitContainer3.TabIndex = 0;
            // 
            // s33Panel1
            // 
            this.s33Panel1.AllowDrop = true;
            this.s33Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.s33Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s33Panel1.Location = new System.Drawing.Point(0, 39);
            this.s33Panel1.Name = "s33Panel1";
            this.s33Panel1.Size = new System.Drawing.Size(594, 484);
            this.s33Panel1.TabIndex = 5;
            this.s33Panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.s33Panel1_DragDrop);
            this.s33Panel1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.s33Panel1_KeyUp);
            this.s33Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s33Panel1_MouseDown);
            this.s33Panel1.DragLeave += new System.EventHandler(this.s33Panel1_DragLeave);
            this.s33Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s33Panel1_MouseUp);
            this.s33Panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.s33Panel1_DragEnter);
            this.s33Panel1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.s33Panel1_KeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_clear,
            this.btn_save,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.btn_playPouse,
            this.toolStripSeparator2,
            this.btn_exe});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(594, 39);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_clear
            // 
            this.btn_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(36, 36);
            this.btn_clear.Text = "صحنه جدید";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(36, 36);
            this.btn_save.Text = "ذخیره در کتابخانه";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Checked = true;
            this.toolStripButton1.CheckOnClick = true;
            this.toolStripButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "نمایش صفحه مدرج";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_playPouse
            // 
            this.btn_playPouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_playPouse.Image = ((System.Drawing.Image)(resources.GetObject("btn_playPouse.Image")));
            this.btn_playPouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_playPouse.Name = "btn_playPouse";
            this.btn_playPouse.Size = new System.Drawing.Size(36, 36);
            this.btn_playPouse.Text = "پخش و توقف نمایش";
            this.btn_playPouse.Click += new System.EventHandler(this.btn_playPouse_Click);
            // 
            // btn_exe
            // 
            this.btn_exe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_exe.Image = ((System.Drawing.Image)(resources.GetObject("btn_exe.Image")));
            this.btn_exe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_exe.Name = "btn_exe";
            this.btn_exe.Size = new System.Drawing.Size(36, 36);
            this.btn_exe.Text = "اجرا صحنه";
            this.btn_exe.Click += new System.EventHandler(this.btn_exe_Click);
            // 
            // S33SceneEditor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "S33SceneEditor";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.S33SceneEditor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel lbl_selectedObject;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_clear;
        private System.Windows.Forms.ToolStripButton btn_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_playPouse;
        private Nevron.UI.WinForm.Controls.NTreeViewEx nTreeViewEx1;
        private Soshiant33.Panel.S33Panel s33Panel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_exe;

    }
}
