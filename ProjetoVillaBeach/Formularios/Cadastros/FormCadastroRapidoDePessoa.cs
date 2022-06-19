using Microsoft.EntityFrameworkCore;
using ProjetoVillaBeach.Classes;
using ProjetoVillaBeach.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Formularios.Cadastros
{
    public partial class FormCadastroRapidoDePessoa : Form
    {
        private bool _continua = false;
        public bool Continua { get { return _continua; } }

        private Pessoa _pessoa = new();
        public Pessoa Pessoa { get { return _pessoa; } }

        public FormCadastroRapidoDePessoa()
        {
            InitializeComponent();

            _pessoa.ObjectState = EntityObjectState.Added;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbCalendario_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            MonthCalendar calendario = new();
            pnlCadastro.Controls.Add(calendario);

            calendario.DateSelected += Calendario_DateSelected;
            calendario.LostFocus += Calendario_LostFocus;

            calendario.MaxSelectionCount = 1;
            calendario.TabIndex = 0;
            calendario.Location = pictureBox.Location;

            calendario.Focus();
            calendario.BringToFront();
            calendario.Show();
        }

        private void Calendario_LostFocus(object? sender, EventArgs e)
        {
            MonthCalendar calendario = (MonthCalendar)sender;
            calendario.Dispose();
        }

        private void Calendario_DateSelected(object? sender, DateRangeEventArgs e)
        {
            MonthCalendar calendario = (MonthCalendar)sender;
            txtDtNascimento.Text = calendario.SelectionStart.ToString("dd/MM/yyyy");
            calendario.Dispose();
        }

        private void SomenteNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnAddEndereco_Click(object sender, EventArgs e)
        {
            Endereco endereco = new();

            endereco.ObjectState = EntityObjectState.Added;

            _pessoa.Enderecos.Add(endereco);

            PopulaEndereco(endereco);
        }

        private void PopulaEndereco(Endereco end)
        {
            ControleEndereco control = new(end);

            flpEndereco.Controls.Add(control);
            control.AjustaTamanho(flpEndereco.Width - 25);
        }

        private void btnSalvarEContinuarCadastro_Click(object sender, EventArgs e)
        {
            _pessoa.InformaDataDeCadastro(DateTime.Now);

            if (_pessoa.Salvar())
            {
                _continua = true;

                this.Close();
            }
        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            _pessoa.InformaNome(txtNome.Text);
        }

        private void TxtDtNascimento_TextChanged(object sender, EventArgs e)
        {
            if (txtDtNascimento.Text != string.Empty)
            {
                if (!_pessoa.InformaDataDeNascimento(DateTime.Parse(txtDtNascimento.Text)))
                {
                    txtDtNascimento.Text = string.Empty;
                }
            }
        }

        private void TxtFiliacao1_Leave(object sender, EventArgs e)
        {
            _pessoa.InformaFiciliacao1(txtFiliacao1.Text);
        }

        private void TxtFiliacao2_Leave(object sender, EventArgs e)
        {
            _pessoa.InformaFiciliacao2(txtFiliacao2.Text);
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (txtCpf.Text != string.Empty)
            {
                if (!_pessoa.InformaCpf(ulong.Parse(txtCpf.Text)))
                {
                    txtCpf.Text = string.Empty;
                }
            }            
        }

        private void TxtRg_Leave(object sender, EventArgs e)
        {
            _pessoa.InformaRg(ulong.Parse(txtRg.Text));
        }

        private void BtnSalvarECadastrarNovo_Click(object sender, EventArgs e)
        {
            if (_pessoa.Salvar())
            {
                LimpaControles();
            }
        }

        private void LimpaControles()
        {
            foreach (Control textBox in pnlCadastro.Controls)
            {
                if (textBox is TextBox)
                {
                    textBox.Text = string.Empty;
                }
            }
            
            flpEndereco.Controls.Clear();
            flpContatos.Controls.Clear();

            _pessoa = new();
            _pessoa.ObjectState = EntityObjectState.Added;
        }
    }
}
