using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIPs_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolBarAboutButton_Click(object sender, EventArgs e) //关于按钮点击函数
        {
            AboutBox1 AboutBox1 = new AboutBox1();
            AboutBox1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) //窗口载入函数
        {
            
        }

        private void SetModeNormal_Click(object sender, EventArgs e) //标准模式点击函数
        {

        }

        private void SetModePro_Click(object sender, EventArgs e) //专家模式点击函数
        {

        }
    }
}
