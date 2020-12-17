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
        int totalpris = 0;
        public Form1()
        {
            InitializeComponent();
            SKPspecialMere.Visible = false;
            OmadsfavMere.Visible = false;
            ViktorsfavMere.Visible = false;
            numericUpDown1.Visible = false;
            KontaktOsBox.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;



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
            if (checkBox1.Checked == true)
            {
                string[] row = { label2.Text + " " + "65 kr." };
                var ListViewItem = new ListViewItem(row);
                listView1.Items.Add(ListViewItem);
                numericUpDown1.Visible = true;
                totalpris += 65;
                numericUpDown1.Value = 1;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Ændre Visiblily på "mere" info boxes omkring Pizzaerne efter click
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OmadsfavMere.Visible = false;
            label15.Visible = false;
            ViktorsfavMere.Visible = false;
            label16.Visible = false;
            SKPspecialMere.Visible = true;
            label14.Visible = true;
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
            label14.Visible = false;
            ViktorsfavMere.Visible = false;
            label16.Visible = false;
            OmadsfavMere.Visible = true;
            label15.Visible = true;

        }

        //Ændre Visiblily på "mere" info boxes omkring Pizzaerne efter click
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OmadsfavMere.Visible = false;
            label15.Visible = false;
            SKPspecialMere.Visible = false;
            label14.Visible = false;
            ViktorsfavMere.Visible = true;
            label16.Visible = true;

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



        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBox3.Checked == true)
                {
                    string[] row = { label3.Text + " " + checkBox3.Text};
                    var ListViewItem = new ListViewItem(row);
                    listView1.Items.Add(ListViewItem);
                    totalpris += 60;
                    TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
                }
            }
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
                    totalpris += 120;
                    TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
                }

            }
        }

        private void TotalPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBox4.Checked == true)
                {
                    string[] row = { label3.Text + " " + checkBox4.Text };
                    var ListViewItem = new ListViewItem(row);
                    listView1.Items.Add(ListViewItem);
                    totalpris += 110;
                    TotalPriceLabel.Text = totalpris.ToString() + "Kr.";

                }
            }
        }


        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBox5.Checked == true)
                {
                    string[] row = { label6.Text + " " + checkBox5.Text};
                    var ListViewItem = new ListViewItem(row);
                    listView1.Items.Add(ListViewItem);
                    totalpris += 50;
                    TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                string[] row = { label6.Text + " " + checkBox6.Text };
                var ListViewItem = new ListViewItem(row);
                listView1.Items.Add(ListViewItem);
                totalpris += 100;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                string[] row = { label8.Text + " " + checkBox7.Text };
                var ListViewItem = new ListViewItem(row);
                listView1.Items.Add(ListViewItem);
                totalpris += 30;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                string[] row = { label8.Text + " " + checkBox8.Text };
                var ListViewItem = new ListViewItem(row);
                listView1.Items.Add(ListViewItem);
                totalpris += 80;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                string[] row = { checkBox9.Text };
                var ListViewItem = new ListViewItem(row);
                listView1.Items.Add(ListViewItem);
                totalpris += 18;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                string[] row = { checkBox10.Text };
                var ListViewItem = new ListViewItem(row);
                listView1.Items.Add(ListViewItem);
                totalpris += 30;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                string[] row = { checkBox11.Text };
                var ListViewItem = new ListViewItem(row);
                listView1.Items.Add(ListViewItem);
                totalpris += 18;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                string[] row = { checkBox12.Text };
                var ListViewItem = new ListViewItem(row);
                listView1.Items.Add(ListViewItem);
                totalpris += 30;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            label14.Visible = false;
            SKPspecialMere.Visible = false;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label15.Visible = false;
            OmadsfavMere.Visible = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label16.Visible = false;
            ViktorsfavMere.Visible = false;
        }

        private void KontaktOsBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
        