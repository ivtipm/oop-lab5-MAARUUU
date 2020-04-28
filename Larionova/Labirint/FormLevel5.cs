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
    // 5 уровень игры
    public partial class FormLevel5 : Form
    {
        int left_boxex;
        Basis basis;
        public FormLevel5()
        {
            InitializeComponent();
            basis = new Basis();
            left_boxex = 9;
            label_box1.Visible = true;
            label_box2.Visible = true;
            label_box3.Visible = true;
            label_box4.Visible = true;
            label_box5.Visible = true;
            label_box6.Visible = true;
            label_box7.Visible = true;
            label_box8.Visible = true;
            label_box9.Visible = true;
        }

        private void label1_MouseEnter(object sender, EventArgs e)  // курсор мыши вышел за допустимые границы
        {
            basis.finish_game(label_start);

            DialogResult d = MessageBox.Show("Вы проиграли, ещё разок попробовать?", "Сообщение", MessageBoxButtons.YesNo);

            if (d == System.Windows.Forms.DialogResult.Yes)
            {
                left_boxex = 9;
                label_box1.Visible = true;
                label_box2.Visible = true;
                label_box3.Visible = true;
                label_box4.Visible = true;
                label_box5.Visible = true;
                label_box6.Visible = true;
                label_box7.Visible = true;
                label_box8.Visible = true;
                label_box9.Visible = true;
                basis.start_game(label_start);
            }
            else
            {
                d = System.Windows.Forms.DialogResult.Abort;
                this.Hide();
            }
        }

        private void FormLevel5_Shown(object sender, EventArgs e) // старт игры
        {
            basis.start_game(label_start);
        }

       
        private void label_box1_MouseEnter(object sender, EventArgs e) // если собрали "фишку", то из обшего кол-ва вычитается 1 
        {
            Sound.play_key();
            left_boxex--;
            ((Label)sender).Visible = false;
        }

        private void label_finish_MouseEnter(object sender, EventArgs e) // финиш, т.е. игрок прошел  уровень (добрался до финиша)
        {
            if (left_boxex == 0)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
