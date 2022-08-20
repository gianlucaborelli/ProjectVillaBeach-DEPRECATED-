using ProjetoVillaBeach.Entities;
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
            
            dgvModalidades.DataSource = Course.Pesquisar(flatTxtBoxNomeModalidade.Text, out string msg);

            if(!string.IsNullOrEmpty(msg))
                NotificacaoPopUp.MostrarNotificacao(msg, NotificacaoPopUp.AlertType.Info);

            dgvModalidades.Columns["ObjectState"].Visible = false;

            dgvModalidades.Columns["Id"].DisplayIndex = 0;
            dgvModalidades.Columns["Name"].DisplayIndex = 1;
            dgvModalidades.Columns["Description"].DisplayIndex = 2;
            dgvModalidades.Columns["DataInicio"].DisplayIndex = 3;
            dgvModalidades.Columns["DataFim"].DisplayIndex = 4;

            dgvModalidades.Columns["Id"].HeaderText = "Cod.";
            dgvModalidades.Columns["Id"].Width = 60;
            
            dgvModalidades.Columns["Name"].HeaderText = "Nome.";
            
            dgvModalidades.Columns["Description"].HeaderText = "Obs.";

            dgvModalidades.Columns["DataInicio"].HeaderText = "Dt. Inicial";
            dgvModalidades.Columns["DataInicio"].Width = 120;            

            dgvModalidades.Columns["DataFim"].HeaderText = "Dt. Final";
            dgvModalidades.Columns["DataFim"].Width = 120;            
        }

        private void AbrirCadastro()
        {
            foreach (DataGridViewRow row in this.dgvModalidades.SelectedRows)
            {
                Course? mod;
                mod = row.DataBoundItem as Course;

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
                Course? mod;
                mod = row.DataBoundItem as Course;

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
