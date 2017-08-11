using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Nevron.UI.WinForm.Controls;
using System.Threading;

namespace Soshiant33.WorldEditor
{
    public partial class MainForm : NForm
    {
        
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.s33SceneEditor1.TurnOn(new OnEngineTurnedOn(this.Init));
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.s33SceneEditor1.TurnOff();
        }
        private void splitContainer1_SizeChanged(object sender, EventArgs e)
        {
            this.splitContainer1.SplitterDistance = 200;
        }
        delegate void InitDelegate();
        void Init()
        {
            if (this.InvokeRequired)
                this.Invoke(new InitDelegate(_Init));
            else
                _Init();
        }
        void _Init()
        {
            this.s33LibraryManager1.SetClient(this.s33SceneEditor1);
        }
    }
}
