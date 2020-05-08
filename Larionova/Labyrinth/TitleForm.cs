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

    // главное меню игры
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();
        }

        // кнопка осуществляет переход на форму игры
        private void btnStart_Click(object sender, EventArgs e)
        {
            MasterForm _masterForm = new MasterForm();
            _masterForm.ShowDialog();
        }

        // вкл/выкл звука
        private void cbIsSound_CheckedChanged(object sender, EventArgs e)
        {
            PlaySound.MusicOn = cbIsSound.Checked;
        }

        // кнопка закрывает игру
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // кнопка осуществляет переход на форму с правилами
        private void buttonRules_Click(object sender, EventArgs e)
        {
           Rules  _rules = new Rules();
            _rules.ShowDialog();
        }
    }
}
