using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;


namespace Soshiant33.Box2D
{
    public class b2Fixture : NativeObject
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2Fixture_GetNext(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2Fixture_GetShape(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2Fixture_GetFriction(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2Fixture_GetRistitution(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2Fixture_GetDensity(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern bool b2Fixture_GetIsSensor(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Fixture_SetFriction(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Fixture_SetRistitution(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Fixture_SetDensity(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Fixture_SetIsSensor(IntPtr pointer, bool value);

        public b2Fixture(IntPtr pointer)
            : base(pointer) { }
        public b2Fixture GetNext()
        {
            if (b2Fixture_GetNext(this.pointer) != IntPtr.Zero)
                return new b2Fixture(b2Fixture_GetNext(this.pointer));
            return null;
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("مشخصات")]
        public b2Shape شکل
        {
            get
            {
                b2Shape shape = new b2CircleShape(b2Fixture_GetShape(this.pointer));
                if (shape.نوع == b2Shape.Type.چندظلعی)
                    shape = new b2PolygonShape(b2Fixture_GetShape(this.pointer));
                return shape;
            }
        }
        [CategoryAttribute("مشخصات")]
        public float اصطکاک
        {
            get { return b2Fixture_GetFriction(this.pointer); }
            set { b2Fixture_SetFriction(this.pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public float ارتجاع
        {
            get { return b2Fixture_GetRistitution(this.pointer); }
            set { b2Fixture_SetRistitution(this.pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public float چگالی
        {
            get { return b2Fixture_GetDensity(this.pointer); }
            set { b2Fixture_SetDensity(this.pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public bool حسگر
        {
            get { return b2Fixture_GetIsSensor(this.pointer); }
            set { b2Fixture_SetIsSensor(this.pointer, value); }
        }
        #endregion
    }
}
