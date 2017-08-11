using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Nevron.UI.WinForm.Controls;

namespace Soshiant33.LibraryManager
{
    public partial class SpriteEditor : NForm
    {
        S33LibraryBrowser owner;
        public SpritePattern output;
        public SpriteEditor(S33LibraryBrowser owner)
        {
            InitializeComponent();
            this.owner = owner;
        }
        private void SpriteEditor_Load(object sender, EventArgs e)
        {
            this.s33SpriteEditor1.TurnOn(new Soshiant33.SpriteEditor.JobFinished(this.JobFinished));
        }
        private void SpriteEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.s33SpriteEditor1.TurnOff();
        }
        public void JobFinished()
        {
            this.output = this.s33SpriteEditor1.spritePattern;
            this.Close();
        }
    }
}
