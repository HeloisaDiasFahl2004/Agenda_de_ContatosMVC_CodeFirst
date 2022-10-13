using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_ContatosMVC_CodeFirst.Models
{
    internal class Person
    {
        [Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        {
            return 
                $"E-mail:{Mail}";
        }
    }
}
