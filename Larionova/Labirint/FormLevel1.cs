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
    // 1 уровень игры
    public partial class FormLevel1 : Form
    {
        Basis basis;
        public FormLevel1()
        {
            InitializeComponent();
            basis = new Basis();
        }


        private void FormLevel1_Shown(object sender, EventArgs e) // старт игры
        {
            basis.start_game(label_start);
            Point point= label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.play_start();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e) // финиш, т.е. игрок прошел  уровень (добрался до финиша) 
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void label3_MouseEnter(object sender, EventArgs e) // курсор мыши вышел за допустимые границы
                                                                  
        {
          basis.finish_game(label_start);

            DialogResult d = MessageBox.Show("Вы проиграли, ещё разок попробовать?", "Сообщение", MessageBoxButtons.YesNo);

            if (d == System.Windows.Forms.DialogResult.Yes)
                basis.start_game(label_start);
            else
            {
                d = System.Windows.Forms.DialogResult.Abort;
                this.Hide();
            }
        }

    }
}
