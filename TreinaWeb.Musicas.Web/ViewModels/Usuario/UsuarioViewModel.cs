using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TreinaWeb.Musicas.Web.Annotations;

namespace TreinaWeb.Musicas.Web.ViewModels.Usuario
{
    public class UsuarioViewModel
    {
        [Display(Name = "Usuário")]
        [Required(ErrorMessage ="O email é obrigatório")]
        [MaxLength(30, ErrorMessage ="O email não pode ter mais que {1} caracteres")]
        [DataType(DataType.EmailAddress, ErrorMessage = "O email informado não é válido")]
        //[DataType(DataType.EmailAddress, ErrorMessage = "O endereço de email informado não é válido")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage ="A senha é obrigatória")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}