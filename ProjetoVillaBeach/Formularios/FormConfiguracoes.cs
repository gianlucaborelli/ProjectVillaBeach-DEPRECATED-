using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoVillaBeach.Classes;

namespace ProjetoVillaBeach.Formularios
{
    public partial class FormConfiguracoes : Form
    {
        public FormConfiguracoes()
        {
            InitializeComponent();            
        }

        private void CarregaGrid()
        {
            dgvModalidades.DataSource = null;

            dgvModalidades.Columns.Clear();
            dgvModalidades.Rows.Clear();

            dgvModalidades.DataSource = Modalidade.SelecionaTodos();

            dgvModalidades.Columns["IdModalidade"].HeaderText = "Cod.";
            dgvModalidades.Columns["IdModalidade"].Width = 60;

            dgvModalidades.Columns["DataInicial"].HeaderText = "Dt. Inicial";
            dgvModalidades.Columns["DataInicial"].Width = 120;

            dgvModalidades.Columns["DataFinal"].HeaderText = "Dt. Final";
            dgvModalidades.Columns["DataFinal"].Width = 120;

            DataGridViewButtonColumn buttonSalvar = new();
            buttonSalvar.HeaderText = "Salvar";
            buttonSalvar.Name = "btnSalvar";
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseColumnTextForButtonValue = true;
            buttonSalvar.Width = 100;
            dgvModalidades.Columns.Add(buttonSalvar);

            DataGridViewButtonColumn buttonEditar = new();
            buttonEditar.HeaderText = "Editar";
            buttonEditar.Name = "btnEditar";
            buttonEditar.Text = "Editar";
            buttonEditar.UseColumnTextForButtonValue = true;

            dgvModalidades.Columns.Add(buttonEditar);

            DataGridViewButtonColumn buttonExcluir = new();
            buttonExcluir.HeaderText = "Excluir";
            buttonExcluir.Name = "btnExcluir";
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseColumnTextForButtonValue = true;
            buttonExcluir.Width = 100;
            dgvModalidades.Columns.Add(buttonExcluir);

            dgvModalidades.Columns["btnSalvar"].Width = 80;
            dgvModalidades.Columns["btnEditar"].Width = 80;
            dgvModalidades.Columns["btnExcluir"].Width = 80;

            dgvModalidades.ReadOnly = true;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            if (e.ColumnIndex == dgvModalidades.Columns["btnExcluir"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Deseja realmente remover este item?", "Deseja Realmente Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Modalidade? mod = dgvModalidades.Rows[e.RowIndex].DataBoundItem as Modalidade;
                    mod.Excluir();
                    CarregaGrid();
                }
            }
            else if (e.ColumnIndex == dgvModalidades.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {
                this.dgvModalidades.Rows[e.RowIndex].Cells["Nome"].ReadOnly = true;

                /*dgvModalidades.Rows[e.RowIndex].ReadOnly = false;
                dgvModalidades.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;*/
            }
            else if (e.ColumnIndex == dgvModalidades.Columns["btnSalvar"].Index && e.RowIndex >= 0)
            {

            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            new Modalidade() { Nome = txtNome.Text,
                                Observacao = txtObs.Text,
                                DataInicial = dateInicial.SelectionRange.Start,
                                DataFinal = dateFinal.SelectionRange.Start
            }.Salvar();
            CarregaGrid();
        }
    }
}
