using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bit = new Bitmap(200, 200);
        Bitmap grad = new Bitmap(50, 200);
        Boolean wheelClick = false;
        Boolean gradClick = false;        
        Color wheelColour = Color.White;
        Color gradColour = Color.White;
        Point wheel;
        Point gradient;
        int gR = 255;
        int gG = 255;
        int gB = 255;
        int wR = 255;
        int wG = 255;
        int wB = 255;        
        int gradY = 200;
        double percent = 1;

        void getColour(int Y)
        {
            gR = gradColour.R;
            gG = gradColour.G;
            gB = gradColour.B;
            wR = wheelColour.R;
            wG = wheelColour.G;
            wB = wheelColour.B;

            double userGrad = Y;
            
            double totalGrad = pbGradient.Height;
            percent = Math.Round(userGrad / totalGrad, 2);     

            label4.Text = percent * 100 + "%";
            wR = Convert.ToInt32(Math.Round(wR * percent));
            wG = Convert.ToInt32(Math.Round(wG * percent));
            wB = Convert.ToInt32(Math.Round(wB * percent));
            if (wR > 255) { wR = 255; }
            if (wG > 255) { wG = 255; }
            if (wB > 255) { wB = 255; }
            if (wR < 0) { wR = 0; }
            if (wG < 0) { wG = 0; }
            if (wB < 0) { wB = 0; }
            Color newColor = Color.FromArgb(wR, wG, wB);
            pnlColour.BackColor = newColor;

            string hex = "#" + pnlColour.BackColor.R.ToString("X2") + pnlColour.BackColor.G.ToString("X2") + pnlColour.BackColor.B.ToString("X2");
            string r = pnlColour.BackColor.R.ToString();
            string g = pnlColour.BackColor.G.ToString();
            string b = pnlColour.BackColor.B.ToString();
            txtHex.Text = hex;
            txtR.Text = r;
            txtB.Text = b;
            txtG.Text = g;
        }


        //Draw a color wheel
        private void pnlWheel_Paint(object sender, PaintEventArgs e)
        {            
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            DrawColorWheel(e.Graphics, this.BackColor, 10, 10, pnlWheel.Width - 20, pnlWheel.Height - 20);
        }

        // Draw a color wheel in the indicated area.
        private void DrawColorWheel(Graphics gr, Color outline_color, int xmin, int ymin, int wid, int hgt)
        {
            Rectangle rect = new Rectangle(xmin, ymin, wid, hgt);
            GraphicsPath wheel_path = new GraphicsPath();
            wheel_path.AddEllipse(rect);
            wheel_path.Flatten();

            int num_pts = (wheel_path.PointCount - 1) / 3;
            Color[] surround_colors = new Color[wheel_path.PointCount];
            float r = 255, g = 0, b = 0;
            float dr, dg, db;
            dr = -255 / num_pts;
            db = 255 / num_pts;
            for (int i = 0; i < num_pts; i++)
            {
                surround_colors[i] = Color.FromArgb(255, (int)r, (int)g, (int)b);
                r += dr;
                b += db;
            }

            r = 0; g = 0; b = 255;
            dg = 255 / num_pts;
            db = -255 / num_pts;
            for (int i = num_pts; i < 2 * num_pts; i++)
            {
                surround_colors[i] = Color.FromArgb(255, (int)r, (int)g, (int)b);
                g += dg;
                b += db;
            }

            r = 0; g = 255; b = 0;
            dr = 255 / (wheel_path.PointCount - 2 * num_pts);
            dg = -255 / (wheel_path.PointCount - 2 * num_pts);
            for (int i = 2 * num_pts; i < wheel_path.PointCount; i++)
            {
                surround_colors[i] = Color.FromArgb(255, (int)r, (int)g, (int)b);
                r += dr;
                g += dg;
            }

            using (PathGradientBrush path_brush = new PathGradientBrush(wheel_path))
            {
                path_brush.CenterColor = Color.White;
                path_brush.SurroundColors = surround_colors;

                gr.FillPath(path_brush, wheel_path);
                
                // It looks better if we outline the wheel.
                using (Pen thick_pen = new Pen(Color.Black, 2))
                {
                    gr.DrawPath(thick_pen, wheel_path);
                }
            }

            Rectangle pnlBounds = new Rectangle(0, 0, pnlWheel.Width, pnlWheel.Height);

            
            pnlWheel.DrawToBitmap(bit, pnlBounds);
            //bit.Save("wheel.bmp");

            //// Uncomment the following to draw the path's points.
            //for (int i = 0; i < wheel_path.PointCount; i++)
            //{
            //    gr.FillEllipse(Brushes.Black,
            //        wheel_path.PathPoints[i].X - 2,
            //        wheel_path.PathPoints[i].Y - 2,
            //        4, 4);
            //}

            //Bitmap bit = new Bitmap(pnlWheel.Width, pnlWheel.Height, );
            //bit.Save("wheel.bmp");
        }        

        private void pnlWheel_MouseDown(object sender, MouseEventArgs e)
        {
            wheelClick = true;            
        }

        private void pnlWheel_MouseUp(object sender, MouseEventArgs e)
        {
            wheelClick = false;
        }

        private void pnlWheel_MouseMove(object sender, MouseEventArgs e)
        {
            if (wheelClick == true)
            {
                //label2.Text = pnlWheel.PointToClient(MousePosition).ToString();
                int xc = 100;//these are hard values. dont move the wheel picture box
                int yc = 100;
                //5,30

                int x = pnlWheel.PointToClient(MousePosition).X;
                int y = pnlWheel.PointToClient(MousePosition).Y;

                int r = 87;//technically should be 90 but this works best

                wheel = pnlWheel.PointToClient(MousePosition);
                //label3.Text = (r*r) + "";
                //label4.Text = ((x - xc)* (x - xc)) + ((y - yc)* (y - yc)) + "";

                if (((x - xc) * (x - xc)) + ((y - yc) * (y - yc)) <= (r * r))//if were in the circle
                {                    
                    wheelColour = bit.GetPixel(wheel.X, wheel.Y);
                    getColour(gradY);                                       
                }
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grad = new Bitmap(pbGradient.Image);
        }      

        private void pbGradient_MouseDown_1(object sender, MouseEventArgs e)
        {
            gradClick = true;
        }

        private void pbGradient_MouseUp(object sender, MouseEventArgs e)
        {
            gradClick = false;
        }

        private void pbGradient_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (gradClick == true)
            {
                gradient = pbGradient.PointToClient(MousePosition);
                if (gradient.X < pbGradient.Width && gradient.X > 0 && gradient.Y < pbGradient.Height && gradient.Y > 0)
                {
                    gradColour = grad.GetPixel(gradient.X, gradient.Y);
                    gradY = gradient.Y;
                    getColour(gradY);
                    Point arrowPT = new Point(arrow.Location.X, gradient.Y+12);
                    arrow.Location = arrowPT;                    
                }
            }
        }

        private void lblCopyHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHex.Text);
        }

        private void lblCopyRGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("{"+txtR.Text+", "+txtG.Text+", "+txtB.Text+"}");            
        }

        private void lblCopyRGB_MouseEnter(object sender, EventArgs e)
        {
            lblCopyRGB.BackColor = Color.Purple;
            lblCopyRGB.ForeColor = Color.White;
        }

        private void lblCopyRGB_MouseLeave(object sender, EventArgs e)
        {
            lblCopyRGB.BackColor = Color.Black;
            lblCopyRGB.ForeColor = Color.White;
        }

        private void lblCopyHex_MouseEnter(object sender, EventArgs e)
        {
            lblCopyHex.BackColor = Color.Purple;
            lblCopyHex.ForeColor = Color.White;
        }

        private void lblCopyHex_MouseLeave(object sender, EventArgs e)
        {
            lblCopyHex.BackColor = Color.Black;
            lblCopyHex.ForeColor = Color.White;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spectrum V1\n09/02/18\nBy Owen Goodwin\nthe404.ml");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Detailed help content avaliable at: \nthe404.ml");
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int r = Convert.ToInt16(txtR.Text);
                int g = Convert.ToInt16(txtG.Text);
                int b = Convert.ToInt16(txtB.Text);

                string hex = "#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");

                txtHex.Text = hex;
                pnlColour.BackColor = Color.FromArgb(255, Convert.ToInt32(r), Convert.ToInt32(g), Convert.ToInt32(b));

                //double rD = Convert.ToDouble(r);
                //double gD = Convert.ToDouble(g);
                //double bD = Convert.ToDouble(b);

                //double rPercent = (rD / 255) * 100.0;
                //double gPercent = (gD / 255) * 100.0;
                //double bPercent = (bD / 255) * 100.0;

                //int avgPercent = Convert.ToInt32((rPercent + gPercent + bPercent) / 3);
                ////MessageBox.Show(rPercent+"\n"+gPercent+"\n"+bPercent);
                //label4.Text = avgPercent + "%";

                //double arrowHeight = pbGradient.Height * (avgPercent/100.0);
                ////MessageBox.Show(arrowHeight + "");

                //Point arrowPT = new Point(arrow.Location.X, Convert.ToInt32(arrowHeight) + pbGradient.Location.Y - 10);
                //arrow.Location = arrowPT;
                //MessageBox.Show(pbGradient.Height+"");
            }
            catch (Exception) {   }
        }

        private void txtHex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                String Rhex = txtHex.Text.Substring(1, 2);
                String Ghex = txtHex.Text.Substring(3, 2);
                String Bhex = txtHex.Text.Substring(5, 2);
                int r = int.Parse(Rhex, System.Globalization.NumberStyles.HexNumber);
                int g = int.Parse(Ghex, System.Globalization.NumberStyles.HexNumber);
                int b = int.Parse(Bhex, System.Globalization.NumberStyles.HexNumber);

                txtR.Text = r + "";
                txtG.Text = g + "";
                txtB.Text = b + "";
            }
            catch (Exception) { }
        }
    }
}
