using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Nevron.UI.WinForm.Controls;
using Soshiant33.Box2D;

namespace Soshiant33.SpriteEditor
{
    public partial class PhysicalShapeEditor : NForm
    {
        public b2FixtureDef fixtureDef;
        b2CircleShape circleShape;
        b2PolygonShape polygonShape;
        Rect rect;
        public bool ok = false;
        public PhysicalShapeEditor(Rect frameRect)
        {
            InitializeComponent();
            this.fixtureDef = new b2FixtureDef(IntPtr.Zero);
            this.propertyGrid.SelectedObject = this.fixtureDef;
            this.rect = frameRect;

            this.circleShape = new b2CircleShape(IntPtr.Zero);
            this.polygonShape = new b2PolygonShape(IntPtr.Zero);
            this.nBox_Rect_H_meter.Value = (decimal)(Math.Abs(rect.GetHeight()) / Scene.meterPixelRatio);
            this.nBox_Rect_W_meter.Value = (decimal)(Math.Abs(rect.GetWidth()) / Scene.meterPixelRatio);
            CreateMohitCircle();
            this.fixtureDef.شکل = this.circleShape;
        }
        void CreateMohitCircle()
        {
            this.nBox_Circle_R_meter.Value = (decimal)(Math.Sqrt(Math.Pow(rect.GetWidth(), 2) + Math.Pow(rect.GetHeight(), 2)) / Scene.meterPixelRatio / 2);
        }
        void CreateMohatCircle()
        {
            this.nBox_Circle_R_meter.Value = (decimal)(Math.Min(rect.GetHeight(), rect.GetWidth()) / Scene.meterPixelRatio / 2);
        }
        private void btn_Mohat_Click(object sender, EventArgs e)
        {
            CreateMohatCircle();
        }
        private void btn_Mohit_Click(object sender, EventArgs e)
        {
            CreateMohitCircle();
        }
        private void rbtn_Rect_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtn_Rect.Checked)
            {
                this.gbox_rect.Enabled = true;
                this.gbox_circle.Enabled = false;
                this.fixtureDef.شکل = this.polygonShape;
                this.propertyGrid.SelectedObject = this.fixtureDef;
            }
        }

        private void rbtn_Circle_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtn_Circle.Checked)
            {
                this.gbox_rect.Enabled = false;
                this.gbox_circle.Enabled = true;
                this.fixtureDef.شکل = this.circleShape;
                this.propertyGrid.SelectedObject = this.fixtureDef;
            }
        }
        private void nBox_Circle_R_meter_ValueChanged(object sender, EventArgs e)
        {
            this.txt_R.Text = Math.Round(this.nBox_Circle_R_meter.Value * 40).ToString();
            this.circleShape.شعاع = (float)this.nBox_Circle_R_meter.Value;
        }
        private void nBox_Rect_H_meter_ValueChanged(object sender, EventArgs e)
        {
            this.txt_H.Text = Math.Round(this.nBox_Rect_H_meter.Value * 40).ToString();
            this.polygonShape.SetAsBox((float)this.nBox_Rect_W_meter.Value, (float)this.nBox_Rect_H_meter.Value);
        }
        private void nBox_Rect_W_meter_ValueChanged(object sender, EventArgs e)
        {
            this.txt_W.Text = Math.Round(this.nBox_Rect_W_meter.Value * 40).ToString();
            this.polygonShape.SetAsBox((float)this.nBox_Rect_W_meter.Value, (float)this.nBox_Rect_H_meter.Value);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.ok = true;
            this.Close();
        }
    }
}
