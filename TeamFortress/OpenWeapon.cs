using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace TeamFortress
{
    class OpenWeapon
    {
        public static Weapon open (string path)
        {
            StreamReader sr = new StreamReader(path + @"\index.txt");
            return new Weapon(sr.ReadLine(),Convert.ToInt32(sr.ReadLine()),Image.FromFile(path+@"\index.png"));

        }
    }
}
