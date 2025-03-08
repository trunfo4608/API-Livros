﻿using System.ComponentModel.DataAnnotations;

namespace LivrosAPP.Service.Dto
{
    public class AutorPutDto
    {
        [Required(ErrorMessage ="Id Obrigatório.")]
        public int Id { get; set; }


        [Required(ErrorMessage = "Nome obrigatório.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Nome entre {2} e {1} caracteres.")]
        public string Nome { get; set; }


    }
}
