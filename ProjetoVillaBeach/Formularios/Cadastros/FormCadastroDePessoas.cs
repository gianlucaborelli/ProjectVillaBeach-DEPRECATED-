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
using ProjetoVillaBeach.Classes;
using ProjetoVillaBeach.Controles;

namespace ProjetoVillaBeach.Formularios.Cadastros
{
    public partial class FormCadastroDePessoas : Form
    {
        Pessoa pessoa = new();

        public FormCadastroDePessoas()
        {
            InitializeComponent();
        }

        public FormCadastroDePessoas(Pessoa id)
        {
            InitializeComponent();

            pessoa = id;
            
            CarregaPessoa();
        }

        private void CarregaPessoa()
        {
            flatTxtNome.Text = pessoa.Nome;

            flatTxtCpf.Text = pessoa.NumeroCpf.ToString();

            flatTxtDn.Text = pessoa.DataDeNascimento.ToString();

            if (flpEndereco.Controls.Count > 0)
                flpEndereco.Controls.Clear();

            foreach (Endereco endereco in pessoa.Enderecos)
            {
                endereco.ObjectState = EntityObjectState.Unchanged;
                PopulaEndereco(endereco);
            }
        }

        private void PopulaEndereco(Endereco end)
        {
            ControleEndereco control = new(end);

            flpEndereco.Controls.Add(control);
            control.AjustaTamanho(flpEndereco.Width);
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            pessoa.Salvar();
            CarregaPessoa();
        }

        private void BtnAddEndereco_Click(object sender, EventArgs e)
        {
            Endereco endereco = new();

            endereco.IdPessoa = pessoa.IdPessoa;

            endereco.ObjectState = EntityObjectState.Added;

            pessoa.Enderecos.Add(endereco);

            PopulaEndereco(endereco);
        }

        private void textNome1_Leave(object sender, EventArgs e)
        {
            pessoa.InformaNome(flatTxtNome.Text);
            flatTxtNome.Text = pessoa.Nome;
        }

        private void textCpf1_Leave(object sender, EventArgs e)
        {
            pessoa.InformaCpf(ulong.Parse(flatTxtCpf.Text));
            flatTxtCpf.Text = pessoa.NumeroCpf.ToString();
        }

        private void textData1_Leave(object sender, EventArgs e)
        {
            pessoa.InformaDataDeNascimento(DateTime.Parse(flatTxtDn.Text));
            flatTxtDn.Text = pessoa.DataDeNascimento.ToString();
        }

        private void CadastroPessoa_SizeChanged(object sender, EventArgs e)
        {
            foreach(ControleEndereco controle in flpEndereco.Controls)
            {
                controle.AjustaTamanho(flpEndereco.Width - 6);
            }
        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            PictureBox sender2 = (PictureBox)sender;
            MonthCalendar calendario = new();
            tableLayoutPanel2.Controls.Add(calendario);

            calendario.DateSelected += Calendario_DateSelected;
            calendario.LostFocus += Calendario_LostFocus;

            calendario.MaxSelectionCount = 1;
            calendario.TabIndex = 0;
            calendario.Location = sender2.Location;

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
            flatTxtDn.Text = calendario.SelectionStart.ToString("dd/MM/yyyy");
            calendario.Dispose();

        }
    }
}
