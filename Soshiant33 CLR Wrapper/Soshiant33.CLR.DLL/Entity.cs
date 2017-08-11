using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Soshiant33
{
    public class Entity : NativeObject
    {
        public enum Types : byte
        {
            Entity,
            Sprite,
            ComplexEntity,
            Scene,
            Engine
        };

        [DllImport("Soshiant33.Native.dll")]
        static extern void Entity_Release(IntPtr entity);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr Entity_GetEP(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Entity_Update(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Entity_Render(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr Entity_Pick(IntPtr pointer, int x, int y);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr Entity_GetPattern(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern Types Entity_GetType(IntPtr pointer);

        EntityParameters ep;
        public Entity(IntPtr pointer)
            :base(pointer)
        {
            this.ep = new EntityParameters(Entity_GetEP(this.pointer));
        }
        public virtual void Release()
        {
            Entity_Release(this.pointer);
        }
        public override string ToString()
        {
            return this.ep.نام;
        }
        public void Update()
        {
            Entity_Update(pointer);
        }
        public void Render()
        {
            Entity_Render(pointer);
        }
        public Entity Pick(Point screenPoint)
        {
            IntPtr result = Entity_Pick(pointer,screenPoint.X,screenPoint.Y);
            if (result != IntPtr.Zero)
                return new Sprite(result);
            else
                return null;
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("مشخصات"), DescriptionAttribute("مولفه ها")]
        public EntityParameters مولفه_ها
        {
            get { return ep; }
        }
        [CategoryAttribute("مشخصات")]
        public Types نوع
        {
            get { return Entity_GetType(pointer);}
        }
        [CategoryAttribute("مشخصات")]
        public EntityPattern الگو
        {
            get
            {
                switch (this.نوع)
                {
                    case Types.Sprite:
                        return new SpritePattern(Entity_GetPattern(pointer));
                    case Types.Scene:
                        return new ScenePattern(Entity_GetPattern(pointer));
                    case Types.ComplexEntity:
                        return new ComplexEntityPattern(Entity_GetPattern(pointer));
                    case Types.Engine:
                        return new ComplexEntityPattern(Entity_GetPattern(pointer));
                }
                return null;
            }
        }
        #endregion
    }
}
