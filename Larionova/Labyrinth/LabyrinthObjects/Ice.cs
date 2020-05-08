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
    public partial class Ice : UserControl
    {
        Timer timer;
        public Ice()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Visible = true;
        }
    }
}
