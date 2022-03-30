using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TeamFortress
{
    class OpenWarriors
    {
       public static Warriors open(string path)
        {
            StreamReader stream = new StreamReader(path+@"\index.txt");
            Warriors warriors = new Warriors(stream.ReadLine(), new Weapon("Gun", 100),Convert.ToInt32(stream.ReadLine()));
            warriors.setPicture(path + @"\index.png");
            return warriors;

        }

    }
}
