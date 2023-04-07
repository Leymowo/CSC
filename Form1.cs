using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*

Program Author: Khalid Alghamdi

Assignment: Program 3: Lenny's Car Wash

Description:

A Program where you can Choose which tier you want to pay for,
with a real time updating Total price and Optional Addons. This is the Class

*/
namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private double washPrice;
        private double addonsPrice;

        public Form1()
        {
            InitializeComponent();
            washPrice = 0.0;
            addonsPrice = 0.0;
            UpdateTotalLabel();
        }

        private void WashTierRadioButton_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                switch (radioButton.Text)
                {
                    case "Basic Wash":
                        washPrice = 10.0;
                        break;
                    case "Premium Wash":
                        washPrice = 15.0;
                        break;
                    case "Ultra Wash":
                        washPrice = 20.0;
                        break;
                    default:
                        break;
                }
            }
            UpdateTotalLabel();
        }

        private void AddonsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                switch (checkBox.Text)
                {
                    case "Air Freshener":
                    case "Vacuum Service":
                        addonsPrice += 2.0;
                        break;
                    case "Wax On Service":
                    case "Tire Shine Service":
                        addonsPrice += 5.0;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (checkBox.Text)
                {
                    case "Air Freshener":
                    case "Vacuum Service":
                        addonsPrice -= 2.0;
                        break;
                    case "Wax On Service":
                    case "Tire Shine Service":
                        addonsPrice -= 5.0;
                        break;
                    default:
                        break;
                }
            }
            UpdateTotalLabel();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            double totalPrice = washPrice + addonsPrice;
            string message = "Wash Selected: ";
            if (BasicWashButton.Checked)
            {
                message += "Basic Wash";
            }
            else if (PremiumWashButton.Checked)
            {
                message += "Premium Wash";
            }
            else if (UltraWashButton.Checked)
            {
                message += "Ultra Wash";
            }
            if (addonsPrice > 0.0)
            {
                message += "\nAdd-Ons Selected: ";
                if (AirFreshener.Checked)
                {
                    message += "\n- Air Freshener";
                }
                if (VacuumService.Checked)
                {
                    message += "\n- Vacuum Service";
                }
                if (WaxOnService.Checked)
                {
                    message += "\n- Wax On Service";
                }
                if (TireShineService.Checked)
                {
                    message += "\n- Tire Shine Service";
                }
            }
            message += "\nTotal Price: $" + totalPrice.ToString("0.00");
            MessageBox.Show(message, "Order Summary");
        }

        private void UpdateTotalLabel()
        {
            double totalPrice = washPrice + addonsPrice;
            label1.Text = "Total: $" + totalPrice.ToString("0.00");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
