namespace Soshiant33.SpriteEditor
{
    partial class S33SpriteEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S33SpriteEditor));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.statesGallery = new Nevron.UI.WinForm.Controls.NGalleryPanel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_newState = new System.Windows.Forms.ToolStripButton();
            this.btn_removeState = new System.Windows.Forms.ToolStripButton();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_selectedObject = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.soshiant33Panel = new Soshiant33.Panel.S33Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_clear = new System.Windows.Forms.ToolStripButton();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_physicalShape = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_sceneColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_playPouse = new System.Windows.Forms.ToolStripButton();
            this.nTabControl3 = new Nevron.UI.WinForm.Controls.NTabControl();
            this.tab_TimeLine = new Nevron.UI.WinForm.Controls.NTabPage();
            this.timeline = new Nevron.UI.WinForm.Controls.NGalleryPanel();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.btn_addFrames = new System.Windows.Forms.ToolStripButton();
            this.btn_removeFrames = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_swapFrameR = new System.Windows.Forms.ToolStripButton();
            this.btn_swapFrameL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_frameScrip = new System.Windows.Forms.ToolStripButton();
            this.tab_ActionEditor = new Nevron.UI.WinForm.Controls.NTabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openMeshFile = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesGallery)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.nTabControl3.SuspendLayout();
            this.tab_TimeLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeline)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(800, 600);
            this.splitContainer2.SplitterDistance = 194;
            this.splitContainer2.TabIndex = 2;
            this.splitContainer2.SizeChanged += new System.EventHandler(this.splitContainer2_SizeChanged);
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
            this.splitContainer3.Panel1.Controls.Add(this.statesGallery);
            this.splitContainer3.Panel1.Controls.Add(this.toolStrip3);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.propertyGrid);
            this.splitContainer3.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer3.Size = new System.Drawing.Size(194, 600);
            this.splitContainer3.SplitterDistance = 296;
            this.splitContainer3.TabIndex = 0;
            // 
            // statesGallery
            // 
            this.statesGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statesGallery.FillInfo.FillStyle = Nevron.UI.WinForm.Controls.FillStyle.Gradient;
            this.statesGallery.FillInfo.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.statesGallery.FillInfo.HatchStyle = System.Drawing.Drawing2D.HatchStyle.SolidDiamond;
            this.statesGallery.ItemLayout = Nevron.UI.WinForm.Controls.GalleryPanelLayout.VerticalStack;
            this.statesGallery.ItemSize = new Nevron.GraphicsCore.NSize(64, 64);
            this.statesGallery.Location = new System.Drawing.Point(0, 39);
            this.statesGallery.Name = "statesGallery";
            this.statesGallery.Palette.ControlLight = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.statesGallery.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Longhorn;
            this.statesGallery.ShadowInfo.Draw = false;
            this.statesGallery.ShowFocusRect = false;
            this.statesGallery.Size = new System.Drawing.Size(192, 255);
            this.statesGallery.StrokeInfo.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statesGallery.StrokeInfo.Gradient2 = System.Drawing.Color.Black;
            this.statesGallery.StrokeInfo.Rounding = 5;
            this.statesGallery.StrokeInfo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.statesGallery.TabIndex = 2;
            this.statesGallery.Text = "nGalleryPanel1";
            this.statesGallery.ItemClick += new Nevron.UI.WinForm.Controls.NGalleryItemEventHandler(this.statesGallery_ItemClick);
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.Silver;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripSeparator8,
            this.btn_newState,
            this.btn_removeState});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip3.Size = new System.Drawing.Size(192, 39);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.Black;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(55, 36);
            this.toolStripLabel2.Text = "وضعیت ها";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_newState
            // 
            this.btn_newState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_newState.Image = ((System.Drawing.Image)(resources.GetObject("btn_newState.Image")));
            this.btn_newState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_newState.Name = "btn_newState";
            this.btn_newState.Size = new System.Drawing.Size(36, 36);
            this.btn_newState.Text = "وضعیت جدید";
            this.btn_newState.Click += new System.EventHandler(this.btn_newState_Click);
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
            this.btn_removeState.Click += new System.EventHandler(this.btn_removeState_Click);
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
            this.propertyGrid.Size = new System.Drawing.Size(192, 273);
            this.propertyGrid.TabIndex = 1;
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
            this.toolStrip2.Size = new System.Drawing.Size(192, 25);
            this.toolStrip2.TabIndex = 0;
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
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.soshiant33Panel);
            this.splitContainer4.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.nTabControl3);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer4.Size = new System.Drawing.Size(602, 600);
            this.splitContainer4.SplitterDistance = 464;
            this.splitContainer4.TabIndex = 0;
            // 
            // soshiant33Panel
            // 
            this.soshiant33Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soshiant33Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soshiant33Panel.Location = new System.Drawing.Point(0, 39);
            this.soshiant33Panel.Name = "soshiant33Panel";
            this.soshiant33Panel.Size = new System.Drawing.Size(600, 423);
            this.soshiant33Panel.TabIndex = 1;
            this.soshiant33Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.engine_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_clear,
            this.btn_save,
            this.toolStripSeparator1,
            this.btn_physicalShape,
            this.toolStripSeparator2,
            this.btn_sceneColor,
            this.toolStripSeparator3,
            this.btn_playPouse});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(600, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_clear
            // 
            this.btn_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(36, 36);
            this.btn_clear.Text = "موجود جدید خالی";
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
            // btn_physicalShape
            // 
            this.btn_physicalShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_physicalShape.Image = ((System.Drawing.Image)(resources.GetObject("btn_physicalShape.Image")));
            this.btn_physicalShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_physicalShape.Name = "btn_physicalShape";
            this.btn_physicalShape.Size = new System.Drawing.Size(36, 36);
            this.btn_physicalShape.Text = "شکل فیزیکی";
            this.btn_physicalShape.Click += new System.EventHandler(this.btn_physicalShape_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_sceneColor
            // 
            this.btn_sceneColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_sceneColor.Image = ((System.Drawing.Image)(resources.GetObject("btn_sceneColor.Image")));
            this.btn_sceneColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_sceneColor.Name = "btn_sceneColor";
            this.btn_sceneColor.Size = new System.Drawing.Size(36, 36);
            this.btn_sceneColor.Text = "رنگ زمینه صحنه";
            this.btn_sceneColor.Click += new System.EventHandler(this.btn_sceneColor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
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
            // nTabControl3
            // 
            this.nTabControl3.Controls.Add(this.tab_TimeLine);
            this.nTabControl3.Controls.Add(this.tab_ActionEditor);
            this.nTabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nTabControl3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nTabControl3.Location = new System.Drawing.Point(0, 0);
            this.nTabControl3.Margin = new System.Windows.Forms.Padding(0);
            this.nTabControl3.Name = "nTabControl3";
            this.nTabControl3.Padding = new System.Windows.Forms.Padding(4, 4, 29, 4);
            this.nTabControl3.Palette.ControlLight = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.nTabControl3.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Longhorn;
            this.nTabControl3.Selectable = true;
            this.nTabControl3.SelectedIndex = 0;
            this.nTabControl3.Size = new System.Drawing.Size(600, 130);
            this.nTabControl3.TabAlign = Nevron.UI.WinForm.Controls.TabAlign.Right;
            this.nTabControl3.TabIndex = 0;
            // 
            // tab_TimeLine
            // 
            this.tab_TimeLine.Controls.Add(this.timeline);
            this.tab_TimeLine.Controls.Add(this.toolStrip4);
            this.tab_TimeLine.Location = new System.Drawing.Point(4, 4);
            this.tab_TimeLine.Margin = new System.Windows.Forms.Padding(0);
            this.tab_TimeLine.Name = "tab_TimeLine";
            this.tab_TimeLine.Size = new System.Drawing.Size(567, 122);
            this.tab_TimeLine.TabIndex = 1;
            this.tab_TimeLine.Text = "نوار زمان";
            // 
            // timeline
            // 
            this.timeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeline.FillInfo.Gradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.timeline.FillInfo.Gradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.timeline.ItemLayout = Nevron.UI.WinForm.Controls.GalleryPanelLayout.HorizontalStack;
            this.timeline.ItemSize = new Nevron.GraphicsCore.NSize(38, 38);
            this.timeline.Location = new System.Drawing.Point(0, 39);
            this.timeline.Name = "timeline";
            this.timeline.Palette.ControlLight = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.timeline.Palette.Scheme = Nevron.UI.WinForm.Controls.ColorScheme.Longhorn;
            this.timeline.ShadowInfo.Draw = false;
            this.timeline.Size = new System.Drawing.Size(567, 83);
            this.timeline.StrokeInfo.Rounding = 5;
            this.timeline.TabIndex = 2;
            this.timeline.Text = "nGalleryPanel1";
            this.timeline.ItemSelectionChanged += new Nevron.UI.WinForm.Controls.NGalleryItemSelectionChangedEventHandler(this.timeline_ItemSelectionChanged);
            this.timeline.ItemClick += new Nevron.UI.WinForm.Controls.NGalleryItemEventHandler(this.timeline_ItemClick);
            // 
            // toolStrip4
            // 
            this.toolStrip4.BackColor = System.Drawing.Color.Silver;
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_addFrames,
            this.btn_removeFrames,
            this.toolStripSeparator6,
            this.btn_swapFrameR,
            this.btn_swapFrameL,
            this.toolStripSeparator7,
            this.btn_frameScrip});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip4.Size = new System.Drawing.Size(567, 39);
            this.toolStrip4.TabIndex = 1;
            this.toolStrip4.Text = "toolStrip4";
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
            // btn_swapFrameR
            // 
            this.btn_swapFrameR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_swapFrameR.Enabled = false;
            this.btn_swapFrameR.Image = ((System.Drawing.Image)(resources.GetObject("btn_swapFrameR.Image")));
            this.btn_swapFrameR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_swapFrameR.Name = "btn_swapFrameR";
            this.btn_swapFrameR.Size = new System.Drawing.Size(36, 36);
            this.btn_swapFrameR.Text = "جابجایی با قاب بعدی";
            this.btn_swapFrameR.Click += new System.EventHandler(this.btn_swapFrameR_Click);
            // 
            // btn_swapFrameL
            // 
            this.btn_swapFrameL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_swapFrameL.Enabled = false;
            this.btn_swapFrameL.Image = ((System.Drawing.Image)(resources.GetObject("btn_swapFrameL.Image")));
            this.btn_swapFrameL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_swapFrameL.Name = "btn_swapFrameL";
            this.btn_swapFrameL.Size = new System.Drawing.Size(36, 36);
            this.btn_swapFrameL.Text = "جابجایی با قاب قبلی";
            this.btn_swapFrameL.Click += new System.EventHandler(this.btn_swapFrameL_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_frameScrip
            // 
            this.btn_frameScrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_frameScrip.Image = ((System.Drawing.Image)(resources.GetObject("btn_frameScrip.Image")));
            this.btn_frameScrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_frameScrip.Name = "btn_frameScrip";
            this.btn_frameScrip.Size = new System.Drawing.Size(36, 36);
            this.btn_frameScrip.Text = "دستورات قاب";
            // 
            // tab_ActionEditor
            // 
            this.tab_ActionEditor.Location = new System.Drawing.Point(4, 4);
            this.tab_ActionEditor.Name = "tab_ActionEditor";
            this.tab_ActionEditor.Size = new System.Drawing.Size(567, 122);
            this.tab_ActionEditor.TabIndex = 2;
            this.tab_ActionEditor.Text = "دستور";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "keyFrame.png");
            // 
            // openMeshFile
            // 
            this.openMeshFile.FileName = "...";
            this.openMeshFile.Filter = "Soshiant Sprite Sheet File  [*.sht]|*.sht|3D Object Mesh File [*.x]|*.x";
            this.openMeshFile.RestoreDirectory = true;
            this.openMeshFile.SupportMultiDottedExtensions = true;
            // 
            // S33SpriteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "S33SpriteEditor";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.SpriteEditor_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statesGallery)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.nTabControl3.ResumeLayout(false);
            this.tab_TimeLine.ResumeLayout(false);
            this.tab_TimeLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeline)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Nevron.UI.WinForm.Controls.NGalleryPanel statesGallery;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btn_newState;
        private System.Windows.Forms.ToolStripButton btn_removeState;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel lbl_selectedObject;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_clear;
        private System.Windows.Forms.ToolStripButton btn_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_physicalShape;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_sceneColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_playPouse;
        private Nevron.UI.WinForm.Controls.NTabControl nTabControl3;
        private Nevron.UI.WinForm.Controls.NTabPage tab_TimeLine;
        private Nevron.UI.WinForm.Controls.NGalleryPanel timeline;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton btn_addFrames;
        private System.Windows.Forms.ToolStripButton btn_removeFrames;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_swapFrameR;
        private System.Windows.Forms.ToolStripButton btn_swapFrameL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btn_frameScrip;
        private Nevron.UI.WinForm.Controls.NTabPage tab_ActionEditor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openMeshFile;
        private Soshiant33.Panel.S33Panel soshiant33Panel;
    }
}
