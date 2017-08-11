using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Nevron.UI.WinForm.Controls;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Soshiant33
{
    public class KeyFrame : NativeObject
    {
        [DllImport("Soshiant33.Native.dll", CharSet = CharSet.Ansi)]
        static extern string KeyFrame_GetActionFuncName(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void KeyFrame_SetActionFuncName(IntPtr pointer,char[] value);
        [DllImport("Soshiant33.Native.dll")]
        static extern int KeyFrame_GetSubsetIndex(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void KeyFrame_SetSubsetIndex(IntPtr pointer,int value);
        [DllImport("Soshiant33.Native.dll")]
        static extern int KeyFrame_GetHasAction(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void KeyFrame_SetHasAction(IntPtr pointer, bool value);

        //public string actionFuncName;
        //public int subsetIndex;
        public bool hasAction;
        public NGalleryItem avatar;

        public KeyFrame(IntPtr pointer)
            :base(pointer)
        {

            this.avatar = new NGalleryItem();
            this.avatar.Label.ImageSize = new Nevron.GraphicsCore.NSize(32, 32);
            this.avatar.Label.Text = this.شناسه_زیرمجموعه.ToString();// +" قاب ";
            this.avatar.Label.ImageTextRelation = Nevron.UI.ImageTextRelation.ImageAboveText;
            this.avatar.Label.Image = global::Soshiant33.Properties.Resources.keyFrame;
        }

        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("نام تابع قاب"), DescriptionAttribute("هنگام ورود به قاب این تابع از اسکریپت های موجود صدا زده می شود .")]
        public string نام_تابع_قاب
        {
            get
            {
                return KeyFrame_GetActionFuncName(this.pointer);
            }
            set
            {
                KeyFrame_SetActionFuncName(this.pointer, value.ToCharArray());
            }
        }

        [CategoryAttribute("دستور دارد ؟"), DescriptionAttribute("برای قاب دستوری وجود دارد؟")]
        public bool دستور_دارد
        {
            get
            {
                if (KeyFrame_GetHasAction(this.pointer) == 0)
                    return false;
                else
                    return true;
            }
            set
            {
                //this.hasAction = value;
                KeyFrame_SetHasAction(pointer, value);
                if (value)
                {
                    this.avatar.Label.Image = global::Soshiant33.Properties.Resources.keyFrame_action;
                }
                else
                {
                    this.avatar.Label.Image = global::Soshiant33.Properties.Resources.keyFrame;
                }
            }
        }

        [CategoryAttribute("شناسه زیرمجموعه"), DescriptionAttribute("شناسه زیر مجموعه گرافیکی از صورت)گرافیک( وضعیت.")]
        public int شناسه_زیرمجموعه
        {
            get
            {
                return KeyFrame_GetSubsetIndex(pointer);
            }
            set
            {
                KeyFrame_SetSubsetIndex(pointer, value);
            }
        }
        #endregion
    }
}
