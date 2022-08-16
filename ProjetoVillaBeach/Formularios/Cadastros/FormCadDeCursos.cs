using ProjetoVillaBeach.Classes;
using ProjetoVillaBeach.Classes.Controllers;
using ProjetoVillaBeach.Controles;
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
        private Modalidade mod = new();
        private ValoresModalidade? valorModalidadeSelecionada = new();

        private ModalidadeController modController;

        public FormCadDeCursos()
        {
            InitializeComponent();
            modController = new();
        }

        public FormCadDeCursos(Modalidade modalidade)
        {
            InitializeComponent();
            AtivaControlesDeModalidade(false);
            modController = new(modalidade);
        }

        //Formulário
        private void Form_OnLoad(object sender, EventArgs e)
        {
            flatTxtBoxNomeModalidade.Text = modController.ModalidadeSelecionada.Nome;
            flatTxtBoxInicioModalidade.Text = modController.ModalidadeSelecionada.DataInicial.ToString("dd/MM/yyyy");
            flatTxtBoxFimModalidade.Text = modController.ModalidadeSelecionada.DataFinal.ToString();
            txtObsModalidade.Text = modController.ModalidadeSelecionada.Observacao;

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

            foreach (ValoresModalidade valor in modController.ModalidadeSelecionada.ValoresModalidades)
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

            dgvValoresModalidades.DataSource = modController.ModalidadeSelecionada.ValoresModalidades;

            dgvValoresModalidades.Columns["ObjectState"].Visible = false;
            dgvValoresModalidades.Columns["Id"].Visible = false;
            dgvValoresModalidades.Columns["IdModalidade"].Visible = false;
            dgvValoresModalidades.Columns["Modalidade"].Visible = false;

            dgvValoresModalidades.Columns["Valor"].DisplayIndex = 0;
            dgvValoresModalidades.Columns["DataInicio"].DisplayIndex = 1;
            dgvValoresModalidades.Columns["DataFim"].DisplayIndex = 2;

            dgvValoresModalidades.Columns["Valor"].HeaderText = "Valor.";
            dgvValoresModalidades.Columns["DataInicio"].HeaderText = "Dt. Inicial";
            dgvValoresModalidades.Columns["DataFim"].HeaderText = "Dt. Final";

            this.dgvValoresModalidades.ClearSelection();
        }

        private void DgvValoresModalidades_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var valor = dgvValoresModalidades.Rows[e.RowIndex].DataBoundItem as ValoresModalidade;

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
                CarregaValoresModalidade(dgvValoresModalidades.CurrentRow.DataBoundItem as ValoresModalidade);
            }
        }

        private void CarregaValoresModalidade(ValoresModalidade? valor)
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

            if (mod.DataFinal == null)
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
                    ValoresModalidade? valor = new()
                    {
                        ObjectState = EntityObjectState.Added,
                        Valor = double.Parse(flatTxtBoxValorModalidade.Text),
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
                ValoresModalidade? valor = dgvValoresModalidades.CurrentRow.DataBoundItem as ValoresModalidade;
                valor.ObjectState = EntityObjectState.Deleted;
                LimparControlesValoresModalidades();
                PopupaGridValoresModalidade();
            }
        }

        private void FlatTxtNomeModalidade_Leave(object sender, EventArgs e)
        {
            try
            {
                modController.ModalidadeSelecionada.Nome = flatTxtBoxNomeModalidade.ReturnValue<string>();
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
                modController.ModalidadeSelecionada.DataInicial = flatTxtBoxInicioModalidade.ReturnValue<DateTime>();
            }
            catch (ArgumentException ex)
            {
                NotificacaoPopUp.MostrarNotificacao(ex.Message, NotificacaoPopUp.AlertType.Error);
            }
        }
    }
}
