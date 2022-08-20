using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoVillaBeach.Entities;
using ProjetoVillaBeach;
using ProjetoVillaBeach.Controles;

namespace ProjetoVillaBeach.Formularios.Pesquisas
{
    public partial class FormPesquisaDePessoas : Form
    {   
        public FormPesquisaDePessoas()
        {
            InitializeComponent();
        }

        private void btnCadastrarNovo_Click(object sender, EventArgs e)
        {
            Cadastros.FormCadastroDePessoas frm = new();

            frm.TopLevel = false;
            Parent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();
        }
        private void CarregaGrid()
        {
            dataGridView1.DataSource = null;

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.DataSource = Pessoa.Pesquisar(flatTxtNome.Text, flatTxtCpf.ToUlongParse(), flatTxtRg.Text, out string msg);

            if (!string.IsNullOrEmpty(msg))
                NotificacaoPopUp.MostrarNotificacao(msg, NotificacaoPopUp.AlertType.Info);

            /*dataGridView1.Columns["ObjectState"].Visible = false;

            dataGridView1.Columns["IdModalidade"].DisplayIndex = 0;
            dataGridView1.Columns["Nome"].DisplayIndex = 1;
            dataGridView1.Columns["Observacao"].DisplayIndex = 2;
            dataGridView1.Columns["DataInicial"].DisplayIndex = 3;
            dataGridView1.Columns["DataFinal"].DisplayIndex = 4;

            dataGridView1.Columns["IdModalidade"].HeaderText = "Cod.";
            dataGridView1.Columns["IdModalidade"].Width = 60;

            dataGridView1.Columns["Nome"].HeaderText = "Nome.";

            dataGridView1.Columns["Observacao"].HeaderText = "Obs.";

            dataGridView1.Columns["DataInicial"].HeaderText = "Dt. Inicial";
            dataGridView1.Columns["DataInicial"].Width = 120;

            dataGridView1.Columns["DataFinal"].HeaderText = "Dt. Final";
            dataGridView1.Columns["DataFinal"].Width = 120;*/
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void AbrirCadastro()
        {            
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Pessoa? pessoa;
                pessoa = row.DataBoundItem as Pessoa;
                
                if (pessoa != null)
                {
                    Cadastros.FormCadastroDePessoas frm = new(pessoa);

                    frm.TopLevel = false;
                    Parent.Controls.Add(frm);
                    frm.Dock = DockStyle.Fill;
                    frm.BringToFront();
                    frm.Show();
                }
            }            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AbrirCadastro();
        }

        private void btnAbrirCadastro_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
        }

        private void BtnExcluirCadastro_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Pessoa? pessoa;
                pessoa = row.DataBoundItem as Pessoa;

                if (pessoa != null)
                {
                   var returned = MessageBox.Show("Deseja realmente excluir esse cadastro?\n" +
                        "\nAo prosseguir não será possivel reverter.", 
                        "Confirmar ação", 
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (returned == DialogResult.OK)
                        pessoa.Excluir();

                    CarregaGrid();
                }
            }
        }
    }
}
