using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Windows.Forms;

namespace Soshiant33
{
    [TypeConverter(typeof(WitheConverter))]
    public abstract class NativeObject
    {
        protected IntPtr pointer;

        public NativeObject(IntPtr pointer)
        {
            this.pointer = pointer;
        }
        public IntPtr GetNativPointer()
        {
            return this.pointer;
        }
        public void SetNativPointer(IntPtr pointer)
        {
            this.pointer = pointer;
        }
    }
    internal class WitheConverter : ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context,
                             System.Globalization.CultureInfo culture,
                             object value, Type destType)
        {
            return "[...]";
        }
    }
}
