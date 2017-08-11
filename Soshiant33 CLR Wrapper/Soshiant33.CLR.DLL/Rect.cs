using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Soshiant33
{
    public class Rect : NativeObject
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr Rect_New();
        [DllImport("Soshiant33.Native.dll")]
        static extern int Rect_GetTop(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern int Rect_GetBottom(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern int Rect_GetLeft(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern int Rect_GetRight(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Rect_SetTop(IntPtr pointer, int value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Rect_SetBottom(IntPtr pointer, int value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Rect_SetLeft(IntPtr pointer, int value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Rect_SetRight(IntPtr pointer, int value);

        public Rect(IntPtr pointer)
            : base(pointer)
        {
            if (pointer == IntPtr.Zero)
                this.pointer = Rect_New();
        }
        public int GetHeight()
        {
            return this.پایین - this.بالا;
        }
        public int GetWidth()
        {
            return this.راست - this.چپ;
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("مشخصات")]
        public int بالا
        {
            get { return Rect_GetTop(this.pointer); }
            set { Rect_SetTop(this.pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public int پایین
        {
            get { return Rect_GetBottom(this.pointer); }
            set { Rect_SetBottom(this.pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public int چپ
        {
            get { return Rect_GetLeft(this.pointer); }
            set { Rect_SetLeft(this.pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public int راست
        {
            get { return Rect_GetRight(this.pointer); }
            set { Rect_SetRight(this.pointer, value); }
        }
        #endregion
    }
    internal class RectConverter : ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context,
                             System.Globalization.CultureInfo culture,
                             object value, Type destType)
        {
            if (destType == typeof(string) && value is Rect)
            {
                Rect v = (Rect)value;
                return "مستطیل";
            }
            return base.ConvertTo(context, culture, value, destType);
        }
    }
}
