using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;


namespace Soshiant33.Box2D
{
    public class b2BodyDef : NativeObject
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2BodyDef_New();
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2BodyDef_GetPosition(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr b2BodyDef_GetLinearVelocity(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern b2BodyType b2BodyDef_GetType(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2BodyDef_GetAngle(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2BodyDef_GetAngularVelocity(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2BodyDef_GetLinearDamping(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2BodyDef_GetAngularDamping(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern bool b2BodyDef_GetAllowSleep(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern bool b2BodyDef_GetAwake(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern bool b2BodyDef_GetFixedRotation(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern bool b2BodyDef_GetBullet(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern bool b2BodyDef_GetActive(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern float b2BodyDef_GetInertiaScale(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2BodyDef_SetType(IntPtr pointer, b2BodyType value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2BodyDef_SetAngle(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2BodyDef_SetAngularVelocity(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2BodyDef_SetLinearDamping(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2BodyDef_SetAngularDamping(IntPtr pointer, float value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2BodyDef_SetAllowSleep(IntPtr pointer, bool value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2BodyDef_SetAwake(IntPtr pointer, bool value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2BodyDef_SetFixedRotation(IntPtr pointer, bool value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2BodyDef_SetBullet(IntPtr pointer, bool value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2BodyDef_SetActive(IntPtr pointer, bool value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void b2BodyDef_SetInertiaScale(IntPtr pointer, float value);

        [DllImport("Soshiant33.Native.dll")]
        static extern bool Tester(IntPtr handle);

        b2Vec2 position;
        b2Vec2 linearVelocity;

        public b2BodyDef(IntPtr pointer)
            : base(pointer)
        {
            if (pointer == IntPtr.Zero || pointer == null)
                this.pointer = b2BodyDef_New();
           position = new b2Vec2(b2BodyDef_GetPosition(this.pointer));
           linearVelocity = new b2Vec2(b2BodyDef_GetLinearVelocity(this.pointer));
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
        public b2Vec2 سرعت_خطی
        {
            get { return this.linearVelocity; }
        }
        [CategoryAttribute("مشخصات")]
        public b2BodyType نوع
        {
            get { return b2BodyDef_GetType(this.pointer); }
            set { b2BodyDef_SetType(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public float زاویه
        {
            get { return b2BodyDef_GetAngle(this.pointer); }
            set { b2BodyDef_SetAngle(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public float سرعت_زاویه_ای
        {
            get { return b2BodyDef_GetAngularVelocity(this.pointer); }
            set { b2BodyDef_SetAngularVelocity(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public float میرایی_خطی
        {
            get { return b2BodyDef_GetLinearDamping(this.pointer); }
            set { b2BodyDef_SetLinearDamping(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public float میرایی_زاویه_ای
        {
            get { return b2BodyDef_GetAngularDamping(this.pointer); }
            set { b2BodyDef_SetAngularDamping(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public bool اجازه_خوابیدن
        {
            get { return b2BodyDef_GetAllowSleep(this.pointer); }
            set { b2BodyDef_SetAllowSleep(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public bool نچرخ
        {
            get { return b2BodyDef_GetFixedRotation(this.pointer); }            
            set { b2BodyDef_SetFixedRotation(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public bool فعال
        {
            get { return b2BodyDef_GetActive(this.pointer); }
            set { b2BodyDef_SetActive(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public bool شبیه_ساز_گلوله_ای
        {
            get { return b2BodyDef_GetBullet(this.pointer); }
            set { b2BodyDef_SetBullet(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public float مقیاس_اینرسی
        {
            get { return b2BodyDef_GetInertiaScale(this.pointer); }
            set { b2BodyDef_SetInertiaScale(pointer, value); }
        }
        [CategoryAttribute("مشخصات")]
        public bool بیدار
        {
            get { return b2BodyDef_GetAwake(this.pointer); }
            set { b2BodyDef_SetAwake(pointer, value); }
        }
        #endregion
    }
}
