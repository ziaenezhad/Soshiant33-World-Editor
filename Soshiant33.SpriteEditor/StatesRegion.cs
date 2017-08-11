using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Soshiant33.SpriteEditor
{
    public partial class S33SpriteEditor
    {
        //Add New State BTN
        private void btn_newState_Click(object sender, EventArgs e)
        {
            if (this.spritePattern != null)
            {
                openMeshFile.InitialDirectory = Application.ExecutablePath +"\\Res\\";
                if (openMeshFile.ShowDialog() == DialogResult.OK)
                {
                    SpriteState state = this.spritePattern.AddNewState("State_" + statesCounter++.ToString());
                    this.Cursor = Cursors.WaitCursor;
                    state.صورت = System.IO.Path.GetFileName(openMeshFile.FileName);
                    if (System.IO.Path.GetExtension(openMeshFile.FileName) == ".sht")
                        for (int i = 0; i < state.تعداد_زیرمجموعه_های_صورت; i++)
                            state.AddNewKeyFrame(i);
                    else
                        state.AddNewKeyFrame(-1);
                    this.btn_removeFrames.Enabled = true;
                    this.statesGallery.Items.Add(state.avatar);
                    state.avatar.Selected = true;
                    this.ResetTimeLine(state);
                    this.sprite.currentState = (ushort)(this.spritePattern.وضعیتها.Count - 1);
                    this.propertyGrid.SelectedObject = state;
                    this.lbl_selectedObject.Text = "[" + state.نام + "]";

                    if (this.statesGallery.Items.Count > 1)
                        this.btn_removeState.Enabled = true;
                    this.Cursor = Cursors.Arrow;
                }
            }
        }
        //Remove State BTN
        private void btn_removeState_Click(object sender, EventArgs e)
        {
            if (this.statesGallery.SelectedItems != null && this.spritePattern != null)
            {
                if (MessageBox.Show("مطمئنی می خوای این وضعیت از موجود رو حذف کنی ؟", "اخطار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.timeline.Items.Clear();
                    int index = this.statesGallery.SelectedItems[0].Index;
                    this.statesGallery.Items.RemoveAt(index);
                    this.spritePattern.RemoveState((ushort)index);
                    if (index > 0)
                        this.statesGallery.Items[index - 1].Selected = true;
                    else
                        this.statesGallery.Items[index].Selected = true;
                    ResetTimeLine(null);
                    if (this.statesGallery.Items.Count == 1)
                        this.btn_removeState.Enabled = false;

                    engine_MouseUp(null, null);
                }
            }
        }
        //Selected State Changing
        private void statesGallery_ItemClick(object sender, Nevron.UI.WinForm.Controls.NGalleryItemEventArgs e)
        {
            if (this.spritePattern != null)
            {
                SpriteState state = spritePattern.وضعیتها[e.Item.Index];
                this.sprite.currentState = (ushort)e.Item.Index;

                this.propertyGrid.SelectedObject = state;
                this.lbl_selectedObject.Text = "[" + state.نام + "]";

                this.ResetTimeLine(state);
            }
        }
    }
}
