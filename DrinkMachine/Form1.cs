using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkMachine
{
    public partial class Form1 : Form
    {
        // Structure
        struct Drink
        {
            public string name;
            public double cost;
            public int num;
        }

        // Array for the drinks
        Drink[] drinks = new Drink[5];

        static double Total;

        public Form1()
        {
            InitializeComponent();

            // Drink Cola
            drinks[0].name = "Cola";
            drinks[0].cost = 1.00;
            drinks[0].num = 20;
            costCola.Text = drinks[0].cost.ToString("c");
            ColaLeft.Text = drinks[0].num.ToString();

            // Root Beer
            drinks[1].name = "Root Beer";
            drinks[1].cost = 1.00;
            drinks[1].num = 20;
            costBeer.Text = drinks[1].cost.ToString("c");
            BeerLeft.Text = drinks[1].num.ToString();

            // Lemon Lime
            drinks[2].name = "Lemon Lime";
            drinks[2].cost = 1.00;
            drinks[2].num = 20;
            costLime.Text = drinks[2].cost.ToString("c");
            LimeLeft.Text = drinks[2].num.ToString();

            // Grape Soda
            drinks[3].name = "Grape Soda";
            drinks[3].cost = 1.50;
            drinks[3].num = 20;
            costGrape.Text = drinks[3].cost.ToString("c");
            GrapeLeft.Text = drinks[3].num.ToString();

            // Cream Soda
            drinks[4].name = "Cream Soda";
            drinks[4].cost = 1.50;
            drinks[4].num = 20;
            costCream.Text = drinks[4].cost.ToString("c");
            CreamLeft.Text = drinks[4].num.ToString();
        }

        private void pbCola_Click(object sender, EventArgs e)
        {
            double totalc = drinks[0].cost;
            drinks[0].num -= 1;

            // Set the total for the cola soda
            if (drinks[0].num >= 0)
            {
                ColaLeft.Text = drinks[0].num.ToString();
                Total = Total + totalc;
                totalSales.Text = Total.ToString("c");
            }
            else
                ranOut();
        }
        
        private void pbBeer_Click(object sender, EventArgs e)
        {
            double totalb = drinks[1].cost;
            drinks[1].num -= 1;

            // Set the total for the rootbeer
            if (drinks[1].num >= 0)
            {
                BeerLeft.Text = drinks[1].num.ToString();
                Total = Total + totalb;
                totalSales.Text = Total.ToString("c");
            }
            else
                ranOut();
        }

        private void pbLime_Click(object sender, EventArgs e)
        {
            double totalL = drinks[2].cost;
            drinks[2].num -= 1;


            if (drinks[2].num >= 0)
            {
                LimeLeft.Text = drinks[2].num.ToString();
                Total = Total + totalL;
                totalSales.Text = Total.ToString("c");
            }
            else
                ranOut();
        }

        private void pbGrape_Click(object sender, EventArgs e)
        {
            double totalG = drinks[3].cost;
            drinks[3].num -= 1;

            if (drinks[3].num >= 0)
            {
                GrapeLeft.Text = drinks[3].num.ToString();
                Total = Total + totalG;
                totalSales.Text = Total.ToString("c");
            }
            else
                ranOut();
        }

        private void pbCream_Click(object sender, EventArgs e)
        {
            double totalCr = drinks[4].cost;
            drinks[4].num -= 1;

            if (drinks[4].num >= 0)
            {
                CreamLeft.Text = drinks[4].num.ToString();
                Total = Total + totalCr;
                totalSales.Text = Total.ToString("c");
            }
            else
                ranOut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ranOut()
        {
            MessageBox.Show("Soda Ran OUT", "No More Sodas", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
