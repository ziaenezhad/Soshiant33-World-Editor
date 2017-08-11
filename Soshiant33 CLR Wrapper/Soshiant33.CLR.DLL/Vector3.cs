using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Soshiant33
{
    [TypeConverter(typeof(Vector3Converter))]
    public class Vector3 : NativeObject
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr Vector3_New();

        [DllImport("Soshiant33.Native.dll")]
        static extern float Vector3_GetX(IntPtr pointer);

        [DllImport("Soshiant33.Native.dll")]
        static extern float Vector3_GetY(IntPtr pointer);

        [DllImport("Soshiant33.Native.dll")]
        static extern float Vector3_GetZ(IntPtr pointer);

        [DllImport("Soshiant33.Native.dll")]
        static extern void Vector3_SetX(IntPtr pointer, float value);

        [DllImport("Soshiant33.Native.dll")]
        static extern void Vector3_SetY(IntPtr pointer, float value);

        [DllImport("Soshiant33.Native.dll")]
        static extern void Vector3_SetZ(IntPtr pointer, float value);

        public Vector3(IntPtr pointer)
            : base(pointer) { }
        public Vector3(float x, float y, float z)
            : base(Vector3_New())
        {
            this.Set(x, y, z);
        }
        public void Set(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        public float x
        {
            get { return Vector3_GetX(this.pointer); }
            set { Vector3_SetX(this.pointer, value); }
        }
        public float y
        {
            get { return Vector3_GetY(this.pointer); }
            set { Vector3_SetY(this.pointer, value); }
        }
        public float z
        {
            get { return Vector3_GetZ(this.pointer); }
            set { Vector3_SetZ(this.pointer, value); }
        }
        #endregion
    }
    internal class Vector3Converter : ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context,
                             System.Globalization.CultureInfo culture,
                             object value, Type destType)
        {
            if (destType == typeof(string) && value is Vector3)
            {
                Vector3 v = (Vector3)value;
                return v.x + ";" + v.y + ";" + v.z;
            }
            return base.ConvertTo(context, culture, value, destType);
        }
    }
}
