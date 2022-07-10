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
            List<Pessoa> pessoas = Pessoa.Pesquisar(flatTxtNome.Text, flatTxtCpf.ToUlongParse(), flatTxtRg.ToUlongParse());

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
