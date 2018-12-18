using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using System.Reflection;
using System.Diagnostics;

namespace 破岩UI_ForHY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlConfigurator.Configure();
            Type type = MethodBase.GetCurrentMethod().DeclaringType;
            ILog m_log = LogManager.GetLogger(type);
            m_log.Debug("这是一个Debug日志");
            m_log.Info("这是一个Info日志");
            m_log.Warn("这是一个Warn日志");
            m_log.Error("这是一个Error日志");
            m_log.Fatal("这是一个Fatal日志");


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle,
                                   Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                                   Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                                   Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                                   Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel4.ClientRectangle,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel6.ClientRectangle,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel7.ClientRectangle,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
                       Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel8.ClientRectangle,
           Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
           Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
           Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid,
           Color.DarkSeaGreen, 2, ButtonBorderStyle.Solid);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            aquaGauge2.Value = float.Parse(textBox29.Text);
            aquaGauge2.Value -= (float)0.1;
            aquaGauge2.DialText = "rpm";
            textBox29.Text = aquaGauge2.Value.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            aquaGauge2.Value = float.Parse(textBox29.Text);
            aquaGauge2.Value += (float)0.1;
            aquaGauge2.DialText = "rpm";
            textBox29.Text = aquaGauge2.Value.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            aquaGauge3.Value = float.Parse(textBox31.Text);
            aquaGauge3.Value -= (float)0.1;
            aquaGauge3.DialText = "rpm";
            textBox31.Text = aquaGauge3.Value.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            aquaGauge3.Value = float.Parse(textBox31.Text);
            aquaGauge3.Value += (float)0.1;
            aquaGauge3.DialText = "rpm";
            textBox31.Text = aquaGauge3.Value.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            float bef = aquaGauge1.Value;
            float aft = bef - 1;
            aquaGauge1.Value = aft;
            aquaGauge1.DialText = "kN";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            float bef = aquaGauge1.Value;
            float aft = bef + 1;
            aquaGauge1.Value = aft;
            aquaGauge1.DialText = "kN";
        }
        private void button35_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Program.GetStartupPath();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_Path_Y1.Text = openFileDialog1.FileName;
                    string[] temp = System.IO.File.ReadAllLines(openFileDialog1.FileName);

                    for(int i=0;i<temp.Count();i++)
                    {
                        chart3.Series[0].Points.AddXY(temp[i].Split(',')[0], temp[i].Split(',')[1]);
                    }

                }
                catch
                {
                    // MyLog.Error("加载发送码本失败！");             
                    //MessageBox.Show("运行日志打开失败！");
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Program.GetStartupPath();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_Path_Y2.Text = openFileDialog1.FileName;
                    string[] temp = System.IO.File.ReadAllLines(openFileDialog1.FileName);

                    for (int i = 0; i < temp.Count(); i++)
                    {
                        chart3.Series[1].Points.AddXY(temp[i].Split(',')[0], temp[i].Split(',')[1]);
                    }

                }
                catch
                {
                    // MyLog.Error("加载发送码本失败！");             
                    //MessageBox.Show("运行日志打开失败！");
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Program.GetStartupPath();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_Path_Y3.Text = openFileDialog1.FileName;
                    string[] temp = System.IO.File.ReadAllLines(openFileDialog1.FileName);

                    for (int i = 0; i < temp.Count(); i++)
                    {
                        chart3.Series[2].Points.AddXY(temp[i].Split(',')[0], temp[i].Split(',')[1]);
                    }
                }
                catch
                {
                }
            }
        }

        private void btn_Y4_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Program.GetStartupPath();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_Path_Y4.Text = openFileDialog1.FileName;
                    string[] temp = System.IO.File.ReadAllLines(openFileDialog1.FileName);

                    for (int i = 0; i < temp.Count(); i++)
                    {
                        chart3.Series[3].Points.AddXY(temp[i].Split(',')[0], temp[i].Split(',')[1]);
                    }
                }
                catch
                {
                }
            }
        }

        private void btn_Y5_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Program.GetStartupPath();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_Path_Y5.Text = openFileDialog1.FileName;
                    string[] temp = System.IO.File.ReadAllLines(openFileDialog1.FileName);

                    for (int i = 0; i < temp.Count(); i++)
                    {
                        chart3.Series[4].Points.AddXY(temp[i].Split(',')[0], temp[i].Split(',')[1]);
                    }
                }
                catch
                {
                }
            }
        }

        private void btn_Y6_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Program.GetStartupPath();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_Path_Y6.Text = openFileDialog1.FileName;
                    string[] temp = System.IO.File.ReadAllLines(openFileDialog1.FileName);

                    for (int i = 0; i < temp.Count(); i++)
                    {
                        chart3.Series[5].Points.AddXY(temp[i].Split(',')[0], temp[i].Split(',')[1]);
                    }
                }
                catch
                {
                }
            }
        }
    }
}
