using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Star_Studios
{
    public partial class Form1 : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;

            Panel pnlTop = new Panel() { Height = 4, Dock = DockStyle.Top, BackColor = Color.DarkBlue };
            Controls.Add(pnlTop);

            Panel pnlRight = new Panel() { Width = 4, Dock = DockStyle.Right, BackColor = Color.DarkBlue };
            Controls.Add(pnlRight);

            Panel pnlBottom = new Panel() { Height = 4, Dock = DockStyle.Bottom, BackColor = Color.DarkBlue };
            Controls.Add(pnlBottom);

            Panel pnlLeft = new Panel() { Width = 4, Dock = DockStyle.Left, BackColor = Color.DarkBlue };
            Controls.Add(pnlLeft);

            pictureBox1.Visible = false;
            label2.Visible = false;
        }



       
            private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
            {                      
            pictureBox1.Visible = true;
            label2.Visible = true;         
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
                axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk3NzFf/beat1.wav";              
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(4000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
                axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk3Nzlf/Bell1SFX.wav";
                 
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label2.Visible = true;
            pictureBox1.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(4000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            //Other codes which you put here, will not wait and will run immediately.
            //Then after 5 seconds the picture box will be invisible again.       
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk3ODBf/Bell2SFX.wav";
          
        }

        private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk3ODFf/bloodpop.wav";         
        }

        private void linkLabel5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(4000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk3ODJf/Boom1SFX.wav";          
        }

        private void linkLabel6_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk3ODNf/bridgeloop.wav";        
        }

        private void linkLabel7_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(4000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk3NzVf/CinematicHorror%20SFX.wav";         
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;         
            Task.Run(() =>
            {
                Thread.Sleep(7000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk3NzZf/comingloop.wav";
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(7000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk3Nzdf/crazyloop.wav";
          
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk3Nzhf/creepy%20radio.wav";

        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(4000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk4MDVf/DarkPassageSFX.wav";
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk3OTZf/EvilKeyboardSFX.wav";
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(8000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk4MTBf/FastWhooshSFX.wav";
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(2000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk4MTFf/femalegasp.wav";
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(6000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk4MjRf/fxwhoosh1.wav";
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk4MzBf/heartbeatwhoosh.wav";
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk4Mjdf/horrorambience.wav";
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk4Mjhf/horrormovie1.wav";
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = true;
            label2.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(4000);
                Invoke(new Action(() =>
                {
                    pictureBox1.Visible = false;
                    label2.Visible = false;
                }));
            });
            axWindowsMediaPlayer1.URL = "https://od.lk/s/MTRfMjYwNzk4Mjlf/horrormovie2.wav";
        }
    }
}
