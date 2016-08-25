using System;
using System.Xml;
using System.Xml.Serialization;
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
        List<Recipe> d_Recipes = new List<Recipe>();

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
                pictureBox1.Image = Image.FromFile("../textures/lavender.png");
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
                pictureBox1.Image = Image.FromFile("../textures/m_glory.png");
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
                pictureBox1.Image = Image.FromFile("../textures/Nightshade.png");
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
                pictureBox1.Image = Image.FromFile("../textures/Nirnroot.png");
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
                pictureBox1.Image = Image.FromFile("../textures/Wax.png");
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
                pictureBox1.Image = Image.FromFile("../textures/Honeycomb.png");
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
                pictureBox1.Image = Image.FromFile("../textures/Bonemeal.png");
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
                pictureBox1.Image = Image.FromFile("../textures/water.png");
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
                pictureBox1.Image = Image.FromFile("../textures/BleedingCrown.png");
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
                pictureBox1.Image = Image.FromFile("../textures/Canis_root.png");
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
                pictureBox1.Image = Image.FromFile("../textures/Creep_cluster.png");
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
                pictureBox1.Image = Image.FromFile("../textures/FireSalts.png");
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
                pictureBox1.Image = Image.FromFile("../textures/FrostSalts.png");
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
                pictureBox1.Image = Image.FromFile("../textures/Ectoplasm.png");
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
                    //Potion made
                    Console.WriteLine("Potion made");
                }
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            //Saves the Ingredients
            SaveFileDialog a = new SaveFileDialog();
            a.Filter = "(*ptn)| *.ptn";
            if (a.ShowDialog() == DialogResult.OK)
            {
                string i_text = a.FileName;
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(i_text);
                foreach (var item in listBox1.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }
                //Creates a recipe with the ingredients that you saved
                Recipe temp = new Recipe();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    temp.ingredients.Add((string)listBox1.Items[i]);
                }
                d_Recipes.Add(temp);
                SaveFile.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Loads the Potion
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "(*ptn)| *.ptn";
            if (f.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear(); //clears the mixer before loading

                List<string> lines = new List<string>();
                using (System.IO.StreamReader r = new System.IO.StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }
    }
}
