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

        public FormCadDeCursos()
        {
            InitializeComponent();

            mod.ObjectState = EntityObjectState.Added;
        }

        public FormCadDeCursos(Modalidade mod)
        {
            InitializeComponent();
            this.mod = mod;
            CarragaModalidade();
        }

        private void CarragaModalidade()
        {
            flatTxtBoxNomeModalidade.Text = mod.Nome;
            flatTxtBoxInicioModalidade.Text = mod.DataInicial.ToString();
            flatTxtBoxFimModalidade.Text = mod.DataFinal.ToString();
            txtObsModalidade.Text = mod.Observacao;

            dgvValoresModalidades.DataSource = mod.ValoresModalidades;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            mod.Salvar();

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (mod.ObjectState != EntityObjectState.Added)
            {
                var returned = MessageBox.Show("Deseja realmente excluir esta Modalidade?\n" +
                                "\nApós confirmar a exclusão, não será possivel reverter!",
                                "Confirmar ação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (returned == DialogResult.OK)
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
        }

        private void txtNomeModalidade_Leave(object sender, EventArgs e)
        {
            mod.Nome = flatTxtBoxNomeModalidade.Text;
        }

        private void flatTxtInicioModalidade_Leave(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(flatTxtBoxInicioModalidade.Text, "dd/MM/yyyy",
                                        CultureInfo.InvariantCulture,
                                        DateTimeStyles.None,
                                        out DateTime inicio))
            {
                mod.DataInicial = inicio;
            }

        }

        private void FlatTxtFimModalide_Leave(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(flatTxtBoxFimModalidade.Text, "dd/MM/yyyy",
                                            CultureInfo.InvariantCulture,
                                            DateTimeStyles.None,
                                            out DateTime fim))
            {
                mod.DataFinal = fim;
            }
        }

        private void TxtObsModalidade_Leave(object sender, EventArgs e)
        {
            mod.Observacao = txtObsModalidade.Text;
        }

        private void BtnAddModalidade_Click(object sender, EventArgs e)
        {
            ValoresModalidade valor = new();

            valor.ObjectState = EntityObjectState.Added;
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
                valor.DataInicio = fim;
            }

            mod.ValoresModalidades.Add(valor);            
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
