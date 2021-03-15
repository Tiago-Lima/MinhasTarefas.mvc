using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasTarefas.Models
{
    public class Tarefa
    {
       
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Data { get; set; }
        public bool Status { get; set; }

       
    }
}
