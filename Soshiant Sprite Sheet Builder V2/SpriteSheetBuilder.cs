using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Nevron.UI.WinForm.Controls;

namespace Soshiant_Sprite_Sheet_Builder
{
    public partial class SpriteSheetBuilder : NForm
    {
        List<Frame> frames = null;
        Frame selectedFrame = null;
        public SpriteSheetBuilder()
        {
            InitializeComponent();
            InitDirect3D();
            frames = new List<Frame>();
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseWeel); 
        }
        private void btn_addFrames_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    Frame frame = new Frame(filename);
                    frames.Add(frame);
                    selectedFrame = frames[0];
                    this.timeline.Items.Add(frame.avatar);
                    this.Update();
                    btn_removeFrames.Enabled = true;
                    btn_save.Enabled = true;
                    toolStripStatusLabel1.Text = "نقطه مرکز قاب [" + selectedFrame.centerPoint.X.ToString() + "," + selectedFrame.centerPoint.Y.ToString() + "]";
                }
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            this.Render();
        }

        int xMouse = 0;
        int yMouse = 0;
        private void splitContainer1_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            xMouse = e.X;
            yMouse = e.Y;
        }

        bool mouseIsDown = false;
        private void splitContainer1_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(MouseDraging)).Start(e);
        }
        void MouseDraging(object e)
        {
            this.mouseIsDown = true;
            int mx = ((MouseEventArgs)e).X;
            int my = ((MouseEventArgs)e).Y;
            if (((MouseEventArgs)e).Button == MouseButtons.Left)
            {
                if (selectedFrame != null)
                {
                    centerPointTextureColor = Color.White;
                    while (this.mouseIsDown)
                    {
                        selectedFrame.centerPoint.X += (float)(mx - xMouse);
                        selectedFrame.centerPoint.Y += (float)(my - yMouse);
                        mx = xMouse;
                        my = yMouse;
                        centerPointTextureRotation += 0.08f;
                        System.Threading.Thread.Sleep(7);
                    }
                    centerPointTextureColor = Color.Red;
                }
            }
        }

        private void splitContainer1_Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void timeline_ItemSelectionChanged(object sender, NGalleryItemSelectionChangedEventArgs e)
        {
            selectedFrame = frames[e.Item.Index];
            Render();
            timeline.Update();
            //toolStripStatusLabel1.Text = "نقطه مرکز قاب [" + selectedFrame.centerPoint.X.ToString() + "," + selectedFrame.centerPoint.Y.ToString() + "]";
        }

        private void btn_removeFrames_Click(object sender, EventArgs e)
        {
            if (timeline.SelectedItems != null)
            {
                frames.RemoveAt(timeline.SelectedItems[0].Index);
                timeline.Items.RemoveAt(timeline.SelectedItems[0].Index);
                if (frames.Count > 0)
                    selectedFrame = frames[0];
                else
                {
                    btn_removeFrames.Enabled = false;
                    btn_save.Enabled = false;
                    selectedFrame = null;
                }

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (btn_save.Enabled)
                if (MessageBox.Show("مطمئنی می خوای همه چیز نابود بشه ؟", "اخطار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.timeline.Items.Clear();
                    this.frames.Clear();
                    btn_removeFrames.Enabled = false;
                    btn_save.Enabled = false;
                    selectedFrame = null;
                }
        }
        private void Panel_MouseWeel(object sender, MouseEventArgs e)
        {
            world_scale.X += e.Delta / 2000.0f;
            world_scale.Y += e.Delta / 2000.0f;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                SaveTexture(saveFileDialog1.FileName);
        }        
    }
}