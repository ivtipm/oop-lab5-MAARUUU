using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Labyrinth
{
    public partial class Flashing_wall : UserControl
    {
        Timer timer;
        public Flashing_wall()
        {
            InitializeComponent();
            timer = new Timer()
            {
                Interval = 800
            };
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            System.Threading.Thread.Sleep(10);
            Random _rnd = new Random();
            timer.Interval = _rnd.Next(500, 1000);
        }

        private void Flashing_wall_Load(object sender, EventArgs e)
        {
            timer.Tick += Timer_Tick;
            timer.Start();
        }
    }
}
