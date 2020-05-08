using Labyrinth.Levels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Labyrinth
{
    public partial class MasterForm : Form
    {
        private UserControl currentLevel; // используется для задания уровней
        private int numberCurrentLevel; // номер текущего уровня
        private List<Type> listLevelType;

        public MasterForm()
        {
            InitializeComponent();
        }

        // метод, который отображает  уровень и начинает игру
        private void TestForm_Load(object sender, EventArgs e)
        {
            listLevelType = GetListTypeLevels();
            numberCurrentLevel = 0;
            StartGame();
        }

        // метод, отвечающий за старт игры
        private void StartGame()
        {
            currentLevel = GetCurrentLevel();
            LoadCurrentLevel(currentLevel);
            Cursor.Position = GetStartPosition(currentLevel);
            AddEventsMouseEnter(currentLevel);
            PlaySound.PlayMusic(Sound.start);
        }

        // метод, который отвечает за проигрыш в игре
        private void restartGame()
        {
            PlaySound.PlayMusic(Sound.fail);
            if (MessageBox.Show("Вы проиграли! Ещё разок?", "Неудача :(", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                StartGame();
            }
            else
            {
                this.Close();
            }
        }

        // метод, который завершает игру
        private void finishGame()
        {
            numberCurrentLevel++;
            if (numberCurrentLevel == listLevelType.Count)
            {
                PlaySound.PlayMusic(Sound.victory);
                MessageBox.Show("Вы прошли лабиринт! Поздравляю!!! :)");
                this.Close();
            }
            else
            {
                PlaySound.PlayMusic(Sound.finish);
                MessageBox.Show("Уровень пройден!");
                StartGame();
            }

        }


        // метод, отвечающий за различные препятствия и не только
        private void control_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Wall || sender is Flashing_wall)
            {
                restartGame();
            }
            if (sender is Finish)
            {
                finishGame();
            }
            if (sender is Key)
            {
                (sender as Key).Visible = false;
                PlaySound.PlayMusic(Sound.key);
            }
            if (sender is Door)
            {
                checkKey(sender);
            }
            if (sender is Ice)
            {
                DanceMouse();
            }

        }

        // метод, отвечающий за передвижения курсора мыши
        private void AddEventsMouseEnter(UserControl currentLevel)
        {
            foreach (Control _control in currentLevel.Controls)
            {
                _control.MouseEnter += control_MouseEnter;
            }
        }

        // метод, отвечающий за позицию курсора мыши
        private static void DanceMouse()
        {
            Random rnd = new Random();
            int MAX_OFF = 15;
            int _xOff = rnd.Next(MAX_OFF * 2);
            Thread.Sleep(10);
            int _yOff = rnd.Next(MAX_OFF * 2);
            Point _currentPosition = Cursor.Position;
            _currentPosition.Offset(_xOff - MAX_OFF, _yOff - MAX_OFF);
            Cursor.Position = _currentPosition;
        }


        // метод, отвечающий за ключи
        private void checkKey(object sender)
        {
            Key _key = (Key)(from key in currentLevel.Controls.Cast<UserControl>()
                             where key is Key && key.BackColor == (sender as Door).BackColor
                             select key).FirstOrDefault();
            if (_key.Visible)
            {
                restartGame();
            }
            else
            {
                PlaySound.PlayMusic(Sound.key);
                (sender as Door).Visible = false;
            }
        }

        // метод, возвражающий позицию курсора мыши
        private Point GetStartPosition(UserControl aCurrentLevel)
        {
            Start _start = (Start)(from start in aCurrentLevel.Controls.Cast<Control>()
                                   where start is Start
                                   select start).FirstOrDefault();

            Point _startPoint = _start.Location;
            _startPoint.Offset(_start.Width / 2, _start.Height / 2);
            return PointToScreen(_startPoint);
        }

        // метод получает уровни
        private static List<Type> GetListTypeLevels()
        {
            return (from type in Assembly.GetExecutingAssembly().GetTypes()
                    where type.BaseType == typeof(UserControl) && type.Name.Contains("Level")
                    orderby type.Name
                    select type).ToList();
        }

        // метод, отвечающий за опред. уровень
        private UserControl GetCurrentLevel()
        {
            ConstructorInfo _levelConstructor = listLevelType[numberCurrentLevel].GetConstructors().FirstOrDefault();
            UserControl currentLevel = (UserControl)_levelConstructor.Invoke(null);
            return currentLevel;
        }

        // метод, отвечающий за переход на след. уровень
        private void LoadCurrentLevel(UserControl currentLevel)
        {
            this.Controls.Clear();
            this.Controls.Add(currentLevel);
            this.Size = currentLevel.Size;
        }
    }
}
