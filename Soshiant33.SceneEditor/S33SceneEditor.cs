using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace Soshiant33.SceneEditor
{
    public partial class S33SceneEditor : UserControl
    {
        Scene scene;
        ScenePattern scenePattern;
        static uint scenesCounter = 0;
        static uint sceneChildsCounter = 0;
        static EntityParameters ep = new EntityParameters(IntPtr.Zero);
        public event EventHandler OnTurnedOn;
        bool mouseIsDown = false;
        Keys currentKey = Keys.None;
        //Keys currentControlKey = Keys.None;
        
        public S33SceneEditor()
        {
            InitializeComponent();
        }
        public void TurnOn()
        {
            this.s33Panel1.engine.OnTurnedOn += this.Init;
            this.s33Panel1.engine.TurnOn();
        }
        public void TurnOff()
        {
            this.s33Panel1.engine.TurnOff();
        }
        delegate void InitDelegate();
        void Init(object sender,EventArgs args)
        {
            if (this.InvokeRequired)
                this.Invoke(new InitDelegate(_Init));
            else
                _Init();
        }
        void _Init()
        {
            this.btn_clear_Click(null, null);
            this.s33Panel1.engine.camera.Fly(250);
            this.s33Panel1.engine.camera.Pitch(0.4f);
            this.s33Panel1.engine.camera.Walk(220);
            ///~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            this.s33Panel1.engine.Resize(this.s33Panel1.Width, this.s33Panel1.Height);
            this.splitContainer2.SplitterDistance = 200;
            if (this.OnTurnedOn != null)
                this.OnTurnedOn(this, null);
        }
        private void s33Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseIsDown = false;
        }
        private void splitContainer1_SizeChanged(object sender, EventArgs e)
        {
            this.splitContainer1.SplitterDistance = 200;
        }
        private void S33SceneEditor_Load(object sender, EventArgs e)
        {
            //this.TurnOn();
        }
        private void s33Panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            if (e.Data.GetDataPresent(typeof(SpritePattern)) && !mouseIsDown)
            {
                SpritePattern pattern = (SpritePattern)e.Data.GetData(typeof(SpritePattern));
                ep.نام = pattern.نام + "_" + sceneChildsCounter++.ToString();
                SelectEntity(this.scene.AddChild(pattern, ep));
                mouseIsDown = true;
                new Thread(this.TransformChild).Start();
            }
        }
        void TransformChild()
        {
            Point basePosition = Cursor.Position;
            while (mouseIsDown)
            {
                switch (this.currentKey)
                {
                    case Keys.X:
                        this.selectedEntity.مولفه_ها.موقعیت.x += (Cursor.Position.X - basePosition.X)/99999.0f;
                        break;
                    case Keys.Z:
                        this.selectedEntity.مولفه_ها.موقعیت.z += (Cursor.Position.X - basePosition.X) / 99999.0f;
                        break;
                    case Keys.Y:
                        this.selectedEntity.مولفه_ها.موقعیت.y += (Cursor.Position.Y - basePosition.Y) / 99999.0f;
                        break;
                }
                //if (Cursor.Position.Y == Screen.PrimaryScreen.Bounds.Height - 1)
                //    Cursor.Position = new Point(Cursor.Position.X, 0);
                //if (Cursor.Position.Y == 0)
                //    Cursor.Position = new Point(Cursor.Position.X, Screen.PrimaryScreen.Bounds.Height);
                //if (Cursor.Position.X == Screen.PrimaryScreen.Bounds.Width - 1)
                //    Cursor.Position = new Point(0, Cursor.Position.Y);
                //if (Cursor.Position.X == 0)
                //    Cursor.Position = new Point(Screen.PrimaryScreen.Bounds.Width, Cursor.Position.Y);
                //basePosition = Cursor.Position;

            }
            this.scene.SortChildsByDepth();
            System.Threading.Thread.Sleep(1);
        }

        private void s33Panel1_DragDrop(object sender, DragEventArgs e)
        {
            mouseIsDown = false;
        }

        private void s33Panel1_DragLeave(object sender, EventArgs e)
        {
            s33Panel1_DragDrop(null, null);
        }
        private void s33Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseIsDown = true;
            if (this.scene != null)
                if (e.Button == MouseButtons.Left)
                {
                    this.SelectEntity(this.scene.Pick(e.Location));
                    if(this.selectedEntity != null)
                        new Thread(this.TransformChild).Start();
                }
        }

        private void s33Panel1_KeyDown(object sender, KeyEventArgs e)
        {
            this.currentKey = e.KeyCode;
        }

        private void s33Panel1_KeyUp(object sender, KeyEventArgs e)
        {
            this.currentKey = Keys.None;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.basePlane.مولفه_ها.قابل_دیدن = !this.basePlane.مولفه_ها.قابل_دیدن;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.scene != null)
                this.scene.SaveAsScenePattern(Application.StartupPath + "\\Ptrn\\" + this.scene.مولفه_ها.نام + ".sen");
        }

        private void btn_exe_Click(object sender, EventArgs e)
        {
            if (this.scene != null)
            {
                this.basePlane.مولفه_ها.قابل_دیدن = false;
                this.SelectEntity(null);
                this.scene.SaveAsScenePattern(Application.StartupPath + "\\Ptrn\\" + this.scene.مولفه_ها.نام + ".sen");
                this.basePlane.مولفه_ها.قابل_دیدن = true ;
                GamePad pad = new GamePad(this.scene.مولفه_ها.نام + ".sen");
                pad.ShowDialog();
            }
        }
    }
}
