using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using Microsoft.DirectX;
//using Microsoft.DirectX.DirectInput;

namespace Soshiant33.SceneEditor
{
    public partial class GamePad : Form
    {
        Engine engine = null;
        Keys currentKey = Keys.None;
        string scenePatternName;
        Thread inputTread = null;
        Microsoft.DirectX.DirectInput.Device keyboard = null;
        Microsoft.DirectX.DirectInput.Key[] keys = null;
        

        
        public GamePad(string scenePattern)
        {
            InitializeComponent();
            this.scenePatternName = scenePattern;
            engine = new Engine(this);
            engine.OnTurnedOn += this.Init;
            engine.TurnOn();
            keyboard = new Microsoft.DirectX.DirectInput.Device(Microsoft.DirectX.DirectInput.SystemGuid.Keyboard);
            //keyboard.SetCooperativeLevel(this, Microsoft.DirectX.DirectInput.CooperativeLevelFlags.Exclusive);
            keyboard.Acquire();
        }
        void Init(object sender, EventArgs args)
        {
            engine.AddChild(Library.GetScenePattern(this.scenePatternName), null);
            this.inputTread = new Thread(new ThreadStart(this.InputLoop));
            this.inputTread.Start();
        }

        private void GamePad_FormClosing(object sender, FormClosingEventArgs e)
        {
            engine.TurnOff();
            this.inputTread.Abort();
        }
        void InputLoop()
        {
            while (true)
            {
                keys = keyboard.GetPressedKeys();
                if (keys.Length > 0)
                {
                    switch (keys[0])
                    {
                        case Microsoft.DirectX.DirectInput.Key.Left:
                            engine.camera.Strafe(-5);
                            break;
                        case Microsoft.DirectX.DirectInput.Key.Right:
                            engine.camera.Strafe(5);
                            break;
                        case Microsoft.DirectX.DirectInput.Key.Up:
                            engine.camera.Fly(5);
                            break;
                        case Microsoft.DirectX.DirectInput.Key.Down:
                            engine.camera.Fly(-5);
                            break;
                    }
                }
                Thread.Sleep(1);
            }
        }
    }
}
