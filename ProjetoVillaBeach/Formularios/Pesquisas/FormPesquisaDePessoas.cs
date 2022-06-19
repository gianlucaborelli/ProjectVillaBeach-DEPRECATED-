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
        Pessoa pessoa = new();

        public FormPesquisaDePessoas()
        {
            InitializeComponent();
        }

        private void btnCadastrarNovo_Click(object sender, EventArgs e)
        {
            Cadastros.FormCadastroRapidoDePessoa frm = new();

            frm.FormClosing += FormCadastroRapido_Closing;

            frm.TopLevel = false;
            Parent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();            
        }

        private void FormCadastroRapido_Closing(object? sender, EventArgs e)
        {
            Cadastros.FormCadastroRapidoDePessoa frm = (Cadastros.FormCadastroRapidoDePessoa)sender;

            if (frm.Continua)
            {
                Cadastros.FormCadastroDePessoas frm2 = new(frm.Pessoa);

                frm.Dispose();

                frm2.TopLevel = false;
                Parent.Controls.Add(frm2);
                frm2.Dock = DockStyle.Fill;
                frm2.BringToFront();
                frm2.Show();
            }
        }

        private void textCpf1_Validated(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas = Pessoa.Pesquisar(textNome1.Text, textCpf1.NumeroCpf);

            if (pessoas.Count > 0)
            {
                dataGridView1.DataSource = pessoas;
            }
            else
            {
                dataGridView1.DataSource = Pessoa.SelecionaTodos();
            }
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Pessoa? pessoa = new();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                pessoa = row.DataBoundItem as Pessoa;                
            }

            Cadastros.FormCadastroDePessoas frm = new(pessoa);

            frm.TopLevel = false;
            Parent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();
        }
    }
}
