using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokwium
{
    public partial class Form1 : Form
    {

        Produkt[] myszki = { new Produkt("123", "SteelSreies", true, 626), new Produkt("54", "Bloody", false, 212) };
        Produkt[] klawiatury = { new Produkt("255", "Bloody", false, 234) };
        Produkt[] monitory = { new Produkt("2243", "Asus", true, 352)};



        public Form1()
        {
           
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                for (int i = 0;i<myszki.Length;i++) 
                {
                    listBox1.Items.Add(myszki[i].nazwa);
                }
            }

            if (comboBox3.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < klawiatury.Length; i++)
                {
                    listBox1.Items.Add(klawiatury[i].nazwa);
                }

            }

            if (comboBox3.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < monitory.Length; i++)
                {
                    listBox1.Items.Add(monitory[i].nazwa);
                }

            }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Enabled = checkBox1.Checked;
            dateTimePicker1.Enabled = checkBox1.Checked;

            label3.Enabled = checkBox1.Checked;
            dateTimePicker2.Enabled = checkBox1.Checked;

            label1.Enabled = checkBox1.Checked;
            textBox3.Enabled = checkBox1.Checked;
        }
    }
}
