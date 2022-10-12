using Agenda_de_ContatosMVC_CodeFirst.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_ContatosMVC_CodeFirst.Repository
{
    internal interface IPerson
    {
        void Insert();
        void Update();
        void Delet();
        void SelectAll();
    }
}
