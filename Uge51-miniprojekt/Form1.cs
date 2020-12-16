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
        Decimal SKPSpecialALM = 65;
        public Form1()
        {
            InitializeComponent();
            SKPspecialMere.Visible = false;
            OmadsfavMere.Visible = false;
            ViktorsfavMere.Visible = false;
            numericUpDown1.Visible = false;
            KontaktOsBox.Visible = false;


        
        }
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
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
        //Adder den første pizza til listen over i "kurv" s
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                string[] row = { label2.Text + " " + SKPSpecialALM};
                var ListViewItem = new ListViewItem(row);
                listView1.Items.Add(ListViewItem);
                numericUpDown1.Visible = true;
                numericUpDown1.Value = 1;
            }
            int totalprice = (int)((int)SKPSpecialALM * numericUpDown1.Value);
            TotalPriceLabel.Text = "Total Pris: " + totalprice;
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
            int totalprice = (int)((int)SKPSpecialALM * numericUpDown1.Value);
            TotalPriceLabel.Text = "Total Pris: " + totalprice;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kontaktOsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KontaktOsBox.Visible = true;
            KontaktOsBox.BringToFront();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KontaktOsBox.Visible = false;
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBox2.Checked == true)
                {
                    string[] row = { label2.Text + " " + checkBox2.Text };
                    var ListViewItem = new ListViewItem(row);
                    listView1.Items.Add(ListViewItem);
                }

            }
        }

        private void TotalPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
