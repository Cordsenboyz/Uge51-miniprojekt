using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uge51_miniprojekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SKPspecialMere.Visible = false;
            OmadsfavMere.Visible = false;
            ViktorsfavMere.Visible = false;
            linkLabel4.Visible = false;
            numericUpDown1.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Pizza1.Text == string.Empty)
            {
                if (checkBox1.Checked == true)
                {
                    Pizza1.Text = "SKP Special";
                    linkLabel4.Visible = true;
                    numericUpDown1.Value = 1;
                    numericUpDown1.Visible = true;
                }
                else
                {
                    Pizza1.Text = "";
                    linkLabel4.Visible = false;
                    numericUpDown1.Value = 0;
                    numericUpDown1.Visible = false;
                }
            }
        }

            private void label3_Click(object sender, EventArgs e)
        {

        }

        //Ændre Visiblily på "mere" info boxes omkring Pizzaerne efter click
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OmadsfavMere.Visible = false;
            ViktorsfavMere.Visible = false;
            SKPspecialMere.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void OmadsfavMere_Click(object sender, EventArgs e)
        {

        }

        //Ændre Visiblily på "mere" info boxes omkring Pizzaerne efter click
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SKPspecialMere.Visible = false;
            ViktorsfavMere.Visible = false;
            OmadsfavMere.Visible = true;

        }

        //Ændre Visiblily på "mere" info boxes omkring Pizzaerne efter click
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OmadsfavMere.Visible = false;
            SKPspecialMere.Visible = false;
            ViktorsfavMere.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (Pizza1.Text == string.Empty)
                {
                    if (checkBox3.Checked == true)
                    {
                        Pizza1.Text = "Omad's Favorit";
                        linkLabel4.Visible = true;
                        numericUpDown1.Value = 1;
                        numericUpDown1.Visible = true;
                    }
                    else
                    {
                        Pizza1.Text = "";
                        linkLabel4.Visible = false;
                        numericUpDown1.Value = 0;
                        numericUpDown1.Visible = false;
                    }
                }
            }
        }
    }
}
