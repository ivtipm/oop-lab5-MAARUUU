using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace Labirint
{
    //класс отвечает за звуковые эффекты
   static class Sound 
    {
        static SoundPlayer sound_fail = new SoundPlayer(Properties.Resources.sound_fail); // звуковой эффект для ошибки
        static SoundPlayer sound_key = new SoundPlayer(Properties.Resources.sound_key); // звуковой эффект для ключей
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.sound_start); // звуковой эффект для старта игры
        static SoundPlayer sound_youwin = new SoundPlayer(Properties.Resources.sound_youwin); // звуковой эффект конца игры
        static bool sound_enabled = true; // отвечает за звук

        public static void sound_on() // звук есть
        {
            sound_enabled = true;
        }

        public static void sound_off() // звука нет
        {
            sound_enabled = false;
        }


        public static void play_fail() // если звук есть, то проигрывает звук.эф ошибки
        {
            if (sound_enabled)
             sound_fail.Play();
        }

        public static void play_key() // если звук есть, то проигрывает звук.эф ключа/бонуса 
        {
            if (sound_enabled)
                sound_key.Play();
        }
        public static void play_start() // если звук есть, то проигрывает звук.эф старта игры 
        {
            if (sound_enabled)
                sound_start.Play();
        }
        public static void play_youwin() // если звук есть, то проигрывает  звук.эф успешного конца игры
        {
            if (sound_enabled)
                sound_youwin.Play();
        }

    }
 }
