using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace TeamFortress
{
    class Warriors
    {


        public string name;
        public Weapon weapon;
        public int maxspeed;
        private string extension;
        string picture;
         
        public string GetPictureExtension()
        {
            return this.extension;
        }

        public void SetPictureExtension(string extension)
        {
            this.extension = extension;
        }
        public Warriors(string Name, Weapon weapon, int Maxspeed)
        {
            name = Name;
            this.weapon = weapon;
            maxspeed = Maxspeed;



        }
        public Warriors(string Name, int Maxspeed)
            {
                name = Name;
                maxspeed = Maxspeed;
            }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Оружие: {weapon.ToString()} Максимальная скорость: {maxspeed}");
        }
        public void setPicture(string path)
        {
            picture = path;
            extension = Path.GetExtension(path);

        }

        public string getPicture()
        {
            return picture;
        }
    }
}
