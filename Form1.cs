using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_Project08
{
    public partial class Form1 : Form
    {
        Bitmap hinhgoc;
        public Form1()
        {
            InitializeComponent();
            hinhgoc = new Bitmap(@"C:\Users\hoang\OneDrive\Máy tính\Image Processing\C#\lena_color.gif");
            pictureBox_hinhgoc.Image = hinhgoc;
            textBox_nguong.Text = "130";//ngưỡng mặc định
        }
        public Bitmap Edge_Detect_Sobel(Bitmap HinhGoc, int D0)
        {
            //sobel gx
            int[,] mask_x = new int[3, 3];
            mask_x[0, 0] = -1; mask_x[1, 0] = -2; mask_x[2, 0] = -1;
            mask_x[0, 1] = 0; mask_x[1, 1] = 0; mask_x[2, 1] = 0;
            mask_x[0, 2] = 1; mask_x[1, 2] = 2; mask_x[2, 2] = 1;
            //sobel gy
            int[,] mask_y = new int[3, 3];
            mask_y[0, 0] = -1; mask_y[1, 0] = 0; mask_y[2, 0] = 1;
            mask_y[0, 1] = -2; mask_y[1, 1] = 0; mask_y[2, 1] = 2;
            mask_y[0, 2] = -1; mask_y[1, 2] = 0; mask_y[2, 2] = 1;

            Bitmap edge = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 1; x < HinhGoc.Width - 1; x++)
                for (int y = 1; y < HinhGoc.Height - 1; y++)
                {
                    double gxR = 0, gyR = 0;
                    double gxG = 0, gyG = 0;
                    double gxB = 0, gyB = 0;

                    double gxx = 0;
                    double gyy = 0;
                    double gxy = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = HinhGoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            gxR += R * mask_x[i - (x - 1), j - (y - 1)];//tích chập ma trận mask_x và ma trận 3x3 giá trị các điểm ảnh lân cận f(x,y)
                            gyR += R * mask_y[i - (x - 1), j - (y - 1)];//tích chập ma trận mask_y và ma trận 3x3 giá trị các điểm ảnh lân cận f(x,y)
                    

                            gxG += G * mask_x[i - (x - 1), j - (y - 1)];//tích chập ma trận mask_x và ma trận 3x3 giá trị các điểm ảnh lân cận f(x,y)
                            gyG += G * mask_y[i - (x - 1), j - (y - 1)];//tích chập ma trận mask_y và ma trận 3x3 giá trị các điểm ảnh lân cận f(x,y)


                            gxB += B * mask_x[i - (x - 1), j - (y - 1)];//tích chập ma trận mask_x và ma trận 3x3 giá trị các điểm ảnh lân cận f(x,y)
                            gyB += B * mask_y[i - (x - 1), j - (y - 1)];//tích chập ma trận mask_y và ma trận 3x3 giá trị các điểm ảnh lân cận f(x,y)
                        }
                    gxx = Math.Pow(gxR, 2) + Math.Pow(gxG, 2) + Math.Pow(gxB, 2);
                    gyy = Math.Pow(gyR, 2) + Math.Pow(gyG, 2) + Math.Pow(gyB, 2);
                    gxy = gxR * gyR + gxG * gyG + gxB * gyB;
                    double theta = 0.5*Math.Atan(2 * gxy/( gxx - gyy));
                    
                    double F0 = Math.Sqrt(((gxx+gyy)+(gxx-gyy)*Math.Cos(2*theta)+2*gxy*Math.Sin(2*theta))/2);
                    if (F0 <= D0)
                        edge.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        edge.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }

            return edge;
        }

        public Bitmap Edge_Detect_Sobel_v2(Bitmap HinhGoc, int D0)//code rút gọn
        {
            //sobel gx
            int[,] dx = new int[3, 3];
            dx[0, 0] = -1; dx[1, 0] = -2; dx[2, 0] = -1;
            dx[0, 1] = 0; dx[1, 1] = 0; dx[2, 1] = 0;
            dx[0, 2] = 1; dx[1, 2] = 2; dx[2, 2] = 1;
            //sobel gy
            int[,] dy = new int[3, 3];
            dy[0, 0] = -1; dy[1, 0] = 0; dy[2, 0] = 1;
            dy[0, 1] = -2; dy[1, 1] = 0; dy[2, 1] = 2;
            dy[0, 2] = -1; dy[1, 2] = 0; dy[2, 2] = 1;

            Bitmap edge = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 1; x < HinhGoc.Width - 1; x++)
                for (int y = 1; y < HinhGoc.Height - 1; y++)
                {
                    double[] gx = new double[3];
                    double[] gy = new double[3];

                    double gxx = 0;
                    double gyy = 0;
                    double gxy = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = HinhGoc.GetPixel(i, j);
                            byte R = color.R;//get red
                            byte G = color.G;//get green
                            byte B = color.B;//get blue

                            gx[0] += R * dx[i - (x - 1), j - (y - 1)];//Red convolution  - X
                            gy[0] += R * dy[i - (x - 1), j - (y - 1)];//Red convolution  - y
                            
                            gx[1] += G * dx[i - (x - 1), j - (y - 1)];//Green convolution - x
                            gy[1] += G * dy[i - (x - 1), j - (y - 1)];//Green convolution - y
                            
                            gx[2] += B * dx[i - (x - 1), j - (y - 1)];//Blue convolution - x
                            gy[2] += B * dy[i - (x - 1), j - (y - 1)];//Blue convolution - y
                        }
                    gxx = Math.Pow(gx[0], 2) + Math.Pow(gx[1], 2) + Math.Pow(gx[2], 2); //dot product
                    gyy = Math.Pow(gy[0], 2) + Math.Pow(gy[1], 2) + Math.Pow(gy[2], 2); 
                    gxy = gx[0] * gy[0] + gx[1] * gy[1] + gx[2] * gy[2];
                    
                    double theta = 0.5 * Math.Atan(2 * gxy/ (gxx - gyy)); //direction of maximum rate of change of pixxel c(x, y)
                   
                    double F0 = Math.Sqrt(((gxx + gyy) + (gxx - gyy) * Math.Cos(2 * theta) + 2 * gxy * Math.Sin(2 * theta)) *0.5); //the value of the rate of change at(x, y)
                    if (F0 <= D0)
                        edge.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        edge.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }

            return edge;
        }


        public Bitmap Edge_Detect_Prewittl(Bitmap HinhGoc, int D0)
        {
            //prewitt gx
            int[,] mask_x = new int[3, 3];
            mask_x[0, 0] = -1; mask_x[1, 0] = -1; mask_x[2, 0] = -1;
            mask_x[0, 1] = 0; mask_x[1, 1] = 0; mask_x[2, 1] = 0;
            mask_x[0, 2] = 1; mask_x[1, 2] = 1; mask_x[2, 2] = 1;
            //prewitt gy
            int[,] mask_y = new int[3, 3];
            mask_y[0, 0] = -1; mask_y[1, 0] = 0; mask_y[2, 0] = 1;
            mask_y[0, 1] = -1; mask_y[1, 1] = 0; mask_y[2, 1] = 1;
            mask_y[0, 2] = -1; mask_y[1, 2] = 0; mask_y[2, 2] = 1;

            Bitmap edge = new Bitmap(HinhGoc.Width, HinhGoc.Height);

            for (int x = 1; x < HinhGoc.Width - 1; x++)
                for (int y = 1; y < HinhGoc.Height - 1; y++)
                {
                    double gxR = 0, gyR = 0;
                    double gxG = 0, gyG = 0;
                    double gxB = 0, gyB = 0;

                    double gxx = 0;
                    double gyy = 0;
                    double gxy = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            Color color = HinhGoc.GetPixel(i, j);
                            byte R = color.R;
                            byte G = color.G;
                            byte B = color.B;

                            gxR += R * mask_x[i - (x - 1), j - (y - 1)];//tích chập ma trận mask_x và ma trận 3x3 giá trị các điểm ảnh lân cận f(x,y)
                            gyR += R * mask_y[i - (x - 1), j - (y - 1)];//tích chập ma trận mask_y và ma trận 3x3 giá trị các điểm ảnh lân cận f(x,y)


                            gxG += G * mask_x[i - (x - 1), j - (y - 1)];//tích chập ma trận mask_x và ma trận 3x3 giá trị các điểm ảnh lân cận f(x,y)
                            gyG += G * mask_y[i - (x - 1), j - (y - 1)];//tích chập ma trận mask_y và ma trận 3x3 giá trị các điểm ảnh lân cận f(x,y)


                            gxB += B * mask_x[i - (x - 1), j - (y - 1)];//tích chập ma trận mask_x và ma trận 3x3 giá trị các điểm ảnh lân cận f(x,y)
                            gyB += B * mask_y[i - (x - 1), j - (y - 1)];//tích chập ma trận mask_y và ma trận 3x3 giá trị các điểm ảnh lân cận f(x,y)
                        }
                    gxx = Math.Pow(Math.Abs(gxR), 2) + Math.Pow(Math.Abs(gxG), 2) + Math.Pow(Math.Abs(gxB), 2);
                    gyy = Math.Pow(Math.Abs(gyR), 2) + Math.Pow(Math.Abs(gyG), 2) + Math.Pow(Math.Abs(gyB), 2);
                    gxy = gxR * gyR + gxG * gyG + gxB * gyB;
                    double theta = Math.Atan(2 * gxy/ (gxx - gyy)) / 2.0;
                    double F0 = Math.Sqrt(((gxx + gyy) + (gxx - gyy) * Math.Cos(2 * theta) + 2 * gxy * Math.Sin(2 * theta)) / 2);

                    if (F0 <= D0)
                        edge.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        edge.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }

            return edge;
        }
        private void button_sobel_Click(object sender, EventArgs e)
        {
            pictureBox_edge.Image = Edge_Detect_Sobel_v2(hinhgoc, Convert.ToInt32(textBox_nguong.Text));
        }

        private void button_prewitt_Click(object sender, EventArgs e)
        {

            pictureBox_edge.Image = Edge_Detect_Prewittl(hinhgoc, Convert.ToInt32(textBox_nguong.Text));
        }
    }
}
