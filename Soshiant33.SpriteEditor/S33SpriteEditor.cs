using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Threading;

namespace Soshiant33.SpriteEditor
{
    //public delegate void JobFinished();
    public partial class S33SpriteEditor : UserControl
    {
        static uint statesCounter = 0;
        static uint patternCounter = 0;
        Scene scene = null;
        ScenePattern scenePattern = null;
        Sprite sprite = null;
        public SpritePattern spritePattern = null;
        //JobFinished callback = null;
        public event EventHandler OnTurnedOn;

        public S33SpriteEditor()
        {
            InitializeComponent();
        }
        public void TurnOn()
        {
            this.soshiant33Panel.engine.OnTurnedOn += this.Init;
            this.soshiant33Panel.engine.TurnOn();
        }
        public void TurnOff()
        {
            this.soshiant33Panel.engine.TurnOff();
        }
        private void SpriteEditor_Load(object sender, EventArgs e)
        {
            this.TurnOn();
        }
        //delegate void InitDelegate();
        //void Init()
        //{
        //    if (this.InvokeRequired)
        //        this.Invoke(new InitDelegate(_Init));
        //    else
        //        _Init();
        //}
        void Init(object sender,EventArgs args)
        {
            this.scenePattern = Library.GetScenePattern("snptrn0");//new ScenePattern("ScenePattern");
            this.scene = (Scene)this.soshiant33Panel.engine.AddChild(this.scenePattern, null);
            this.scene.رنگ_زمینه = this.BackColor;
            this.scene.Pause();
            //base Plane
            SpritePattern plane = new SpritePattern("Plane Pattern");
            SpriteState state = plane.AddNewState("st0");
            state.صورت = "basePlane.x";
            state.AddNewKeyFrame(0);
            Sprite basePlane = (Sprite)scene.AddChild(plane, null);
            basePlane.مولفه_ها.موقعیت.z = 1000;
            //Target Sprite
            this.spritePattern = new SpritePattern("SpritePatern" + patternCounter++.ToString());
            this.sprite = (Sprite)this.scene.AddChild(this.spritePattern, null);

            this.soshiant33Panel.engine.camera.Fly(250);
            this.soshiant33Panel.engine.camera.Pitch(0.4f);
            this.soshiant33Panel.engine.camera.Walk(220);
            this.soshiant33Panel.engine.Resize(this.soshiant33Panel.Width, this.soshiant33Panel.Height);
            //this.splitContainer2.SplitterDistance = 200;
            if(this.OnTurnedOn !=null)
                this.OnTurnedOn(this, null);
        }
        private void engine_MouseUp(object sender, MouseEventArgs e)
        {
            this.propertyGrid.SelectedObject = this.spritePattern;
            this.lbl_selectedObject.Text = "[" + this.spritePattern.نام + "]";
        }
        private void splitContainer2_SizeChanged(object sender, EventArgs e)
        {
            this.splitContainer2.SplitterDistance = 200;
        }
    }
}
