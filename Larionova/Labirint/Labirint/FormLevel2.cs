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
    public partial class FormLevel2 : Form
    {

        Basis basis;
        public FormLevel2()
        {
            InitializeComponent();
            basis = new Basis();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
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

        private void FormLevel2_Shown(object sender, EventArgs e)
        {
            basis.start_game(label_start);
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

       
    }
}
