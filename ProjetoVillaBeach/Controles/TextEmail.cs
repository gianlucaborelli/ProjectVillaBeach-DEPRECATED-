using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Controles
{
    public partial class TextEmail : UserControl
    {
        public bool IsValid = false;
        public TextEmail()
        {
            InitializeComponent();
        }

        private void Control_BackColorChanged(object sender, EventArgs e)
        {
            txtEmail.BackColor = this.BackColor;
        }

        private void Txt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "E-Mail";
                txtEmail.ForeColor = Color.Gray;
            }
        }
        private void Txt_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "E-Mail")
            {
                txtEmail.Text = string.Empty;
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void Txt_Validating(object sender, CancelEventArgs e)
        {
            if (EmailIsValid(txtEmail.Text))
            {
                IsValid = true;               

                pnlValido.BackColor = Color.DarkGreen; ;
            }
            else
            {
                IsValid = false;
                pnlValido.BackColor = Color.Red;
            }
        }
        private static bool EmailIsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
