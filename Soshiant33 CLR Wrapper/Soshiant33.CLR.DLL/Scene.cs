using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Drawing;
using System.Runtime.InteropServices;
using System.ComponentModel;

using Soshiant33.Box2D;

namespace Soshiant33
{
    public class Scene : ComplexEntity
    {        
        [DllImport("Soshiant33.Native.dll")]
        static extern void Scene_SetPositionIteration(IntPtr pointer, ushort value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Scene_SetVelocityIteration(IntPtr pointer, ushort value);
        [DllImport("Soshiant33.Native.dll")]
        static extern ushort Scene_GetPositionIteration(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern ushort Scene_GetVelocityIteration(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Scene_SetBackColor(IntPtr pointer, int value);
        [DllImport("Soshiant33.Native.dll")]
        static extern int Scene_GetBackColor(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Scene_Play(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Scene_Pause(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr Scene_GetWorld(IntPtr pointer);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Scene_SaveAsScenePattern(IntPtr pointer,char[] filename);

        bool paused;
        //b2World world;
        public static float meterPixelRatio = 40; 
        
        public Scene(IntPtr pointer)
            : base(pointer)
        {
            //backColor = this.الگو.;
            paused = false;
            //this.world = new b2World(Scene_GetWorld(this.pointer));
        }
        public void Play()
        {
            Scene_Play(this.pointer);
            this.paused = false;
        }
        public void Pause()
        {
            Scene_Pause(this.pointer);
            this.paused = true;
        }
        public bool IsPaused()
        {
            return this.paused;
        }
        public void SaveAsScenePattern(string filename)
        {
            Scene_SaveAsScenePattern(pointer, filename.ToCharArray());
        }
        //__________________________________________________________________________________________
        //------------------------------------------------------------------------------------------
        #region Members Discription
        [CategoryAttribute("فیزیک"), DescriptionAttribute("دقت تعیین موقعیت اشیاء در هر بروزرسانی جهان فیزیکی")]
        public ushort گردش_موقعیت
        {
            get { return Scene_GetPositionIteration(this.pointer); }
            set { Scene_SetPositionIteration(this.pointer, value); }
        }
        [CategoryAttribute("فیزیک"), DescriptionAttribute("دقت تعیین سرعت اشیاء در هر بروزرسانی جهان فیزیکی")]
        public ushort گردش_سرعت
        {
            get { return Scene_GetVelocityIteration(this.pointer); }
            set { Scene_SetVelocityIteration(this.pointer, value); }
        }
        //[CategoryAttribute("فیزیک"), DescriptionAttribute("دقت تعیین سرعت اشیاء در هر بروزرسانی جهان فیزیکی")]
        //public b2World جهان
        //{
        //    get { return this.world; }
        //    set { this.world = value; }
        //}
        [CategoryAttribute("مشخصات"), DescriptionAttribute("رنگ زمینه صحنه")]
        public Color رنگ_زمینه
        {
            get { return Color.FromArgb(Scene_GetBackColor(pointer)); }
            set { Scene_SetBackColor(this.pointer, value.ToArgb()); }
        }
        #endregion
    }
}