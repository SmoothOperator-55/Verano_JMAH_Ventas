﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }
      
        [Display (Name= "Pais")]
        [MaxLength(100, ErrorMessage ="El campo debe de tener un maximo de 1 caracteres")]
        [Required(ErrorMessage ="El campo es obligatorio")]

        public string Name { get; set; } = null;


      
    }
}
