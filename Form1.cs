using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_form
{
    public partial class Form1 : Form
    {
        logic_class Obj_Logic = new logic_class();
        public object obj_logic;

        public Form1()
        {
            InitializeComponent();

            btn_spin.Enabled = false;
            btn_headshot.Enabled = false;
            btn_shootaway.Enabled = false;
        }
        

        private void btn_spin_Click(object sender, EventArgs e)
        {
            btn_shootaway.Enabled = true;
            btn_headshot.Enabled = true;
            btn_spin.Enabled = false;

            //code to change display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Game_form.Resources.spin.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            image_showbox.Image = bmp_Object;

            //spin the bullet

            Random Obj_random = new Random();
            Obj_Logic.spin_position = Obj_random.Next(1, 7);
            MessageBox.Show("spin_position " + Obj_Logic.spin_position);
        }
            

        private void btn_load_Click(object sender, EventArgs e)
        {
            btn_spin.Enabled = true;
            btn_load.Enabled = false;
            //code to display image in picture box on button click   

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Game_form.Resources.load.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            image_showbox.Image = bmp_Object;

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Game_form.Properties.Resources.reload);

            Sound_Object.Play();

            // load logic

            Obj_Logic.load_position = 1;
        }

        private void btn_playagain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_headshot_Click(object sender, EventArgs e)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Game_form.Resources.headshot.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            image_showbox.Image = bmp_Object;

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Game_form.Properties.Resources.shots);

            Sound_Object.Play();

        }

        private void btn_shootaway_Click(object sender, EventArgs e)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Game_form.Resources.shoot.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            image_showbox.Image = bmp_Object;


            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Game_form.Properties.Resources.shot);

            Sound_Object.Play();


        }
    }
}
