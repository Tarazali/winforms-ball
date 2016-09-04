using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuBall
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            
            //this.TopMost = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Left += speed_left;
            ball.Top += speed_top;

            if(ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if(ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if(ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if(ball.Bottom >= playground.Bottom)
            {
                speed_top = -speed_top;
            }
        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        
    }
}
