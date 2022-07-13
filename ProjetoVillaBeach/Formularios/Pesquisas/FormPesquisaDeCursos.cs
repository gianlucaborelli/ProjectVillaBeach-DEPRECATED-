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
    }
}
