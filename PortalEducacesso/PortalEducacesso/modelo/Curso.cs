using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalEducacesso.modelo
{
    public class Curso
    {
        // Atributos        
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private String descricao;

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        private String categoria;

        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
    }
}