using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_MelissaMoake
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void cancelQuoteButton_Click(object sender, MouseEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }


        private void width_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidWidth(width.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                width.Select(0, width.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.widthErrorProvider.SetError(width, errorMsg);
                width.BackColor = Color.LightCoral;
            }
        }

        private void width_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            widthErrorProvider.SetError(width, "");
            width.BackColor = Color.LightGreen;
        }


        public bool ValidWidth(string width, out string errorMessage)
        {
            // Confirm that the width field is not empty.
            if (width.Length == 0)
            {
                errorMessage = "Width is required.";
                return false;
            }

            // check that the width is between 24 and 96 inches
            if (Convert.ToDecimal(width) >= DeskQuote.MIN_WIDTH && Convert.ToDecimal(width) <= DeskQuote.MAX_WIDTH)
            {
                    errorMessage = "";
                    return true;
                    
            }

            errorMessage = "Width must be between " + DeskQuote.MIN_WIDTH +
                 " inches and " + DeskQuote.MAX_WIDTH + " inches.";
            return false;
        }

        private void depth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDepth(depth.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                depth.Select(0, depth.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.depthErrorProvider.SetError(depth, errorMsg);
                depth.BackColor = Color.LightCoral;
            }
        }

        private void depth_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            depthErrorProvider.SetError(depth, "");
            depth.BackColor = Color.LightGreen;
        }

        public bool ValidDepth(string depth, out string errorMessage)
        {
            // Confirm that the width field is not empty.
            if (depth.Length == 0)
            {
                errorMessage = "Depth is required.";
                return false;
            }

            // check that the width is between 24 and 96 inches
            if (Convert.ToDecimal(depth) >= DeskQuote.MIN_DEPTH && 
                Convert.ToDecimal(depth) <= DeskQuote.MAX_DEPTH)
            {
                errorMessage = "";
                return true;

            }

            errorMessage = "Depth must be between " + DeskQuote.MIN_DEPTH + 
                " inches and " + DeskQuote.MAX_DEPTH +" inches.";
            return false;
        }

        private void widthCharValidation(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event. 
            //Backspace doesn't work!! Fix if possible

            if (char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar))
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void depthCharValidation(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event. 
            //Backspace doesn't work!! Fix if possible

            if (char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar))
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

    }
}
