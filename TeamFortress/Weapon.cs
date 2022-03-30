using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TeamFortress
{

    class Weapon
    {
        public Image getPicture()
        {
            return picture;
        } 

           
        public override string ToString()
        {
            return $"name:{name}, damag{damage}";
        }
        
        string name;
        int damage;
        Image picture;
        string extension;
        public string GetExtension()
        {
            return extension;
        }
        public void SetExtension(string extension)
        {
            this.extension = extension;
        }
        public Weapon(string Name , int Damage)
        {
            name = Name;
            damage = Damage;
         }
        public Weapon(string Name, int Damage, Image Picture): this(Name, Damage)
        {
            picture = Picture;
        }
        public void SetPicture(Image Picture)
        { 
            picture = Picture;
        }
        public string GetName()
        {
            return this.name;
        }
        public int GetDamage()
        {
            return this.damage;
        }

    }
    
}
