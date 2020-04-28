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
    // класс отвечает за положение курсора мыши
    public class Basis
    {
       
        public void start_game(Label label_start) 
        {
            Form f = new Form();
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = label_start.PointToScreen(point);
            Sound.play_start();

        }
        public void finish_game(Label label_start) 
        {
            Sound.play_fail();
        }
    }
}
