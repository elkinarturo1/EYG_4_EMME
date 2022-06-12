using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMME_Acabados_.Data
{
    public class Contacto
    {
        [Required(ErrorMessage = "El compo Email es obligatorio")]
        public string Primero_Nombre { get; set; }

        [Required(ErrorMessage = "El compo Email es obligatorio")]
        public string Segundo_Nombre { get; set; }

        [Required(ErrorMessage = "El compo Email es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de Email incorrecto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El compo Email es obligatorio")]
        public string Asunto { get; set; }

        [Required(ErrorMessage = "El compo Email es obligatorio")]
        public string Mensaje { get; set; }
    }
}
