using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Soshiant33
{
    public enum BlendingMode : byte
	{
		Normal = 0,
		Darken,
		Multiply,
		Lighten,
		Screen,
		LinearDodge,
	};
    [TypeConverter(typeof(EntityParametersConverter))]
    public class EntityParameters : NativeObject
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr EntityParameters_New();
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr EntityParameters_GetPosition(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr EntityParameters_GetRotation(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr EntityParameters_GetScale(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll", CharSet = CharSet.Ansi)]
        static extern string EntityParameters_GetName(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void EntityParameters_SetName(IntPtr pointer, char[] value);
        [DllImport("Soshiant33.Native.dll")]
        static extern bool EntityParameters_GetVisible(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void EntityParameters_SetVisible(IntPtr pointer, bool value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void EntityParameters_SetColor(IntPtr pointer, byte r, byte g, byte b, byte a);
        [DllImport("Soshiant33.Native.dll")]
        static extern int EntityParameters_GetColor(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void EntityParameters_SetTransparency(IntPtr pointer, byte value);
        [DllImport("Soshiant33.Native.dll")]
        static extern byte EntityParameters_GetTransparency(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern BlendingMode EntityParameters_GetBlendingMode(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void EntityParameters_SetBlendingMode(IntPtr pointer, BlendingMode value);



        Vector3 position = null;
        Vector3 rotation = null;
        Vector3 sacal = null;
        
        public EntityParameters(IntPtr pointer)
            : base(pointer)
        {
            if (pointer == IntPtr.Zero)
                this.pointer = EntityParameters_New();
            this.position = new Vector3(EntityParameters_GetPosition(this.pointer));
            this.rotation = new Vector3(EntityParameters_GetRotation(this.pointer));
            this.sacal = new Vector3(EntityParameters_GetScale(this.pointer));
            //this.color = Color.FromArgb(255, 255, 255, 255);
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("مشخصات"), DescriptionAttribute("مختصات موقعیت")]
        public Vector3 موقعیت
        {
            get { return this.position; }
            set { this.position = value; }
        }
        [CategoryAttribute("مشخصات"), DescriptionAttribute("زوایای چرخش")]
        public Vector3 چرخش
        {
            get { return this.rotation; }
            set { this.rotation = value; }
        }
        [CategoryAttribute("مشخصات"), DescriptionAttribute("مقیاس")]
        public Vector3 مقیاس
        {
            get { return this.sacal; }
            set { this.sacal = value; }
        }
        [CategoryAttribute("مشخصات"), DescriptionAttribute("رنگ")]
        public Color رنگ
        {
            get { return Color.FromArgb(EntityParameters_GetColor(pointer)); }
            set { EntityParameters_SetColor(this.pointer, value.R, value.G, value.B, value.A);}
        }
        [CategoryAttribute("مشخصات"), DescriptionAttribute("شفافیت")]
        public byte شفافیت
        {
            get { return EntityParameters_GetTransparency(pointer); }
            set { EntityParameters_SetTransparency(pointer,value); }
        }
        [CategoryAttribute("مشخصات"), DescriptionAttribute("با استفاده از این نام می توانید در دستورات به این موجود دسترسی داشته باشید .")]
        public string نام
        {
            get { return EntityParameters_GetName(this.pointer); }
            set { EntityParameters_SetName(this.pointer, value.ToCharArray()); }
        }
        [CategoryAttribute("مشخصات")]
        public bool قابل_دیدن
        {
            get { return EntityParameters_GetVisible(this.pointer); }
            set { EntityParameters_SetVisible(this.pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public BlendingMode سبک_ترکیب
        {
            get { return EntityParameters_GetBlendingMode(pointer); }
            set { EntityParameters_SetBlendingMode(this.pointer, value); }
        }
        
        #endregion
    }
    internal class EntityParametersConverter : ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context,
                             System.Globalization.CultureInfo culture,
                             object value, Type destType)
        {
            if (destType == typeof(string) && value is EntityParameters)
            {
                EntityParameters v = (EntityParameters)value;
                return "رنگ،موقعیت،چرخش،مقیاس،نام";
            }
            return base.ConvertTo(context, culture, value, destType);
        }
    }
}
