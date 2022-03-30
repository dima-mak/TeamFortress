using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TeamFortress
{
    class SaveWarriors
    {
        public static void Save(Warriors warrior, string path)
        {
            if(!Directory.Exists(path + @"\" + warrior.name))
            {
                Directory.CreateDirectory(path + @"\" + warrior.name);
            StreamWriter sw = new StreamWriter(path+@"\"+warrior.name+@"\index.txt");
            //C: \Users\Dmitriy\source\repos\TeamFortress\TeamFortress\bin\Debug\netcoreapp3.1\Warriors\Scout
            sw.WriteLine(warrior.name);
            sw.WriteLine(warrior.maxspeed);
                sw.WriteLine(warrior.GetPictureExtension());
            File.Copy(warrior.getPicture(),path+@"\"+ warrior.name+@"\index"+warrior.GetPictureExtension());
            sw.Close();

           }          

        }
    }
}
  