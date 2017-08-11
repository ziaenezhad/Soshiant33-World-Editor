using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Soshiant33.Box2D
{
    [TypeConverter(typeof(b2ShapeConverter))]
    public abstract class b2Shape : NativeObject
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern b2Shape.Type b2Shape_GetType(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Shape_SetType(IntPtr pointer, b2Shape.Type value);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2Shape_GetRadius(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Shape_SetRadius(IntPtr pointer, float value);
        
        public enum Type
        {
            ناشناس = -1,
            دایره = 0,
            چندظلعی = 1,
        }
        public b2Shape(IntPtr pointer)
            : base(pointer) { }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("مشخصات")]
        public float شعاع
        {
            get { return b2Shape_GetRadius(this.pointer); }
            set { b2Shape_SetRadius(this.pointer, value); }
        }
        [Browsable(false)]
        public Type نوع
        {
            get { return b2Shape_GetType(this.pointer); }
            //set { b2Shape_SetType(this.pointer, value); }
        }
        #endregion
    }
    internal class b2ShapeConverter : ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context,
                             System.Globalization.CultureInfo culture,
                             object value, Type destType)
        {
            b2Shape v = (b2Shape)value;
            return v.نوع.ToString();
        }
    }
}
