using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PizzaOrder
{
    public partial class Form1 : Form
    {
        void updateToppings(string Topping_Price, bool Topping_Checked, string Word)
        {
            List<string> toppings = label3.Text.Split('\n').ToList<string>();

            byte total = Convert.ToByte(priceInfo.Tag);
            byte SubPrice = Convert.ToByte(Topping_Price);

            if (Topping_Checked)
            {
                total += SubPrice;
                toppings.Add(Word);
            }
            else
            {
                total -= SubPrice;
                toppings.Remove(Word);
            }

            priceInfo.Tag = total;
            priceInfo.Text = "$" + total.ToString();

            label3.Text = string.Join("\n", toppings).Trim('\n');
        }

        void updateSize(string size, string size_price, bool size_checked)
        {
            label2.Text = size;

            byte total = Convert.ToByte(priceInfo.Tag);
            byte SubPrice = Convert.ToByte(size_price);

            if (size_checked)
                total += SubPrice;
            else
                total -= SubPrice;

            priceInfo.Tag = total;
            priceInfo.Text = "$" + total.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            updateSize("Small", Convert.ToString(rdSmall.Tag), rdSmall.Checked);
        }

        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {
            updateSize("Medium", Convert.ToString(rdMedium.Tag), rdMedium.Checked);
        }

        private void rdLarge_CheckedChanged(object sender, EventArgs e)
        {
            updateSize("Large", Convert.ToString(rdLarge.Tag), rdLarge.Checked);
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings(Convert.ToString(chkCheese.Tag), chkCheese.Checked, "Extra Cheese");
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings(Convert.ToString(chkMushroom.Tag), chkMushroom.Checked, "Mushrooms");
        }

        private void chkTomatoe_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings(Convert.ToString(chkTomatoe.Tag), chkTomatoe.Checked, "Tomatoes");

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings(Convert.ToString(chkOnion.Tag), chkOnion.Checked, "Onion");

        }

        private void chkOlive_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings(Convert.ToString(chkOlive.Tag), chkOlive.Checked, "Olives");

        }

        private void chkGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings(Convert.ToString(chkGreenPepper.Tag), chkGreenPepper.Checked, "Green Peppers");
        }

        private void rdThin_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Thin";
        }

        private void rdThik_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Thick";
        }

        private void rdHere_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Here";
        }

        private void rdOutside_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Outside";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grpCrust.Enabled = true;
            grpSize.Enabled = true;
            grpEatingPlace.Enabled = true;
            rdHere.Enabled = true;
            rdOutside.Enabled = true;
            grpToppings.Enabled = true;

            rdSmall.Checked = false;
            rdMedium.Checked = false;
            rdLarge.Checked = false;

            chkCheese.Checked = false;
            chkGreenPepper.Checked = false;
            chkMushroom.Checked = false;
            chkOlive.Checked = false;
            chkOnion.Checked = false;
            chkTomatoe.Checked = false;

            priceInfo.Tag = 0;

            rdThik.Checked = false;
            rdThin.Checked = false;

            rdHere.Checked = false;
            rdOutside.Checked = false;

            label5.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            priceInfo.Text = "$0";
        }

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you confirm your order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool toppings = (chkCheese.Checked || chkGreenPepper.Checked || chkMushroom.Checked || chkOlive.Checked || chkTomatoe.Checked || chkOnion.Checked);
                bool size = (rdSmall.Checked || rdLarge.Checked || rdMedium.Checked);
                bool scrust = (rdThik.Checked || rdThin.Checked);
                bool place = (rdHere.Checked || rdOutside.Checked);

                if (toppings && size && scrust && place)
                {
                    grpCrust.Enabled = false;
                    grpSize.Enabled = false;
                    grpEatingPlace.Enabled = false;
                    rdHere.Enabled = false;
                    rdOutside.Enabled = false;
                    grpToppings.Enabled = false;
                }
                else
                    MessageBox.Show("No Order is found!!\nTry Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
