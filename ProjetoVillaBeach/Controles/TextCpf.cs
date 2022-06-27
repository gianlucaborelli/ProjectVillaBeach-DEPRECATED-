﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Controles
{
    public partial class TextCpf : UserControl
    {
        private ulong? _numeroCpf;
        public ulong? NumeroCpf
        {
            get
            {
                return _numeroCpf;
            }
            set
            {
                _numeroCpf = value;
            }
        }

        /*[Category("Appearance")]
        [Description("The text displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get
            {
                return txtCpf.Text;
            }
            set 
            {
                if (IsCpf(value.ToString()))
                {

                    txtCpf.Text = TrataCpf(value);
                }else
                {
                    txtCpf.Text = value;
                }                
            }
        }*/

        [Category("Appearance")]
        [Description("The text displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string PlaceholderText
        {
            get
            {

                return txtCpf.PlaceholderText;
            }
            set
            {
                txtCpf.PlaceholderText = value;
            }
        }

        public TextCpf()
        {
            InitializeComponent();
            txtCpf.BackColor = this.BackColor;
        }

        private string InformaCpf(string cpf)
        {
            string tempStrCpf = cpf;

            tempStrCpf = tempStrCpf.Trim();
            tempStrCpf = tempStrCpf.Replace(".", "").Replace("-", "");

            if(tempStrCpf == "")
            {
                NumeroCpf = null;
            }
            else
            {
                ulong? tempCpf = ulong.Parse(tempStrCpf);
                NumeroCpf = tempCpf;
            }            

            /*if (IsCpf(cpf))
            {   
                pnlValido.BackColor = Color.DarkGreen;
                cpf = TrataCpf(cpf);                
            }
            else
            {
                pnlValido.BackColor = Color.Red;
            }
            Text = cpf;*/
            return cpf;
        }

        private void TextCpf_BackColorChanged(object sender, EventArgs e)
        {
            txtCpf.BackColor = this.BackColor;
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private static string TrataCpf(string cpf)
        {
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if ( cpf.Length>= 11)
            {
                cpf = cpf.Insert(3, ".");
                cpf = cpf.Insert(7, ".");
                cpf = cpf.Insert(11, "-");
            }
            
            return cpf;
        }

        private void TextCpf_Leave(object sender, EventArgs e)
        {
            txtCpf.Text = InformaCpf(txtCpf.Text);
        }
    }
}
