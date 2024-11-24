using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class form_paintit : Form
    {
        //Fiel1ds
        PointF CurrentPositionSystem, CurrentPositionCartesian;
        bool isDrawing = false;
        int indexDrawing = -1;
        int x, y, sX, sY, cX, cY;
        Color colorP;
        Point pointX, pointY;
        Bitmap bm;
        Graphics gr;
        Image openedFile;
        Pen pen = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 1);
        ColorDialog colorDialog = new ColorDialog();

        readonly Stack<Bitmap> UndoStack = new Stack<Bitmap>();
        readonly Stack<Bitmap> RedoStack = new Stack<Bitmap>();

        public form_paintit()
        {
            InitializeComponent();

            bm = new Bitmap(picbox_canvas.Width, picbox_canvas.Height);
            gr = Graphics.FromImage(bm);
            gr.Clear(Color.White);
            picbox_canvas.Image = bm;

            colorP = btn_ColorSet.BackColor = Color.Black;
            picbox_second_colorSet.BackColor = Color.White;
        }


        //Methods
        private PointF PointToCartesian(Point point)
        {
            return new PointF(point.X, picbox_canvas.Height - point.Y);
        }

        static Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float pY = 1f * pictureBox.Image.Height / pictureBox.Height;
            return new Point((int)(point.X * pX), (int)(point.Y * pY));
        }

        private void Validate(Bitmap bm, Stack<Point> pointStack, int x, int y, Color colorNew, Color colorOld)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == colorOld)
            {
                pointStack.Push(new Point(x, y));
                bm.SetPixel(x, y, colorNew);
            }
        }

        private bool ExcessBounds(int x, int y, int width, int height)
        {
            if (x < 0 || y < 0 || width + x > bm.Width || height + y > bm.Height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void FillUp(Bitmap bm, int x, int y, Color newColor)
        {
            Color oldColor = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, newColor);
            if (oldColor == newColor) return;

            while (pixel.Count > 0)
            {
                Point point = pixel.Pop();
                if (point.X > 0 && point.Y > 0 && point.X < bm.Width - 1 && point.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, point.X - 1, point.Y, newColor, oldColor);
                    Validate(bm, pixel, point.X, point.Y - 1, newColor, oldColor);
                    Validate(bm, pixel, point.X + 1, point.Y, newColor, oldColor);
                    Validate(bm, pixel, point.X, point.Y + 1, newColor, oldColor);
                }
            }
        }

        private void picbox_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            CurrentPositionSystem = e.Location;
            CurrentPositionCartesian = PointToCartesian(e.Location);
            lbl_coords.Text = String.Format("X: {0} Y: {1}", CurrentPositionCartesian.X, CurrentPositionCartesian.Y);

            if (isDrawing)
            {
                if (indexDrawing == 0)
                {
                    pointX = e.Location;
                    gr.DrawLine(pen, pointY, pointX);
                    pointY = pointX;
                }

                if (indexDrawing == 1)
                {
                    pointX = e.Location;
                    gr.DrawLine(eraser, pointY, pointX);
                    pointY = pointX;
                }

            }
            picbox_canvas.Refresh();
        }


        private void picbox_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            pointY = e.Location;
            x = pointY.X;
            y = pointY.Y;

            UndoStack.Push((Bitmap)bm.Clone());
            RedoStack.Clear();
        }

        private void picbox_canvas_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = SetPoint(picbox_canvas, e.Location);
            if (indexDrawing == 3)
            {
                FillUp(bm, point.X, point.Y, colorP);
            }
        }

        private void picbox_canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            sX = e.Location.X;
            sY = e.Location.Y;
            cX = sX;
            cY = sY;

            switch (indexDrawing)
            {
                case 2:
                    gr.DrawLine(pen, x, y, cX, cY);

                    break;

                case 4:
                    if (ExcessBounds(x, y, Math.Abs(y - cY), Math.Abs(y - cY)) == false)
                    {
                        gr.DrawEllipse(pen, x, y, Math.Abs(y - cY), Math.Abs(y - cY));
                    }
                    break;

                case 5:
                    if (ExcessBounds(x, y, Math.Abs(x - cX), Math.Abs(x - cX)) == false)
                    {
                        gr.DrawRectangle(pen, x, y, Math.Abs(x - cX), Math.Abs(x - cX));

                    }
                    break;

                case 6:
                    if (ExcessBounds(x, y, Math.Abs(x - cX), Math.Abs(y - cY)) == false)
                    {
                        gr.DrawRectangle(pen, x, y, Math.Abs(x - cX), Math.Abs(y - cY));

                    }
                    break;

                case 7:
                    int widthTriangle = Math.Abs(x - cX);
                    if (ExcessBounds(x, y, Math.Abs(x - widthTriangle), cY) == false)
                    {
                        Point[] triangle = new Point[3];
                        triangle[0] = new Point { X = x, Y = y };
                        triangle[1] = new Point { X = cX, Y = cY };
                        triangle[2] = new Point { X = Math.Abs(x - widthTriangle), Y = cY };
                        gr.DrawPolygon(pen, triangle);
                    }
                    break;

                case 8:
                    int widthside = Math.Abs(x - cX);
                    if (ExcessBounds(x, y, Math.Abs(x - widthside), cY) == false)
                    {
                        Point[] pentagon = new Point[5];

                        pentagon[0] = new Point { X = x, Y = y };
                        pentagon[1] = new Point { X = cX, Y = cY };
                        pentagon[2] = new Point { X = cX, Y = cY - widthside };


                        pentagon[3] = new Point { X = Math.Abs(x - widthside), Y = cY - widthside };
                        pentagon[4] = new Point { X = Math.Abs(x - widthside), Y = cY + widthside };


                        gr.DrawPolygon(pen, pentagon);
                    }
                    break;
            }
        }

        private void btn_ColorSet_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorP = btn_ColorSet.BackColor = pen.Color = colorDialog.Color;
        }

        private void btn_swap_color_Click(object sender, EventArgs e)
        {
            Color aux_color;
            aux_color = picbox_second_colorSet.BackColor;
            picbox_second_colorSet.BackColor = btn_ColorSet.BackColor;
            pen.Color = colorP = btn_ColorSet.BackColor = aux_color;
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            indexDrawing = 0;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            indexDrawing = 1;
        }

        private void cleanCanvasMstrip_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.White);
            picbox_canvas.Refresh();
        }

        private void backgroundChangeColorMstrip_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            gr.Clear(colorDialog.Color);
            picbox_canvas.Refresh();
        }

        private void width_bar_pen_Scroll(object sender, EventArgs e)
        {
            lbl_width_show.Text = (width_bar_pen.Value + 1).ToString();
            eraser.Width = pen.Width = width_bar_pen.Value;
        }

        private void picbox_canvas_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //if (isDrawing)
            //{
            //    switch (indexDrawing)
            //    {
            //        case 2:
            //            g.DrawLine(pen, x, y, cX, cY);
            //            break;

            //        case 4:
            //            if (ExcessBounds(x, y, Math.Abs(y - cY), Math.Abs(y - cY)) == false)
            //            {
            //                g.DrawEllipse(pen, x, y, Math.Abs(y - cY), Math.Abs(y - cY));
            //            }
            //            break;

            //        case 5:
            //            if (ExcessBounds(x, y, Math.Abs(x - cX), Math.Abs(x - cX)) == false)
            //            {
            //                g.DrawRectangle(pen, x, y, Math.Abs(x - cX), Math.Abs(x - cX));
            //            }
            //            break;

            //        case 6:
            //            if (ExcessBounds(x, y, Math.Abs(x - cX), Math.Abs(y - cY)) == false)
            //            {
            //                g.DrawRectangle(pen, x, y, Math.Abs(x - cX), Math.Abs(y - cY));
            //            }
            //            break;

            //        case 7:
            //            int widthTriangle = Math.Abs(x - cX);
            //            if (ExcessBounds(x, y, Math.Abs(x - widthTriangle), cY) == false)
            //            {
            //                Point[] triangle = new Point[3];
            //                triangle[0] = new Point { X = x, Y = y };
            //                triangle[1] = new Point { X = cX, Y = cY };
            //                triangle[2] = new Point { X = Math.Abs(x - widthTriangle), Y = cY };
            //                g.DrawPolygon(pen, triangle);
            //            }
            //            break;

            //        case 8:
            //            int widthside = Math.Abs(x - cX);
            //            if (ExcessBounds(x, y, Math.Abs(x - widthside), cY) == false)
            //            {
            //                Point[] pentagon = new Point[5];

            //                pentagon[0] = new Point { X = x, Y = y };
            //                pentagon[1] = new Point { X = cX, Y = cY };
            //                pentagon[2] = new Point { X = cX, Y = cY - widthside };


            //                pentagon[3] = new Point { X = Math.Abs(x - widthside), Y = cY - widthside };
            //                pentagon[4] = new Point { X = Math.Abs(x - widthside), Y = cY + widthside };


            //                g.DrawPolygon(pen, pentagon);
            //            }
            //            break;
            //    }
            //}
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save an image file";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        this.picbox_canvas.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.picbox_canvas.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
                fs.Close();
            }

        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Bitmap Image|*.bmp";
            openFile.Title = "Open a image file";

            DialogResult dr = openFile.ShowDialog();

            if (dr == DialogResult.OK)
            {
                try
                {
                    picbox_canvas.Image = new Bitmap(openFile.FileName);
                    bm = new Bitmap(picbox_canvas.Image);
                    gr = Graphics.FromImage(bm);
                    picbox_canvas.Image = bm;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Cargar el archivo" + ex.Message);
                }
            }
        }

        private void btn_text_Click(object sender, EventArgs e)
        {
            indexDrawing = 9;
        }

        private void dezhacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UndoStack.Count > 0)
            {
                RedoStack.Push((Bitmap)bm.Clone());
                bm = UndoStack.Pop();
                gr = Graphics.FromImage(bm);
                picbox_canvas.Image = bm;
                picbox_canvas.Invalidate();
            }
            else
            {
                MessageBox.Show("There is nothing to undo");
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RedoStack.Count > 0)
            {
                UndoStack.Push((Bitmap)bm.Clone());
                bm = RedoStack.Pop();
                gr = Graphics.FromImage(bm);
                picbox_canvas.Image = bm;
                picbox_canvas.Invalidate();
            }
            else
            {
                MessageBox.Show("There is nothing to redo");
            }
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            indexDrawing = 2;
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            indexDrawing = 3;
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            indexDrawing = 4;
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            indexDrawing = 5;
        }
        private void btn_rectangle_Click(object sender, EventArgs e)
        {
            indexDrawing = 6;
        }

        private void btn_triangle_Click(object sender, EventArgs e)
        {
            indexDrawing = 7;
        }

        private void btn_polygon_Click(object sender, EventArgs e)
        {
            indexDrawing = 8;
        }

    }

}
