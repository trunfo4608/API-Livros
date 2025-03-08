﻿using System.ComponentModel.DataAnnotations;

namespace LivrosAPP.Model
{
    public class Autor
    {
        
        public int Id { get; set; }

        public string Nome { get; set; }

        public List<Livro> Livros { get; set; }
    }
}
