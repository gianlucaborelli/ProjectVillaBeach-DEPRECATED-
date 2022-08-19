using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProjetoVillaBeach.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Classes
{
    public class Course : Product
    {
        public virtual List<Matricula> Matriculas { get; set; }

        public void Salvar()
        {
            if (DataInicio == DateTime.Parse("01/01/0001"))
                DataInicio = DateTime.Now;

            try
            {
                using (var contexto = new Contexto())
                {
                    contexto.Courses.Add(this);
                    contexto.SaveChanges();
                    NotificacaoPopUp.MostrarNotificacao("Salvo com sucesso", NotificacaoPopUp.AlertType.Success);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        public static ICollection<Course> SelecionaTodos()
        {
            var contexto = new Contexto();
            return contexto.Courses.ToList();
        }

        public static ICollection<Course> Pesquisar(string? nome, out string msg)
        {
            var contexto = new Contexto();
            msg = "";
            IQueryable<Course> query = contexto.Courses;
            query = query.Where(x => x.Name == nome);

            if (query.ToList().Count >= 1)
                return query.ToList();

            if (!string.IsNullOrEmpty(nome))
                msg = "Não foram encontradas modalidades com o parâmetro informado";

            return contexto.Courses.ToList();

        }

        public void Excluir()
        {
            var contexto = new Contexto();
            contexto.Remove(this);
            contexto.SaveChanges();
        }
    }
}
