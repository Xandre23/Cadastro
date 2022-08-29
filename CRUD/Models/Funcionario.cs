using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Funcionario
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [DisplayName("Matricula")]
        public int Matricula { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [DisplayName("Cargo")]
        public int Posicao { get; set; }
    
        
    }

}
