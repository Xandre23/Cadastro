using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Funcionario
    {
        
        public int ID { get; set; } 
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Matricula { get; set; }
        [Required]
        public int Posicao { get; set; }
    }
}
