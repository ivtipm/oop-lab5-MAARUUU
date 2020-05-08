using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Labyrinth
{
    // правила игры
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        // кнопка отвечает за переход в главное меню
        private void btnOk_Click(object sender, EventArgs e)
        {
            TitleForm ifrm = new TitleForm();
            ifrm.Show();
            this.Close();
        }
    }
}
