using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormLevel4 : Form
    {

        Basis basis;
        public FormLevel4()
        {
            InitializeComponent();
            basis = new Basis();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            basis.finish_game(label_start);

            DialogResult d = MessageBox.Show("Вы проиграли, ещё разок попробовать?", "Сообщение", MessageBoxButtons.YesNo);

            if (d == System.Windows.Forms.DialogResult.Yes)
            {
                label_key.Visible = true;
                label_door.Visible = true;
                basis.start_game(label_start);
            }
            else
            {
                d = System.Windows.Forms.DialogResult.Abort;
                this.Hide();
            }
        }

        private void label_key_MouseEnter(object sender, EventArgs e)
        {
            label_key.Visible = false;
            Sound.play_key();
        }

        private void label_door_MouseEnter(object sender, EventArgs e)
        {
            if (label_key.Visible)
                basis.finish_game(label_start);
            else
            { 
                label_door.Visible = false;
                Sound.play_key();
            }
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FormLevel4_Shown(object sender, EventArgs e)
        {
            basis.start_game(label_start);
        }
    }
}
