using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简易班里挑一
{
    public partial class Frm : Form
    {
        private Selector sel = new Selector();
        int sec = 0;
            //倒计时计时器秒
        public Frm()
        {
            InitializeComponent();
          
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            sec = 5;
            labTime.Text = "5";
            timer2.Start();
            //按钮被按，调用计时器
            timer1.Start();
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Name student = sel.RandomStd();
            //创建一个name类，来被随机属性赋值
            txName.Text = student.name;
            txClass.Text=Convert.ToString(student.classNumber);
        txID.Text=Convert.ToString(student.id);
            txZhuanye.Text = student.zhuanYe;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec--;
            //倒计时少一秒
            if (sec==0)
            {
                timer1.Stop();
                timer2.Stop();
            }
            labTime.Text = sec.ToString();
            
           
        }
    }
}
