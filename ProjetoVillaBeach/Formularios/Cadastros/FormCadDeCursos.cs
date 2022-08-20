using ProjetoVillaBeach.Classes.Controllers;
using ProjetoVillaBeach.Controles;
using ProjetoVillaBeach.Entities.Base;
using ProjetoVillaBeach.Entities;
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

namespace ProjetoVillaBeach.Formularios.Cadastros
{
    public partial class FormCadDeCursos : Form
    {
        private Course mod = new();
        private Price? valorModalidadeSelecionada = new();

        private ModalidadeController modController;

        public FormCadDeCursos()
        {
            InitializeComponent();
            modController = new();
        }

        public FormCadDeCursos(Course modalidade)
        {
            InitializeComponent();
            AtivaControlesDeModalidade(false);
            modController = new(modalidade);
        }

        //Formulário
        private void Form_OnLoad(object sender, EventArgs e)
        {
            flatTxtBoxNomeModalidade.Text = modController.ModalidadeSelecionada.Name;
            flatTxtBoxInicioModalidade.Text = modController.ModalidadeSelecionada.DataInicio.ToString("dd/MM/yyyy");
            flatTxtBoxFimModalidade.Text = modController.ModalidadeSelecionada.DataFim.ToString();
            txtObsModalidade.Text = modController.ModalidadeSelecionada.Description;

            PopupaGridValoresModalidade();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            this.dgvValoresModalidades.ClearSelection();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            bool canClose = !(modController.ModalidadeSelecionada.ObjectState == EntityObjectState.Added
                           || modController.ModalidadeSelecionada.ObjectState == EntityObjectState.Modified);

            foreach (Price valor in modController.ModalidadeSelecionada.Prices)
            {
                if (valor.ObjectState == EntityObjectState.Added
                 || valor.ObjectState == EntityObjectState.Modified)
                {
                    canClose = false;
                    break;
                }
            }

            if (!canClose)
            {
                if (DialogResult.No == MessageBox.Show("Deseja realmente sair sem salvar as alterações deste cadastro?",
                                                       "Deseja realmente sair",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning))
                {
                    e.Cancel = true;
                    return;
                }
            }

            this.Dispose();
        }

        //dgvValoresModalidades
        private void PopupaGridValoresModalidade()
        {
            dgvValoresModalidades.DataSource = null;

            dgvValoresModalidades.Columns.Clear();
            dgvValoresModalidades.Rows.Clear();

            dgvValoresModalidades.DataSource = modController.ModalidadeSelecionada.Prices;

            dgvValoresModalidades.Columns["ObjectState"].Visible = false;
            dgvValoresModalidades.Columns["Id"].Visible = false;

            dgvValoresModalidades.Columns["Value"].DisplayIndex = 0;
            dgvValoresModalidades.Columns["DataInicio"].DisplayIndex = 1;
            dgvValoresModalidades.Columns["DataFim"].DisplayIndex = 2;

            dgvValoresModalidades.Columns["Value"].HeaderText = "Valor.";
            dgvValoresModalidades.Columns["DataInicio"].HeaderText = "Dt. Inicial";
            dgvValoresModalidades.Columns["DataFim"].HeaderText = "Dt. Final";

            this.dgvValoresModalidades.ClearSelection();
        }

        private void DgvValoresModalidades_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var valor = dgvValoresModalidades.Rows[e.RowIndex].DataBoundItem as Price;

            switch (valor.ObjectState)
            {
                case EntityObjectState.Added:
                    dgvValoresModalidades.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                    break;
                case EntityObjectState.Deleted:
                    dgvValoresModalidades.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                    break;
                case EntityObjectState.Modified:
                    dgvValoresModalidades.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    break;
            }
        }

        private void dgvValoresModalidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvValoresModalidades.SelectedRows.Count > 0)
            {
                CarregaValoresModalidade(dgvValoresModalidades.CurrentRow.DataBoundItem as Price);
            }
        }

        private void CarregaValoresModalidade(Price? valor)
        {
            flatTxtBoxValorModalidade.DataBindings.Clear();
            flatTxtBoxInicioValorModalidade.DataBindings.Clear();
            flatTxtBoxFimValorModalidade.DataBindings.Clear();

            valorModalidadeSelecionada = valor;

            flatTxtBoxValorModalidade.DataBindings.Add("Text", valor, "Valor", true, DataSourceUpdateMode.OnPropertyChanged);
            flatTxtBoxInicioValorModalidade.DataBindings.Add("Text", valor, "DataInicio", true, DataSourceUpdateMode.OnPropertyChanged);
            flatTxtBoxFimValorModalidade.DataBindings.Add("Text", valor, "DataFim", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AtivaControlesDeModalidade(bool status)
        {
            flatTxtBoxFimModalidade.Enabled = status;
            flatTxtBoxInicioModalidade.Enabled = status;
            txtObsModalidade.Enabled = status;
            flatTxtBoxNomeModalidade.Enabled = status;

            if (mod.DataFim == null)
            {
                flatTxtBoxFimModalidade.Enabled = true;
            }
        }

        private void LimparControlesValoresModalidades()
        {
            valorModalidadeSelecionada = null;

            flatTxtBoxValorModalidade.DataBindings.Clear();
            flatTxtBoxInicioValorModalidade.DataBindings.Clear();
            flatTxtBoxFimValorModalidade.DataBindings.Clear();

            flatTxtBoxValorModalidade.Clear();
            flatTxtBoxInicioValorModalidade.Clear();
            flatTxtBoxFimValorModalidade.Clear();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (modController.Salvar())
                    NotificacaoPopUp.MostrarNotificacao("Salvo com sucesso", NotificacaoPopUp.AlertType.Success);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                PopupaGridValoresModalidade();
                AtivaControlesDeModalidade(false);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (mod.ObjectState != EntityObjectState.Added)
            {
                if (MessageBox.Show("Deseja realmente excluir esta Modalidade?\n" +
                    "\nApós confirmar a exclusão, não será possivel reverter!",
                    "Confirmar ação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    == DialogResult.OK)
                {
                    try
                    {
                        if (modController.Excluir())
                            this.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                this.Dispose();
            }
        }

        private void BtnAddModalidade_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flatTxtBoxValorModalidade.Text))
                return;

            try
            {
                if (this.dgvValoresModalidades.SelectedRows.Count == 0)
                {
                    Price? valor = new()
                    {
                        ObjectState = EntityObjectState.Added,
                        Value = decimal.Parse(flatTxtBoxValorModalidade.Text),
                        DataInicio = flatTxtBoxInicioValorModalidade.ReturnValue<DateTime>()

                    };
                    valor.DataFim = flatTxtBoxFimValorModalidade.ReturnValue<DateTime?>();

                    modController.AddValorModalidade(valor);
                }
            }
            catch (Exception ex)
            {
                NotificacaoPopUp.MostrarNotificacao(ex.Message, NotificacaoPopUp.AlertType.Error);
            }
            finally
            {
                LimparControlesValoresModalidades();
                PopupaGridValoresModalidade();
            }
        }

        private void BtnCancelarAlteracaoValor_Click(object sender, EventArgs e)
        {
            LimparControlesValoresModalidades();
            this.dgvValoresModalidades.ClearSelection();
        }

        private void btnExcluirValor_Click(object sender, EventArgs e)
        {
            if (this.dgvValoresModalidades.SelectedRows.Count > 0)
            {
                Price? valor = dgvValoresModalidades.CurrentRow.DataBoundItem as Price;
                valor.ObjectState = EntityObjectState.Deleted;
                LimparControlesValoresModalidades();
                PopupaGridValoresModalidade();
            }
        }

        private void FlatTxtNomeModalidade_Leave(object sender, EventArgs e)
        {
            try
            {
                modController.ModalidadeSelecionada.Name = flatTxtBoxNomeModalidade.ReturnValue<string>();
            }
            catch (ArgumentException ex)
            {
                NotificacaoPopUp.MostrarNotificacao(ex.Message, NotificacaoPopUp.AlertType.Error);
            }
        }

        private void FlatTxtInicioModalidade_Leave(object sender, EventArgs e)
        {
            try
            {
                modController.ModalidadeSelecionada.DataInicio = flatTxtBoxInicioModalidade.ReturnValue<DateTime>();
            }
            catch (ArgumentException ex)
            {
                NotificacaoPopUp.MostrarNotificacao(ex.Message, NotificacaoPopUp.AlertType.Error);
            }
        }
    }
}
