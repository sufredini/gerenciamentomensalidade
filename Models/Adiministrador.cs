﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoMensalidade.Models
{
    public class Adiministrador
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("Cpf")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; } = string.Empty;
    }
}
