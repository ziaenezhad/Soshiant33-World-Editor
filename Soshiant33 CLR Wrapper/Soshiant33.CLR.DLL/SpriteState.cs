using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Nevron.UI.WinForm.Controls;

namespace Soshiant33
{
    public class SpriteState : NativeObject
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr SpriteState_AddNewKeyFrame(IntPtr state, int subsetIndex);
        [DllImport("Soshiant33.Native.dll")]
        static extern void SpriteState_RemoveKeyFrame(IntPtr state,ushort index);
        [DllImport("Soshiant33.Native.dll")]
        static extern void SpriteState_SetCurrentFrame(IntPtr state, ushort index);
        [DllImport("Soshiant33.Native.dll")]
        static extern void SpriteState_SetName(IntPtr state, char[] name);
        [DllImport("Soshiant33.Native.dll", CharSet = CharSet.Ansi)]
        static extern string SpriteState_GetName(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void SpriteState_SetGraphic(IntPtr state, char[] name);
        [DllImport("Soshiant33.Native.dll", CharSet = CharSet.Ansi)]
        static extern string SpriteState_GetGraphic(IntPtr pointer);
	    [DllImport("Soshiant33.Native.dll")]
        static extern void SpriteState_SetFPS(IntPtr state,ushort fps);
        [DllImport("Soshiant33.Native.dll")]
        static extern ushort SpriteState_GetGraphicSubsetsCount(IntPtr pointer);


        uint fps;
        string name;
        public NGalleryItem avatar;
        public List<KeyFrame> timeline;
        ushort curreanFrame;



        public SpriteState(string name, IntPtr pointer)
            : base(pointer)
        {
            this.timeline = new List<KeyFrame>();
            this.name = name;
            this.fps = 30;
            this.curreanFrame = 0;
            this.avatar = new NGalleryItem();
            this.avatar.Label.ImageSize = new Nevron.GraphicsCore.NSize(64, 64);
            this.avatar.Label.Text = name;
            this.avatar.Label.ImageTextRelation = Nevron.UI.ImageTextRelation.TextBeforeImage;
            this.avatar.Label.ContentAlign = ContentAlignment.MiddleRight;
            this.avatar.Label.Image = global::Soshiant33.Properties.Resources.Empty_Big;
        }
        public KeyFrame AddNewKeyFrame(int subsetIndex)
        {
            KeyFrame keyFrame = new KeyFrame(SpriteState_AddNewKeyFrame(this.pointer, subsetIndex));
            this.timeline.Add(keyFrame);
            return keyFrame;
        }
        public void RemoveKeyFrame(ushort index)
        {
            this.timeline.RemoveAt(index);
            //for (int i = 0; i < this.timeline.Count; i++)
            //    if (this.timeline[i].شناسه_زیرمجموعه > index)
            //        this.timeline[i].شناسه_زیرمجموعه--;
            SpriteState_RemoveKeyFrame(this.pointer, index);
        }
        public void SetCurrentFrame(ushort index)
        {
            if (index < this.timeline.Count)
            {
                this.curreanFrame = index;
                SpriteState_SetCurrentFrame(this.pointer,index);
            }
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("مشخصات"), DescriptionAttribute("نام وضعیت")]
        public string نام
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                this.avatar.Label.Text = value;

                SpriteState_SetName(this.pointer, this.name.ToCharArray());
            }
        }

        [CategoryAttribute("مشخصات"), DescriptionAttribute("سرعت نمایش پشت سر هم قاب ها به واحد قاب بر ثانیه")]
        public uint نرخ_قاب
        {
            get
            {
                return this.fps;
            }
            set
            {
                this.fps = value;

                SpriteState_SetFPS(this.pointer, (ushort)value);
            }
        }

        [CategoryAttribute("صورت"), DescriptionAttribute("شکل گرافیکی وضعیت ؛ مش یا اسپریت شیت.")]
        public string صورت
        {
            get
            {
                return SpriteState_GetGraphic(this.pointer);
            }
            set
            {
                SpriteState_SetGraphic(this.pointer, value.ToCharArray());
            }
        }

        [CategoryAttribute("تعداد زیر مجموعه های صورت"), DescriptionAttribute("...")]
        public ushort تعداد_زیرمجموعه_های_صورت
        {
            get
            {
                return SpriteState_GetGraphicSubsetsCount(pointer);
            }
        }
        #endregion
    }
}
