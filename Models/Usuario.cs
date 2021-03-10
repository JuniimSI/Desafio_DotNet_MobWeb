using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_dotNet_Mobweb.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Column(TypeName = "nvarchar(50)")]
        public string Nome { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Apelido { get; set; }
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Column(TypeName = "nvarchar(20)")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Column(TypeName = "nvarchar(50)")]
        public string Telefone { get; set; }
    }
}
