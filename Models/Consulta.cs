using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIOData.Models
{
    public class Consulta
    {
        //Dados do objeto a ser consultado (teste)
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Descricao { get; set; }
    }
}
