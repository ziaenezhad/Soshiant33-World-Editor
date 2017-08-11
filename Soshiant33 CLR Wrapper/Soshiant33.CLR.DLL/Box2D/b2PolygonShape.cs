using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;


namespace Soshiant33.Box2D
{
    public class b2PolygonShape : b2Shape
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2PolygonShape_New();
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2PolygonShape_GetCentroid(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2PolygonShape_GetVertex(IntPtr pointer, int index);
        [DllImport("Soshiant33.Native.dll")]
        static extern int b2PolygonShape_GetVertexesCount(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2PolygonShape_SetVertexesCount(IntPtr pointer, int value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2PolygonShape_SetAsBox(IntPtr pointer, float width, float height);

        b2Vec2 m_centriod;
        List<b2Vec2> m_vertexes;
        public b2PolygonShape(IntPtr pointer)
            : base(pointer)
        {
            if (pointer == IntPtr.Zero || pointer == null)
                this.pointer = b2PolygonShape_New();
            this.m_centriod = new b2Vec2(b2PolygonShape_GetCentroid(this.pointer));
            this.m_vertexes = new List<b2Vec2>();
            for (int i = 0; i < 8; i++)
                this.m_vertexes.Add(new b2Vec2(b2PolygonShape_GetVertex(this.pointer, i)));
        }
        public void SetAsBox(float width, float height)
        {
            b2PolygonShape_SetAsBox(this.pointer, width, height);
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("مشخصات"), DescriptionAttribute("موقعیت مرکز ثقل در مختصات محلی")]
        public b2Vec2 مرکزثقل
        {
            get { return this.m_centriod; }
        }
        [CategoryAttribute("مشخصات")]
        public List<b2Vec2> رئوس
        {
            get { return this.m_vertexes; }
        }
        [CategoryAttribute("مشخصات")]
        public int تعدادرئوس
        {
            get { return b2PolygonShape_GetVertexesCount(this.pointer); }
            set { b2PolygonShape_SetVertexesCount(this.pointer, value); }
        }

        #endregion
    }
}
