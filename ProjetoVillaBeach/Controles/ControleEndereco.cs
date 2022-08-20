using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ProjetoVillaBeach.Entities.Base;
using ProjetoVillaBeach.Entities;

namespace ProjetoVillaBeach.Controles
{
    public partial class ControleEndereco : UserControl
    {
        private Endereco endereco = new();
        public Endereco Endereco { get { return this.endereco; } set { endereco = value; } }

        public ControleEndereco()
        {
            InitializeComponent();
        }
        public ControleEndereco(Endereco end)
        {
            InitializeComponent();
            endereco = end;
            CarregaEndereco();
        }

        private void CarregaEndereco()
        {
            txtCep.DataBindings.Add("Text", endereco, "Cep");
            txtLogradouro.DataBindings.Add("Text", endereco, "Logradouro");
            txtNumero.DataBindings.Add("Text", endereco, "Numero");
            txtLocalidade.DataBindings.Add("Text", endereco, "Localidade");
            txtBairro.DataBindings.Add("Text", endereco, "Bairro");
            cbUf.DataBindings.Add("Text", endereco, "Uf");
            txtObs.DataBindings.Add("Text", endereco, "Obs");
        }

        private void Cep_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCep.Text))
                    throw new ArgumentNullException("C.E.P. em Branco");

                string cep = Endereco.TrataCep(txtCep.Text);

                if (cep.Length != 9)
                    throw new ArgumentOutOfRangeException("C.E.P. em formato invalido");

                Endereco temp = Endereco.ConstroiAsync(cep);

                endereco.Cep = temp.Cep;
                endereco.Logradouro = temp.Logradouro;
                endereco.Bairro = temp.Bairro;
                endereco.Localidade = temp.Localidade;
                endereco.Uf = temp.Uf;                

                if (endereco.ObjectState != EntityObjectState.Added)
                    endereco.ObjectState = EntityObjectState.Modified;

            }
            catch (ArgumentNullException ex)
            {
                NotificacaoPopUp.MostrarNotificacao("Erro" + ex, NotificacaoPopUp.AlertType.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                NotificacaoPopUp.MostrarNotificacao("Erro" + ex, NotificacaoPopUp.AlertType.Error);
            }
            catch (Exception ex)
            {
                NotificacaoPopUp.MostrarNotificacao("Erro" + ex, NotificacaoPopUp.AlertType.Error);
            }
            finally
            {
                if (endereco.Logradouro != null)
                {
                    txtNumero.Focus();
                }
                else
                {
                    txtLogradouro.Focus();
                }
            }
        }

        private void SomenteNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            this.Endereco.ObjectState = EntityObjectState.Deleted;
            this.Dispose();
        }

        private void Controle_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void Controle_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void Numero_Leave(object sender, EventArgs e)
        {
            if (endereco.Numero != txtNumero.Text)
            {
                if (endereco.ObjectState != EntityObjectState.Added)
                    endereco.ObjectState = EntityObjectState.Modified;
            }                
        }

        private void Obs_Leave(object sender, EventArgs e)
        {
            if (endereco.Obs != txtObs.Text)
            {
                if (endereco.ObjectState != EntityObjectState.Added)
                    endereco.ObjectState = EntityObjectState.Modified;
            }
        }

        private void Logradouro_Leave(object sender, EventArgs e)
        {
            if (endereco.Logradouro != txtLogradouro.Text)
            {
                if (endereco.ObjectState != EntityObjectState.Added)
                    endereco.ObjectState = EntityObjectState.Modified;
            }
        }

        private void Bairro_Leave(object sender, EventArgs e)
        {
            if (endereco.Bairro != txtBairro.Text)
            {
                if (endereco.ObjectState != EntityObjectState.Added)
                    endereco.ObjectState = EntityObjectState.Modified;
            }
        }

        private void Localidade_Leave(object sender, EventArgs e)
        {
            if (endereco.Localidade != txtLocalidade.Text)
            {
                if (endereco.ObjectState != EntityObjectState.Added)
                    endereco.ObjectState = EntityObjectState.Modified;
            }
        }

        private void Uf_Selection(object sender, EventArgs e)
        {
            if (cbUf.SelectedItem.ToString() != endereco.Uf)
            {
                if (endereco.ObjectState != EntityObjectState.Added)
                    endereco.ObjectState = EntityObjectState.Modified;
            }
        }

        public void AjustaTamanho (int width)
        {
            this.Width = width;
        }
    }
}
