using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soshiant33.SceneEditor
{
    public partial class S33SceneEditor
    {
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
        Sprite basePlane = null;
        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.scenePattern = Library.GetScenePattern("ScenePattern_" + scenesCounter++.ToString()) ;//new ScenePattern("ScenePattern_" + scenesCounter++.ToString());
            this.scene = (Scene)this.s33Panel1.engine.AddChild(this.scenePattern, null);
            this.scene.رنگ_زمینه = this.BackColor;
            this.scene.Pause();
            //base Plane
            SpritePattern plane = new SpritePattern("Plane Pattern");
            SpriteState state = plane.AddNewState("st0");
            state.صورت = "basePlane.x";
            state.AddNewKeyFrame(0);
            basePlane = (Sprite)this.scene.AddChild(plane, null);
            basePlane.مولفه_ها.موقعیت.z = 1000;
            s33Panel1_MouseUp(null, null);
        }

    }
}
