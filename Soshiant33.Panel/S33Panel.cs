using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace Soshiant33.Panel
{
    public partial class S33Panel : UserControl
    {
        int xMouse = 0;
        int yMouse = 0;
        bool mouseDownFlag = false;
        public Engine engine = null;
        Keys key = Keys.None;

        public S33Panel()
        {
            InitializeComponent();
            engine = new Engine(this);
        }
        private void Panel_MouseWeel(object sender, MouseEventArgs e)
        {
            engine.camera.Walk(e.Delta / 6.0f);
        }
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            new Thread(new ParameterizedThreadStart(MouseDraging)).Start(e);
        }
        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseDownFlag = false;
        }
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            xMouse = e.X;
            yMouse = e.Y;
        }
        void MouseDraging(object e)
        {
            this.mouseDownFlag = true;
            int mx = ((MouseEventArgs)e).X;
            int my = ((MouseEventArgs)e).Y;
            if (((MouseEventArgs)e).Button == MouseButtons.Middle)
            {
                while (this.mouseDownFlag)
                {
                    switch (key)
                    {
                        case Keys.None:
                            this.engine.camera.Strafe((mx - xMouse) / 1.0f);
                            this.engine.camera.Fly((yMouse - my) / 1.0f);
                            break;
                        case Keys.ControlKey:
                            this.engine.camera.Pitch((yMouse - my) / 200.0f);
                            this.engine.camera.Yaw((mx - xMouse) / -200.0f);
                            break;
                    }
                    mx = xMouse;
                    my = yMouse;
                    Thread.Sleep(7);
                }
            }
        }
        private void Panel_SizeChanged(object sender, EventArgs e)
        {
            this.engine.Resize(this.Width, this.Height);
        }
        private void Panel_KeyDown(object sender, KeyEventArgs e)
        {
            this.key = e.KeyCode;
        }
        private void Panel_KeyUp(object sender, KeyEventArgs e)
        {
            this.key = Keys.None;
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            //this.engine.TurnOn(null); 
        }

        private void اورتوگرافیToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (اورتوگرافیToolStripMenuItem.Checked)
            {
                this.پرسپکتیوToolStripMenuItem.Checked = false;
                this.engine.camera.نوع_تابش = Camera.ProjectionTypes.ارتوگرافیک;
                this.engine.SetFillMode(FillMode.Wireframe);
            }
        }

        private void پرسپکتیوToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (پرسپکتیوToolStripMenuItem.Checked)
            {
                this.اورتوگرافیToolStripMenuItem.Checked = false;
                this.engine.camera.نوع_تابش = Camera.ProjectionTypes.پرسپکتیو;
                this.engine.SetFillMode(FillMode.Solid);
            }
        }
    }
}
