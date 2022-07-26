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

namespace ProjetoVillaBeach.Formularios.Pesquisas
{
    public partial class FormPesquisaDeCursos : Form
    {   
        public FormPesquisaDeCursos()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            dgvModalidades.DataSource = null;

            dgvModalidades.Columns.Clear();
            dgvModalidades.Rows.Clear();
            
            dgvModalidades.DataSource = Modalidade.Pesquisar(flatTxtBoxNomeModalidade.Text, out string msg);

            if(!string.IsNullOrEmpty(msg))
                NotificacaoPopUp.MostrarNotificacao(msg, NotificacaoPopUp.AlertType.Info);

            dgvModalidades.Columns["ObjectState"].Visible = false;

            dgvModalidades.Columns["IdModalidade"].DisplayIndex = 0;
            dgvModalidades.Columns["Nome"].DisplayIndex = 1;
            dgvModalidades.Columns["Observacao"].DisplayIndex = 2;
            dgvModalidades.Columns["DataInicial"].DisplayIndex = 3;
            dgvModalidades.Columns["DataFinal"].DisplayIndex = 4;

            dgvModalidades.Columns["IdModalidade"].HeaderText = "Cod.";
            dgvModalidades.Columns["IdModalidade"].Width = 60;
            
            dgvModalidades.Columns["Nome"].HeaderText = "Nome.";
            
            dgvModalidades.Columns["Observacao"].HeaderText = "Obs.";

            dgvModalidades.Columns["DataInicial"].HeaderText = "Dt. Inicial";
            dgvModalidades.Columns["DataInicial"].Width = 120;            

            dgvModalidades.Columns["DataFinal"].HeaderText = "Dt. Final";
            dgvModalidades.Columns["DataFinal"].Width = 120;            
        }

        private void AbrirCadastro()
        {
            foreach (DataGridViewRow row in this.dgvModalidades.SelectedRows)
            {
                Modalidade? mod;
                mod = row.DataBoundItem as Modalidade;

                if (mod != null)
                {
                    Cadastros.FormCadDeCursos frm = new(mod);

                    frm.TopLevel = false;
                    Parent.Controls.Add(frm);
                    frm.Dock = DockStyle.Fill;
                    frm.BringToFront();
                    frm.Show();
                }
            }
        }

        private void BtnCadastrarCurso_Click(object sender, EventArgs e)
        {
            Cadastros.FormCadDeCursos frm = new();

            frm.TopLevel = false;
            Parent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();
        }
                
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {            
            CarregaGrid();
        }        

        private void BtnAbrirCadastro_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
        }

        private void DgvModalidades_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AbrirCadastro();
        }

        private void BtnExcluirCadastro_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvModalidades.SelectedRows)
            {
                Modalidade? mod;
                mod = row.DataBoundItem as Modalidade;

                if (mod != null)
                {
                    var returned = MessageBox.Show("Deseja realmente excluir esse cadastro?\n" +
                        "\nAo prosseguir não será possivel reverter.",
                        "Confirmar ação",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (returned == DialogResult.OK)
                        mod.Excluir();

                    dgvModalidades.ClearSelection();
                    CarregaGrid();
                }
            }
        }
    }
}
