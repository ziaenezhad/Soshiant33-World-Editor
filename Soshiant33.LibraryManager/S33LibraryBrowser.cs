using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Soshiant33.LibraryManager
{
    public partial class S33LibraryBrowser : UserControl
    {
        Library client;
        bool mouseUp = true;
        public S33LibraryBrowser()
        {
            InitializeComponent();
            this.membersGallery.LargeImageList = LibMember.imageList;
        }
        public void SetClient(Library client)
        {
            this.client = client;
            this.ResetMembersGalery();
        }
        void ResetMembersGalery()
        {
            if (client != null)
            {
                this.membersGallery.Items.Clear();
                for (int i = 0; i < client.libMembers.Count; i++)
                {
                    this.membersGallery.Items.Add(client.libMembers[i].avatar);
                }
            }
        }

        private void mnu_addSprite_Click(object sender, EventArgs e)
        {
            SpriteEditor editor = new SpriteEditor(this);
            editor.ShowDialog();
            this.client.AddMember(editor.output);
            ResetMembersGalery();
        }

        private void membersGallery_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.membersGallery.SelectedItems.Count != 0)
            {
                DoDragDrop(this.client.libMembers[this.membersGallery.SelectedItems[0].Index], DragDropEffects.Copy);
                mouseUp = false;

            }  
        }

        //private void membersGallery_MouseUp(object sender, MouseEventArgs e)
        //{
        //    mouseUp = true;
        //}

        //private void membersGallery_MouseEnter(object sender, EventArgs e)
        //{
        //    //mouseUp = true;
        //}
    }
}
