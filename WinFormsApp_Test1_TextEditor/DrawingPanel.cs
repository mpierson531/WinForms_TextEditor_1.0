using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Text_Editor
{
    internal class DrawingPanel : System.Windows.Forms.Panel
    {
        public bool DrawingEnabled { get; set; } = false;
        private bool ShouldDraw = false;
        public bool Filled { get; set; } = true;
        public string? DrawShapeType { get; set; }
        public string? DrawColor { get; set; }
        public string? DrawThickness { get; set; }
        private int Thickness;
        public Bitmap? DrawingBitmap { get; set; }
        private Graphics? BitmapGraphics;
        private Pen Pen;
        private Brush Brush;

        public DrawingPanel(Point location, Size size) : this(location.X, location.Y, size.Width, size.Height)
        { }

        public DrawingPanel(int x, int y, int width, int height) : base()
        {
            BackColor = Color.White;
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SetBounds(x, y, width, height);
            Enabled = false;
            Visible = false;
            MouseClick += MouseClicked;
            MouseUp += MouseIsUp;
            MouseDown += MouseIsDown;
            MouseMove += MouseMoving;
            Paint += Painting;
            VisibleChanged += VisibilityChanged;

            typeof(Panel).InvokeMember(
           "DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null,
           this, new object[] { true });
        }

        private void Painting(object? sender, PaintEventArgs e)
        {
            if (DrawingEnabled && DrawingBitmap != null)
            {
                SetGraphicsQuality(e.Graphics, false);
                e.Graphics.DrawImage(DrawingBitmap, ClientRectangle.X, ClientRectangle.Y);
            }
        }

        private void MouseClicked(object? sender, MouseEventArgs e)
        {
            if (DrawingEnabled)
            {
                ShouldDraw = true;
                Draw(e);
            }
        }

        private void MouseIsDown(object? sender, MouseEventArgs e)
        {
            if (DrawingEnabled)
            {
                ShouldDraw = true;
                Draw(e);
            }
        }

        private void MouseIsUp(object? sender, MouseEventArgs e)
        {
            ShouldDraw = false;
        }

        private void MouseMoving(object? sender, MouseEventArgs e)
        {
            if (DrawingEnabled && ShouldDraw)
            {
                Draw(e);
            }
        }

        private void Draw(MouseEventArgs e)
        {
            SetPenAndBrush();

            if (string.IsNullOrEmpty(DrawThickness) || !int.TryParse(DrawThickness.Trim(), out Thickness))
            {
                Thickness = 15;
            }

            DrawToBitmap(e);
            Invalidate();
        }

        private void DrawToBitmap(MouseEventArgs e)
        {
            BitmapGraphics = Graphics.FromImage(DrawingBitmap);
            SetGraphicsQuality(BitmapGraphics, false);
            GC.SuppressFinalize(BitmapGraphics);
            int x;
            int y;
            int width;
            int height;
            if (!string.IsNullOrEmpty(DrawShapeType))
            {
                if (Filled)
                {
                    switch (DrawShapeType.Trim())
                    {
                        case "Line":
                        case "line":
                            x = e.X;
                            y = e.Y;
                            width = Thickness;
                            height = Thickness;
                            BitmapGraphics.FillEllipse(Brush, x, y, width, height / 2);
                            break;
                        case "Circle":
                        case "circle":
                            x = e.X - Thickness;
                            y = e.Y - Thickness;
                            width = Thickness * 2;
                            height = Thickness * 2;
                            BitmapGraphics.FillEllipse(Brush, x, y, width, height);
                            break;
                        case "Rectangle":
                        case "rectangle":
                        case "rect":
                        case "Rect":
                            x = e.X;
                            y = e.Y;
                            width = Thickness;
                            height = Thickness;
                            BitmapGraphics.FillRectangle(Brush, x, y, width, height);
                            break;
                        default:
                            x = e.X;
                            y = e.Y;
                            width = Thickness;
                            height = Thickness;
                            BitmapGraphics.FillEllipse(Brush, x, y, width, height);
                            break;
                    }
                }
                else
                {
                    switch (DrawShapeType.Trim())
                    {
                        case "Line":
                        case "line":
                            x = e.X;
                            y = e.Y;
                            width = Thickness;
                            height = Thickness;
                            BitmapGraphics.DrawEllipse(Pen, x, y, width, height);
                            break;
                        case "Circle":
                        case "circle":
                            x = e.X - Thickness;
                            y = e.Y - Thickness;
                            width = Thickness * 2;
                            height = Thickness * 2;
                            BitmapGraphics.DrawEllipse(Pen, x, y, width, height);
                            break;
                        case "Rectangle":
                        case "rectangle":
                        case "rect":
                        case "Rect":
                            x = e.X;
                            y = e.Y;
                            width = Thickness;
                            height = Thickness;
                            BitmapGraphics.DrawRectangle(Pen, x, y, width, height);
                            break;
                        default:
                            x = e.X;
                            y = e.Y;
                            width = Thickness;
                            height = Thickness;
                            BitmapGraphics.DrawEllipse(Pen, x, y, width, height);
                            break;
                    }
                }
            }
            else
            {
                x = e.X;
                y = e.Y;
                width = Thickness;
                height = Thickness;
                BitmapGraphics.FillEllipse(Brush, x, y, width, height);
            }

            DisposePenAndBrush();
            DisposeGraphics(false);
        }

        private void SetPenAndBrush()
        {
            if (!string.IsNullOrEmpty(DrawColor))
            {
                switch (DrawColor.Trim())
                {
                    case "Blue":
                        Brush = new SolidBrush(Color.Blue);
                        Pen = new Pen(Color.Blue);
                        break;
                    case "Black":
                        Brush = new SolidBrush(Color.Black);
                        Pen = new Pen(Color.Black);
                        break;
                    case "Green":
                        Brush = new SolidBrush(Color.Green);
                        Pen = new Pen(Color.Green);
                        break;
                    case "Orange":
                        Brush = new SolidBrush(Color.Orange);
                        Pen = new Pen(Color.Orange);
                        break;
                    case "Red":
                        Brush = new SolidBrush(Color.Red);
                        Pen = new Pen(Color.Red);
                        break;
                    case "Yellow":
                        Brush = new SolidBrush(Color.Yellow);
                        Pen = new Pen(Color.Yellow);
                        break;
                    default:
                        Brush = new SolidBrush(Color.Blue);
                        Pen = new Pen(Color.Blue);
                        break;
                }
            } else
            {
                Brush = new SolidBrush(Color.Blue);
                Pen = new Pen(Color.Blue);
            }
        }

        private void VisibilityChanged(object? sender, EventArgs e)
        {
            if (Visible)
            {
                BitmapGraphics = Graphics.FromImage(DrawingBitmap);
                BitmapGraphics.Clear(Color.White);
            }
            else
            {
                DisposeGraphics(true);
                BitmapGraphics = null;
                DrawingBitmap = null;
            }
        }

        public void Clear(Color color)
        {
            if (BitmapGraphics != null)
            {
                BitmapGraphics = Graphics.FromImage(DrawingBitmap);
                BitmapGraphics.Clear(color);
                Invalidate();
            }
        }

        public void ResizePanel(int width, int height)
        {
            Width = width;
            Height = height;

            if (DrawingEnabled)
            {
                DrawingBitmap = GetResizedBitmap(width, height);
                BitmapGraphics = Graphics.FromImage(DrawingBitmap);
                Invalidate();
            }
        }

        private Bitmap GetResizedBitmap(int width, int height)
        {
            var destinationRect = new Rectangle(0, 0, width, height);
            var newBitmap = new Bitmap(width, height);

            newBitmap.SetResolution(DrawingBitmap.HorizontalResolution, DrawingBitmap.VerticalResolution);

            var newGraphics = Graphics.FromImage(newBitmap);
            SetGraphicsQuality(newGraphics, true);

            var attributes = new ImageAttributes();
            attributes.SetWrapMode(WrapMode.Clamp, Color.White);

            newGraphics.Clear(Color.White);
            newGraphics.DrawImage(DrawingBitmap, destinationRect, 0, 0, width,
                height, GraphicsUnit.Pixel, attributes);

            return newBitmap;
        }

        private void SetGraphicsQuality(Graphics graphics, bool doSourceCopy)
        {
            if (doSourceCopy)
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
            } else
            {
                graphics.CompositingMode = CompositingMode.SourceOver;
            }
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
        }

        public void DisposeGraphics(bool disposeBitmap)
        {
            BitmapGraphics.Dispose();

            if (disposeBitmap)
            {
                DrawingBitmap.Dispose();
            }
        }

        private void DisposePenAndBrush()
        {
            Pen.Dispose();
            Brush.Dispose();
        }
    }
}