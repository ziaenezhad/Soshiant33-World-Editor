using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Soshiant33
{
    public delegate void OnEngineTurnedOn();
    public enum FillMode :byte
    {
        Solid,
        Point,
        Wireframe
    };
    public class Engine: ComplexEntity
    {
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr Engine_New(int width, int height, bool fullscreen, IntPtr clientHandle);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Engine_Resize(IntPtr engine, int width, int height, bool resetBackbufferSize);
        [DllImport("Soshiant33.Native.dll")]
        static extern IntPtr Engine_GetCamera(IntPtr engine);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Engine_Fullscreen(IntPtr engine, bool value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Engine_Release(IntPtr engine);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Engine_SetWindowHandle(IntPtr engine, IntPtr value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Engine_ClearBackBuffer(IntPtr engine,int value);
        [DllImport("Soshiant33.Native.dll")]
        static extern void Engine_Lock();
        [DllImport("Soshiant33.Native.dll")]
        static extern void Engine_UnLock();
        [DllImport("Soshiant33.Native.dll")]
        static extern void Engine_SetFillMode(IntPtr pointer, FillMode value);

        Thread engineThread = null;
        Control chassis = null;
        public Camera camera = null;
        public bool eunuch = false;
        bool isAlive = true;
        public event EventHandler OnTurnedOn;

        public Engine(Control chassis)
            : base(IntPtr.Zero)
        {
            this.chassis = chassis;
        }
        public void TurnOn()
        {
            this.engineThread = new Thread(new ParameterizedThreadStart(StartThread));
            object[] args = new object[1];
            args[0] = this.chassis.Handle;
            this.engineThread.Start(args);
        }
        void StartThread(object input)
        {
            Array args = new object[1];
            args = (Array)input;
            if (this.pointer != IntPtr.Zero)
                Engine_Release(this.pointer);
            this.pointer = Engine_New(800, 600, false, (IntPtr)args.GetValue(0));
            this.camera = new Camera(Engine_GetCamera(this.pointer));
            if(this.OnTurnedOn != null)
                this.OnTurnedOn(this,null);
            //Random rand = new Random();
            while (this.isAlive)
            {
                if (eunuch)
                {
                    Thread.Sleep(100);
                    continue;
                }
                //Engine_ClearBackBuffer(this.pointer, (byte)rand.Next(255), (byte)rand.Next(255), (byte)rand.Next(255));
                this.Update();
                this.Render();
                Thread.Sleep(7);
            }
            //Engine_Release(this.pointer);
        }
        public void TurnOff()
        {
            this.isAlive = false;
        }
        public void Resize(int width,int height)
        {
            Engine_Resize(this.pointer, width, height, false);
        }
        public void Lock()
        {
            Engine_Lock();
        }
        public void UnLock()
        {
            Engine_UnLock();
        }
        public void SetFillMode(FillMode value)
        {
            Engine_SetFillMode(pointer, value);
        }
    }
}
