using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

using Soshiant33.Box2D;

namespace Soshiant33
{
    public class ScenePattern : ComplexEntityPattern
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr ScenePattern_New();
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr ScenePattern_GetGravity(IntPtr pattern);

        [DllImport("Soshiant33.Native.dll")]
        static extern void ScenePattern_SetDoSleep(IntPtr pattern, bool value);

        [DllImport("Soshiant33.Native.dll")]
        static extern bool ScenePattern_GetDoSleep(IntPtr pattern);

        [DllImport("Soshiant33.Native.dll")]
        static extern void ScenePattern_SetBackColor(IntPtr pattern, int value);

        Color backColor;
        b2Vec2 gravity;

        public ScenePattern(string name)
            : base(ScenePattern_New())
        {
            this.type = Types.Type_ScenePattern;
            //this.gravity = new b2Vec2(ScenePattern_GetGravity(this.pointer));
            //this.avatar.ImageIndex = 2;
            this.نام = name;
        }
        public ScenePattern(IntPtr pointer)
            : base(pointer)
        {
            this.type = Types.Type_ScenePattern;
            if (pointer == IntPtr.Zero)
                MessageBox.Show("ScenePattern(IntPtr.Zero)", "Error");
            this.gravity = new b2Vec2(ScenePattern_GetGravity(this.pointer));
            //this.avatar.ImageIndex = 2;
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("فیزیک"), DescriptionAttribute("گرانش صحنه")]
        public b2Vec2 گرانش
        {
            get { return this.gravity; }
            set { this.gravity = value; }
        }
        [CategoryAttribute("فیزیک"), DescriptionAttribute("اگر شیئی از محدوده کنش های فیزیکی خارج شد به حالت استراحت برود.این باعث افزایش سرعت شبیه سازی می شود.")]
        public bool اجازه_خوابیدن
        {
            get { return ScenePattern_GetDoSleep(this.pointer); }
            set { ScenePattern_SetDoSleep(this.pointer, value); }
        }
        [CategoryAttribute("مشخصات"), DescriptionAttribute("رنگ زمینه صحنه")]
        public Color رنگ_زمینه
        {
            get { return this.backColor; }
            set { this.backColor = value; ScenePattern_SetBackColor(this.pointer, value.ToArgb()); }
        }
        #endregion
    }
}
