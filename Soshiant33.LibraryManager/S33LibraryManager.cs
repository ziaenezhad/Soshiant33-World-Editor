using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Soshiant33.SceneEditor;

namespace Soshiant33.LibraryManager
{
    public enum TargetLibrary
    {
        اشتراکی,
        صحنه
    }
    public partial class S33LibraryManager : UserControl
    {
        S33SceneEditor client;
        public S33LibraryManager()
        {
            InitializeComponent();
        }
        public void SetClient(S33SceneEditor client)
        {
            this.client = client;
            this.sharedLib_browser.SetClient(client.GetSharedLibrary());
            this.sceneLib_browser.SetClient(client.GetSceneLibrary(new OnSceneSwitched(this.OnSceneSwitched)));
        }
        void OnSceneSwitched()
        {
            this.sceneLib_browser.SetClient(client.GetSceneLibrary(new OnSceneSwitched(this.OnSceneSwitched)));
        }
    }
}
