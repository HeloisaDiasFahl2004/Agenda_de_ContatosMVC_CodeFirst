using Agenda_de_ContatosMVC_CodeFirst.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Agenda_de_ContatosMVC_CodeFirst
{
    internal class Program
    {
        static PersonController controls = new PersonController();


        static void Menu()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("\t<<< MENU >>>");
                Console.WriteLine("\t 0-Sair do Menu");
                Console.WriteLine("\t 1-Inserir Contato");
                Console.WriteLine("\t 2-Editar Contato");
                Console.WriteLine("\t 3-Deletar Contato");
                Console.WriteLine("\t 4-Visualizar Contatos");
                Console.Write("\t Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 0:
                        Console.Write("Saindo . ");
                        Thread.Sleep(200);
                        Console.Write(" .");
                        Thread.Sleep(200);
                        Console.Write(" .");
                        Thread.Sleep(200);
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine(" <<< Cadastro iniciado >>> ");
                        controls.Insert();
                        Console.WriteLine(" <<< Fim cadastro >>> ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine(" <<< Atualização iniciada >>> ");
                        controls.Update();
                        Console.WriteLine(" <<< Fim atualização >>> ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(" <<< Deleção iniciada >>> ");
                        controls.Delet();
                        Console.WriteLine(" <<< Fim deleção >>> ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine(" <<< Impressão Iniciada >>>");
                        controls.SelectAll();
                        Console.WriteLine(" <<< Fim impressão >>> ");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;

                }
            } while (opc != 0);
        }
        static void Main(string[] args)
        {
            Menu();
        }

    }
}
