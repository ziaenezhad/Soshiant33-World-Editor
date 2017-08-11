using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Nevron.UI.WinForm.Controls;

namespace Soshiant33.SpriteEditor
{
    public partial class S33SpriteEditor
    {
        void ResetTimeLine(SpriteState state)
        {
            if (state == null)
            {
                ResetTimeLine(spritePattern.وضعیتها[statesGallery.SelectedItems[0].Index]);
                return;
            }
            this.timeline.Items.Clear();
            for (int i = 0; i < state.timeline.Count; i++)
            {
                state.timeline[i].avatar.Selected = false;
                state.timeline[i].avatar.Label.Text = i.ToString();
                this.timeline.Items.Add(state.timeline[i].avatar);
                this.Update();
            }
        }
        private void btn_addFrames_Click(object sender, EventArgs e)
        {
            //this.soshiant33Panel.engine.Resize(this.soshiant33Panel.Width, this.soshiant33Panel.Height);
            if (this.spritePattern != null && this.statesGallery.SelectedItems != null)
            {
                KeyFrame keyframe = this.spritePattern.وضعیتها[this.statesGallery.SelectedItems[0].Index].AddNewKeyFrame(-2);
                keyframe.avatar.Label.Text = this.timeline.Items.Count.ToString();
                this.timeline.Items.Add(keyframe.avatar);
                this.btn_removeFrames.Enabled = true;
            }
        }
        private void btn_removeFrames_Click(object sender, EventArgs e)
        {
            if (timeline.SelectedItems != null)
            {
                this.spritePattern.وضعیتها[statesGallery.SelectedItems[0].Index].RemoveKeyFrame((ushort)timeline.SelectedItems[0].Index);
                btn_playPouse_Click(null, null);
                this.timeline.Items.RemoveAt(timeline.SelectedItems[0].Index);
                if (this.timeline.Items.Count == 0)
                    this.btn_removeFrames.Enabled = false;
                ResetTimeLine(this.spritePattern.وضعیتها[statesGallery.SelectedItems[0].Index]);
                engine_MouseUp(null, null);
            }
        }

        private void timeline_ItemClick(object sender, Nevron.UI.WinForm.Controls.NGalleryItemEventArgs e)
        {
            if (!this.scene.IsPaused())
                btn_playPouse_Click(null, null);
            this.spritePattern.وضعیتها[this.statesGallery.SelectedItems[0].Index].SetCurrentFrame((ushort)e.Item.Index);
            if (e.Item.Index == this.timeline.Items.Count - 1)
                btn_swapFrameR.Enabled = false;
            else
                btn_swapFrameR.Enabled = true;
            if (e.Item.Index == 0)
                btn_swapFrameL.Enabled = false;
            else
                btn_swapFrameL.Enabled = true;


            this.propertyGrid.SelectedObject = this.spritePattern.وضعیتها[this.statesGallery.SelectedItems[0].Index].timeline[(ushort)e.Item.Index];
            this.lbl_selectedObject.Text = "[قاب " + e.Item.Index + "]";
        }


        private void timeline_ItemSelectionChanged(object sender, Nevron.UI.WinForm.Controls.NGalleryItemSelectionChangedEventArgs e)
        {
            timeline_ItemClick(sender, e);
        }



        private void btn_swapFrameR_Click(object sender, EventArgs e)
        {
            if (this.timeline.SelectedItems.Length > 0)
            {
                //this.spritePattern.وضعیتها[statesGallery.SelectedItems[0].Index].SwapKeyFrame(this.timeline.SelectedItems[0].Index, this.timeline.SelectedItems[0].Index + 1);

                //int temp = this.timeline.Items[this.timeline.SelectedItems[0].Index].Label.ImageIndex;
                //this.timeline.Items[this.timeline.SelectedItems[0].Index].Label.ImageIndex = this.timeline.Items[this.timeline.SelectedItems[0].Index + 1].Label.ImageIndex;
                //this.timeline.Items[this.timeline.SelectedItems[0].Index + 1].Label.ImageIndex = temp;

            }
        }

        private void btn_swapFrameL_Click(object sender, EventArgs e)
        {
            if (this.timeline.SelectedItems.Length > 0)
            {
                //this.spritePattern.وضعیتها[statesGallery.SelectedItems[0].Index].SwapKeyFrame(this.timeline.SelectedItems[0].Index, this.timeline.SelectedItems[0].Index - 1);

                //int temp = this.timeline.Items[this.timeline.SelectedItems[0].Index].Label.ImageIndex;
                //this.timeline.Items[this.timeline.SelectedItems[0].Index].Label.ImageIndex = this.timeline.Items[this.timeline.SelectedItems[0].Index - 1].Label.ImageIndex;
                //this.timeline.Items[this.timeline.SelectedItems[0].Index - 1].Label.ImageIndex = temp;
            }
        }
    }
}
