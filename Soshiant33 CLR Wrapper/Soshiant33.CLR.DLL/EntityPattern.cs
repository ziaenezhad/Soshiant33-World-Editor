using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace Soshiant33
{
    public abstract class EntityPattern : NativeObject
    {
        public enum Types : byte
        {
            Type_EntityPattern = 0,
            Type_SpritePattern = 1,
            Type_ComplexEntityPattern = 2,
            Type_ScenePattern = 3
        };
        [DllImport("Soshiant33.Native.dll")]
        static extern void EntityPattern_SetName(IntPtr pointer, char[] name);
        [DllImport("Soshiant33.Native.dll", CharSet = CharSet.Ansi)]
        static extern string EntityPattern_GetName(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void EntityPattern_SetType(IntPtr pointer, EntityPattern.Types type);
        [DllImport("Soshiant33.Native.dll")]
        static extern Types EntityPattern_GetType(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void EntityPattern_SetScript(IntPtr pointer, char[] value);
        [DllImport("Soshiant33.Native.dll", CharSet = CharSet.Ansi)]
        static extern string EntityPattern_GetScript(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void EntityPattern_Save(IntPtr pointer, char[] filename);


        public ListViewItem avatar;
        public static ImageList imageList = new ImageList();
        public EntityPattern(IntPtr pointer)
            : base(pointer)
        {
            //MessageBox.Show("NativeObject");
            this.type = Types.Type_EntityPattern;
            //if (imageList.Images.Count == 0)
            //{
            //    imageList.ImageSize = new Size(64, 64);
            //    imageList.ColorDepth = ColorDepth.Depth32Bit;

            //    imageList.Images.Add(global::Soshiant33.Properties.Resources.Sprite);
            //    imageList.Images.Add(global::Soshiant33.Properties.Resources.ComplexEntity);
            //    imageList.Images.Add(global::Soshiant33.Properties.Resources.Scene);
            //}

            //this.avatar = new ListViewItem();
            //this.avatar.Text = this.نام;
        }
        public void Save(string filename)
        {
            EntityPattern_Save(pointer, filename.ToCharArray());
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("مشخصات"), DescriptionAttribute("با استفاده از این نام می توانید در دستورات از این الگو نمونه سازی کنید .")]
        public string نام
        {
            get { return EntityPattern_GetName(this.pointer); }
            set { EntityPattern_SetName(this.pointer, value.ToCharArray()); }
        }
        [Browsable(false)]
        public EntityPattern.Types type
        {
            get { return EntityPattern_GetType(this.pointer); }
            set { EntityPattern_SetType(this.pointer, value); }
        }
        [Browsable(false)]
        public string دستورات
        {
            get { return EntityPattern_GetScript(this.pointer); }
            set { EntityPattern_SetScript(this.pointer, value.ToCharArray()); }
        }
        #endregion


    }
}
