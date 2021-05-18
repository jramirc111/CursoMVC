using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC.Models.User
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="El Campo Nombre es Obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage ="El Nombre solo debe contener LETRAS")]
        public string Nombre { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El Apellido solo debe contener LETRAS")]
        public string Apellido { get; set; }

        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "La Cedula solo admite numeros")]
        public string Cedula { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Correo Invalido")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Contraseña")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage ="* Minimo 5 Caracteres")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirmar Contraseña")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Las contraseñas Ingresadas NO coinciden")]
        public string PasswordConfirm { get; set; }
    }
}