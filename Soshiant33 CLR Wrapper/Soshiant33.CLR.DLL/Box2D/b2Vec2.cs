using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Soshiant33.Box2D
{
    [TypeConverter(typeof(b2Vec2Converter))]
    public class b2Vec2 : NativeObject
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2Vec2_New();
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2Vec2_GetX(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2Vec2_GetY(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Vec2_SetX(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Vec2_SetY(IntPtr pointer, float value);

        public b2Vec2(IntPtr pointer)
            : base(pointer)
        {
            if (pointer == IntPtr.Zero || pointer == null)
            {
                this.pointer = b2Vec2_New();
                this.x = 0;
                this.y = 0;
            }
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("مشخصات")]
        public float x
        {
            get { return b2Vec2_GetX(this.pointer); }
            set { b2Vec2_SetX(this.pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public float y
        {
            get { return b2Vec2_GetY(this.pointer); }
            set { b2Vec2_SetY(this.pointer, value); }
        }
        #endregion
    }
    internal class b2Vec2Converter : ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context,
                             System.Globalization.CultureInfo culture,
                             object value, Type destType)
        {
            if (destType == typeof(string) && value is b2Vec2)
            {
                b2Vec2 v = (b2Vec2)value;
                return v.x + ";" + v.y;
            }
            return base.ConvertTo(context, culture, value, destType);
        }
    }
}
