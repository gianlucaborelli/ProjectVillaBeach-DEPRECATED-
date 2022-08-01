using ProjetoVillaBeach.Classes;
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

        public FormCadDeCursos()
        {
            InitializeComponent();
            mod.ObjectState = EntityObjectState.Added;
        }

        public FormCadDeCursos(Modalidade mod)
        {
            InitializeComponent();
             this.mod = mod;            
            AtivaControlesDeModalidade(false);
        }

        //Formulário
        private void Form_OnLoad(object sender, EventArgs e)
        {
            flatTxtBoxNomeModalidade.DataBindings.Add("Text", mod, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
            flatTxtBoxInicioModalidade.DataBindings.Add("Text", mod, "DataInicial", true, DataSourceUpdateMode.OnPropertyChanged);
            flatTxtBoxFimModalidade.DataBindings.Add("Text", mod, "DataFinal", true, DataSourceUpdateMode.OnPropertyChanged);
            txtObsModalidade.DataBindings.Add("Text", mod, "Observacao", true, DataSourceUpdateMode.OnPropertyChanged);
                        
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
            bool canClose = !(mod.ObjectState == EntityObjectState.Added
                           || mod.ObjectState == EntityObjectState.Modified);

            foreach (ValoresModalidade valor in mod.ValoresModalidades)
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

            dgvValoresModalidades.DataSource = mod.ValoresModalidades;

            dgvValoresModalidades.Columns["ObjectState"].Visible = false;
            dgvValoresModalidades.Columns["IdValoresModalidades"].Visible = false;
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
            mod.Salvar();
            PopupaGridValoresModalidade();
            AtivaControlesDeModalidade(false);
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
                    mod.ObjectState = EntityObjectState.Deleted;

                    try
                    {
                        mod.Excluir();
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
            ValoresModalidade? valor = new();

            if (this.dgvValoresModalidades.SelectedRows.Count == 0)            
            {
                valor.ObjectState = EntityObjectState.Added;
                mod.ValoresModalidades.Add(valor);

                if (!string.IsNullOrEmpty(flatTxtBoxValorModalidade.Text))
                    valor.Valor = double.Parse(flatTxtBoxValorModalidade.Text);

                if (DateTime.TryParseExact(flatTxtBoxInicioValorModalidade.Text, "dd/MM/yyyy",
                                            CultureInfo.InvariantCulture,
                                            DateTimeStyles.None,
                                            out DateTime inicio))
                {
                    valor.DataInicio = inicio;
                }

                if (DateTime.TryParseExact(flatTxtBoxFimValorModalidade.Text, "dd/MM/yyyy",
                                            CultureInfo.InvariantCulture,
                                            DateTimeStyles.None,
                                            out DateTime fim))
                {
                    valor.DataFim = fim;
                }
            }            

            LimparControlesValoresModalidades();
            PopupaGridValoresModalidade();
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
    }
}
