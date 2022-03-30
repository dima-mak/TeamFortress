using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TeamFortress
{
    class SaveWeapon
    {
        public static void Save(Weapon weapon, string path)
        {
            string directory = Application.StartupPath + @"\Weapon\" + weapon.GetName();
            if (!Directory.Exists(directory)) 
            {
                Directory.CreateDirectory(directory);
            }
            StreamWriter sw = new StreamWriter(directory+@"\index.txt");
            sw.WriteLine(weapon.GetName());
            sw.WriteLine(weapon.GetDamage());
            sw.WriteLine(Path.GetExtension(path));
            sw.Close();
            File.Copy(path,directory+@"\index"+ Path.GetExtension(path));

        }
    }
}
