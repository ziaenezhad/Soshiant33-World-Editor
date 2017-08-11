using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace Soshiant33
{
    public class Library
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr SpritePattern_New();
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr Library_GetScenePattern(char[] name);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr Library_GetSpritePattern(char[] name);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr Library_GetComplexEntityPattern(char[] name);

        public static ScenePattern GetScenePattern(string name)
        {
            return new ScenePattern(Library_GetScenePattern(name.ToCharArray()));
        }
        public static SpritePattern GetSpritePattern(string name)
        {
            return new SpritePattern(Library_GetSpritePattern(name.ToCharArray()));
        }
        public static ComplexEntityPattern GetComplexEntityPattern(string name)
        {
            return new ComplexEntityPattern(Library_GetComplexEntityPattern(name.ToCharArray()));
        }
    }
}
