using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Soshiant33.ResourceExplorer
{
    public partial class ResourceExplorer : UserControl
    {
        public string basePath = "\\";
        bool mouseUp = true;
        public ResourceExplorer()
        {
            InitializeComponent();
            this.imageList1.Images.Add(global::Soshiant33.Properties.Resources.Sprite_32);
            this.imageList1.Images.Add(global::Soshiant33.Properties.Resources.ComplexEntity_32);
            //this.Reload();
        }
        public void Reload()
        {
            listView1.Items.Clear();
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(this.basePath);
            foreach (System.IO.FileInfo fi in di.GetFiles())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = fi.Name;
                switch (System.IO.Path.GetExtension(fi.Name))
                {
                    case ".sprt":
                        lvi.ImageIndex = 0;
                        listView1.Items.Add(lvi);
                        break;
                    case ".cmplx":
                        lvi.ImageIndex = 1;
                        listView1.Items.Add(lvi);
                        break;
                }
            }
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.listView1.SelectedItems.Count != 0)
            {
                switch (System.IO.Path.GetExtension(this.listView1.SelectedItems[0].Text))
                {
                    case ".sprt":
                        DoDragDrop(Library.GetSpritePattern(this.listView1.SelectedItems[0].Text), DragDropEffects.Copy);
                        break;
                    case ".cmplx":
                        DoDragDrop(Library.GetComplexEntityPattern(this.listView1.SelectedItems[0].Text), DragDropEffects.Copy);
                        break;
                }
                mouseUp = false;
            } 
        }

        private void btn_refreash_Click(object sender, EventArgs e)
        {
            this.Reload();
        }
    }
}
