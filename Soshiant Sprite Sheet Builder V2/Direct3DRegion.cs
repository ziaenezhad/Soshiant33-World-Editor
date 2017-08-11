using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

using Nevron.UI.WinForm.Controls;

namespace Soshiant_Sprite_Sheet_Builder
{
    class Frame
    {
        public NGalleryItem avatar;
        public Texture texture;
        public PointF centerPoint;
        public Frame(string filename)
        {
            avatar = new NGalleryItem();
            avatar.Label.Image = Bitmap.FromFile(filename);
            avatar.Label.ImageSize = new Nevron.GraphicsCore.NSize(avatar.Label.Image.Width, (int)(avatar.Label.Image.Height / (float)avatar.Label.Image.Width * 100));
            avatar.Label.ImageSizeMode = Nevron.UI.ImageSizeMode.Stretch;
            avatar.Label.ImageTextRelation = Nevron.UI.ImageTextRelation.ImageAboveText;
            if (SpriteSheetBuilder.d3dDevice != null)
            {
                texture = TextureLoader.FromFile(SpriteSheetBuilder.d3dDevice, filename, avatar.Label.Image.Width, avatar.Label.Image.Height, 1, Usage.RenderTarget, Format.A8R8G8B8, Pool.Default, Filter.Linear, Filter.Linear, 0);
                centerPoint.X = avatar.Label.Image.Width / 2.0f;
                centerPoint.Y = avatar.Label.Image.Height / 2.0f;
            }
            else
                texture = null;
        }
    }
    partial class SpriteSheetBuilder
    {
        public static Device d3dDevice;
        Sprite sprite;
        Texture gridTexture;
        Rectangle gridRect;
        PointF gridIndex = new PointF(0, 0);
        SizeF grideSize ;
        Texture centerPointTexture;
        PointF centerPoint;
        Color centerPointTextureColor = Color.Red;
        float centerPointTextureRotation = 0;
        PointF centerPointCP = new PointF(8, 8);
        Vector2 world_trans = new Vector2(0, 0);
        Vector2 world_scale = new Vector2(1, 1);
        Mesh testMesh = null;

        void InitDirect3D()
        {
            PresentParameters pp = new PresentParameters();
            pp.Windowed = true;
            pp.SwapEffect = SwapEffect.Discard;
            pp.EnableAutoDepthStencil = true;
            pp.AutoDepthStencilFormat = DepthFormat.D24X8;
            Caps cap = Manager.GetDeviceCaps(0, DeviceType.Hardware);
            d3dDevice = new Device(0, DeviceType.Hardware, this.splitContainer1.Panel2, CreateFlags.HardwareVertexProcessing, pp);
            Application.Idle += new EventHandler(Application_Idle);

            sprite = new Sprite(d3dDevice);
            gridTexture = new Texture(SpriteSheetBuilder.d3dDevice, global::Soshiant_Sprite_Sheet_Builder.Properties.Resources.gridPic, Usage.None, Pool.Managed);
            centerPointTexture = new Texture(SpriteSheetBuilder.d3dDevice, global::Soshiant_Sprite_Sheet_Builder.Properties.Resources.centerPointPic, Usage.None, Pool.Managed);

            d3dDevice.RenderState.CullMode = Cull.None;
            d3dDevice.RenderState.FillMode = FillMode.WireFrame;
            d3dDevice.RenderState.Lighting = false;
            d3dDevice.Transform.Projection = Matrix.PerspectiveFovLH((float)Math.PI / 4, this.Width / this.Height, 1f, 80f);
            
            //d3dDevice.Transform.View = Matrix.LookAtLH(new Vector3(0, 0, -300), new Vector3(0, 0, 0), new Vector3(0, 1, 0));

            //testMesh = Mesh.Teapot(d3dDevice);
            //ExtendedMaterial[] materials = new ExtendedMaterial[1];
            //materials[0] = new ExtendedMaterial();
            //Material material = new Material();
            //material.Diffuse = Color.Red;
            //materials[0].Material3D = material;
            //testMesh.Save("e:\\teapot.cmp.x", (int[])null, materials, null, XFileFormat.Compressed);
        }
        float xRot = 0;
        void Render()
        {
            if (d3dDevice != null)
            {
                d3dDevice.Clear(ClearFlags.Target| ClearFlags.ZBuffer,splitContainer1.Panel2.BackColor, 1.0f, 0);
                d3dDevice.BeginScene();
                sprite.Begin(SpriteFlags.AlphaBlend);
                d3dDevice.SamplerState[0].AddressU = TextureAddress.Wrap;
                d3dDevice.SamplerState[0].AddressV = TextureAddress.Wrap;
                sprite.Draw2D(gridTexture, gridRect, grideSize, gridIndex, Color.Green);
                sprite.Flush();
                d3dDevice.SetTransform(TransformType.World, Matrix.Transformation2D(new Vector2(centerPoint.X, centerPoint.Y), 0, world_scale, Vector2.Empty, 0, world_trans));
                if (selectedFrame != null)
                    sprite.Draw2D(selectedFrame.texture, selectedFrame.centerPoint, 0, centerPoint, Color.White);
                sprite.Draw2D(centerPointTexture, centerPointCP, centerPointTextureRotation, centerPoint, centerPointTextureColor);
                sprite.End();
                d3dDevice.EndScene();
                d3dDevice.Present();
            }
        }
        void Application_Idle(object sender, EventArgs e)
        {
            this.Render();
            if (selectedFrame != null)
                toolStripStatusLabel1.Text = "نقطه مرکز قاب [" + selectedFrame.centerPoint.X.ToString() + "," + selectedFrame.centerPoint.Y.ToString() + "]";
            else
                toolStripStatusLabel1.Text = "نقطه مرکز قاب [0,0]";
        }
        private void splitContainer1_Panel2_SizeChanged(object sender, EventArgs e)
        {
            if (d3dDevice != null)
            {
                d3dDevice.Transform.Projection = Matrix.PerspectiveLH(
                    (float)this.splitContainer1.Panel2.Width,
                    (float)this.splitContainer1.Panel2.Height,
                    1.0f,
                    64000.0f);
                centerPoint = new PointF(splitContainer1.Panel2.Width / 2.0f, splitContainer1.Panel2.Height / 2.0f);
                gridRect = new Rectangle(0, 0, splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);
                grideSize = new SizeF(gridRect.Width, gridRect.Height);
            }
        }
        static int FrameCompare(Frame a, Frame b)
        {
            if ((a.avatar.Label.Image.Width * a.avatar.Label.Image.Height) > (b.avatar.Label.Image.Width * b.avatar.Label.Image.Height))
                return -1;
            else
                return 1;
        }
        void SaveTexture(string filename)
        {
            //this.frames.Sort(FrameCompare);
            int tWidth = 1;// frames[0].avatar.Label.Image.Width;
            int tHeight = 1;// frames[0].avatar.Label.Image.Height;
            bool flag = true;
            Texture outputTexture = null;
            CustomVertex.PositionColoredTextured[] vertexes = new CustomVertex.PositionColoredTextured[4 * frames.Count];
            short[] indexes = new short[frames.Count * 6];
            for (int j = 0; j < frames.Count * 4; j++)
            {
                vertexes[j].Color = Color.White.ToArgb();
                vertexes[j].Position = new Vector3(0, 0, 0);
            }
            //int maxWidth, maxHeight;
            if (frames.Count > 1)
                while (flag)
                {
                    if (OTNode.wFlag)
                        tWidth += OTNode.widthNeed;
                    else
                        tHeight += OTNode.heightNeed;
                    //tWidth *= 2;
                    // tHeight *= 2;
                    if (outputTexture != null)
                        outputTexture.Dispose();
                    outputTexture = new Texture(d3dDevice, tWidth, tHeight, 1, Usage.RenderTarget, Format.A8R8G8B8, Pool.Default);
                    Surface outputTextureSurface = outputTexture.GetSurfaceLevel(0);
                    d3dDevice.ColorFill(outputTextureSurface, new Rectangle(0, 0, tWidth, tHeight), Color.Magenta);
                    OTNode.target = outputTextureSurface;
                    OTNode node = new OTNode(new Rectangle(0, 0, tWidth, tHeight));

                    //maxHeight = maxWidth = 0;
                    for (int i = 0; i < frames.Count; i++)
                    {
                        toolStripProgressBar1.Value = (int)((float)(i + 1) / frames.Count * 100);
                        this.Update();
                        Rectangle rect = node.Insert(frames[i]);
                        if (rect == Rectangle.Empty)
                        {
                            flag = true;
                            break;
                        }
                        else
                            flag = false;
                        //if (rect.Right > maxWidth)
                        //    maxWidth = rect.Right;
                        //if (rect.Bottom > maxHeight)
                        //    maxHeight = rect.Bottom;
                        vertexes[i * 4].X = -frames[i].centerPoint.X;
                        vertexes[i * 4].Y = frames[i].centerPoint.Y - frames[i].avatar.Label.Image.Height;

                        vertexes[i * 4 + 1].X = vertexes[i * 4].X;
                        vertexes[i * 4 + 1].Y = frames[i].centerPoint.Y;

                        vertexes[i * 4 + 2].X = frames[i].avatar.Label.Image.Width - frames[i].centerPoint.X; ;
                        vertexes[i * 4 + 2].Y = vertexes[i * 4 + 1].Y;

                        vertexes[i * 4 + 3].X = vertexes[i * 4 + 2].X;
                        vertexes[i * 4 + 3].Y = vertexes[i * 4].Y;

                        vertexes[i * 4].Tu = (rect.Left + 1) / (float)tWidth;
                        vertexes[i * 4].Tv = (rect.Bottom - 1) / (float)tHeight;
                        vertexes[i * 4 + 1].Tu = vertexes[i * 4].Tu;
                        vertexes[i * 4 + 1].Tv = (rect.Top + 1) / (float)tHeight;
                        vertexes[i * 4 + 2].Tu = (rect.Right - 1) / (float)tWidth;
                        vertexes[i * 4 + 2].Tv = vertexes[i * 4 + 1].Tv;
                        vertexes[i * 4 + 3].Tu = vertexes[i * 4 + 2].Tu;
                        vertexes[i * 4 + 3].Tv = vertexes[i * 4].Tv;


                        indexes[i * 6 + 0] = (short)(i * 4 + 0); indexes[i * 6 + 1] = (short)(i * 4 + 1); indexes[i * 6 + 2] = (short)(i * 4 + 2);
                        indexes[i * 6 + 3] = (short)(i * 4 + 3); indexes[i * 6 + 4] = (short)(i * 4 + 0); indexes[i * 6 + 5] = (short)(i * 4 + 2);
                    }
                }
            else
            {
                int i = 0;
                tWidth = frames[0].avatar.Label.Image.Width;
                tHeight = frames[0].avatar.Label.Image.Height;
                Rectangle rect = new Rectangle(0, 0, frames[0].avatar.Label.Image.Width, frames[0].avatar.Label.Image.Height);
                vertexes[i * 4].X = -frames[i].centerPoint.X;
                vertexes[i * 4].Y = frames[i].centerPoint.Y - frames[i].avatar.Label.Image.Height;

                vertexes[i * 4 + 1].X = vertexes[i * 4].X;
                vertexes[i * 4 + 1].Y = frames[i].centerPoint.Y;

                vertexes[i * 4 + 2].X = frames[i].avatar.Label.Image.Width - frames[i].centerPoint.X; ;
                vertexes[i * 4 + 2].Y = vertexes[i * 4 + 1].Y;

                vertexes[i * 4 + 3].X = vertexes[i * 4 + 2].X;
                vertexes[i * 4 + 3].Y = vertexes[i * 4].Y;

                vertexes[i * 4].Tu = (rect.Left + 1) / (float)tWidth;
                vertexes[i * 4].Tv = (rect.Bottom - 1) / (float)tHeight;
                vertexes[i * 4 + 1].Tu = vertexes[i * 4].Tu;
                vertexes[i * 4 + 1].Tv = (rect.Top + 1) / (float)tHeight;
                vertexes[i * 4 + 2].Tu = (rect.Right - 1) / (float)tWidth;
                vertexes[i * 4 + 2].Tv = vertexes[i * 4 + 1].Tv;
                vertexes[i * 4 + 3].Tu = vertexes[i * 4 + 2].Tu;
                vertexes[i * 4 + 3].Tv = vertexes[i * 4].Tv;


                indexes[i * 6 + 0] = (short)(i * 4 + 0); indexes[i * 6 + 1] = (short)(i * 4 + 1); indexes[i * 6 + 2] = (short)(i * 4 + 2);
                indexes[i * 6 + 3] = (short)(i * 4 + 3); indexes[i * 6 + 4] = (short)(i * 4 + 0); indexes[i * 6 + 5] = (short)(i * 4 + 2);

                outputTexture = frames[0].texture;
            }
            Mesh mesh = new Mesh(2 * frames.Count, 4 * frames.Count, MeshFlags.Managed, CustomVertex.PositionColoredTextured.Format, d3dDevice);
            
            mesh.SetVertexBufferData(vertexes, LockFlags.None);
            mesh.SetIndexBufferData(indexes, LockFlags.None);
            //---------------------------
            //Setting one of these does NOT work.  You MUST set both.
            AttributeRange[] attributeTable = new AttributeRange[frames.Count];
            int[] attributes = mesh.LockAttributeBufferArray(LockFlags.None);
            for (int i = 0; i < frames.Count; i++)
            {
                attributes[i*2] = i;
                attributes[i*2+1] = i;
                attributeTable[i].AttributeId = i;  //ID is the value passed into the DrawSubset function of Mesh.
                attributeTable[i].FaceCount = 2;    //Our subsets only have 1 face.
                attributeTable[i].FaceStart = i*2;
                attributeTable[i].VertexCount = 4;  //We need 3 vertices to make a face.
                attributeTable[i].VertexStart = i*4;
            }
            mesh.UnlockAttributeBuffer(attributes);
            mesh.SetAttributeTable(attributeTable);
            //---------------------------
            ExtendedMaterial[] em = new ExtendedMaterial[frames.Count];
            em[0].TextureFilename = System.IO.Path.GetFileNameWithoutExtension(filename)+".dds";
            for (int i = 0; i < frames.Count; i++)
            {
                Material mat = new Material();
                mat.Diffuse = Color.White;
                mat.Ambient = mat.Diffuse;
                mat.Specular = mat.Diffuse;
                mat.Emissive = Color.Black;
                em[i].Material3D = mat;
            }
            mesh.Save(System.IO.Path.GetFileNameWithoutExtension(filename)+".sht", (int[])null, em, null, XFileFormat.Binary);
            TextureLoader.Save(System.IO.Path.GetFileNameWithoutExtension(filename) + ".dds", ImageFileFormat.Dds, outputTexture);
        }
    }
    public struct PositionNormalTexVertex
    {
        public Vector3 Position;
        public Vector3 Normal;
        public float u, v;
        public uint diffuse;
        public static readonly VertexFormats FVF = VertexFormats.Position | VertexFormats.Normal| VertexFormats.Texture1| VertexFormats.Diffuse;
    }
    internal class OTNode
    {
        public static Surface target = null;
        public static int widthNeed = 0;
        public static int heightNeed = 0;
        public static bool wFlag = true;

        public Rectangle rect = Rectangle.Empty;
        public bool filled = false;
        public OTNode Bottom = null;
        public OTNode Right = null;

        public OTNode(Rectangle size)
        {
            this.rect = size;
        }
        public Rectangle Insert(Frame frame)
        {
            if (this.filled)
            {
                // I am not a leaf
                Rectangle output = this.Right.Insert(frame);
                if (output != Rectangle.Empty)
                    return output;
                else
                    return this.Bottom.Insert(frame);
            }
            //so this is leaf 
            if (this.rect.Width < frame.avatar.Label.Image.Width)
            {
                OTNode.wFlag = true;
                OTNode.widthNeed = frame.avatar.Label.Image.Width - this.rect.Width;
                return Rectangle.Empty;
            }
            OTNode.widthNeed = 0;
            if (this.rect.Height < frame.avatar.Label.Image.Height)
            {
                OTNode.wFlag = false;
                OTNode.heightNeed = frame.avatar.Label.Image.Height - this.rect.Height;
                if (target.Description.Width < target.Description.Height)
                {
                    OTNode.wFlag = true;
                    OTNode.widthNeed = frame.avatar.Label.Image.Width;
                }
                return Rectangle.Empty;
            }
            OTNode.heightNeed = 0;
            // frame is fitt for this
            //if((this.rect.Width == frame.avatar.Label.Image.Width) && (this.rect.Height == frame.avatar.Label.Image.Height))
            //{
            //    this.Insert(frame, this.rect);
            //    return this.rect;
            //}
            //frame is smaller than this.rect
            Rectangle destRect = new Rectangle(this.rect.Left,this.rect.Top,frame.avatar.Label.Image.Width, frame.avatar.Label.Image.Height);
            this.Insert(frame, destRect);
            //int dw = this.rect.Width - frame.avatar.Label.Image.Width;
            //int dh = this.rect.Height - frame.avatar.Label.Image.Height;  
            

            Rectangle BRect = new Rectangle(this.rect.Left
                                            , this.rect.Top + frame.avatar.Label.Image.Height
                                            , this.rect.Width
                                            , this.rect.Height - frame.avatar.Label.Image.Height);
            Rectangle RRect = new Rectangle(this.rect.Left + frame.avatar.Label.Image.Width
                                            , this.rect.Top
                                            , this.rect.Width - frame.avatar.Label.Image.Width
                                            , frame.avatar.Label.Image.Height);
            //if (dw > dh)
            //{
                this.Bottom = new OTNode(BRect);
                this.Right = new OTNode(RRect);
            //}
            //else
            //{
            //    this.Bottom = new OTNode(RRect);
            //    this.Right = new OTNode(BRect);
            //}
            return destRect;
        }
        void Insert(Frame frame,Rectangle targetRect)
        {
            if (OTNode.target != null && SpriteSheetBuilder.d3dDevice != null)
            {
                Surface surf = frame.texture.GetSurfaceLevel(0);
                Rectangle sourceRect = new Rectangle(0, 0, frame.avatar.Label.Image.Width, frame.avatar.Label.Image.Height);
                SpriteSheetBuilder.d3dDevice.StretchRectangle(surf, sourceRect, OTNode.target, targetRect, TextureFilter.None);
            }
            this.filled = true;
        }
    }
}
