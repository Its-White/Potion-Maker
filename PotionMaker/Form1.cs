using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotionMaker
{
    public partial class Form1 : Form
    {
        static Recipe Staminup = new Recipe(new string[] {"Lavender", "Water"});
        static Recipe MagicSalt = new Recipe(new string[] { "Fire Salts", "Ice Salts","Ectoplasm" });

        Recipe[] recipes = { Staminup, MagicSalt };

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // all of the Image updates for when you check a box
        #region
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\Lavender.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\m_glory.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\Nightshade.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\Nirnroot.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\Wax.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\Honeycomb.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\Bonemeal.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\water.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\BleedingCrown.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\Canis_root.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\Creep_cluster.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\FireSalts.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\FrostSalts.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\alexander.armst\Documents\Visual Studio 2015\Projects\PotionMaker\Textures\Ectoplasm.png");
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            //Unchecks all checked boxes when the 'clear' button is clicked
            #region
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }
            if (checkBox3.Checked == true)
            {
                checkBox3.Checked = false;
            }
            if (checkBox4.Checked == true)
            {
                checkBox4.Checked = false;
            }
            if (checkBox6.Checked == true)
            {
                checkBox6.Checked = false;
            }
            if (checkBox7.Checked == true)
            {
                checkBox7.Checked = false;
            }
            if (checkBox8.Checked == true)
            {
                checkBox8.Checked = false;
            }
            if (checkBox9.Checked == true)
            {
                checkBox9.Checked = false;
            }
            if (checkBox10.Checked == true)
            {
                checkBox10.Checked = false;
            }
            if (checkBox11.Checked == true)
            {
                checkBox11.Checked = false;
            }
            if (checkBox12.Checked == true)
            {
                checkBox12.Checked = false;
            }
            if (checkBox13.Checked == true)
            {
                checkBox13.Checked = false;
            }
            if (checkBox14.Checked == true)
            {
                checkBox14.Checked = false;
            }
            if (checkBox15.Checked == true)
            {
                checkBox15.Checked = false;
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> t_ingred = new List<string>();
            foreach (string item in listBox1.Items) {
                foreach (Recipe recipe in recipes) {
                    foreach (string ingredient in recipe.ingredients)
                    {
                        if (item == ingredient)
                        {
                            t_ingred.Add(item);
                        }
                    }
                }
            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items.Count > t_ingred.Count)
                {
                    //Too many ingredients
                }
                if (listBox1.Items.Count < t_ingred.Count)
                {
                    //Too little Ingredients
                }
                if (listBox1.Items.Count == t_ingred.Count)
                {
                    for(int j = 0; j < t_ingred.Count; j++)
                    {
                        if ((string)listBox1.Items[i] != t_ingred[j])
                        {
                            //Can't mix
                            return;
                        }
                    }
                }
            }
            //Potion made
            Console.WriteLine("Potion made");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Adds the selected ingredient to the Mixer list
            #region
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add(checkBox1.Text);
            }
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add(checkBox2.Text);
            }
            if (checkBox3.Checked == true)
            {
                listBox1.Items.Add(checkBox3.Text);
            }
            if (checkBox4.Checked == true)
            {
                listBox1.Items.Add(checkBox4.Text);
            }
            if (checkBox6.Checked == true)
            {
                listBox1.Items.Add(checkBox6.Text);
            }
            if (checkBox7.Checked == true)
            {
                listBox1.Items.Add(checkBox7.Text);
            }
            if (checkBox8.Checked == true)
            {
                listBox1.Items.Add(checkBox8.Text);
            }
            if (checkBox9.Checked == true)
            {
                listBox1.Items.Add(checkBox9.Text);
            }
            if (checkBox10.Checked == true)
            {
                listBox1.Items.Add(checkBox10.Text);
            }
            if (checkBox11.Checked == true)
            {
                listBox1.Items.Add(checkBox11.Text);
            }
            if (checkBox12.Checked == true)
            {
                listBox1.Items.Add(checkBox12.Text);
            }
            if (checkBox13.Checked == true)
            {
                listBox1.Items.Add(checkBox13.Text);
            }
            if (checkBox14.Checked == true)
            {
                listBox1.Items.Add(checkBox14.Text);
            }
            if (checkBox15.Checked == true)
            {
                listBox1.Items.Add(checkBox15.Text);
            }
            #endregion
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch
            {

            }
        }
    }
}
