using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamFortress
{

    public partial class Form1 : Form
    {
        List<Warriors> warriors = new List<Warriors>();
        List<Weapon> weapon = new List<Weapon>();
        public void getWarriors ()
        {
           string[] directoriesNames = Directory.GetDirectories(Application.StartupPath + @"\Warriors\");
           foreach(string directoryname in directoriesNames)
            {
                openWarrior(directoryname);
            }
        }
        public void openWarrior(string directory)
        {
            Warriors scout = OpenWarriors.open(directory);
            warriors.Add(scout);
            listBox1.Items.Add(scout.name);
        }
        public void getWeapon()
        {
            string[] directoriesNames = Directory.GetDirectories(Application.StartupPath + @"\Weapon\");
            foreach (string directoryname in directoriesNames)
            {
                openWeapon(directoryname);
            }
        }
        public void openWeapon(string directory)
        {
            Weapon scout = OpenWeapon.open(directory);
            weapon.Add(scout);
            listBox2.Items.Add(scout.GetName());
            
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getWarriors();
            getWeapon();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            tempFileName = openFile.FileName;
        }
        string tempFileName = null, tempWeaponFileName = null;
        private void button2_Click(object sender, EventArgs e)
        {
            Warriors scout = new Warriors(nameTxt.Text, new Weapon(weaponNameTxt.Text, Convert.ToInt32(damageTxt.Text)), Convert.ToInt32(speedTxt.Text));

            scout.setPicture(tempFileName);
            SaveWarriors.Save(scout, Application.StartupPath + @"\Warriors");
            warriors.Add(scout);
            listBox1.Items.Add(scout.name);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showWarrior(listBox1.SelectedIndex);
        }
        private void showWarrior(int index)
        {
            Warriors warrior = warriors[index];
            label1.Text = warrior.name;
            label2.Text = warrior.weapon.ToString();
            label3.Text = warrior.maxspeed.ToString();
            pictureBox1.BackgroundImage = Image.FromFile(warrior.getPicture());

        }

        private void damageTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Weapon weapon = new Weapon(weaponNameTxt.Text, Convert.ToInt32(damageTxt.Text),Image.FromFile(tempWeaponFileName));
            SaveWeapon.Save(weapon, tempWeaponFileName);
            listBox2.Items.Clear();
            this.weapon.Clear();
            getWeapon();
        }

        private void createWarrior_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void weaponNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Weapon weapon = this.weapon[listBox2.SelectedIndex];
            label2.Text = weapon.GetDamage().ToString();
            //using (var file = new FileStream(Application.StartupPath + @"\Weapon\" + weapon.GetName() + @"\index.png", FileMode.Open, FileAccess.Read, FileShare.Inheritable))
            //{
            //    pictureBox2.BackgroundImage = Image.FromStream(file);            
            //}
            pictureBox2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Weapon\" + weapon.GetName() + @"\index.png");
            //Bitmap bmp = new Bitmap(Application.StartupPath + @"\Weapon\" + weapon.GetName() + @"\index.png");
            //bmp.Save("weapon.png");
            //bmp.Dispose();
            //Bitmap bmp1 = new Bitmap("weapon.png");
            //pictureBox2.BackgroundImage = bmp1;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName!=null)
            {
               
                
                Weapon weapon = this.weapon[listBox2.SelectedIndex];
                pictureBox2.BackgroundImage.Dispose();
                pictureBox2.BackgroundImage = null;
                pictureBox2.BackgroundImage = Image.FromFile(ofd.FileName);
                //File.Delete(Application.StartupPath + @"\Weapon\" + weapon.GetName() + @"\index.png");
                //File.Copy(ofd.FileName, Application.StartupPath + @"\Weapon\" + weapon.GetName() + @"\index.png",true);
                
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            tempWeaponFileName = openFile.FileName;

        }
    }
}
