using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Nevron.UI.WinForm.Controls;

namespace Soshaint33.WorldEditor
{
    public partial class Main : NForm
    {
        public Main()
        {
            InitializeComponent();
            resourceExplorer1.basePath = Application.StartupPath+ "\\Ptrn\\";
            resourceExplorer1.Reload();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.s33SceneEditor1.TurnOn();
            this.s33SpriteEditor1.TurnOn();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.s33SceneEditor1.TurnOff();
            this.s33SpriteEditor1.TurnOff();
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            this.splitContainer1.SplitterDistance = 200;
        }
    }
}
