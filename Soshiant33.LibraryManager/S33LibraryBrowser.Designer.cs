namespace Soshiant33.LibraryManager
{
    partial class S33LibraryBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S33LibraryBrowser));
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btn_newState = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnu_addSprite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_addComplexEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_removeState = new System.Windows.Forms.ToolStripButton();
            this.membersGallery = new System.Windows.Forms.ListView();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.Silver;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_newState,
            this.btn_removeState});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip3.Size = new System.Drawing.Size(230, 39);
            this.toolStrip3.TabIndex = 3;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btn_newState
            // 
            this.btn_newState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_newState.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_addSprite,
            this.mnu_addComplexEntity});
            this.btn_newState.Image = ((System.Drawing.Image)(resources.GetObject("btn_newState.Image")));
            this.btn_newState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_newState.Name = "btn_newState";
            this.btn_newState.Size = new System.Drawing.Size(45, 36);
            this.btn_newState.Text = "وضعیت جدید";
            // 
            // mnu_addSprite
            // 
            this.mnu_addSprite.Image = ((System.Drawing.Image)(resources.GetObject("mnu_addSprite.Image")));
            this.mnu_addSprite.Name = "mnu_addSprite";
            this.mnu_addSprite.Size = new System.Drawing.Size(131, 22);
            this.mnu_addSprite.Text = "موجود";
            this.mnu_addSprite.Click += new System.EventHandler(this.mnu_addSprite_Click);
            // 
            // mnu_addComplexEntity
            // 
            this.mnu_addComplexEntity.Image = ((System.Drawing.Image)(resources.GetObject("mnu_addComplexEntity.Image")));
            this.mnu_addComplexEntity.Name = "mnu_addComplexEntity";
            this.mnu_addComplexEntity.Size = new System.Drawing.Size(131, 22);
            this.mnu_addComplexEntity.Text = "موجود مرکب";
            // 
            // btn_removeState
            // 
            this.btn_removeState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_removeState.Enabled = false;
            this.btn_removeState.Image = ((System.Drawing.Image)(resources.GetObject("btn_removeState.Image")));
            this.btn_removeState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_removeState.Name = "btn_removeState";
            this.btn_removeState.Size = new System.Drawing.Size(36, 36);
            this.btn_removeState.Text = "حذف وضعیت";
            // 
            // membersGallery
            // 
            this.membersGallery.BackColor = System.Drawing.Color.DimGray;
            this.membersGallery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.membersGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersGallery.ForeColor = System.Drawing.Color.Gainsboro;
            this.membersGallery.GridLines = true;
            this.membersGallery.Location = new System.Drawing.Point(0, 39);
            this.membersGallery.MultiSelect = false;
            this.membersGallery.Name = "membersGallery";
            this.membersGallery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.membersGallery.Size = new System.Drawing.Size(230, 351);
            this.membersGallery.TabIndex = 4;
            this.membersGallery.UseCompatibleStateImageBehavior = false;
            this.membersGallery.MouseDown += new System.Windows.Forms.MouseEventHandler(this.membersGallery_MouseDown);
            // 
            // S33LibraryBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.membersGallery);
            this.Controls.Add(this.toolStrip3);
            this.Name = "S33LibraryBrowser";
            this.Size = new System.Drawing.Size(230, 390);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btn_removeState;
        private System.Windows.Forms.ToolStripDropDownButton btn_newState;
        private System.Windows.Forms.ToolStripMenuItem mnu_addSprite;
        private System.Windows.Forms.ToolStripMenuItem mnu_addComplexEntity;
        private System.Windows.Forms.ListView membersGallery;
    }
}
