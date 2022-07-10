using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            pessoa.ObjectState = EntityObjectState.Added;
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
            flatTxtRg.Text = pessoa.NumeroRg;
            flatTxtFiliacao1.Text = pessoa.Filiacao1;
            flatTxtFiliacao2.Text = pessoa.Filiacao2;

            if (flpEndereco.Controls.Count > 0)
                flpEndereco.Controls.Clear();

            foreach (Endereco endereco in pessoa.Enderecos)
            {
                endereco.ObjectState = EntityObjectState.Unchanged;
                PopulaEndereco(endereco);
            }
        }

        private void BtnAddEndereco_Click(object sender, EventArgs e)
        {
            Endereco endereco = new();

            endereco.IdPessoa = pessoa.IdPessoa;

            endereco.ObjectState = EntityObjectState.Added;

            pessoa.Enderecos.Add(endereco);

            PopulaEndereco(endereco);
        }

        private void PopulaEndereco(Endereco end)
        {
            ControleEndereco control = new(end);

            flpEndereco.Controls.Add(control);
            control.AjustaTamanho(flpEndereco.Width - 25);
        }

        private void CadastroPessoa_SizeChanged(object sender, EventArgs e)
        {
            foreach (ControleEndereco controle in flpEndereco.Controls)
            {
                controle.AjustaTamanho(flpEndereco.Width - 25);
            }
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

        private void NomeFlatTextBox_Leave(object sender, EventArgs e)
        {
            pessoa.Nome = flatTxtNome.Text;
        }

        private void Filiacao1FlatTextBox_Valited(object sender, EventArgs e)
        {
            pessoa.Filiacao1 = flatTxtFiliacao1.Text;
        }

        private void DataDeNascimentoFlatTextBox_Valited(object sender, EventArgs e)
        {
            try
            {
                if(!DateTime.TryParseExact(flatTxtDn.Text, "dd/MM/yyyy", 
                                        CultureInfo.InvariantCulture, 
                                        DateTimeStyles.None, 
                                        out DateTime date))
                {
                    NotificacaoPopUp.MostrarNotificacao("Formato da data escolhida é invalida", NotificacaoPopUp.AlertType.Warning);
                    flatTxtDn.Text = string.Empty;
                }
                pessoa.DataDeNascimento = date;
            }
            catch(ArgumentException ex)
            {
                NotificacaoPopUp.MostrarNotificacao(ex.Message, NotificacaoPopUp.AlertType.Warning);
                flatTxtDn.Text = string.Empty;
            }            
        }

        private void Filiacao2FlatTextBox_Valited(object sender, EventArgs e)
        {
            pessoa.Filiacao2 = flatTxtFiliacao2.Text;
        }

        private void CpfFlatTextBox_Validated(object sender, EventArgs e)
        {
            try
            {
                pessoa.NumeroCpf = flatTxtCpf.ToUlongParse();
            }
            catch (ArgumentException ex)
            {
                NotificacaoPopUp.MostrarNotificacao(ex.Message, NotificacaoPopUp.AlertType.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RgFlatTextBox_Valited(object sender, EventArgs e)
        {
            pessoa.NumeroRg = flatTxtRg.Text;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var returned = MessageBox.Show("Deseja realmente excluir este cadastro?\n" +
                "\nApós confirmar a exclusão, não será possivel reverter!",
                "Confirmar ação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (returned == DialogResult.OK)
            {
                pessoa.ObjectState = EntityObjectState.Deleted;

                try
                {
                    pessoa.Excluir();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }      
        }
    }
}
