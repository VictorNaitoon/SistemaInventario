﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nombre es requerido")]
        [MaxLength(60, ErrorMessage ="Nombre debe ser de máximo de 60 carácteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Descripcion es requerida")]
        [MaxLength(150, ErrorMessage ="Descripción debe ser de máximo de 150 carácteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="Estado es requerido")]
        public bool Estado { get; set; }
    }
}
