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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            start_level1();
            
       
        }

        private void box_sound_CheckedChanged(object sender, EventArgs e)
        {
            if(box_sound.Checked)
            {
                Sound.sound_on();
                box_sound.Text = "Звук есть";
                Sound.play_key();
            }
            else
            {
                Sound.sound_off();
                box_sound.Text = "Звука нет";
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void start_level1()
        {
            FormLevel1 level1 = new FormLevel1();
            DialogResult d=level1.ShowDialog();
            if (d == System.Windows.Forms.DialogResult.OK)
                start_level2();
            
        }

        private void start_level2()
        {
            Sound.play_youwin();
            FormLevel2 level2 = new FormLevel2();
            DialogResult d = level2.ShowDialog();
            if (d == System.Windows.Forms.DialogResult.OK)
                start_level3();
        }

        private void start_level3()
        {
            Sound.play_youwin();
            FormLevel3 level3 = new FormLevel3();
            DialogResult d = level3.ShowDialog();
            if (d == System.Windows.Forms.DialogResult.OK)
                start_level4();
        }

        private void start_level4()
        {
            Sound.play_youwin();
            FormLevel4 level4 = new FormLevel4();
            DialogResult d = level4.ShowDialog();
            if (d == System.Windows.Forms.DialogResult.OK)
                start_level5();
        }

        private void start_level5()
        {
            Sound.play_youwin();
            FormLevel5 level5 = new FormLevel5();
            DialogResult d = level5.ShowDialog();
            if (d == System.Windows.Forms.DialogResult.OK)
                start_youwin();
        }


        private void start_youwin()
        {
            Sound.play_youwin();
            MessageBox.Show("Вы прошли все лабиринты!", "Поздравляем ;)");
        }
    }
}
