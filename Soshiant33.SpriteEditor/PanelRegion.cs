using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Soshiant33.SpriteEditor
{
    public partial class S33SpriteEditor
    {
        private void btn_sceneColor_Click(object sender, EventArgs e)
        {
            if (this.scene != null)
            {
                ColorDialog colorPicker = new ColorDialog();
                colorPicker.Color = this.scene.رنگ_زمینه;
                if (colorPicker.ShowDialog() == DialogResult.OK)
                {
                    this.scene.رنگ_زمینه = colorPicker.Color;
                }
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (this.spritePattern != null)
            {
                if (MessageBox.Show("مطمئنی می خوای همه چیز نابود بشه ؟", "اخطار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.timeline.Items.Clear();
                    this.statesGallery.Items.Clear();
                    if (this.sprite != null)
                        this.sprite.Release();
                    this.spritePattern = new SpritePattern("SpritePatern" + patternCounter++.ToString());

                    this.sprite = (Sprite)this.scene.AddChild(this.spritePattern, null);
                    statesCounter = 0;
                    engine_MouseUp(null, null);
                }
            }
        }
        private void btn_playPouse_Click(object sender, EventArgs e)
        {
            if (this.scene.IsPaused())
            {
                this.scene.Play();
                this.btn_playPouse.Image = global::Soshiant33.Properties.Resources.pause;
            }
            else
            {
                this.scene.Pause();
                this.btn_playPouse.Image = global::Soshiant33.Properties.Resources.play;
            }
        }
        private void btn_physicalShape_Click(object sender, EventArgs e)
        {
            bool flag = true;

            //if (this.spritePattern.وضعیتها[this.sprite.currentState].timeline.Count > 0)
            //{
                PhysicalShapeEditor editor = new PhysicalShapeEditor(new Rect(IntPtr.Zero));
                editor.ShowDialog();
                if (editor.ok)
                {
                    this.spritePattern.بستها.Add(editor.fixtureDef);
                    this.sprite.تنه.CreateFixture(editor.fixtureDef);
                }
                flag = false;
            //}
            //else
            //    foreach (SpriteState state in this.spritePattern.وضعیتها)
            //    {
            //        if (state.timeline.Count > 0)
            //        {
            //            //PhysicalShapeEditor editor = new PhysicalShapeEditor(state.GetFrameRect(1));
            //            //editor.ShowDialog();
            //            //if (editor.ok)
            //            //{
            //            //    this.spritePattern.بستها.Add(editor.fixtureDef);
            //            //    this.sprite.تنه.CreateFixture(editor.fixtureDef);
            //            //}
            //            //flag = false;
            //            //break;
            //        }
            //    }
            //if (flag)
            //{
            //    MessageBox.Show("ابتدا به یکی از وضعیت ها یک قاب اضاف کنید", "توجه", MessageBoxButtons.OK);
            //}
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.spritePattern.Save(Application.StartupPath+"\\Ptrn\\" + spritePattern.نام+".sprt");
        }
    }
}
