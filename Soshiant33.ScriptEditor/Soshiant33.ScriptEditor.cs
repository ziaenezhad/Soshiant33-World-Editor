using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Soshiant33.ScriptEditor
{
    public partial class S33ScriptEditor : UserControl
    {
        public S33ScriptEditor()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.syntaxEditor1.Document.LoadLanguageFromXml("e:\\Syntax.xml", 0);
        }
    }
}
