using PortalEducacesso.dao;
using PortalEducacesso.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortalEducacesso.asp
{
    public partial class cadastroCurso : System.Web.UI.Page
    {
        Curso curso = new Curso();
        CursoDAO cDao = new CursoDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private Curso getForm()
        {
            curso.Nome = txtNome.Text;
            curso.Descricao = txtDescricao.Text;
            curso.Categoria = selectCateg.Text;
            return curso;
        }
        private void setForm(Curso curso)
        {
            txtNome.Text = curso.Nome;
            txtDescricao.Text = curso.Descricao;
            selectCateg.Text = curso.Categoria;
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            curso = getForm();
            cDao.cadastrar(curso);
        }
    }
}