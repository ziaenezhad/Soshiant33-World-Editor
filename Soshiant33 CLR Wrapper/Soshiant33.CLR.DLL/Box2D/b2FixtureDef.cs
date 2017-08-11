using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;


namespace Soshiant33.Box2D
{
    public class b2FixtureDef : NativeObject
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2FixtureDef_New();
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2FixtureDef_GetShape(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2FixtureDef_GetFriction(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2FixtureDef_GetRistitution(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2FixtureDef_GetDensity(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern bool b2FixtureDef_GetIsSensor(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2FixtureDef_SetShape(IntPtr pointer, IntPtr value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2FixtureDef_SetFriction(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2FixtureDef_SetRistitution(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2FixtureDef_SetDensity(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2FixtureDef_SetIsSensor(IntPtr pointer, bool value);


        public b2FixtureDef(IntPtr pointer)
            : base(pointer)
        {
            if (pointer == IntPtr.Zero || pointer == null)
                this.pointer = b2FixtureDef_New();
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("مشخصات")]
        public b2Shape شکل
        {
            get 
            {
                b2Shape shape = new b2CircleShape(b2FixtureDef_GetShape(this.pointer));
                if(shape.نوع == b2Shape.Type.چندظلعی)
                    shape = new b2PolygonShape(b2FixtureDef_GetShape(this.pointer));
                return shape;
            }
            set { b2FixtureDef_SetShape(this.pointer, value.GetNativPointer()); }
        }
        [CategoryAttribute("مشخصات")]
        public float اصطکاک
        {
            get { return b2FixtureDef_GetFriction(this.pointer); }
            set { b2FixtureDef_SetFriction(this.pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public float ارتجاع
        {
            get { return b2FixtureDef_GetRistitution(this.pointer); }
            set { b2FixtureDef_SetRistitution(this.pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public float چگالی
        {
            get { return b2FixtureDef_GetDensity(this.pointer); }
            set { b2FixtureDef_SetDensity(this.pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public bool حسگر
        {
            get { return b2FixtureDef_GetIsSensor(this.pointer); }
            set { b2FixtureDef_SetIsSensor(this.pointer, value); }
        }
        #endregion
    }
}
