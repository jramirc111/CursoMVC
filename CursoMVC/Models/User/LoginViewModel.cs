using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC.Models.User
{
    public class LoginViewModel
    {
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "La Cedula solo admite numeros")]
        [Display(Name = "Cedula")]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
    }
}