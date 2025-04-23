using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu do usuário

            char opcao;

            do
            {

                

                Console.WriteLine("                                                            ");
                Console.WriteLine("************************************************************");
                Console.WriteLine("                                                            ");
                Console.WriteLine("                          Banco JK                          ");
                Console.WriteLine("                                                            ");
                Console.WriteLine("            Escolha a opção da operação a ser realizada:    ");
                Console.WriteLine("                                                            ");
                Console.WriteLine("                  1 - Cadastrar cliente.                    ");
                Console.WriteLine("                  2 - Inserir cliente na fila.              ");
                Console.WriteLine("                  3 - Listar a fila                         ");
                Console.WriteLine("                  4 - Incluir cliente prioritário           ");
                Console.WriteLine("                  5 - Atender cliente                       ");
                Console.WriteLine("                                                            ");
                Console.WriteLine("************************************************************");
                Console.WriteLine("                                                            ");
                Console.WriteLine("                  Digite 'q' para sair.                     ");
                Console.WriteLine("                                                            ");
                Console.WriteLine("************************************************************");
                opcao = char.Parse(Console.ReadLine());

                switch (opcao) {
                    case '1':

                        break;
                    case '2':

                        break;
                    case '3':

                        break;
                    case '4':

                        break;

                    case '5':

                        break;

                    case 'q':
                        Console.WriteLine("Operação finalizada.");
                        break;

                    default:
                        Console.WriteLine("Valor digitado inválido!");
                        break;
                }

            } while (opcao != 'q');
        }
    }
}
