using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

namespace Soshiant33.SceneEditor
{
    public partial class S33SceneEditor
    {
        Entity selectedEntity = null;
        Color selectedEntityColor = Color.White;

        void SelectEntity(Entity value)
        {
            if (selectedEntity != null)
            {
                if (selectedEntity.مولفه_ها.رنگ.ToArgb() == Color.FromArgb(128, 128, 255).ToArgb())
                    selectedEntity.مولفه_ها.رنگ = selectedEntityColor;
                selectedEntity = null;
            }
            this.selectedEntity = value;
            if (value != null)
            {
                selectedEntityColor = value.مولفه_ها.رنگ;
                value.مولفه_ها.رنگ = Color.FromArgb(128, 128, 255);
                if (value.GetNativPointer() == this.basePlane.GetNativPointer())
                    value = this.scene;
                this.lbl_selectedObject.Text = "[" + value.مولفه_ها.نام + "]";
            }
            else
                this.lbl_selectedObject.Text = "[ - ]";
            this.propertyGrid.SelectedObject = value;
        }
    }
}
