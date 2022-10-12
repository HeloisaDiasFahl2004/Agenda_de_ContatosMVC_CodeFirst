using Agenda_de_ContatosMVC_CodeFirst.Models;
using Agenda_de_ContatosMVC_CodeFirst.Repository;
using Agenda_de_ContatosMVC_CodeFirst.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_ContatosMVC_CodeFirst.Controllers
{
    internal class PersonController:IPerson
    {
        public void Insert() => new PersonService().Insert();
        public void Update() => new PersonService().Update();
        public void Delet() => new PersonService().Delet();
        public void SelectAll() => new PersonService().SelectAll();
    }
}
