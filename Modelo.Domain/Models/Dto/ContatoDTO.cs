using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Domain.Models.Dto
{
    public class ContatoDTO
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; private set; }
        [Required]
        public string Email { get; private set; }
    }
}
