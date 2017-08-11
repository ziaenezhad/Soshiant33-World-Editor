using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Soshiant33
{
    public class ComplexEntity : Entity
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr ComplexEntity_AddChild(IntPtr pointer,IntPtr pattern, IntPtr ep);
        [DllImport("Soshiant33.Native.dll")]
        static extern void ComplexEntity_SortChildsByDepth(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void ComplexEntity_SaveAsComplexEntityPattern(IntPtr pointer, char[] filename);

        List<Entity> childs = null;
        public ComplexEntity(IntPtr pointer)
            : base(pointer)
        {
            this.childs = new List<Entity>();
        }
        public Entity AddChild(EntityPattern pattern,EntityParameters ep)
        {
            Entity entity = null;
            IntPtr ep_pointer = IntPtr.Zero;
            if (ep != null)
                ep_pointer = ep.GetNativPointer();
            switch (pattern.type)
            {
                case EntityPattern.Types.Type_ScenePattern:
                    entity = new Scene(ComplexEntity_AddChild(this.pointer, pattern.GetNativPointer(), ep_pointer));
                    break;
                case EntityPattern.Types.Type_SpritePattern:
                    entity = new Sprite(ComplexEntity_AddChild(this.pointer, pattern.GetNativPointer(), ep_pointer));
                    break;
            }
            if (entity != null)
                childs.Add(entity);
            return entity;
        }
        public void SortChildsByDepth()
        {
            ComplexEntity_SortChildsByDepth(pointer);
        }
        public void SaveAsComplexEntityPattern(string filename)
        {
            ComplexEntity_SaveAsComplexEntityPattern(pointer, filename.ToCharArray());
        }
    }
}
