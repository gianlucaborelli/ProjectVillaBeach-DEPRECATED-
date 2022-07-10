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
using ProjetoVillaBeach;

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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas = Pessoa.Pesquisar(flatTxtNome.Text, flatTxtCpf.ToUlongParse(), flatTxtRg.Text);

            if (pessoas.Count > 0)
            {
                dataGridView1.DataSource = pessoas;
            }
            else
            {
                dataGridView1.DataSource = Pessoa.SelecionaTodos();
            }
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
                }
            }
        }
    }
}
