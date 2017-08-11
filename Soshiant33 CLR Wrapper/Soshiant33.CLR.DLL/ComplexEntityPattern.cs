using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soshiant33
{
    public class ComplexEntityPattern : EntityPattern
    {
        public ComplexEntityPattern(IntPtr pointer)
            : base(pointer)
        {
            this.type = Types.Type_ComplexEntityPattern;
            //this.avatar.ImageIndex = 1;
        }
    }
}
