using Agenda_de_ContatosMVC_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_ContatosMVC_CodeFirst.Context
{
    internal class BaseContext : DbContext
    {
        public BaseContext() : base("Contatos") { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}
