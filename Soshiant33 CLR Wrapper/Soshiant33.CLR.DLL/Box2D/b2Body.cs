using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;


namespace Soshiant33.Box2D
{
    public enum b2BodyType
    {
        ایستا = 0,
        متحرک,
        پویا,
    }
    public class b2Body : NativeObject
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2Body_GetPosition(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern b2BodyType b2Body_GetType(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2Body_GetAngle(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2Body_GetAngularVelocity(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2Body_GetLinearDamping(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2Body_GetAngularDamping(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern bool b2Body_GetAllowSleep(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern bool b2Body_GetAwake(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern bool b2Body_GetFixedRotation(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern bool b2Body_GetBullet(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern bool b2Body_GetActive(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Body_SetType(IntPtr pointer, b2BodyType value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Body_SetAngularVelocity(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Body_SetLinearDamping(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Body_SetAngularDamping(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Body_SetAllowSleep(IntPtr pointer, bool value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Body_SetAwake(IntPtr pointer, bool value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Body_SetFixedRotation(IntPtr pointer, bool value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Body_SetBullet(IntPtr pointer, bool value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Body_SetActive(IntPtr pointer, bool value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2Body_CreateFixture(IntPtr pointer, IntPtr fixtureDef);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2Body_GetFixtureList(IntPtr pointer);

        b2Vec2 position;
        public b2Body(IntPtr pointer)
            : base(pointer) 
        {
            this.position = new b2Vec2(b2Body_GetPosition(this.pointer));
        }
        public void CreateFixture(b2FixtureDef def)
        {
            b2Body_CreateFixture(this.pointer, def.GetNativPointer());
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("مشخصات")]
        public b2Vec2 مکان
        {
            get { return this.position; }
        }
        [CategoryAttribute("مشخصات")]
        public b2BodyType نوع
        {
            get { return b2Body_GetType(this.pointer); }
            set { b2Body_SetType(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public float زاویه
        {
            get { return b2Body_GetAngle(this.pointer); }
        }
        [CategoryAttribute("مشخصات")]
        public float سرعت_زاویه_ای
        {
            get { return b2Body_GetAngularVelocity(this.pointer); }
            set { b2Body_SetAngularVelocity(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public float میرایی_خطی
        {
            get { return b2Body_GetLinearDamping(this.pointer); }
            set { b2Body_SetLinearDamping(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public float میرایی_زاویه_ای
        {
            get { return b2Body_GetAngularDamping(this.pointer); }
            set { b2Body_SetAngularDamping(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public bool اجازه_خوابیدن
        {
            get { return b2Body_GetAllowSleep(this.pointer); }
            set { b2Body_SetAllowSleep(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public bool نچرخ
        {
            get { return b2Body_GetFixedRotation(this.pointer); }
            set { b2Body_SetFixedRotation(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public bool فعال
        {
            get { return b2Body_GetActive(this.pointer); }
            set { b2Body_SetActive(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public bool شبیه_ساز_گلوله_ای
        {
            get { return b2Body_GetBullet(this.pointer); }
            set { b2Body_SetBullet(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public bool بیدار
        {
            get { return b2Body_GetAwake(this.pointer); }
            set { b2Body_SetAwake(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public List<b2Fixture> لیست_بستها
        {
            get
            {
                List<b2Fixture> list = new List<b2Fixture>();
                IntPtr first = b2Body_GetFixtureList(this.pointer);
                if (first != IntPtr.Zero)
                {
                    b2Fixture fixture = new b2Fixture(first);
                    while (fixture != null)
                    {
                        list.Add(fixture);
                        fixture = fixture.GetNext();
                    }
                }
                return list;
            }
        }
        #endregion
    }
}
