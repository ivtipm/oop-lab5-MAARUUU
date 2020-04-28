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
    // 2 уровень игры
    public partial class FormLevel2 : Form
    {

        Basis basis;
        public FormLevel2()
        {
            InitializeComponent();
            basis = new Basis();
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

        private void FormLevel2_Shown(object sender, EventArgs e) // старт игры
        {
            basis.start_game(label_start);
        }

        private void label_finish_MouseEnter(object sender, EventArgs e) // финиш, т.е. игрок прошел  уровень (добрался до финиша) 
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

       
    }
}
