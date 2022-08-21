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
using ProjetoVillaBeach.Entities;
using ProjetoVillaBeach.Controles;
using ProjetoVillaBeach.Entities.Base;
using ProjetoVillaBeach.Entities.Controllers;

namespace ProjetoVillaBeach.Formularios.Cadastros
{
    public partial class FormCadastroDePessoas : Form
    {
        private PeopleController peopleController;
        private People pessoa = new();

        public FormCadastroDePessoas()
        {
            InitializeComponent();
            peopleController = new();
        }

        public FormCadastroDePessoas(People id)
        {
            InitializeComponent();
            peopleController = new(id);
        }

        private void CarregaPessoa()
        {
            flatTxtNome.Text = peopleController.SelectedPeople.Nome;
            flatTxtCpf.Text = peopleController.SelectedPeople.NumeroCpf.ToString();
            flatTxtDn.Text = peopleController.SelectedPeople.DataDeNascimento?.ToString("dd/MM/yyyy");
            flatTxtRg.Text = peopleController.SelectedPeople.NumeroRg?.ToString();
            flatTxtFiliacao1.Text = peopleController.SelectedPeople.Filiacao1;
            flatTxtFiliacao2.Text = peopleController.SelectedPeople.Filiacao2;


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

            endereco.IdPessoa = pessoa.Id;

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
            try
            {
                if (peopleController.Salvar())
                    NotificacaoPopUp.MostrarNotificacao("Salvo com Sucesso",
                                                        NotificacaoPopUp.AlertType.Success);
            }
            catch (Exception ex)
            {
                NotificacaoPopUp.MostrarNotificacao("Erro ao Salvar \n" + ex.Message,
                                                    NotificacaoPopUp.AlertType.Error);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (peopleController.SelectedPeople.ObjectState != EntityObjectState.Added)
            {
                if (MessageBox.Show("Deseja realmente excluir este cadastro?\n\n" +
                                    "Após confirmar a exclusão, não será possivel reverter!",
                                    "Confirmar ação",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning)
                                    == DialogResult.OK)
                {
                    try
                    {
                        if (peopleController.Excluir())
                        {
                            NotificacaoPopUp.MostrarNotificacao("Excluido com Sucesso",
                                                   NotificacaoPopUp.AlertType.Info);
                            this.Dispose();
                        }                            
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Form_OnLoad(object sender, EventArgs e)
        {
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
            try
            {
                peopleController.SelectedPeople.Nome = flatTxtNome.ReturnValue<string>();
            }
            catch (Exception ex)
            {
                NotificacaoPopUp.MostrarNotificacao(ex.Message, NotificacaoPopUp.AlertType.Warning);
            }            
        }

        private void FlatTxtBoxCPF_Leave(object sender, EventArgs e)
        {
            try
            {
                peopleController.SelectedPeople.NumeroCpf = flatTxtCpf.ReturnValue<ulong>();
            }
            catch (Exception ex)
            {
                NotificacaoPopUp.MostrarNotificacao(ex.Message, NotificacaoPopUp.AlertType.Warning);
            }
        }

        private void FlatTxtBoxFiliacao1_Leave(object sender, EventArgs e)
        {
            try
            {
                peopleController.SelectedPeople.Filiacao1 = flatTxtFiliacao1.ReturnValue<string>();
            }
            catch (Exception ex)
            {
                NotificacaoPopUp.MostrarNotificacao(ex.Message, NotificacaoPopUp.AlertType.Warning);
            }
        }

        private void FlatTxtBoxFiliacao2_Leave(object sender, EventArgs e)
        {
            try
            {
                peopleController.SelectedPeople.Filiacao2 = flatTxtFiliacao2.ReturnValue<string>();
            }
            catch (Exception ex)
            {
                NotificacaoPopUp.MostrarNotificacao(ex.Message, NotificacaoPopUp.AlertType.Warning);
            }
        }

        private void FlatTxtBoxRG_Leave(object sender, EventArgs e)
        {
            try
            {
                peopleController.SelectedPeople.NumeroRg = flatTxtRg.ReturnValue<string>();
            }
            catch (Exception ex)
            {
                NotificacaoPopUp.MostrarNotificacao(ex.Message, NotificacaoPopUp.AlertType.Warning);
            }
        }

        private void FlatTxtBoxDN_Leave(object sender, EventArgs e)
        {
            try
            {
                peopleController.SelectedPeople.DataDeNascimento = flatTxtDn.ReturnValue<DateTime?>();
            }
            catch (Exception ex)
            {
                NotificacaoPopUp.MostrarNotificacao(ex.Message, NotificacaoPopUp.AlertType.Warning);
            }
        }

        private void ImageCapturePeople_ImageChanged(object sender, EventArgs args)
        {
            peopleController.SelectedPeople.Photo = ImageCapturePeople.Captured;
        }
    }
}
