using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_ContatosMVC_CodeFirst.Models
{
    internal class Phone
    {
        [Key()]
        public int Id { get; set; }
        public string Mobile { get; set; }
        public string Landline { get; set; }
        [ForeignKey("Person")]
        public int IdPerson { get; set; }
        public virtual Person Person { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}  IdContato: {IdPerson} " +
                $"\nCelular: {Mobile}  Fixo: {Landline} ";

        }
    }
}
