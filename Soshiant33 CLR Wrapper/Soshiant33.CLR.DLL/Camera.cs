using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Soshiant33
{
    public class Camera : NativeObject
    {
        public enum ProjectionTypes
        {
            پرسپکتیو,
            ارتوگرافیک,
        }

        [DllImport("Soshiant33.Native.dll")]
        static extern void Camera_Fly(IntPtr camera, float units);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Camera_Walk(IntPtr camera, float units);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Camera_Strafe(IntPtr camera, float units);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Camera_SetProjectionType(IntPtr pointer, ProjectionTypes type);
        [DllImport("Soshiant33.Native.dll")]
        static extern ProjectionTypes Camera_GetProjectionType(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Camera_Yaw(IntPtr pointer, float angle);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Camera_Roll(IntPtr pointer, float angle);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Camera_Pitch(IntPtr pointer, float angle);

        public Camera(IntPtr pointer)
            : base(pointer) { }
        public void Fly(float units)
        {
            Camera_Fly(this.pointer, units);
        }
        public void Walk(float units)
        {
            Camera_Walk(this.pointer, units);
        }
        public void Strafe(float units)
        {
            Camera_Strafe(this.pointer, units);
        }
        public void Yaw(float angle)
        {
            Camera_Yaw(this.pointer, angle);
        }
        public void Roll(float angle)
        {
            Camera_Roll(this.pointer, angle);
        }
        public void Pitch(float angle)
        {
            Camera_Pitch(this.pointer, angle);
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("مشخصات"), DescriptionAttribute("نوع تابش")]
        public ProjectionTypes نوع_تابش
        {
            get { return Camera_GetProjectionType(this.pointer); }
            set { Camera_SetProjectionType(this.pointer, value); }
        }
        #endregion
    }
}
