using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

using System.IO;

using System.Threading;

using BitmapProcessing;

using System.Diagnostics;



namespace ez_stack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static string ver = "2012.02.04";
        Stopwatch sw = new Stopwatch();

        public static int th;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("EZ_Stack "+ ver + "版本\nerspicu_brox 撰寫&版權所有");
        }

        private void hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Hyperlink thisLink = (Hyperlink)sender;
            string navigateUri = thisLink.NavigateUri.ToString();
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(navigateUri));
            e.Handled = true;

        }

        private void p1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png;.jpg;.tif";
            dlg.Filter = "Image Files (*.png, *.jpg ,*.tif)|*.png;*.jpg;*.tif";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                BitmapImage tmp = new BitmapImage();
                tmp.BeginInit();
                tmp.UriSource = new Uri( dlg.FileName);
                tmp.EndInit();
                p1.Stretch = Stretch.Uniform;
                p1.Source = tmp;
                n1.Content = "照片(1)" + " \"" + dlg.SafeFileName + "\"";
            }
        }
        private void p2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png;.jpg;.tif";
            dlg.Filter = "Image Files (*.png, *.jpg ,*.tif)|*.png;*.jpg;*.tif";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                BitmapImage tmp = new BitmapImage();
                tmp.BeginInit();
                tmp.UriSource = new Uri(dlg.FileName);
                tmp.EndInit();
                p2.Stretch = Stretch.Uniform;
                p2.Source = tmp;
                n2.Content = "照片(2)" + " \"" + dlg.SafeFileName + "\"";
            }
        }
        private void p3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png;.jpg;.tif";
            dlg.Filter = "Image Files (*.png, *.jpg ,*.tif)|*.png;*.jpg;*.tif";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                BitmapImage tmp = new BitmapImage();
                tmp.BeginInit();
                tmp.UriSource = new Uri(dlg.FileName);
                tmp.EndInit();
                p3.Stretch = Stretch.Uniform;
                p3.Source = tmp;
                n3.Content = "照片(3)" + " \"" + dlg.SafeFileName + "\"";
            }
        }
        private void p4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png;.jpg;.tif";
            dlg.Filter = "Image Files (*.png, *.jpg ,*.tif)|*.png;*.jpg;*.tif";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                BitmapImage tmp = new BitmapImage();
                tmp.BeginInit();
                tmp.UriSource = new Uri(dlg.FileName);
                tmp.EndInit();
                p4.Stretch = Stretch.Uniform;
                p4.Source = tmp;
                n4.Content = "照片(4)" + " \"" + dlg.SafeFileName + "\"";
            }
        }
        private void p5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png;.jpg;.tif";
            dlg.Filter = "Image Files (*.png, *.jpg ,*.tif)|*.png;*.jpg;*.tif";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                BitmapImage tmp = new BitmapImage();
                tmp.BeginInit();
                tmp.UriSource = new Uri(dlg.FileName);
                tmp.EndInit();
                p5.Stretch = Stretch.Uniform;
                p5.Source = tmp;
                n5.Content = "照片(5)" + " \"" + dlg.SafeFileName + "\"";
            }
        }
        private void p6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png;.jpg;.tif";
            dlg.Filter = "Image Files (*.png, *.jpg ,*.tif)|*.png;*.jpg;*.tif";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                BitmapImage tmp = new BitmapImage();
                tmp.BeginInit();
                tmp.UriSource = new Uri(dlg.FileName);
                tmp.EndInit();
                p6.Stretch = Stretch.Uniform;
                p6.Source = tmp;
                n6.Content = "照片(6)" + " \"" + dlg.SafeFileName + "\"";
            }
        }


        private void p1_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void p2_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void p3_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void p4_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void p5_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }
        private void p6_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void p1_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = null;
        }
        private void p2_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = null;
        }
        private void p3_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = null;
        }
        private void p4_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = null;
        }
        private void p5_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = null;
        }
        private void p6_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = null;
        }

        private void p1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            p1.Source = new BitmapImage(new Uri("pack://application:,,,/ez_stack;component/image/load_tip.png"));
            n1.Content = "照片(1)";
        }

        private void p2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            p2.Source = new BitmapImage(new Uri("pack://application:,,,/ez_stack;component/image/load_tip.png"));
            n2.Content = "照片(2)";
        }

        private void p3_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            p3.Source = new BitmapImage(new Uri("pack://application:,,,/ez_stack;component/image/load_tip.png"));
            n3.Content = "照片(3)";
        }

        private void p4_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            p4.Source = new BitmapImage(new Uri("pack://application:,,,/ez_stack;component/image/load_tip.png"));
            n4.Content = "照片(4)";
        }

        private void p5_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            p5.Source = new BitmapImage(new Uri("pack://application:,,,/ez_stack;component/image/load_tip.png"));
            n5.Content = "照片(5)";
        }

        private void p6_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            p6.Source = new BitmapImage(new Uri("pack://application:,,,/ez_stack;component/image/load_tip.png"));
            n6.Content = "照片(6)";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
      
            //處理前置檢查 start

            string unload = "pack://application:,,,/ez_stack;component/image/load_tip.png";
            if (p1.Source.ToString() == unload)
            {
                MessageBox.Show("照片(1)必須載入");
                return;
            }

            if (
                p2.Source.ToString() == unload &&
                p3.Source.ToString() == unload &&
                p4.Source.ToString() == unload &&
                p5.Source.ToString() == unload &&
                p6.Source.ToString() == unload
                )
            {
                MessageBox.Show("請最少再載入一張照片");
                return; 
            }

            if (p2.Source.ToString() != unload && (p2.Source.Width != p1.Source.Width || p2.Source.Height != p1.Source.Height) )
            {
                MessageBox.Show("照片(2)長寬不符合照片(1)");
                return; 
            }

            if (p3.Source.ToString() != unload && (p3.Source.Width != p1.Source.Width || p3.Source.Height != p1.Source.Height))
            {
                MessageBox.Show("照片(3)長寬不符合照片(1)");
                return;
            }

            if (p4.Source.ToString() != unload && (p4.Source.Width != p1.Source.Width || p4.Source.Height != p1.Source.Height))
            {
                MessageBox.Show("照片(4)長寬不符合照片(1)");
                return;
            }

            if (p5.Source.ToString() != unload && (p5.Source.Width != p1.Source.Width || p5.Source.Height != p1.Source.Height))
            {
                MessageBox.Show("照片(5)長寬不符合照片(1)");
                return;
            }
            if (p6.Source.ToString() != unload && (p6.Source.Width != p1.Source.Width || p6.Source.Height != p1.Source.Height))
            {
                MessageBox.Show("照片(6)長寬不符合照片(1)");
                return;
            }

            if (d02.IsSelected == true)
            {

                if (p2.Source.ToString() == unload || p3.Source.ToString() == unload)
                {
                    MessageBox.Show("差異重疊最少得載入照片(1)(2)(3)");
                    return;
                }

                if (p5.Source.ToString() != unload && p4.Source.ToString() == unload)
                {
                    MessageBox.Show("差異疊圖請按照順序載入圖片,缺少照片(4)");
                    return; 
                }

                if (p6.Source.ToString() != unload && p5.Source.ToString() == unload && p4.Source.ToString() == unload)
                {
                    MessageBox.Show("差異疊圖請按照順序載入圖片,缺少照片(4)(5)");
                    return;
                }

                if (p6.Source.ToString() != unload && p4.Source.ToString() == unload)
                {
                    MessageBox.Show("差異疊圖請按照順序載入圖片,缺少照片(4)");
                    return;
                }

                if (p6.Source.ToString() != unload && p5.Source.ToString() == unload)
                {
                    MessageBox.Show("差異疊圖請按照順序載入圖片,缺少照片(5)");
                    return;
                }



            }





            //處理前置檢查 end

            sw.Reset();

            sw.Start();

            if (d01.IsSelected == true)
            {
                button1.IsEnabled = false;
                button1.Content = "運算中";

                Thread d01_t = new Thread(new ThreadStart( d01_process ));
                d01_t.IsBackground = true;
                d01_t.Start();		
            }

            if (d02.IsSelected == true)
            {
                button1.IsEnabled = false;
                button1.Content = "運算中";

                Thread d02_t = new Thread(new ThreadStart(d02_process));
                d02_t.IsBackground = true;
                d02_t.Start();
            }

            if (d03.IsSelected == true)
            {
                button1.IsEnabled = false;
                button1.Content = "運算中";

                Thread d03_t = new Thread(new ThreadStart(d03_process));
                d03_t.IsBackground = true;
                d03_t.Start();
            }

            if (d04.IsSelected == true)
            {
                button1.IsEnabled = false;
                button1.Content = "運算中";

                Thread d04_t = new Thread(new ThreadStart(d04_process));
                d04_t.IsBackground = true;
                d04_t.Start();
            }




        }

        public int color_dist(System.Drawing.Color a, System.Drawing.Color b)
        {

            return (int)  (Math.Pow(a.R - b.R, 2)*299 + Math.Pow(a.G - b.G, 2)*587 + Math.Pow(a.B - b.B, 2)*114) ;
        }


        public float s(float tmp)
        {
            if ((int)tmp%60 ==  0 ) 
                return (float)120;
            else 
                return tmp; 
        }


        public void d02_process()
        {
            Bitmap bp1 = null, bp2 = null, bp3 = null, bp4 = null, bp5 = null, bp6 = null ,bp_r = null ;
            FastBitmap fbp1 = null, fbp2 = null, fbp3 = null, fbp4 = null, fbp5 = null, fbp6 = null , fbp_r=null;  
            string unload = "pack://application:,,,/ez_stack;component/image/load_tip.png";

            int pic_num = 0;

            

            this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                delegate()
                {

                    if (p1.Source.ToString() != unload)
                    {
                        bp1 = new Bitmap(GetBitmap(p1));
                        fbp1 = new FastBitmap(bp1);
                        fbp1.LockImage();

                        bp_r = new Bitmap(GetBitmap(p1));
                        fbp_r = new FastBitmap(bp_r);
                        fbp_r.LockImage();

                        pic_num++;

                    }
                    if (p2.Source.ToString() != unload)
                    {
                        bp2 = new Bitmap(GetBitmap(p2));
                        fbp2 = new FastBitmap(bp2);
                        fbp2.LockImage();
                        pic_num++;
                    }
                    if (p3.Source.ToString() != unload)
                    {
                        bp3 = new Bitmap(GetBitmap(p3));
                        fbp3 = new FastBitmap(bp3);
                        fbp3.LockImage();
                        pic_num++;
                    }
                    if (p4.Source.ToString() != unload)
                    {
                        bp4 = new Bitmap(GetBitmap(p4));
                        fbp4 = new FastBitmap(bp4);
                        fbp4.LockImage();
                        pic_num++;
                    }
                    if (p5.Source.ToString() != unload)
                    {
                        bp5 = new Bitmap(GetBitmap(p5));
                        fbp5 = new FastBitmap(bp5);
                        fbp5.LockImage();
                        pic_num++;
                    }
                    if (p6.Source.ToString() != unload)
                    {
                        bp6 = new Bitmap(GetBitmap(p6));
                        fbp6 = new FastBitmap(bp6);
                        fbp6.LockImage();
                        pic_num++;
                    }
                }
                ));

            int width = bp1.Width;
            int height = bp1.Height;

            if (bp2 != null && pic_num == 3)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp1 = fbp1.GetPixel(i, j);
                        System.Drawing.Color tmp2 = fbp2.GetPixel(i, j);
                        System.Drawing.Color tmp3 = fbp3.GetPixel(i, j);

                        System.Drawing.Color av_c = System.Drawing.Color.FromArgb((tmp1.R + tmp2.R + tmp3.R ) / 3,
                            (tmp1.G + tmp2.G + tmp3.G ) / 3, (tmp1.B + tmp2.B + tmp3.B ) / 3);

                        System.Drawing.Color[] c_array = new System.Drawing.Color[3] { tmp1, tmp2, tmp3 };

                        System.Drawing.Color ch_c = c_array[0];

                        int dist = color_dist(av_c, ch_c);

                        for (int c = 1; c <= 2; c++)
                        {

                            int tmp_d = color_dist(av_c, c_array[c]);

                            if (tmp_d > dist)
                            {
                                dist = tmp_d;
                                ch_c = c_array[c];
                            }
                        }

                        fbp_r.SetPixel(i, j, ch_c);
                    }

            if (bp2 != null && pic_num == 4)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp1 = fbp1.GetPixel(i, j);
                        System.Drawing.Color tmp2 = fbp2.GetPixel(i, j);
                        System.Drawing.Color tmp3 = fbp3.GetPixel(i, j);
                        System.Drawing.Color tmp4 = fbp4.GetPixel(i, j);

                        System.Drawing.Color av_c = System.Drawing.Color.FromArgb((tmp1.R + tmp2.R + tmp3.R + tmp4.R ) / 4,
                            (tmp1.G + tmp2.G + tmp3.G + tmp4.G  ) / 4, (tmp1.B + tmp2.B + tmp3.B + tmp4.B ) / 4);

                        System.Drawing.Color[] c_array = new System.Drawing.Color[4] { tmp1, tmp2, tmp3, tmp4 };

                        System.Drawing.Color ch_c = c_array[0];

                        int dist = color_dist(av_c, ch_c);

                        for (int c = 1; c <= 3; c++)
                        {

                            int tmp_d = color_dist(av_c, c_array[c]);

                            if (tmp_d > dist)
                            {
                                dist = tmp_d;
                                ch_c = c_array[c];
                            }
                        }

                        fbp_r.SetPixel(i, j, ch_c);
                    }

            if (bp2 != null && pic_num == 5 )
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp1 = fbp1.GetPixel(i, j);
                        System.Drawing.Color tmp2 = fbp2.GetPixel(i, j);
                        System.Drawing.Color tmp3 = fbp3.GetPixel(i, j);
                        System.Drawing.Color tmp4 = fbp4.GetPixel(i, j);
                        System.Drawing.Color tmp5 = fbp5.GetPixel(i, j);

                        System.Drawing.Color av_c = System.Drawing.Color.FromArgb( (tmp1.R + tmp2.R + tmp3.R + tmp4.R + tmp5.R)/5 , 
                            (tmp1.G + tmp2.G + tmp3.G + tmp4.G + tmp5.G)/5 ,  (tmp1.B + tmp2.B + tmp3.B + tmp4.B + tmp5.B)/5    );

                        System.Drawing.Color[] c_array = new System.Drawing.Color[5] { tmp1, tmp2, tmp3, tmp4, tmp5 };

                        System.Drawing.Color ch_c = c_array[0];

                        int dist = color_dist(av_c , ch_c);

                        for (int c = 1; c <= 4; c++)
                        {

                            int tmp_d = color_dist( av_c ,c_array[c]  ); 

                            if ( tmp_d > dist)
                            {
                                dist = tmp_d; 
                                ch_c = c_array[c];
                            }
                        }

                        fbp_r.SetPixel(i, j, ch_c);
                    }

            if (bp2 != null && pic_num == 6)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp1 = fbp1.GetPixel(i, j);
                        System.Drawing.Color tmp2 = fbp2.GetPixel(i, j);
                        System.Drawing.Color tmp3 = fbp3.GetPixel(i, j);
                        System.Drawing.Color tmp4 = fbp4.GetPixel(i, j);
                        System.Drawing.Color tmp5 = fbp5.GetPixel(i, j);
                        System.Drawing.Color tmp6 = fbp6.GetPixel(i, j);

                        System.Drawing.Color av_c = System.Drawing.Color.FromArgb((tmp1.R + tmp2.R + tmp3.R + tmp4.R + tmp5.R + tmp6.R ) / 6,
                            (tmp1.G + tmp2.G + tmp3.G + tmp4.G + tmp5.G + tmp5.G) / 6, (tmp1.B + tmp2.B + tmp3.B + tmp4.B + tmp5.B + tmp6.B ) / 6);

                        System.Drawing.Color[] c_array = new System.Drawing.Color[6] { tmp1, tmp2, tmp3, tmp4, tmp5 , tmp6 };

                        System.Drawing.Color ch_c = c_array[0];

                        int dist = color_dist(av_c, ch_c);

                        for (int c = 1; c <= 5; c++)
                        {

                            int tmp_d = color_dist(av_c, c_array[c]);

                            if (tmp_d > dist)
                            {
                                dist = tmp_d;
                                ch_c = c_array[c];
                            }
                        }

                        fbp_r.SetPixel(i, j, ch_c);
                    }


            this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                delegate()
                {
         
                    p_result.Source = convertBitmapToBitmapSource(bp_r);
                    bp_r.Dispose();

                    //釋放資源
                    if (p1.Source.ToString() != unload)
                    {
                        bp1.Dispose();
                    }
                    if (p2.Source.ToString() != unload)
                    {
                        bp2.Dispose();

                    }
                    if (p3.Source.ToString() != unload)
                    {
                        bp3.Dispose();

                    }
                    if (p4.Source.ToString() != unload)
                    {
                        bp4.Dispose();

                    }
                    if (p5.Source.ToString() != unload)
                    {
                        bp5.Dispose();
                    }
                    if (p6.Source.ToString() != unload)
                    {
                        bp6.Dispose();
                    }

                    button1.IsEnabled = true;
                    button1.Content = "運算";
                    button2.IsEnabled = true;

                    sw.Stop();

                    ct.Content = "花費時間 " + (sw.ElapsedMilliseconds / 1000.0).ToString() + " 秒";

                }
                ));
            MessageBox.Show("運算完成!");

  


        }

        public void d03_process()
        {
            Bitmap bp1 = null, bp2 = null, bp3 = null, bp4 = null, bp5 = null, bp6 = null, bp_r = null;
            FastBitmap fbp1 = null, fbp2 = null, fbp3 = null, fbp4 = null, fbp5 = null, fbp6 = null, fbp_r = null;
            string unload = "pack://application:,,,/ez_stack;component/image/load_tip.png";

            int pic_num = 0;



            this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                delegate()
                {

                    if (p1.Source.ToString() != unload)
                    {
                        bp1 = new Bitmap(GetBitmap(p1));
                        fbp1 = new FastBitmap(bp1);
                        fbp1.LockImage();

                        bp_r = new Bitmap(GetBitmap(p1));
                        fbp_r = new FastBitmap(bp_r);
                        fbp_r.LockImage();

                        pic_num++;

                    }
                    if (p2.Source.ToString() != unload)
                    {
                        bp2 = new Bitmap(GetBitmap(p2));
                        fbp2 = new FastBitmap(bp2);
                        fbp2.LockImage();
                        pic_num++;
                    }
                    if (p3.Source.ToString() != unload)
                    {
                        bp3 = new Bitmap(GetBitmap(p3));
                        fbp3 = new FastBitmap(bp3);
                        fbp3.LockImage();
                        pic_num++;
                    }
                    if (p4.Source.ToString() != unload)
                    {
                        bp4 = new Bitmap(GetBitmap(p4));
                        fbp4 = new FastBitmap(bp4);
                        fbp4.LockImage();
                        pic_num++;
                    }
                    if (p5.Source.ToString() != unload)
                    {
                        bp5 = new Bitmap(GetBitmap(p5));
                        fbp5 = new FastBitmap(bp5);
                        fbp5.LockImage();
                        pic_num++;
                    }
                    if (p6.Source.ToString() != unload)
                    {
                        bp6 = new Bitmap(GetBitmap(p6));
                        fbp6 = new FastBitmap(bp6);
                        fbp6.LockImage();
                        pic_num++;
                    }
                }
                ));

            int width = bp1.Width;
            int height = bp1.Height;

            if (bp2 != null && pic_num == 3)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp1 = fbp1.GetPixel(i, j);
                        System.Drawing.Color tmp2 = fbp2.GetPixel(i, j);
                        System.Drawing.Color tmp3 = fbp3.GetPixel(i, j);

                        System.Drawing.Color av_c = System.Drawing.Color.FromArgb((tmp1.R + tmp2.R + tmp3.R) / 3,
                            (tmp1.G + tmp2.G + tmp3.G) / 3, (tmp1.B + tmp2.B + tmp3.B) / 3);

                        System.Drawing.Color[] c_array = new System.Drawing.Color[3] { tmp1, tmp2, tmp3 };

                        System.Drawing.Color ch_c = c_array[0];

                        int dist = color_dist(av_c, ch_c);

                        for (int c = 1; c <= 2; c++)
                        {

                            int tmp_d = color_dist(av_c, c_array[c]);

                            if (tmp_d < dist)
                            {
                                dist = tmp_d;
                                ch_c = c_array[c];
                            }
                        }

                        fbp_r.SetPixel(i, j, ch_c);
                    }

            if (bp2 != null && pic_num == 4)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp1 = fbp1.GetPixel(i, j);
                        System.Drawing.Color tmp2 = fbp2.GetPixel(i, j);
                        System.Drawing.Color tmp3 = fbp3.GetPixel(i, j);
                        System.Drawing.Color tmp4 = fbp4.GetPixel(i, j);

                        System.Drawing.Color av_c = System.Drawing.Color.FromArgb((tmp1.R + tmp2.R + tmp3.R + tmp4.R) / 4,
                            (tmp1.G + tmp2.G + tmp3.G + tmp4.G) / 4, (tmp1.B + tmp2.B + tmp3.B + tmp4.B) / 4);

                        System.Drawing.Color[] c_array = new System.Drawing.Color[4] { tmp1, tmp2, tmp3, tmp4 };

                        System.Drawing.Color ch_c = c_array[0];

                        int dist = color_dist(av_c, ch_c);

                        for (int c = 1; c <= 3; c++)
                        {

                            int tmp_d = color_dist(av_c, c_array[c]);

                            if (tmp_d < dist)
                            {
                                dist = tmp_d;
                                ch_c = c_array[c];
                            }
                        }

                        fbp_r.SetPixel(i, j, ch_c);
                    }

            if (bp2 != null && pic_num == 5)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp1 = fbp1.GetPixel(i, j);
                        System.Drawing.Color tmp2 = fbp2.GetPixel(i, j);
                        System.Drawing.Color tmp3 = fbp3.GetPixel(i, j);
                        System.Drawing.Color tmp4 = fbp4.GetPixel(i, j);
                        System.Drawing.Color tmp5 = fbp5.GetPixel(i, j);

                        System.Drawing.Color av_c = System.Drawing.Color.FromArgb((tmp1.R + tmp2.R + tmp3.R + tmp4.R + tmp5.R) / 5,
                            (tmp1.G + tmp2.G + tmp3.G + tmp4.G + tmp5.G) / 5, (tmp1.B + tmp2.B + tmp3.B + tmp4.B + tmp5.B) / 5);

                        System.Drawing.Color[] c_array = new System.Drawing.Color[5] { tmp1, tmp2, tmp3, tmp4, tmp5 };

                        System.Drawing.Color ch_c = c_array[0];

                        int dist = color_dist(av_c, ch_c);

                        for (int c = 1; c <= 4; c++)
                        {

                            int tmp_d = color_dist(av_c, c_array[c]);

                            if (tmp_d < dist)
                            {
                                dist = tmp_d;
                                ch_c = c_array[c];
                            }
                        }

                        fbp_r.SetPixel(i, j, ch_c);
                    }

            if (bp2 != null && pic_num == 6)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp1 = fbp1.GetPixel(i, j);
                        System.Drawing.Color tmp2 = fbp2.GetPixel(i, j);
                        System.Drawing.Color tmp3 = fbp3.GetPixel(i, j);
                        System.Drawing.Color tmp4 = fbp4.GetPixel(i, j);
                        System.Drawing.Color tmp5 = fbp5.GetPixel(i, j);
                        System.Drawing.Color tmp6 = fbp6.GetPixel(i, j);

                        System.Drawing.Color av_c = System.Drawing.Color.FromArgb((tmp1.R + tmp2.R + tmp3.R + tmp4.R + tmp5.R + tmp6.R) / 6,
                            (tmp1.G + tmp2.G + tmp3.G + tmp4.G + tmp5.G + tmp5.G) / 6, (tmp1.B + tmp2.B + tmp3.B + tmp4.B + tmp5.B + tmp6.B) / 6);

                        System.Drawing.Color[] c_array = new System.Drawing.Color[6] { tmp1, tmp2, tmp3, tmp4, tmp5, tmp6 };

                        System.Drawing.Color ch_c = c_array[0];

                        int dist = color_dist(av_c, ch_c);

                        for (int c = 1; c <= 5; c++)
                        {

                            int tmp_d = color_dist(av_c, c_array[c]);

                            if (tmp_d < dist)
                            {
                                dist = tmp_d;
                                ch_c = c_array[c];
                            }
       
                        }

                        fbp_r.SetPixel(i, j, ch_c);

                    }


            this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                delegate()
                {

                    p_result.Source = convertBitmapToBitmapSource(bp_r);
                    bp_r.Dispose();

                    //釋放資源
                    if (p1.Source.ToString() != unload)
                    {
                        bp1.Dispose();
                    }
                    if (p2.Source.ToString() != unload)
                    {
                        bp2.Dispose();

                    }
                    if (p3.Source.ToString() != unload)
                    {
                        bp3.Dispose();

                    }
                    if (p4.Source.ToString() != unload)
                    {
                        bp4.Dispose();

                    }
                    if (p5.Source.ToString() != unload)
                    {
                        bp5.Dispose();
                    }
                    if (p6.Source.ToString() != unload)
                    {
                        bp6.Dispose();
                    }

                    button1.IsEnabled = true;
                    button1.Content = "運算";
                    button2.IsEnabled = true;

                    sw.Stop();

                    ct.Content = "花費時間 " + (sw.ElapsedMilliseconds / 1000.0).ToString() + " 秒";

                }
                ));
            MessageBox.Show("運算完成!");
        }



        public void d04_process()
        {
            Bitmap bp1 = null, bp2 = null, bp3 = null, bp4 = null, bp5 = null, bp6 = null;
            FastBitmap fbp1 = null, fbp2 = null, fbp3 = null, fbp4 = null, fbp5 = null, fbp6 = null;


            string unload = "pack://application:,,,/ez_stack;component/image/load_tip.png";

            this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                delegate()
                {
                    if (p1.Source.ToString() != unload)
                    {
                        bp1 = new Bitmap(GetBitmap(p1));
                        fbp1 = new FastBitmap(bp1);
                        fbp1.LockImage();
                    }

                    if (p2.Source.ToString() != unload)
                    {
                        bp2 = new Bitmap(GetBitmap(p2));
                        fbp2 = new FastBitmap(bp2);
                        fbp2.LockImage();
                    }
                    if (p3.Source.ToString() != unload)
                    {
                        bp3 = new Bitmap(GetBitmap(p3));
                        fbp3 = new FastBitmap(bp3);
                        fbp3.LockImage();
                    }
                    if (p4.Source.ToString() != unload)
                    {
                        bp4 = new Bitmap(GetBitmap(p4));
                        fbp4 = new FastBitmap(bp4);
                        fbp4.LockImage();
                    }
                    if (p5.Source.ToString() != unload)
                    {
                        bp5 = new Bitmap(GetBitmap(p5));
                        fbp5 = new FastBitmap(bp5);
                        fbp5.LockImage();
                    }
                    if (p6.Source.ToString() != unload)
                    {
                        bp6 = new Bitmap(GetBitmap(p6));
                        fbp6 = new FastBitmap(bp6);
                        fbp6.LockImage();
                    }
                }
                ));

            int width = bp1.Width;
            int height = bp1.Height;

            if (bp2 != null)
                for (int i = 1; i < width-1 ; i++)
                    for (int j = 1; j < height-1 ; j++)
                    {
                        //計算b3對比值
                        System.Drawing.Color tmp_b3 = fbp3.GetPixel(i, j);
                        System.Drawing.Color tmp_b3_0 = fbp3.GetPixel(i - 1, j);
                        System.Drawing.Color tmp_b3_1 = fbp3.GetPixel(i, j - 1);
                        System.Drawing.Color tmp_b3_2 = fbp3.GetPixel(i + 1, j);
                        System.Drawing.Color tmp_b3_3 = fbp3.GetPixel(i, j + 1);
                        System.Drawing.Color tmp_b3_4 = fbp3.GetPixel(i + 1, j - 1);
                        System.Drawing.Color tmp_b3_5 = fbp3.GetPixel(i - 1, j + 1);
                        System.Drawing.Color tmp_b3_6 = fbp3.GetPixel(i + 1, j + 1);
                        System.Drawing.Color tmp_b3_7 = fbp3.GetPixel(i - 1, j - 1);

                        long c_b3 = contrast(tmp_b3, tmp_b3_0, tmp_b3_1, tmp_b3_2, tmp_b3_3, tmp_b3_4, tmp_b3_5, tmp_b3_6, tmp_b3_7);



                        //計算b2對比值
                        System.Drawing.Color tmp_b2 = fbp2.GetPixel(i, j);
                        System.Drawing.Color tmp_b2_0 = fbp2.GetPixel(i - 1, j);
                        System.Drawing.Color tmp_b2_1 = fbp2.GetPixel(i, j - 1);
                        System.Drawing.Color tmp_b2_2 = fbp2.GetPixel(i + 1, j);
                        System.Drawing.Color tmp_b2_3 = fbp2.GetPixel(i, j + 1);
                        System.Drawing.Color tmp_b2_4 = fbp2.GetPixel(i + 1, j - 1);
                        System.Drawing.Color tmp_b2_5 = fbp2.GetPixel(i - 1, j + 1);
                        System.Drawing.Color tmp_b2_6 = fbp2.GetPixel(i + 1, j + 1);
                        System.Drawing.Color tmp_b2_7 = fbp2.GetPixel(i - 1, j - 1);

                        long c_b2 = contrast(tmp_b2, tmp_b2_0, tmp_b2_1, tmp_b2_2, tmp_b2_3, tmp_b2_4, tmp_b2_5, tmp_b2_6, tmp_b2_7);

                        //計算b1對比值
                        System.Drawing.Color tmp_o = fbp1.GetPixel(i, j);
                        System.Drawing.Color tmp_o_0 = fbp1.GetPixel(i - 1, j);
                        System.Drawing.Color tmp_o_1 = fbp1.GetPixel(i, j - 1);
                        System.Drawing.Color tmp_o_2 = fbp1.GetPixel(i + 1, j);
                        System.Drawing.Color tmp_o_3 = fbp1.GetPixel(i, j + 1);
                        System.Drawing.Color tmp_o_4 = fbp1.GetPixel(i + 1, j - 1);
                        System.Drawing.Color tmp_o_5 = fbp1.GetPixel(i - 1, j + 1);
                        System.Drawing.Color tmp_o_6 = fbp1.GetPixel(i + 1, j + 1);
                        System.Drawing.Color tmp_o_7 = fbp1.GetPixel(i - 1, j - 1);

                        long c_b1 = contrast(tmp_o, tmp_o_0, tmp_o_1, tmp_o_2, tmp_o_3, tmp_o_4, tmp_o_5, tmp_o_6, tmp_o_7);


                        if (c_b2 > c_b1 && c_b2 > c_b3) fbp1.SetPixel(i, j, tmp_b2);
                        if (c_b3 > c_b1 && c_b3 > c_b2) fbp1.SetPixel(i, j, tmp_b3);


                        //if (c_b2 > c_b1) fbp1.SetPixel(i, j, tmp);
                    }

            /*if (bp3 != null)
                for (int i = 1; i < width-1; i++)
                    for (int j = 1; j < height-1; j++)
                    {
                        //計算b3對比值
                        System.Drawing.Color tmp = fbp3.GetPixel(i, j);
                        System.Drawing.Color tmp_0 = fbp3.GetPixel(i - 1, j);
                        System.Drawing.Color tmp_1 = fbp3.GetPixel(i, j - 1);
                        System.Drawing.Color tmp_2 = fbp3.GetPixel(i + 1, j);
                        System.Drawing.Color tmp_3 = fbp3.GetPixel(i, j + 1);
                        System.Drawing.Color tmp_4 = fbp3.GetPixel(i + 1, j - 1);
                        System.Drawing.Color tmp_5 = fbp3.GetPixel(i - 1, j + 1);
                        System.Drawing.Color tmp_6 = fbp3.GetPixel(i + 1, j + 1);
                        System.Drawing.Color tmp_7 = fbp3.GetPixel(i - 1, j - 1);

                        long c_b3 = contrast(tmp, tmp_0, tmp_1, tmp_2, tmp_3, tmp_4, tmp_5, tmp_6, tmp_7);

                        //計算b1對比值
                        System.Drawing.Color tmp_o = fbp1.GetPixel(i, j);
                        System.Drawing.Color tmp_o_0 = fbp1.GetPixel(i - 1, j);
                        System.Drawing.Color tmp_o_1 = fbp1.GetPixel(i, j - 1);
                        System.Drawing.Color tmp_o_2 = fbp1.GetPixel(i + 1, j);
                        System.Drawing.Color tmp_o_3 = fbp1.GetPixel(i, j + 1);
                        System.Drawing.Color tmp_o_4 = fbp1.GetPixel(i + 1, j - 1);
                        System.Drawing.Color tmp_o_5 = fbp1.GetPixel(i - 1, j + 1);
                        System.Drawing.Color tmp_o_6 = fbp1.GetPixel(i + 1, j + 1);
                        System.Drawing.Color tmp_o_7 = fbp1.GetPixel(i - 1, j - 1);

                        long c_b1 = contrast(tmp_o, tmp_o_0, tmp_o_1, tmp_o_2, tmp_o_3, tmp_o_4, tmp_o_5, tmp_o_6, tmp_o_7);
   

                        if (c_b3 > c_b1) fbp1.SetPixel(i, j, tmp);
                    }*/
           /* if (bp4 != null)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp = fbp4.GetPixel(i, j);
                        int Y_4 = tmp.R * 299 + tmp.G * 587 + tmp.B * 114;

                        System.Drawing.Color tmp_o = fbp1.GetPixel(i, j);
                        int Y_1 = tmp_o.R * 299 + tmp_o.G * 587 + tmp_o.B * 114;

                        if (Y_4 > Y_1) fbp1.SetPixel(i, j, tmp);
                    }

            if (bp5 != null)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp = fbp5.GetPixel(i, j);
                        int Y_5 = tmp.R * 299 + tmp.G * 587 + tmp.B * 114;

                        System.Drawing.Color tmp_o = fbp1.GetPixel(i, j);
                        int Y_1 = tmp_o.R * 299 + tmp_o.G * 587 + tmp_o.B * 114;

                        if (Y_5 > Y_1) fbp1.SetPixel(i, j, tmp);
                    }
            if (bp6 != null)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp = fbp4.GetPixel(i, j);
                        int Y_6 = tmp.R * 299 + tmp.G * 587 + tmp.B * 114;

                        System.Drawing.Color tmp_o = fbp1.GetPixel(i, j);
                        int Y_1 = tmp_o.R * 299 + tmp_o.G * 587 + tmp_o.B * 114;

                        if (Y_6 > Y_1) fbp1.SetPixel(i, j, tmp);
                    }*/


            this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                delegate()
                {
                    fbp1.UnlockImage();
                    p_result.Source = convertBitmapToBitmapSource(bp1);
                    bp1.Dispose();


                    //釋放資源
                    if (p2.Source.ToString() != unload)
                    {
                        fbp2.UnlockImage();
                        bp2.Dispose();
                    }
                    if (p3.Source.ToString() != unload)
                    {
                        fbp3.UnlockImage();
                        bp3.Dispose();
                    }
                    /*if (p4.Source.ToString() != unload)
                    {
                        fbp4.UnlockImage();
                        bp4.Dispose();
                    }
                    if (p5.Source.ToString() != unload)
                    {
                        fbp5.UnlockImage();
                        bp5.Dispose();
                    }
                    if (p6.Source.ToString() != unload)
                    {
                        fbp6.UnlockImage();
                        bp6.Dispose();
                    }*/

                    button1.IsEnabled = true;
                    button1.Content = "運算";
                    button2.IsEnabled = true;

                    sw.Stop();

                    ct.Content = "花費時間 " + (sw.ElapsedMilliseconds / 1000.0).ToString() + " 秒";

                }
                ));
            MessageBox.Show("運算完成!");

        }

        public long contrast(System.Drawing.Color tmp, System.Drawing.Color tmp0, System.Drawing.Color tmp1, System.Drawing.Color tmp2, System.Drawing.Color tmp3, System.Drawing.Color tmp4, System.Drawing.Color tmp5, System.Drawing.Color tmp6, System.Drawing.Color tmp7)
        {
            long c = 
                (tmp.R - tmp0.R) * (tmp.R - tmp0.R) + (tmp.G - tmp0.G) * (tmp.G - tmp0.G) + (tmp.B - tmp0.B) * (tmp.B - tmp0.B) +
                (tmp.R - tmp1.R) * (tmp.R - tmp1.R) + (tmp.G - tmp1.G) * (tmp.G - tmp1.G) + (tmp.B - tmp1.B) * (tmp.B - tmp1.B) +
                (tmp.R - tmp2.R) * (tmp.R - tmp2.R) + (tmp.G - tmp2.G) * (tmp.G - tmp2.G) + (tmp.B - tmp2.B) * (tmp.B - tmp2.B) +
                (tmp.R - tmp3.R) * (tmp.R - tmp3.R) + (tmp.G - tmp3.G) * (tmp.G - tmp3.G) + (tmp.B - tmp3.B) * (tmp.B - tmp3.B) +
                (tmp.R - tmp4.R) * (tmp.R - tmp4.R) + (tmp.G - tmp4.G) * (tmp.G - tmp4.G) + (tmp.B - tmp4.B) * (tmp.B - tmp4.B) +
                (tmp.R - tmp5.R) * (tmp.R - tmp5.R) + (tmp.G - tmp5.G) * (tmp.G - tmp5.G) + (tmp.B - tmp5.B) * (tmp.B - tmp5.B) +
                (tmp.R - tmp6.R) * (tmp.R - tmp6.R) + (tmp.G - tmp6.G) * (tmp.G - tmp6.G) + (tmp.B - tmp6.B) * (tmp.B - tmp6.B) +
                (tmp.R - tmp7.R) * (tmp.R - tmp7.R) + (tmp.G - tmp7.G) * (tmp.G - tmp7.G) + (tmp.B - tmp7.B) * (tmp.B - tmp7.B);

            return c;


        }



        public void d01_process()
        {
            Bitmap bp1=null, bp2=null, bp3=null, bp4=null, bp5=null, bp6=null;
            FastBitmap fbp1 = null, fbp2 = null, fbp3 = null, fbp4 = null, fbp5 = null, fbp6 = null;  


            string unload = "pack://application:,,,/ez_stack;component/image/load_tip.png";

            this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                delegate()
                {
                    if (p1.Source.ToString() != unload)
                    {
                        bp1 = new Bitmap(GetBitmap(p1));
                        fbp1 = new FastBitmap(bp1);
                        fbp1.LockImage();
                    }

                    if (p2.Source.ToString() != unload)
                    {
                        bp2 = new Bitmap(GetBitmap(p2));
                        fbp2 = new FastBitmap(bp2);
                        fbp2.LockImage();
                    }
                    if (p3.Source.ToString() != unload)
                    {
                        bp3 = new Bitmap(GetBitmap(p3));
                        fbp3 = new FastBitmap(bp3);
                        fbp3.LockImage();
                    }
                    if (p4.Source.ToString() != unload)
                    {
                        bp4 = new Bitmap(GetBitmap(p4));
                        fbp4 = new FastBitmap(bp4);
                        fbp4.LockImage();
                    }
                    if (p5.Source.ToString() != unload)
                    {
                        bp5 = new Bitmap(GetBitmap(p5));
                        fbp5 = new FastBitmap(bp5);
                        fbp5.LockImage();
                    }
                    if (p6.Source.ToString() != unload)
                    {
                        bp6 = new Bitmap(GetBitmap(p6));
                        fbp6 = new FastBitmap(bp6);
                        fbp6.LockImage();
                    }
                }
                ));

            int width = bp1.Width;
            int height = bp1.Height;

            if (bp2 != null)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp = fbp2.GetPixel(i, j);
                        int Y_2 = tmp.R * 299 + tmp.G * 587 + tmp.B * 114;

                        System.Drawing.Color tmp_o = fbp1.GetPixel(i, j);
                        int Y_1 = tmp_o.R * 299 + tmp_o.G * 587 + tmp_o.B * 114;

                        if (Y_2 > Y_1) fbp1.SetPixel(i, j, tmp);
                    }

            if (bp3 != null)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp = fbp3.GetPixel(i, j);
                        int Y_3 = tmp.R * 299 + tmp.G * 587 + tmp.B * 114;

                        System.Drawing.Color tmp_o = fbp1.GetPixel(i, j);
                        int Y_1 = tmp_o.R * 299 + tmp_o.G * 587 + tmp_o.B * 114;

                        if (Y_3 > Y_1) fbp1.SetPixel(i, j, tmp);
                    }
            if (bp4 != null)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp = fbp4.GetPixel(i, j);
                        int Y_4 = tmp.R * 299 + tmp.G * 587 + tmp.B * 114;

                        System.Drawing.Color tmp_o = fbp1.GetPixel(i, j);
                        int Y_1 = tmp_o.R * 299 + tmp_o.G * 587 + tmp_o.B * 114;

                        if (Y_4 > Y_1) fbp1.SetPixel(i, j, tmp);
                    }

            if (bp5 != null)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp = fbp5.GetPixel(i, j);
                        int Y_5 = tmp.R * 299 + tmp.G * 587 + tmp.B * 114;

                        System.Drawing.Color tmp_o = fbp1.GetPixel(i, j);
                        int Y_1 = tmp_o.R * 299 + tmp_o.G * 587 + tmp_o.B * 114;

                        if (Y_5 > Y_1) fbp1.SetPixel(i, j, tmp);
                    }
            if (bp6 != null)
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                    {
                        System.Drawing.Color tmp = fbp4.GetPixel(i, j);
                        int Y_6 = tmp.R * 299 + tmp.G * 587 + tmp.B * 114;

                        System.Drawing.Color tmp_o = fbp1.GetPixel(i, j);
                        int Y_1 = tmp_o.R * 299 + tmp_o.G * 587 + tmp_o.B * 114;

                        if (Y_6 > Y_1) fbp1.SetPixel(i, j, tmp);
                    }
            
            
            this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                delegate()
                {
                    fbp1.UnlockImage();
                    p_result.Source = convertBitmapToBitmapSource(bp1);
                    bp1.Dispose();


                    //釋放資源
                    if (p2.Source.ToString() != unload)
                    {
                        fbp2.UnlockImage();
                        bp2.Dispose();
                    }
                    if (p3.Source.ToString() != unload)
                    {
                        fbp3.UnlockImage();
                        bp3.Dispose();
                    }
                    if (p4.Source.ToString() != unload)
                    {
                        fbp4.UnlockImage();
                        bp4.Dispose();
                    }
                    if (p5.Source.ToString() != unload)
                    {
                        fbp5.UnlockImage();
                        bp5.Dispose();
                    }
                    if (p6.Source.ToString() != unload)
                    {
                        fbp6.UnlockImage();
                        bp6.Dispose();
                    }

                    button1.IsEnabled = true;
                    button1.Content = "運算";
                    button2.IsEnabled = true;

                    sw.Stop();

                    ct.Content = "花費時間 " + (sw.ElapsedMilliseconds / 1000.0).ToString() + " 秒"; 

                }
                ));
            MessageBox.Show("運算完成!");

        }

        private BitmapSource convertBitmapToBitmapSource(System.Drawing.Bitmap bitmap)
        {
            using (bitmap)
            {
                System.Windows.Media.Imaging.BitmapSource bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                    bitmap.GetHbitmap(),
                    IntPtr.Zero,
                    Int32Rect.Empty,
                    System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
                return bitmapSource;
            }
        }

        private System.Drawing.Bitmap GetBitmap(System.Windows.Controls.Image image)
        {
            System.Windows.Media.Imaging.BitmapSource bitmapSource = image.Source as BitmapSource;

            System.Windows.Media.Imaging.BitmapSource transformedBitmapSource = new System.Windows.Media.Imaging.TransformedBitmap(bitmapSource,new System.Windows.Media.ScaleTransform(1,1));

            int width = transformedBitmapSource.PixelWidth;
            int height = transformedBitmapSource.PixelHeight;
            int stride = width * ((transformedBitmapSource.Format.BitsPerPixel + 7) / 8);

            byte[] bits = new byte[height * stride];

            transformedBitmapSource.CopyPixels(bits, stride, 0);
            unsafe
            {
                fixed (byte* pBits = bits)
                {
                    IntPtr ptr = new IntPtr(pBits);

                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(
                        width,
                        height,
                        stride,
                        System.Drawing.Imaging.PixelFormat.Format32bppPArgb,
                        ptr);

                    return bitmap;
                }
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.DefaultExt = ".tif;";
            dlg.Filter = "Image Files (*.tif)|*.tif";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                FileStream fileStream = new FileStream( dlg.FileName ,  FileMode.Create );
                TiffBitmapEncoder encoder = new TiffBitmapEncoder();
                encoder.Compression = TiffCompressOption.Lzw;
                encoder.Frames.Add(BitmapFrame.Create( (BitmapSource) p_result.Source ));
                encoder.Save(fileStream);
                fileStream.Close();

            }
           
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }




    }
}
