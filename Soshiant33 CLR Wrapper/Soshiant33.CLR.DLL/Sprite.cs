using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;
using Soshiant33.Box2D;

namespace Soshiant33
{
    public class Sprite : Entity
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern ushort Sprite_GetCurrentState(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Sprite_SetCurrentState(IntPtr pointer, ushort value);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr Sprite_GetBody(IntPtr pointer);

        b2Body body;
        public Sprite(IntPtr pointer)
            : base(pointer) 
        {
            this.body = new b2Body(Sprite_GetBody(this.pointer));
        }

        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [Browsable(false)]
        public ushort currentState
        {
            get { return Sprite_GetCurrentState(this.pointer); }
            set { Sprite_SetCurrentState(this.pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public b2Body تنه
        {
            get { return this.body; }
            //set { this.body = value; }
        }
        #endregion
    }
}
