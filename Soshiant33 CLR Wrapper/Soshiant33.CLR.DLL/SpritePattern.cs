using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using Nevron.UI.WinForm.Controls;
using System.Windows.Forms;

using Soshiant33.Box2D;

namespace Soshiant33
{
    public class SpritePattern : EntityPattern
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr SpritePattern_New();
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr SpritePattern_AddNewState(IntPtr pattern, char[] name);
        [DllImport("Soshiant33.Native.dll")]
        static extern void SpritePattern_RemoveState(IntPtr pattern, ushort index);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr SpritePattern_GetBodyDef(IntPtr pointer);

        b2BodyDef bodyDef;
        List<SpriteState> states;
        List<b2FixtureDef> fixtures;

        public SpritePattern(string name)
            : base(SpritePattern_New())
        {
            this.type = Types.Type_SpritePattern;
            this.states = new List<SpriteState>();
            this.fixtures = new List<b2FixtureDef>();
            this.bodyDef = new b2BodyDef(SpritePattern_GetBodyDef(this.pointer));
            this.نام = name;
        }
        public SpritePattern(IntPtr pointer)
            : base(pointer)
        {
            this.type = Types.Type_SpritePattern;
            if (pointer == IntPtr.Zero)
                MessageBox.Show("SpritePattern(IntPtr.Zero)", "Error");
            this.states = new List<SpriteState>();
            this.fixtures = new List<b2FixtureDef>();
            this.bodyDef = new b2BodyDef(SpritePattern_GetBodyDef(this.pointer));
        }
        public SpriteState AddNewState(string name)
        {
            SpriteState state = new SpriteState(name,SpritePattern_AddNewState(this.pointer, name.ToCharArray()));
            this.states.Add(state);
            return state;
        }
        public void RemoveState(ushort index)
        {
            SpritePattern_RemoveState(this.pointer,index);
            this.states.RemoveAt(index);
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("فیزیک")]
        public b2BodyDef تنه
        {
            get { return this.bodyDef; }
        }
        [CategoryAttribute("مشخصات")]
        public List<SpriteState> وضعیتها
        {
            get 
            { 
                return this.states; 
            }
        }
        [CategoryAttribute("فیزیک"), DescriptionAttribute("یک بست خصوصیات شکل ظاهری یک تنه را مشخص می کند. یک تنه می تواند به هر تعداد بست داشته باشد.")]
        public List<b2FixtureDef> بستها
        {
            get { return this.fixtures; }
        }
        #endregion
    }
}
