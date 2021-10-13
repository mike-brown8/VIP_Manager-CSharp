using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace VIPs_Manager

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static bool ProMode = false;

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
            ProMode = false;
            if (ProMode ==false)
            {
                SetModePro.Checked = false;
                SetModeNormal.Checked = true;
                MessageBox.Show("切换成功！", "信息");
            }
            else
            {
                MessageBox.Show("切换失败！", "信息");
            }
        }

        private void SetModePro_Click(object sender, EventArgs e) //专家模式点击函数
        {
            ProMode = true;
            SetModePro.Checked = true;
            SetModeNormal.Checked = false;
            if (ProMode == true)
            {
                SetModePro.Checked = true;
                SetModeNormal.Checked = false;
                MessageBox.Show("切换成功！\n进行危险操作不会警告。", "信息");
            }
            else
            {
                MessageBox.Show("切换失败！", "信息");
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e) //添加会员操作函数
        {
            VIPAdd VIPAdd = new VIPAdd();
            VIPAdd.ShowDialog();
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e) //删除会员操作函数
        {
            string ID="NONE";
            if (ProMode == false)
            {
                if (MessageBox.Show(text: "这是危险操作，请确认是否继续。", caption: "警告", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ID = Interaction.InputBox("输入要删除的手机号码", "删除会员");
                }
            }
            else
            {
                ID = Interaction.InputBox("输入要删除的手机号码", "删除会员");
            }
            if(ID!="NONE")
            {
                ///数据库操作未编写
            }
        }
    }
}
