using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoVillaBeach.Entities;
using ProjetoVillaBeach.Formularios;
using ProjetoVillaBeach.Formularios.Pesquisas;
using ProjetoVillaBeach.Formularios.Cadastros;
using System.Configuration;

namespace ProjetoVillaBeach
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            Splasher.Show();

            Splasher.Status = "Loading Files...";

            if (!Directory.Exists(ConfigurationManager.AppSettings["PathPhoto"]))
                Directory.CreateDirectory(ConfigurationManager.AppSettings["PathPhoto"]);

            System.Threading.Thread.Sleep(2000);

            Splasher.Status = "Loading Plug/Ins...";
            System.Threading.Thread.Sleep(2000);            

            Splasher.Status = "Connecting to Database...";
            using (var contexto = new Contexto())
            {   
                contexto.Database.CanConnect();
            }

            Splasher.Close();

            EscondeSubMenu();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.Activate();
        }

        private void AbrirFormulario(Form FormFilho)
        {   
            foreach(Control ctrol in this.pnlConteudo.Controls)
            {
                if (ctrol is Form)
                {
                    ctrol.Dispose();
                }
            }

            if (this.pnlConteudo.Controls.Count > 0)
                this.pnlConteudo.Controls.RemoveAt(0);

            Form ff = FormFilho;
            ff.TopLevel = false;
            ff.Dock = DockStyle.Fill;
            this.pnlConteudo.Controls.Add(ff);
            this.pnlConteudo.Tag = ff;
            ff.Show();
        }

        //Metodo para esconder sub menus
        private void EscondeSubMenu()
        {
            //Adicionar aqui todos SubMenu Criados
            SubMenuCadastro.Visible = false;
            SubMenuCadastro.Enabled= false;
            SubMenuMatricula.Enabled= false;
            SubMenuMatricula.Visible = false;
        }

        //Metodo mostra Menu
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EscondeSubMenu();
                subMenu.Visible = true;
                subMenu.Enabled = true;
            }
            else
            {
                subMenu.Visible = false;
                subMenu.Enabled = false;
            }
                
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubMenuCadastro);
        }

        private void btnCadastroDePessoas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPesquisaDePessoas());
        }

        private void BtnConfiguracao_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormConfiguracoes());

            //Conexao.EncriptaConexao();
            //Conexao.DecriptaConexao();
        }

        private void BtnMatricula_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubMenuMatricula);
        }

        private void BtnCurso_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPesquisaDeCursos());
        }
    }
}
