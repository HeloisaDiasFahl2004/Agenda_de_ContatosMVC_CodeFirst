using Agenda_de_ContatosMVC_CodeFirst.Models;
using Agenda_de_ContatosMVC_CodeFirst.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;

namespace Agenda_de_ContatosMVC_CodeFirst.Service
{
    internal class PersonService
    {
        public void Insert()
        {
            //instancio os objetos
            Person p = new Person();
            Phone ph = new Phone();
            //populo os objetos

            using (var context = new BaseContext())
            {
                Console.Write("Nome: ");
                p.Name = Console.ReadLine().ToUpper();
                var find = context.Persons.FirstOrDefault(c => c.Name == p.Name);
                if (find != null)
                {
                    Console.WriteLine("Contato já cadastrado!");
                    return;
                }
                Console.Write("E-mail: ");
                p.Mail = Console.ReadLine();
                context.Persons.Add(p);
                Console.Write("Celular: ");
                ph.Mobile = Console.ReadLine();
                Console.Write("Telefone fixo: ");
                ph.Landline = Console.ReadLine();
                ph.IdPerson = p.Id;//devido ao relacionamento
                context.Phones.Add(ph);
                context.SaveChanges();
                Console.WriteLine("Contato inserido com sucesso!");
            }

        }
        public void Update()
        {
            Person p = new Person();
            using (var context = new BaseContext())
            {
                Console.Write("Nome: ");
                p.Name = Console.ReadLine().ToUpper();
                var find = context.Phones.FirstOrDefault(ph => ph.Person.Name == p.Name);
                var findPerson = context.Persons.FirstOrDefault(pe => pe.Name == p.Name);
                if (find == null)
                {
                    Console.WriteLine("\nContato não encontrado!");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine(find.ToString());
                Console.WriteLine(findPerson.ToString());

                Console.Write("\nEscolha ua opção: 0-Cancelar 1-Celular 2-Telefone fixo 3-E-mail ");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Atualização cancelada!");
                        return;
                    case 1:
                        Console.Write("Celular novo: ");
                        string mob = Console.ReadLine();
                        find.Mobile = mob;
                        context.Entry(find).State = EntityState.Modified;
                        context.SaveChanges();
                        Console.WriteLine("Contato Atualizado com sucesso!");
                        Console.WriteLine(find.ToString());
                        Console.WriteLine(findPerson.ToString());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Telefone fixo novo: ");
                        string landl = Console.ReadLine();
                        find.Landline = landl;
                        context.Entry(find).State = EntityState.Modified;
                        context.SaveChanges();
                        Console.WriteLine("Contato Atualizado com sucesso!");
                        Console.WriteLine(find.ToString());
                        Console.WriteLine(findPerson.ToString());
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("E-mail novo: ");
                        string mail = Console.ReadLine();
                        findPerson.Mail = mail;
                        context.Entry(findPerson).State = EntityState.Modified;
                        context.SaveChanges();
                        Console.WriteLine("Contato Atualizado com sucesso!");
                        Console.WriteLine(find.ToString());
                        Console.WriteLine(findPerson.ToString());
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        public void Delet()
        {
            Person p = new Person();
            using (var context = new BaseContext())
            {
                Console.Write("Nome: ");
                p.Name = Console.ReadLine().ToUpper();
                var find = context.Phones.FirstOrDefault(ph => ph.Person.Name == p.Name);
                var findPerson = context.Persons.FirstOrDefault(pe => pe.Name == p.Name);
                if (find == null)
                {
                    Console.WriteLine("\nContato não encontrado!");
                    return;
                }
                Console.WriteLine(find.ToString());
                Console.WriteLine(findPerson.ToString());
                Console.WriteLine("Continuar deleção: 1-Sim 2-Não ");
                int op = int.Parse(Console.ReadLine());
                if (op == 2)
                {
                    Console.WriteLine("Deleção Cancelada!");
                    return;
                }
                context.Entry(find).State = EntityState.Deleted;
                context.Phones.Remove(find);
                context.SaveChanges();
                Console.WriteLine("Contato deletado!");

            }
        }

        public void SelectAll()
        {
            var context = new BaseContext();
            var persons = context.Persons.ToList();
            var phones = context.Phones.ToList();
            foreach (var item in phones)
            {
                Console.WriteLine(item.ToString());
                persons.Where(x => x.Name == item.Person.Name).ToList().ForEach(x => Console.WriteLine(x + "\n"));
            }
        }
    }
}

