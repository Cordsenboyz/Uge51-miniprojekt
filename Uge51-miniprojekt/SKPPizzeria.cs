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
        string[] Pizzaer = {"SKPSpecialALM","SKPSpecialFAM","OmadsFavALM","OmadsFavFAM","ViktorsFavALM","ViktorsFavFAM","EgenPizzaALM","EgenPizzaFam"};
        string[] Drikkevarer = {"Cola05l","Cola15L","Fanta05L","Fanta15L"};
        int yAmountCalculator = 5;
        int totalpris = 0;
        int RabatPizza = 0;
        bool Rabat = false;
        int RabatDrikkevare = 0;

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
            EgenPizzaList.Visible = false;
            BestilButton.Visible = false;
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
        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (SKPSpcialALMCheckBox.Checked == true)
            {
                BestilButton.Visible = true;
                string[] row = { SKPSpecialLabel.Text + " " + "65 kr." };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                List<Button> MereKnapCreation = new List<Button>();
                Button NyMereKnapCreation = new Button();
                MereKnapCreation.Add(NyMereKnapCreation);
                NyMereKnapCreation.Name = "MereKnap";
                NyMereKnapCreation.Text = "+";
                NyMereKnapCreation.Location = new Point(133, 0 + yAmountCalculator);
                NyMereKnapCreation.Size = new Size(31, 22);
                NyMereKnapCreation.Click += new EventHandler(NewButton_Click);
                KurvListView.Controls.Add(NyMereKnapCreation);
                List<NumericUpDown> AntalPizzaUpDown = new List<NumericUpDown>();
                NumericUpDown nyAntalPizzaUpDown = new NumericUpDown();
                AntalPizzaUpDown.Add(nyAntalPizzaUpDown);
                nyAntalPizzaUpDown.Value = 1;
                nyAntalPizzaUpDown.Name = "AmountCalculator";
                nyAntalPizzaUpDown.Location = new Point(168, 0 + yAmountCalculator);
                nyAntalPizzaUpDown.Size = new Size(31, 22);
                nyAntalPizzaUpDown.Visible = true;
                nyAntalPizzaUpDown.ValueChanged += new EventHandler(SkpSpecialAlm_ValueChange);
                KurvListView.Controls.Add(nyAntalPizzaUpDown);
                yAmountCalculator += 30;
                /*numericUpDown1.Visible = true;
                numericUpDown1.Value = 1;*/
                int Skpspeicalpris = (int)(65 * nyAntalPizzaUpDown.Value);
                totalpris += Skpspeicalpris;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
            RabatPizza += 1;
            if (RabatPizza >= 2 && RabatDrikkevare >= 2 && Rabat == false)
            {
                string[] row = { "Rabat -30 kr." };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris -= 30;
                Rabat = true;
                TotalPriceLabel.Text = totalpris.ToString() + "kr.";
                yAmountCalculator += 30;
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
                    BestilButton.Visible = true;
                    string[] row = { OmadsFavLabel.Text + " " + OmadsFavALMCheckBox.Text};
                    var ListViewItem = new ListViewItem(row);
                    KurvListView.Items.Add(ListViewItem);
                    List<Button> MereKnapCreation = new List<Button>();
                    Button NyMereKnapCreation = new Button();
                    MereKnapCreation.Add(NyMereKnapCreation);
                    NyMereKnapCreation.Name = "MereKnap";
                    NyMereKnapCreation.Text = "+";
                    NyMereKnapCreation.Location = new Point(133, 0 + yAmountCalculator);
                    NyMereKnapCreation.Size = new Size(31, 22);
                    NyMereKnapCreation.Click += new EventHandler(NewButton_Click);
                    KurvListView.Controls.Add(NyMereKnapCreation);
                    List<NumericUpDown> AntalPizzaUpDown = new List<NumericUpDown>();
                    NumericUpDown nyAntalPizzaUpDown = new NumericUpDown();
                    AntalPizzaUpDown.Add(nyAntalPizzaUpDown);
                    nyAntalPizzaUpDown.Value = 1;
                    nyAntalPizzaUpDown.Name = "AmountCalculator";
                    nyAntalPizzaUpDown.Location = new Point(168, 0 + yAmountCalculator);
                    nyAntalPizzaUpDown.Size = new Size(31, 22);
                    nyAntalPizzaUpDown.Visible = true;
                    nyAntalPizzaUpDown.ValueChanged += new EventHandler(OmadsFavAlmUpDown_ValueChange);
                    KurvListView.Controls.Add(nyAntalPizzaUpDown);
                    yAmountCalculator += 30;
                    totalpris += 60;
                    TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
                }

                RabatPizza += 1;
                if (RabatPizza >= 2 && RabatDrikkevare >= 2 && Rabat == false)
                {
                    string[] row = { "Rabat -30 kr." };
                    var ListViewItem = new ListViewItem(row);
                    KurvListView.Items.Add(ListViewItem);
                    totalpris -= 30;
                    Rabat = true;
                    TotalPriceLabel.Text = totalpris.ToString() + "kr.";
                    yAmountCalculator += 30;
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
                    BestilButton.Visible = true;
                    string[] row = { SKPSpecialLabel.Text + " " + SKPSpecialFAMCheckBox.Text };
                    var ListViewItem = new ListViewItem(row);
                    KurvListView.Items.Add(ListViewItem);
                    List<Button> MereKnapCreation = new List<Button>();
                    Button NyMereKnapCreation = new Button();
                    MereKnapCreation.Add(NyMereKnapCreation);
                    NyMereKnapCreation.Name = "MereKnap";
                    NyMereKnapCreation.Text = "+";
                    NyMereKnapCreation.Location = new Point(133, 0 + yAmountCalculator);
                    NyMereKnapCreation.Size = new Size(31, 22);
                    NyMereKnapCreation.Click += new EventHandler(NewButton_Click);
                    KurvListView.Controls.Add(NyMereKnapCreation);
                    List<NumericUpDown> AntalPizzaUpDown = new List<NumericUpDown>();
                    NumericUpDown nyAntalPizzaUpDown = new NumericUpDown();
                    AntalPizzaUpDown.Add(nyAntalPizzaUpDown);
                    nyAntalPizzaUpDown.Value = 1;
                    nyAntalPizzaUpDown.Name = "AmountCalculator";
                    nyAntalPizzaUpDown.Location = new Point(168, 0 + yAmountCalculator);
                    nyAntalPizzaUpDown.Size = new Size(31, 22);
                    nyAntalPizzaUpDown.Visible = true;
                    nyAntalPizzaUpDown.ValueChanged += new EventHandler(SkpSpecialFam_ValueChange);
                    KurvListView.Controls.Add(nyAntalPizzaUpDown);
                    yAmountCalculator += 30;
                    totalpris += 120;
                    TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
                }

            }
            RabatPizza += 1;
            if (RabatPizza >= 2 && RabatDrikkevare >= 2 && Rabat == false)
            {
                string[] row = { "Rabat -30 kr." };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris -= 30;
                Rabat = true;
                TotalPriceLabel.Text = totalpris.ToString() + "kr.";
                yAmountCalculator += 30;
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
                    BestilButton.Visible = true;
                    string[] row = { OmadsFavLabel.Text + " " + OmadsFavFAMCheckBox.Text };
                    var ListViewItem = new ListViewItem(row);
                    KurvListView.Items.Add(ListViewItem);
                    List<Button> MereKnapCreation = new List<Button>();
                    Button NyMereKnapCreation = new Button();
                    MereKnapCreation.Add(NyMereKnapCreation);
                    NyMereKnapCreation.Name = "MereKnap";
                    NyMereKnapCreation.Text = "+";
                    NyMereKnapCreation.Location = new Point(133, 0 + yAmountCalculator);
                    NyMereKnapCreation.Size = new Size(31, 22);
                    NyMereKnapCreation.Click += new EventHandler(NewButton_Click);
                    KurvListView.Controls.Add(NyMereKnapCreation);
                    List<NumericUpDown> AntalPizzaUpDown = new List<NumericUpDown>();
                    NumericUpDown nyAntalPizzaUpDown = new NumericUpDown();
                    AntalPizzaUpDown.Add(nyAntalPizzaUpDown);
                    nyAntalPizzaUpDown.Value = 1;
                    nyAntalPizzaUpDown.Name = "AmountCalculator";
                    nyAntalPizzaUpDown.Location = new Point(168, 0 + yAmountCalculator);
                    nyAntalPizzaUpDown.Size = new Size(31, 22);
                    nyAntalPizzaUpDown.Visible = true;
                    nyAntalPizzaUpDown.ValueChanged += new EventHandler(OmadsFavFamUpDown_ValueChange);
                    KurvListView.Controls.Add(nyAntalPizzaUpDown);
                    yAmountCalculator += 30;
                    totalpris += 110;
                    TotalPriceLabel.Text = totalpris.ToString() + "Kr.";

                }
                RabatPizza += 1;
                if (RabatPizza >= 2 && RabatDrikkevare >= 2 && Rabat == false)
                {
                    string[] row = { "Rabat -30 kr." };
                    var ListViewItem = new ListViewItem(row);
                    KurvListView.Items.Add(ListViewItem);
                    totalpris -= 30;
                    Rabat = true;
                    TotalPriceLabel.Text = totalpris.ToString() + "kr.";
                    yAmountCalculator += 30;
                }
            }
        }

        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (ViktorsFavALMCheckBox.Checked == true)
                {
                    BestilButton.Visible = true;
                    string[] row = { ViktorsFavLabel.Text + " " + ViktorsFavALMCheckBox.Text};
                    var ListViewItem = new ListViewItem(row);
                    KurvListView.Items.Add(ListViewItem);
                    List<Button> MereKnapCreation = new List<Button>();
                    Button NyMereKnapCreation = new Button();
                    MereKnapCreation.Add(NyMereKnapCreation);
                    NyMereKnapCreation.Name = "MereKnap";
                    NyMereKnapCreation.Text = "+";
                    NyMereKnapCreation.Location = new Point(133, 0 + yAmountCalculator);
                    NyMereKnapCreation.Size = new Size(31, 22);
                    NyMereKnapCreation.Click += new EventHandler(NewButton_Click);
                    KurvListView.Controls.Add(NyMereKnapCreation);
                    List<NumericUpDown> AntalPizzaUpDown = new List<NumericUpDown>();
                    NumericUpDown nyAntalPizzaUpDown = new NumericUpDown();
                    AntalPizzaUpDown.Add(nyAntalPizzaUpDown);
                    nyAntalPizzaUpDown.Value = 1;
                    nyAntalPizzaUpDown.Name = "AmountCalculator";
                    nyAntalPizzaUpDown.Location = new Point(168, 0 + yAmountCalculator);
                    nyAntalPizzaUpDown.Size = new Size(31, 22);
                    nyAntalPizzaUpDown.Visible = true;
                    nyAntalPizzaUpDown.ValueChanged += new EventHandler(ViktorsFavAlmUpDown_ValueChange);
                    KurvListView.Controls.Add(nyAntalPizzaUpDown);
                    yAmountCalculator += 30;
                    totalpris += 50;
                    TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
                }
                RabatPizza += 1;
                if (RabatPizza >= 2 && RabatDrikkevare >= 2 && Rabat == false)
                {
                    string[] row = { "Rabat -30 kr." };
                    var ListViewItem = new ListViewItem(row);
                    KurvListView.Items.Add(ListViewItem);
                    totalpris -= 30;
                    Rabat = true;
                    TotalPriceLabel.Text = totalpris.ToString() + "kr.";
                    yAmountCalculator += 30;
                }
            }
        }
        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (ViktorsFavFAMCheckOs.Checked == true)
            {
                BestilButton.Visible = true;
                string[] row = { ViktorsFavLabel.Text + " " + ViktorsFavFAMCheckOs.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                List<Button> MereKnapCreation = new List<Button>();
                Button NyMereKnapCreation = new Button();
                MereKnapCreation.Add(NyMereKnapCreation);
                NyMereKnapCreation.Name = "MereKnap";
                NyMereKnapCreation.Text = "+";
                NyMereKnapCreation.Location = new Point(133, 0 + yAmountCalculator);
                NyMereKnapCreation.Size = new Size(31, 22);
                NyMereKnapCreation.Click += new EventHandler(NewButton_Click);
                KurvListView.Controls.Add(NyMereKnapCreation);
                List<NumericUpDown> AntalPizzaUpDown = new List<NumericUpDown>();
                NumericUpDown nyAntalPizzaUpDown = new NumericUpDown();
                AntalPizzaUpDown.Add(nyAntalPizzaUpDown);
                nyAntalPizzaUpDown.Value = 1;
                nyAntalPizzaUpDown.Name = "AmountCalculator";
                nyAntalPizzaUpDown.Location = new Point(168, 0 + yAmountCalculator);
                nyAntalPizzaUpDown.Size = new Size(31, 22);
                nyAntalPizzaUpDown.Visible = true;
                nyAntalPizzaUpDown.ValueChanged += new EventHandler(ViktorsFavFamUpDown_ValueChange);
                KurvListView.Controls.Add(nyAntalPizzaUpDown);
                yAmountCalculator += 30;
                totalpris += 100;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
            RabatPizza += 1;
            if (RabatPizza >= 2 && RabatDrikkevare >= 2 && Rabat == false)
            {
                string[] row = { "Rabat -30 kr." };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris -= 30;
                Rabat = true;
                TotalPriceLabel.Text = totalpris.ToString() + "kr.";
                yAmountCalculator += 30;
            }
        }
        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (EgenPizzaALMCheckOs.Checked == true)
            {
                BestilButton.Visible = true;
                EgenPizzaList.Visible = true;
                string[] row = { EgenPizzaLabel.Text + " " + EgenPizzaALMCheckOs.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                List<Button> MereKnapCreation = new List<Button>();
                Button NyMereKnapCreation = new Button();
                MereKnapCreation.Add(NyMereKnapCreation);
                NyMereKnapCreation.Name = "MereKnap";
                NyMereKnapCreation.Text = "+";
                NyMereKnapCreation.Location = new Point(133, 0 + yAmountCalculator);
                NyMereKnapCreation.Size = new Size(31, 22);
                NyMereKnapCreation.Click += new EventHandler(NewButton_Click);
                KurvListView.Controls.Add(NyMereKnapCreation);
                List<NumericUpDown> AntalPizzaUpDown = new List<NumericUpDown>();
                NumericUpDown nyAntalPizzaUpDown = new NumericUpDown();
                AntalPizzaUpDown.Add(nyAntalPizzaUpDown);
                nyAntalPizzaUpDown.Value = 1;
                nyAntalPizzaUpDown.Name = "AmountCalculator";
                nyAntalPizzaUpDown.Location = new Point(168, 0 + yAmountCalculator);
                nyAntalPizzaUpDown.Size = new Size(31, 22);
                nyAntalPizzaUpDown.Visible = true;
                nyAntalPizzaUpDown.ValueChanged += new EventHandler(EgenPizzaAlm_ValueChange);
                KurvListView.Controls.Add(nyAntalPizzaUpDown);
                yAmountCalculator += 30;
                KurvListView.Items[0].SubItems.Add("Skinke");
                totalpris += 30;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
            RabatPizza += 1;
            if (RabatPizza >= 2 && RabatDrikkevare >= 2 && Rabat == false)
            {
                string[] row = { "Rabat -30 kr." };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris -= 30;
                Rabat = true;
                TotalPriceLabel.Text = totalpris.ToString() + "kr.";
                yAmountCalculator += 30;
            }
        }
        //Tilføjer en pizza til listen over i kurven og renger prisen sammen
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (EgenPizzaFAMCheckBox.Checked == true)
            {
                BestilButton.Visible = true;
                EgenPizzaList.Visible = true;
                string[] row = { EgenPizzaLabel.Text + " " + EgenPizzaFAMCheckBox.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                List<Button> MereKnapCreation = new List<Button>();
                Button NyMereKnapCreation = new Button();
                MereKnapCreation.Add(NyMereKnapCreation);
                NyMereKnapCreation.Name = "MereKnap";
                NyMereKnapCreation.Text = "+";
                NyMereKnapCreation.Location = new Point(133, 0 + yAmountCalculator);
                NyMereKnapCreation.Size = new Size(31, 22);
                NyMereKnapCreation.Click += new EventHandler(NewButton_Click);
                KurvListView.Controls.Add(NyMereKnapCreation);
                List<NumericUpDown> AntalPizzaUpDown = new List<NumericUpDown>();
                NumericUpDown nyAntalPizzaUpDown = new NumericUpDown();
                AntalPizzaUpDown.Add(nyAntalPizzaUpDown);
                nyAntalPizzaUpDown.Value = 1;
                nyAntalPizzaUpDown.Name = "AmountCalculator";
                nyAntalPizzaUpDown.Location = new Point(168, 0 + yAmountCalculator);
                nyAntalPizzaUpDown.Size = new Size(31, 22);
                nyAntalPizzaUpDown.Visible = true;
                nyAntalPizzaUpDown.ValueChanged += new EventHandler(EgenPizzaFam_ValueChange);
                KurvListView.Controls.Add(nyAntalPizzaUpDown);
                yAmountCalculator += 30;
                totalpris += 80;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
            RabatPizza += 1;
            if (RabatPizza >= 2 && RabatDrikkevare >= 2 && Rabat == false)
            {
                string[] row = { "Rabat -30 kr." };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris -= 30;
                Rabat = true;
                TotalPriceLabel.Text = totalpris.ToString() + "kr.";
                yAmountCalculator += 30;
            }
        }
        //Tilføjer en Drikkevare til listen over i kurven og renger prisen sammen
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (CocaCola05LCheckBox.Checked == true)
            {
                BestilButton.Visible = true;
                string[] row = { CocaCola05LCheckBox.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                List<Button> MereKnapCreation = new List<Button>();
                Button NyMereKnapCreation = new Button();
                MereKnapCreation.Add(NyMereKnapCreation);
                NyMereKnapCreation.Name = "MereKnap";
                NyMereKnapCreation.Text = "+";
                NyMereKnapCreation.Location = new Point(133, 0 + yAmountCalculator);
                NyMereKnapCreation.Size = new Size(31, 22);
                NyMereKnapCreation.Click += new EventHandler(NewButton_Click);
                KurvListView.Controls.Add(NyMereKnapCreation);
                List<NumericUpDown> AntalPizzaUpDown = new List<NumericUpDown>();
                NumericUpDown nyAntalPizzaUpDown = new NumericUpDown();
                AntalPizzaUpDown.Add(nyAntalPizzaUpDown);
                nyAntalPizzaUpDown.Value = 1;
                nyAntalPizzaUpDown.Name = "AmountCalculator";
                nyAntalPizzaUpDown.Location = new Point(168, 0 + yAmountCalculator);
                nyAntalPizzaUpDown.Size = new Size(31, 22);
                nyAntalPizzaUpDown.Visible = true;
                nyAntalPizzaUpDown.ValueChanged += new EventHandler(Cola05LUpDown_ValueChange);
                KurvListView.Controls.Add(nyAntalPizzaUpDown);
                yAmountCalculator += 30;
                totalpris += 18;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
            RabatDrikkevare += 1;
            if (RabatPizza >= 2 && RabatDrikkevare >= 2 && Rabat == false)
            {
                string[] row = { "Rabat -30 kr." };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris -= 30;
                Rabat = true;
                TotalPriceLabel.Text = totalpris.ToString() + "kr.";
                yAmountCalculator += 30;
            }
        }
        //Tilføjer en Drikkevare til listen over i kurven og renger prisen sammen
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (CocaCola1LCheckBox.Checked == true)
            {
                BestilButton.Visible = true;
                string[] row = { CocaCola1LCheckBox.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                List<Button> MereKnapCreation = new List<Button>();
                Button NyMereKnapCreation = new Button();
                MereKnapCreation.Add(NyMereKnapCreation);
                NyMereKnapCreation.Name = "MereKnap";
                NyMereKnapCreation.Text = "+";
                NyMereKnapCreation.Location = new Point(133, 0 + yAmountCalculator);
                NyMereKnapCreation.Size = new Size(31, 22);
                NyMereKnapCreation.Click += new EventHandler(NewButton_Click);
                KurvListView.Controls.Add(NyMereKnapCreation);
                List<NumericUpDown> AntalPizzaUpDown = new List<NumericUpDown>();
                NumericUpDown nyAntalPizzaUpDown = new NumericUpDown();
                AntalPizzaUpDown.Add(nyAntalPizzaUpDown);
                nyAntalPizzaUpDown.Value = 1;
                nyAntalPizzaUpDown.Name = "AmountCalculator";
                nyAntalPizzaUpDown.Location = new Point(168, 0 + yAmountCalculator);
                nyAntalPizzaUpDown.Size = new Size(31, 22);
                nyAntalPizzaUpDown.Visible = true;
                nyAntalPizzaUpDown.ValueChanged += new EventHandler(Cola15LUpDown_ValueChange);
                KurvListView.Controls.Add(nyAntalPizzaUpDown);
                yAmountCalculator += 30;
                totalpris += 30;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
            RabatDrikkevare += 1;
            if (RabatPizza >= 2 && RabatDrikkevare >= 2 && Rabat == false)
            {
                BestilButton.Visible = true;
                string[] row = { "Rabat -30 kr." };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris -= 30;
                Rabat = true;
                TotalPriceLabel.Text = totalpris.ToString() + "kr.";
                yAmountCalculator += 30;
            }
        }
        //Tilføjer en Drikkevare til listen over i kurven og renger prisen sammen
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (Fanta05LCheckBox.Checked == true)
            {
                BestilButton.Visible = true;
                string[] row = { Fanta05LCheckBox.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                List<Button> MereKnapCreation = new List<Button>();
                Button NyMereKnapCreation = new Button();
                MereKnapCreation.Add(NyMereKnapCreation);
                NyMereKnapCreation.Name = "MereKnap";
                NyMereKnapCreation.Text = "+";
                NyMereKnapCreation.Location = new Point(133, 0 + yAmountCalculator);
                NyMereKnapCreation.Size = new Size(31, 22);
                NyMereKnapCreation.Click += new EventHandler(NewButton_Click);
                KurvListView.Controls.Add(NyMereKnapCreation);
                List<NumericUpDown> AntalPizzaUpDown = new List<NumericUpDown>();
                NumericUpDown nyAntalPizzaUpDown = new NumericUpDown();
                AntalPizzaUpDown.Add(nyAntalPizzaUpDown);
                nyAntalPizzaUpDown.Value = 1;
                nyAntalPizzaUpDown.Name = "AmountCalculator";
                nyAntalPizzaUpDown.Location = new Point(168, 0 + yAmountCalculator);
                nyAntalPizzaUpDown.Size = new Size(31, 22);
                nyAntalPizzaUpDown.Visible = true;
                nyAntalPizzaUpDown.ValueChanged += new EventHandler(Fanta05LUpDown_ValueChange);
                KurvListView.Controls.Add(nyAntalPizzaUpDown);
                yAmountCalculator += 30;
                totalpris += 18;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
            RabatDrikkevare += 1;
            if (RabatPizza >= 2 && RabatDrikkevare >= 2 && Rabat == false)
            {
                string[] row = { "Rabat -30 kr." };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris -= 30;
                Rabat = true;
                TotalPriceLabel.Text = totalpris.ToString() + "kr.";
                yAmountCalculator += 30;
            }
        }
        //Tilføjer en Drikkevare til listen over i kurven og renger prisen sammen
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (Fanta1LCheckBox.Checked == true)
            {
                BestilButton.Visible = true;
                string[] row = { Fanta1LCheckBox.Text };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                List<Button> MereKnapCreation = new List<Button>();
                Button NyMereKnapCreation = new Button();
                MereKnapCreation.Add(NyMereKnapCreation);
                NyMereKnapCreation.Name = "MereKnap";
                NyMereKnapCreation.Text = "+";
                NyMereKnapCreation.Location = new Point(133, 0 + yAmountCalculator);
                NyMereKnapCreation.Size = new Size(31, 22);
                NyMereKnapCreation.Click += new EventHandler(NewButton_Click);
                KurvListView.Controls.Add(NyMereKnapCreation);
                List<NumericUpDown> AntalPizzaUpDown = new List<NumericUpDown>();
                NumericUpDown nyAntalPizzaUpDown = new NumericUpDown();
                AntalPizzaUpDown.Add(nyAntalPizzaUpDown);
                nyAntalPizzaUpDown.Value = 1;
                nyAntalPizzaUpDown.Name = "AmountCalculator";
                nyAntalPizzaUpDown.Location = new Point(168, 0 + yAmountCalculator);
                nyAntalPizzaUpDown.Size = new Size(31, 22);
                nyAntalPizzaUpDown.Visible = true;
                nyAntalPizzaUpDown.ValueChanged += new EventHandler(Fanta15LUpDown_ValueChange);
                KurvListView.Controls.Add(nyAntalPizzaUpDown);
                yAmountCalculator += 30;
                totalpris += 30;
                TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            }
            RabatDrikkevare += 1;
            if (RabatPizza >= 2 && RabatDrikkevare >= 2 && Rabat == false)
            {
                BestilButton.Visible = true;
                string[] row = { "Rabat -30 kr." };
                var ListViewItem = new ListViewItem(row);
                KurvListView.Items.Add(ListViewItem);
                totalpris -= 30;
                Rabat = true;
                TotalPriceLabel.Text = totalpris.ToString() + "kr.";
                yAmountCalculator += 30;
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            totalpris += 0;
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
        //fjerner de "items" man har valgt fra listen i "Kurven"
        private void button1_Click(object sender, EventArgs e)
        {
            BestilButton.Visible = false;
            SKPSpcialALMCheckBox.Checked = false;
            SKPSpecialFAMCheckBox.Checked = false;
            OmadsFavALMCheckBox.Checked = false;
            OmadsFavFAMCheckBox.Checked = false;
            ViktorsFavALMCheckBox.Checked = false;
            ViktorsFavFAMCheckOs.Checked = false;
            EgenPizzaALMCheckOs.Checked = false;
            EgenPizzaFAMCheckBox.Checked = false;
            CocaCola05LCheckBox.Checked = false;
            CocaCola1LCheckBox.Checked = false;
            Fanta05LCheckBox.Checked = false;
            Fanta1LCheckBox.Checked = false;
            totalpris = 0;
            RabatDrikkevare = 0;
            RabatPizza = 0;
            Rabat = false;
            yAmountCalculator = 5;
            TotalPriceLabel.Text = totalpris.ToString() + "Kr.";
            KurvListView.Items.Clear();
            KurvListView.Controls.Clear();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] TIlbehør = { EgenPizzaList.SelectedItem.ToString() };
            var ListViewItem = new ListViewItem(TIlbehør);
            KurvListView.Items.Add(ListViewItem);
            totalpris += 5;
            TotalPriceLabel.Text = totalpris.ToString() + "kr.";
        }
        void NewButton_Click(object sender, EventArgs e)
        {
            EgenPizzaList.BringToFront();
            EgenPizzaList.Visible = true;
        }
        private void BestilButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tak for Din Bestilling");
        }
        //Updatere Prisen på Varer efter NumericUpDown_ValueChange
        public void SkpSpecialAlm_ValueChange(object sender, EventArgs e)
        {
            int price = 0;
            price++;
            totalpris += 65 * price;
            TotalPriceLabel.Text = totalpris.ToString() + "kr.";
        }
        //Updatere Prisen på Varer efter NumericUpDown_ValueChange
        public void SkpSpecialFam_ValueChange(object sender, EventArgs e)
        {
            int price = 0;
            price++;
            totalpris += 120 * price;
            TotalPriceLabel.Text = totalpris.ToString() + "kr.";
        }
        //Updatere Prisen på Varer efter NumericUpDown_ValueChange
        public void OmadsFavAlmUpDown_ValueChange(object sender, EventArgs e)
        {
            int price = 0;
            price++;
            totalpris += 60 * price;
            TotalPriceLabel.Text = totalpris.ToString() + "kr.";
        }
        //Updatere Prisen på Varer efter NumericUpDown_ValueChange
        public void OmadsFavFamUpDown_ValueChange(object sender, EventArgs e)
        {
            int price = 0;
            price++;
            totalpris += 110 * price;
            TotalPriceLabel.Text = totalpris.ToString() + "kr.";
        }
        //Updatere Prisen på Varer efter NumericUpDown_ValueChange
        public void ViktorsFavAlmUpDown_ValueChange(object sender, EventArgs e)
        {
            int price = 0;
            price++;
            totalpris += 50 * price;
            TotalPriceLabel.Text = totalpris.ToString() + "kr.";
        }
        //Updatere Prisen på Varer efter NumericUpDown_ValueChange
        public void ViktorsFavFamUpDown_ValueChange(object sender, EventArgs e)
        {
            int price = 0;
            price++;
            totalpris += 100 * price;
            TotalPriceLabel.Text = totalpris.ToString() + "kr.";
        }
        //Updatere Prisen på Varer efter NumericUpDown_ValueChange
        public void EgenPizzaAlm_ValueChange(object sender, EventArgs e)
        {
            int price = 0;
            price++;
            totalpris += 30 * price;
            TotalPriceLabel.Text = totalpris.ToString() + "kr.";
        }
        //Updatere Prisen på Varer efter NumericUpDown_ValueChange
        public void EgenPizzaFam_ValueChange(object sender, EventArgs e)
        {
            int price = 0;
            price++;
            totalpris += 80 * price;
            TotalPriceLabel.Text = totalpris.ToString() + "kr.";
        }
        //Updatere Prisen på Varer efter NumericUpDown_ValueChange
        public void Cola05LUpDown_ValueChange(object sender, EventArgs e)
        {
            int price = 0;
            price++;
            totalpris += 18 * price;
            TotalPriceLabel.Text = totalpris.ToString() + "kr.";
        }
        //Updatere Prisen på Varer efter NumericUpDown_ValueChange
        public void Cola15LUpDown_ValueChange(object sender, EventArgs e)
        {
            int price = 0;
            price++;
            totalpris += 30 * price;
            TotalPriceLabel.Text = totalpris.ToString() + "kr.";
        }
        //Updatere Prisen på Varer efter NumericUpDown_ValueChange
        public void Fanta05LUpDown_ValueChange(object sender, EventArgs e)
        {
            int price = 0;
            price++;
            totalpris += 18 * price;
            TotalPriceLabel.Text = totalpris.ToString() + "kr.";
        }
        //Updatere Prisen på Varer efter NumericUpDown_ValueChange
        public void Fanta15LUpDown_ValueChange(object sender, EventArgs e)
        {
            int price = 0;
            price++;
            totalpris += 30 * price;
            TotalPriceLabel.Text = totalpris.ToString() + "kr.";
        }
    }
}