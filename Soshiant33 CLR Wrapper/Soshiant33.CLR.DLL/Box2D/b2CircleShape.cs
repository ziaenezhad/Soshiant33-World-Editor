using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;


namespace Soshiant33.Box2D
{
    public class b2CircleShape : b2Shape
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2CircleShape_New();
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2CircleShape_GetPosition(IntPtr pointer);

        b2Vec2 m_p;
        public b2CircleShape(IntPtr pointer)
            : base(pointer)
        {
            if (pointer == IntPtr.Zero || pointer == null)
                this.pointer = b2CircleShape_New();
            this.m_p = new b2Vec2(b2CircleShape_GetPosition(this.pointer));
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("مشخصات"), DescriptionAttribute("فاصله از مرکز تنه")]
        public b2Vec2 مکان
        {
            get { return this.m_p; }
        }
        #endregion
    }
}
