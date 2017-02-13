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
 * Sharp_Auto_Center
 * Created by Amandeep Kaur
 * Student no 200332905
 * Created on Feb 12, 2016
 * 
 * This program developed for the calculation of Amount of used and new mobiles.
 */

namespace Sharp_Auto_Center
{
    public partial class SharpAutoCenterForm : Form
    {
        private double _finishCost, _addCost, _basePrice, _tradeIn;
        public SharpAutoCenterForm()
        {
            InitializeComponent();
        }

        private void SharpAutoForm_Load(object sender, EventArgs e)
        {
            textBasePrice.Focus();
            _finishCost = 0;
            _addCost = 0;
            _basePrice = 0;
            _tradeIn = 0;
        }

        private void SharpAutoCenterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // This should exit the application
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new Form
            AboutForm aboutForm = new AboutForm();
            // show the About Form with ShowDialog;
            aboutForm.ShowDialog();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textSalesTax.Text = "0.00";
            textTotal.Text = "0.00";
            textTradeInAllowance.Text = "0.00";
            textBasePrice.Text = "0.00";
            textAdditionalOptions.Text = "0.00";
            textAmountDue.Text = "0.00";
            texSubTotal.Text = "0.00";
            standardRadioButton.Checked = true;
            stereoSystemcheckBox.Checked = false;
            leatherInteriorCheckBox.Checked = false;
            computerNavigationCheckBox.Checked = false;
            _finishCost = 0;
        }

        private void Checkbox_checkChanged(object sender, EventArgs e)
        {
            String senderName = ((CheckBox)sender).Text;
            Boolean senderState = ((CheckBox)sender).Checked;
            if (senderName.Equals("Stereo System") && senderState)
            {
                _addCost += 425.76;
            }
            else if (senderName.Equals("Stereo System"))
            {
                _addCost -= 425.76;
            }
            else if (senderName.Equals("Leather Interior") && senderState)
            {
                _addCost += 987.41;
            }
            else if (senderName.Equals("Leather Interior"))
            {
                _addCost -= 987.41;
            }

            else if (senderState)
            {
                _addCost += 1741.23;
            }
            else
            {
                _addCost -= 1741.23;
            }
            textAdditionalOptions.Text = (_finishCost + _addCost).ToString("C2");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSalesTax.Text = "0.00";
            textTotal.Text = "0.00";
            textTradeInAllowance.Text = "0.00";
            textBasePrice.Text = "0.00";
            textAdditionalOptions.Text = "0.00";
            textAmountDue.Text = "0.00";
            texSubTotal.Text = "0.00";
            standardRadioButton.Checked = true;
            stereoSystemcheckBox.Checked = false;
            leatherInteriorCheckBox.Checked = false;
            computerNavigationCheckBox.Checked = false;
            _finishCost = 0;
        }

        private void ValidateTextBox_TextChanged(object sender, EventArgs e)
        {
            double result = checkInput(((TextBox)sender).Text);
            if (result >= 0 && ((TextBox)sender).Name.Equals("basePriceLabel"))
            {
                _basePrice = result;
            }
            else if (result >= 0)
            {
                _tradeIn = result;
            }
            else
            {
                MessageBox.Show("Must be a value($)");
                ((TextBox)sender).Focus();
            }
        }
        private double checkInput(String input)
        {
            double result;
            if (Double.TryParse(input, out result))
            {
                return result;
            }
            return -1;
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            String senderName = ((RadioButton)sender).Text;
            if (senderName.Equals("Standard"))
            {
                _finishCost = 0;
            }
            else if (senderName.Equals("Pearlized"))
            {
                _finishCost = 345.72;
            }
            else
            {
                _finishCost = 599.99;
            }
            textAdditionalOptions.Text = (_finishCost + _addCost).ToString("C2");
        }



    }

}
    


