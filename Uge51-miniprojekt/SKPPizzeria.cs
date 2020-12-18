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
    public partial class SKPPizzeria : Form
    {
        int totalpris = 0;
        //Gemmer de ting der skal gemmes før de skal bruge
        public SKPPizzeria()
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
        //Tilføjer den første pizza til listen over i kurven og renger prisen sammen
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (SKPSpcialALMCheckBox.Checked == true)
            {
                string[] row = { SKPSpecialLabel.Text + " " + "65 kr." };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
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


        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (OmadsFavALMCheckBox.Checked == true)
                {
                    string[] row = { OmadsFavLabel.Text + " " + OmadsFavALMCheckBox.Text};
                    var ListViewItem = new ListViewItem(row);
                    KurvListView.Items.Add(ListViewItem);
                    totalpris += 60;
                    TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
                }
            }
        }
        //Viser KontaktosVinduet efter tryk i menu baren
        private void kontaktOsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KontaktOsBox.Visible = true;
            KontaktOsBox.BringToFront();
        }
        //Gemmer KontaktosVinduet når man trykker på "menu" i menu baren
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
        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (SKPSpecialFAMCheckBox.Checked == true)
                {
                    string[] row = { SKPSpecialLabel.Text + " " + SKPSpecialFAMCheckBox.Text };
                    var ListViewItem = new ListViewItem(row);
                    KurvListView.Items.Add(ListViewItem);
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
        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (OmadsFavFAMCheckBox.Checked == true)
                {
                    string[] row = { OmadsFavLabel.Text + " " + OmadsFavFAMCheckBox.Text };
                    var ListViewItem = new ListViewItem(row);
                    KurvListView.Items.Add(ListViewItem);
                    totalpris += 110;
                    TotalPriceLabel.Text = totalpris.ToString() + "Kr.";

                }
            }
        }

        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (ViktorsFavALMCheckBox.Checked == true)
                {
                    string[] row = { ViktorsFavLabel.Text + " " + ViktorsFavALMCheckBox.Text};
                    var ListViewItem = new ListViewItem(row);
                    KurvListView.Items.Add(ListViewItem);
                    totalpris += 50;
                    TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
                }
            }
        }
        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (ViktorsFavFAMCheckOs.Checked == true)
            {
                string[] row = { ViktorsFavLabel.Text + " " + ViktorsFavFAMCheckOs.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris += 100;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }
        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (EgenPizzaALMCheckOs.Checked == true)
            {
                string[] row = { EgenPizzaLabel.Text + " " + EgenPizzaALMCheckOs.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris += 30;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }
        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (EgenPizzaFAMCheckBox.Checked == true)
            {
                string[] row = { EgenPizzaLabel.Text + " " + EgenPizzaFAMCheckBox.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris += 80;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }
        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (CocaCola05LCheckBox.Checked == true)
            {
                string[] row = { CocaCola05LCheckBox.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris += 18;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }
        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (CocaCola1LCheckBox.Checked == true)
            {
                string[] row = { CocaCola1LCheckBox.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris += 30;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }
        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (Fanta05LCheckBox.Checked == true)
            {
                string[] row = { Fanta05LCheckBox.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris += 18;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }
        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (Fanta1LCheckBox.Checked == true)
            {
                string[] row = { Fanta1LCheckBox.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris += 30;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        //Som mulig for at kunne lukke "mere" hpyerlinks info'en ned igen efter åbning
        private void label14_Click(object sender, EventArgs e)
        {
            label14.Visible = false;
            SKPspecialMere.Visible = false;
        }
        //Som mulig for at kunne lukke "mere" hpyerlinks info'en ned igen efter åbning
        private void label15_Click(object sender, EventArgs e)
        {
            label15.Visible = false;
            OmadsfavMere.Visible = false;
        }
        //Som mulig for at kunne lukke "mere" hpyerlinks info'en ned igen efter åbning
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
        