using ProjetoVillaBeach.Classes;
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
            dgvModalidades.DataSource = Modalidade.SelecionaTodos();
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

        private void BtnAbrirCadastro_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
        }

        private void DgvModalidades_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AbrirCadastro();
        }
    }
}
