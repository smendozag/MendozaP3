using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MendozaP3
{
    public partial class LogoItemOrderForm : Form
    {
        public LogoItemOrderForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //Instatiate two parameter constructor
            LogoOrderItem order = new LogoOrderItem(txtTextEngraved.Text, chbxLogo.Checked);
            try
            {
                //Read values to remaining items
                order.ItemID = int.Parse(txtOrderNum.Text);
                order.NumItems = int.Parse(txtNumOfItems.Text);
                if (chbxLogo.Checked)
                {
                    order.HasLogo = true;
                    order.NumColors = int.Parse(txtNumOfColors.Text);
                    order.Text = txtTextEngraved.Text;
                }

                //radio buttons
                if (rbUSB.Checked) order.ItemType = rbUSB.Text;
                else if (rbMug.Checked) order.ItemType = rbMug.Text;
                else /*if (rbPen.Checked)*/ order.ItemType = rbPen.Text;
        
                //display information from class back to form
                txtResults.ForeColor = Color.Black;
                txtResults.Text = order.GetOrderSummary();
                //txtResults.Text = 
            }
            catch (Exception ex)
            {
                txtResults.ForeColor = Color.Red;
                txtResults.Text = ex.Message;

            }
        }

        private void chbxLogo_CheckedChanged(object sender, EventArgs e)
        {
            if(chbxLogo.Checked)
            {
                txtTextEngraved.Enabled = true;
                lblNumOfColors.Visible = true;
                txtNumOfColors.Visible = true;
            }
            else
            {
                txtTextEngraved.Enabled = false;
                lblNumOfColors.Visible = false;
                txtNumOfColors.Visible = false;
            }
        }

        private void btnClear(object sender, EventArgs e)
        {
            txtResults.Clear();
            txtOrderNum.Clear();
            txtNumOfItems.Clear();
            txtNumOfColors.Clear();
            txtTextEngraved.Clear();
        }
    }
}
