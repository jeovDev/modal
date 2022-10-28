using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modal
{
    public partial class modalForm : Form
    {
        public modalForm()
        {
            InitializeComponent();
        }
       

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }
            else {
                Opacity += .02;
            }

            int y = Form1.parentY += 3; //INCREMENT
            this.Location = new Point(Form1.parentX + 220,y) ;
            if (y >= i) {
                modalEffect_Timer.Stop();
            }
        }
        int i;
        private void modalForm_Load(object sender, EventArgs e)
        {
            i = Form1.parentY + 150;
            this.Location = new Point(Form1.parentX + 220, Form1.parentY + 150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
